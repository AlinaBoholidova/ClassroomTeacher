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

        public Rating()
        {
            InitializeComponent();
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            string select2 = "SELECT Pupil_ID AS 'ID учня'," +
                "AVG(CONVERT(DECIMAL(5,2), JournalRecord.avg)) AS 'Підсумкова оцінка', " +
                "AVG(JournalRecord.avg)*0.9 AS 'Для рейтингу'  " +
                "FROM (SELECT j1.Pupil_ID, Test.Subject_abbr, AVG(CONVERT(DECIMAL(5,2), j1.Score)) AS avg " +
                "FROM JournalRecord j1 INNER JOIN Test ON j1.Test_ID = Test.Test_ID " +
                "INNER JOIN Subject ON Test.Subject_abbr = Subject.Subject_abbr " +
                "GROUP BY j1.Pupil_ID, Test.Subject_abbr) JournalRecord GROUP BY Pupil_ID";

            string select1 = "SELECT JournalRecord.Pupil_ID, Test.Subject_abbr, " +
                "AVG(CONVERT(DECIMAL(5,2), JournalRecord.Score)) " +
                "FROM JournalRecord INNER JOIN Test ON JournalRecord.Test_ID = Test.Test_ID " +
                "INNER JOIN Subject ON Test.Subject_abbr = Subject.Subject_abbr " +
                "GROUP BY JournalRecord.Pupil_ID, Test.Subject_abbr ORDER BY JournalRecord.Pupil_ID";

            string select = "SELECT JournalRecord.Pupil_ID, AVG(JournalRecord.Score), AVG(JournalRecord.Score)*0.9 AS 'Для рейтингу' " +
                "FROM JournalRecord INNER JOIN Test ON JournalRecord.Test_ID = Test.Test_ID " +
                "GROUP BY JournalRecord.Pupil_ID ORDER BY JournalRecord.Pupil_ID ASC";

            string sell = "SELECT JournalRecord.Pupil_ID, Test.Subject_abbr, JournalRecord.Score " +
                "FROM JournalRecord INNER JOIN Test ON JournalRecord.Test_ID = Test.Test_ID " +
                "INNER JOIN Subject ON Test.Subject_abbr = Subject.Subject_abbr " +
                " ORDER BY JournalRecord.Pupil_ID";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter da = new SqlDataAdapter(select2, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            scoresDataGridView.DataSource = dt;
            sqlconn.Close();


            string sel1 = "SELECT JournalRecord.Pupil_ID, AVG(JournalRecord.Score), SUM(PointsDistribution.Points), " +
                "(AVG(JournalRecord.Score) * 0.9 + SUM(PointsDistribution.Points) * 0.3) AS 'Рейтинг' " +
                "FROM JournalRecord INNER JOIN Test ON JournalRecord.Test_ID = Test.Test_ID, " +
                "AdditionalParticipation INNER JOIN PointsDistribution " +
                "ON AdditionalParticipation.Distribution_ID = PointsDistribution.Distribution_ID " +
                "GROUP BY JournalRecord.Pupil_ID ORDER BY JournalRecord.Pupil_ID";

            string sel = "SELECT AdditionalParticipation.Pupil_ID AS 'ID учня', " +
                "SUM(PointsDistribution.Points) AS 'Кількість балів'," +
                "SUM(PointsDistribution.Points)*0.3 AS 'Для рейтингу' " +
                "FROM AdditionalParticipation INNER JOIN PointsDistribution " +
                "ON AdditionalParticipation.Distribution_ID = PointsDistribution.Distribution_ID " +
                "GROUP BY AdditionalParticipation.Pupil_ID";
            sqlconn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter(sel, sqlconn);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            pointsDataGridView.DataSource = dt1;
            sqlconn.Close();

            
        }

        private void back_Subjects_Click(object sender, EventArgs e)
        {
            Main main = new Main();
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
                    + Convert.ToDouble(pointsDataGridView.Rows[i].Cells[2].Value));
            }
            value = value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<int, double> keyValue in value)
            {
                ratingDataGridView.Rows.Add(keyValue.Key, keyValue.Value);
            }

            int pcount = value.Count;
            List<double> percent = new List<double>();
            double highlow = Math.Round(pcount * 0.1, 0);
            double rest = pcount - highlow;
            percent.Add(highlow);
            percent.Add(rest);

            DataContext db = new DataContext(ConnectionString);
            Table<Payment> users = db.GetTable<Payment>();
            List<Payment> payments = new List<Payment>();
            //foreach (KeyValuePair<int, double> keyValue in value)
            //{
            //    PaymentClass payment = new PaymentClass
            //    {
            //        Pupil_ID = keyValue.Key,
            //        PaymentRate_ID = ,
            //        Month = "січень"
            //    };
            //}
            for (int i = 0; i < highlow; i++)
            {
                Payment payment = new Payment
                {
                    Pupil_ID = value.ElementAt(i).Key,
                    PaymentRate_ID = 2,
                    Month = "січень"
                };
                db.GetTable<Payment>().InsertOnSubmit(payment);
            }
            int top = Convert.ToInt32(highlow);
            for (int i = top; i < count - top; i++)
            {
                Payment payment = new Payment
                {
                    Pupil_ID = value.ElementAt(i).Key,
                    PaymentRate_ID = 4,
                    Month = "січень"
                };
                db.GetTable<Payment>().InsertOnSubmit(payment);
            }
            for (int i = count - top; i < count; i++)
            {
                Payment payment = new Payment
                {
                    Pupil_ID = value.ElementAt(i).Key,
                    PaymentRate_ID = 3,
                    Month = "січень"
                };
                db.GetTable<Payment>().InsertOnSubmit(payment);
            }
            db.SubmitChanges();

        }
    }
}
