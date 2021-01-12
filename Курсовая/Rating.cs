using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Rating : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly string status;

        public Rating()
        {
            InitializeComponent();
        }

        public Rating(string status) : this()
        {
            this.status = status;
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            string select3 = "SELECT JournalRecord.Pupil_ID AS 'ID учня', " +
                "ISNULL(CAST(ROUND(AVG(JournalRecord.avg), 2) AS DECIMAL(5,2)), 0) AS 'Підсумкова оцінка', " +
                "ISNULL(CAST(ROUND(AVG(JournalRecord.avg) * 0.9, 2) AS DECIMAL(5,2)), 0) AS 'Для рейтингу'  " +
                "FROM (SELECT Pupil.Pupil_ID, Test.Subject_abbr, " +
                "ISNULL(CAST(ROUND(AVG(j1.Score), 2) AS DECIMAL(5,2)), 0) AS avg " +
                "FROM Pupil LEFT OUTER JOIN JournalRecord j1 ON Pupil.Pupil_ID = j1.Pupil_ID " +
                "LEFT OUTER JOIN Test ON j1.Test_ID = Test.Test_ID " +
                "LEFT OUTER JOIN Subject ON Test.Subject_abbr = Subject.Subject_abbr " +
                "GROUP BY Pupil.Pupil_ID, Test.Subject_abbr) JournalRecord GROUP BY JournalRecord.Pupil_ID";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter da = new SqlDataAdapter(select3, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            scoresDataGridView.DataSource = dt;
            sqlconn.Close();

            string sel = "SELECT Pupil.Pupil_ID AS 'ID учня', Pupil.SNP AS 'ПІБ учня', " +
                "ISNULL(SUM(PointsDistribution.Points), 0) AS 'Кількість балів'," +
                "ISNULL(SUM(PointsDistribution.Points)*0.3, 0) AS 'Для рейтингу' " +
                "FROM Pupil LEFT OUTER JOIN AdditionalParticipation ON Pupil.Pupil_ID = AdditionalParticipation.Pupil_ID" +
                " LEFT OUTER JOIN PointsDistribution " +
                "ON AdditionalParticipation.Distribution_ID = PointsDistribution.Distribution_ID " +
                "GROUP BY Pupil.Pupil_ID, Pupil.SNP";
            sqlconn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(sel, sqlconn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            pointsDataGridView.DataSource = dt1;
            sqlconn.Close();
        }

        private void back_Subjects_Click(object sender, EventArgs e)
        {
            Main main = new Main(status);
            main.Show();
            this.Hide();
        }

        private void createRateButton_Click(object sender, EventArgs e)
        {
            int count = scoresDataGridView.RowCount;
            Dictionary<int, double> value = new Dictionary<int, double>();
            for (int i = 0; i < count; i++)
            {
                value.Add(Convert.ToInt32(scoresDataGridView.Rows[i].Cells[0].Value),
                    Convert.ToDouble(scoresDataGridView.Rows[i].Cells[2].Value)
                    + Convert.ToDouble(pointsDataGridView.Rows[i].Cells[3].Value));
            }
            value = value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<int, double> keyValue in value)
            {
                ratingDataGridView.Rows.Add(keyValue.Key, keyValue.Value);
            }

            int checkIDonPayment;
            string select = "";

            int pcount = value.Count;
            List<double> percent = new List<double>();
            double highlow = Math.Round(pcount * 0.1, 0);
            double rest = pcount - highlow;
            percent.Add(highlow);
            percent.Add(rest);

            string selectMax = "SELECT PaymentRate_ID FROM PaymentRate WHERE Sum = (SELECT MAX(Sum) FROM PaymentRate)";
            string selectMin = "SELECT PaymentRate_ID FROM PaymentRate WHERE Sum = (SELECT MIN(Sum) FROM PaymentRate)";
            string selectCom = "SELECT PaymentRate_ID FROM PaymentRate WHERE PaymentRate_type = 'Стандартний'";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlCommand maxCommand = new SqlCommand(selectMax, sqlconn);
            SqlCommand minCommand = new SqlCommand(selectMin, sqlconn);
            SqlCommand comCommand = new SqlCommand(selectCom, sqlconn);
            SqlDataReader maxReader;
            SqlDataReader minReader;
            SqlDataReader comReader;
            sqlconn.Open();
            maxReader = maxCommand.ExecuteReader();
            List<int> lstMax = new List<int>();
            while (maxReader.Read())
            {
                lstMax.Add(Convert.ToInt32(maxReader[0]));
            }
            sqlconn.Close();
            sqlconn.Open();
            minReader = minCommand.ExecuteReader();
            List<int> lstMin = new List<int>();
            while (minReader.Read())
            {
                lstMin.Add(Convert.ToInt32(minReader[0]));
            }
            sqlconn.Close();
            sqlconn.Open();
            comReader = comCommand.ExecuteReader();
            List<int> lstCom = new List<int>();
            while (comReader.Read())
            {
                lstCom.Add(Convert.ToInt32(comReader[0]));
            }
            sqlconn.Close();

            int month = DateTime.Now.Month;
            Dictionary<int, string> monthYear = new Dictionary<int, string>();
            monthYear.Add(1, "січень");
            monthYear.Add(2, "лютий");
            monthYear.Add(3, "березень");
            monthYear.Add(4, "квітень");
            monthYear.Add(5, "травень");
            monthYear.Add(6, "червень");
            monthYear.Add(7, "липень");
            monthYear.Add(8, "серпень");
            monthYear.Add(9, "вересень");
            monthYear.Add(10, "жовтень");
            monthYear.Add(11, "листопад");
            monthYear.Add(12, "грудень");
            string selectMonth = monthYear[month];

            string checkPayment = $"SELECT Pupil_ID FROM Payment WHERE ";

            DataContext db = new DataContext(ConnectionString);
            Table<Payment> users = db.GetTable<Payment>();

            List<Payment> payments = new List<Payment>();
            for (int i = 0; i < highlow; i++)
            {
                Payment check = new Payment { Pupil_ID = value.ElementAt(i).Key, Month = selectMonth };
                var result = users.Where(user => user.Pupil_ID == check.Pupil_ID && user.Month == check.Month).ToList();
                if (result == null)
                {
                    Payment payment = new Payment
                    {
                        Pupil_ID = value.ElementAt(i).Key,
                        PaymentRate_ID = lstMin[0],
                        Month = selectMonth
                    };
                    db.GetTable<Payment>().InsertOnSubmit(payment);
                }
                else
                {
                    MessageBox.Show("Запис з такою оплатою вже існує.", "Повідомлення");
                }
            }
            int top = Convert.ToInt32(highlow);
            for (int i = top; i < count - top; i++)
            {
                Payment check = new Payment { Pupil_ID = value.ElementAt(i).Key, Month = selectMonth };
                var result = users.Where(user => user.Pupil_ID == check.Pupil_ID && user.Month == check.Month).ToList();
                if (result == null)
                {
                    Payment payment = new Payment
                    {
                        Pupil_ID = value.ElementAt(i).Key,
                        PaymentRate_ID = lstCom[0],
                        Month = selectMonth
                    };
                    db.GetTable<Payment>().InsertOnSubmit(payment);
                }
                else
                {
                    MessageBox.Show("Запис з такою оплатою вже існує.", "Повідомлення");
                }
            }
            for (int i = count - top; i < count; i++)
            {
                Payment check = new Payment { Pupil_ID = value.ElementAt(i).Key, Month = selectMonth };
                var result = users.Where(user => user.Pupil_ID == check.Pupil_ID && user.Month == check.Month).ToList();

                if (result == null)
                {
                    Payment payment = new Payment
                    {
                        Pupil_ID = value.ElementAt(i).Key,
                        PaymentRate_ID = lstMax[0],
                        Month = selectMonth
                    };
                    db.GetTable<Payment>().InsertOnSubmit(payment);
                }
                else
                {
                    MessageBox.Show("Запис з такою оплатою вже існує.", "Повідомлення");
                }
            }
            db.SubmitChanges();

        }

        private void Rating_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main(status);
            main.Show();
            this.Hide();
        }
    }
}
