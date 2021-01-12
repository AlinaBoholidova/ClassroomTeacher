using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Statistics : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.schoolCourseDataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.schoolCourseDataSet.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.JournalRecord". При необходимости она может быть перемещена или удалена.
            this.journalRecordTableAdapter.Fill(this.schoolCourseDataSet.JournalRecord);

            string skipsSelect = "SELECT Pupil.Pupil_ID, Pupil.SNP," +
                "((SELECT COUNT(Test_ID) FROM TEST) - COUNT(JournalRecord.Score)) AS Missed " +
                "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID " +
                "GROUP BY Pupil.Pupil_ID, Pupil.SNP ORDER BY Missed DESC";
            string birthdaysSelect = "SELECT Pupil_ID, SNP, CASE " +
                "WHEN MONTH(BirthDate) = 1 THEN 'січень' WHEN MONTH(BirthDate) = 2 THEN 'лютий' " +
                "WHEN MONTH(BirthDate) = 3 THEN 'березень' WHEN MONTH(BirthDate) = 4 THEN 'квітень' " +
                "WHEN MONTH(BirthDate) = 5 THEN 'травень' WHEN MONTH(BirthDate) = 6 THEN 'червень' " +
                "WHEN MONTH(BirthDate) = 7 THEN 'липень' WHEN MONTH(BirthDate) = 8 THEN 'серпень' " +
                "WHEN MONTH(BirthDate) = 9 THEN 'вересень' WHEN MONTH(BirthDate) = 10 THEN 'жовтень' " +
                "WHEN MONTH(BirthDate) = 11 THEN 'листопад' ELSE 'грудень' " +
                "END FROM Pupil ORDER BY MONTH(BirthDate)";
            string debtorsSelect = "SELECT Payment.Payment_ID, Pupil.SNP, PaymentRate.PaymentRate_type, Payment.Month " +
                "FROM Pupil INNER JOIN Payment ON Pupil.Pupil_ID = Payment.Pupil_ID INNER JOIN " +
                "PaymentRate ON Payment.PaymentRate_ID = PaymentRate.PaymentRate_ID " +
                "WHERE(Payment.Paid = 0)";
            string activitiesSelect = "SELECT AdditionalActivity.Activity_ID, AdditionalActivity.Activity_name, " +
                "COUNT(AdditionalParticipation.Pupil_ID) AS Quantity " +
                "FROM AdditionalActivity LEFT OUTER JOIN AdditionalParticipation " +
                "ON AdditionalActivity.Activity_ID = AdditionalParticipation.Activity_ID " +
                "GROUP BY AdditionalActivity.Activity_ID, AdditionalActivity.Activity_name " +
                "ORDER BY Quantity DESC";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter skipsDA = new SqlDataAdapter(skipsSelect, sqlconn);
            DataTable skipsDT = new DataTable();
            skipsDA.Fill(skipsDT);
            skipsDataGridView.DataSource = skipsDT;
            SqlDataAdapter birthdaysDA = new SqlDataAdapter(birthdaysSelect, sqlconn);
            DataTable birthdaysDT = new DataTable();
            birthdaysDA.Fill(birthdaysDT);
            birthdaysDataGridView.DataSource = birthdaysDT;
            SqlDataAdapter debtorsDA = new SqlDataAdapter(debtorsSelect, sqlconn);
            DataTable debtorsDT = new DataTable();
            debtorsDA.Fill(debtorsDT);
            debtorsDataGridView.DataSource = debtorsDT;
            SqlDataAdapter activitiesDA = new SqlDataAdapter(activitiesSelect, sqlconn);
            DataTable activitiesDT = new DataTable();
            activitiesDA.Fill(activitiesDT);
            activitiesDataGridView.DataSource = activitiesDT;
            sqlconn.Close();
            
            skipsDataGridView.Columns[0].HeaderText = "ID учня";
            skipsDataGridView.Columns[1].HeaderText = "ПІБ";
            skipsDataGridView.Columns[2].HeaderText = "Кількість пропусків";
            birthdaysDataGridView.Columns[0].HeaderText = "ID учня";
            birthdaysDataGridView.Columns[1].HeaderText = "ПІБ";
            birthdaysDataGridView.Columns[2].HeaderText = "Місяць";
            debtorsDataGridView.Columns[0].HeaderText = "ID оплати";
            debtorsDataGridView.Columns[1].HeaderText = "ПІБ";
            debtorsDataGridView.Columns[2].HeaderText = "Тип тарифу";
            debtorsDataGridView.Columns[3].HeaderText = "Місяць";
            activitiesDataGridView.Columns[0].HeaderText = "ID активності";
            activitiesDataGridView.Columns[1].HeaderText = "Назва";
            activitiesDataGridView.Columns[2].HeaderText = "Брали участь";

            // chartBirthMonth
            int birthCount = birthdaysDataGridView.Rows.Count - 1;
            List<string> birthMonth = new List<string>();
            for (int i = 0; i < birthCount; i++)
            {
                if (!birthMonth.Contains(Convert.ToString(birthdaysDataGridView.Rows[i].Cells[2].Value)))
                {
                    birthMonth.Add(Convert.ToString(birthdaysDataGridView.Rows[i].Cells[2].Value));
                }
            }
            Dictionary<string, double> birthData = new Dictionary<string, double>();
            for (int i = 0; i < birthCount; i++)
            {
                if (!birthData.ContainsKey(birthMonth[i]))
                    birthData.Add(birthMonth[i], 1);

                else
                    birthData[birthMonth[i]] += 1;
            }
            foreach (string i in birthData.Keys)
                chartBirthMonth.Series[0].Points.AddXY(i, birthData[i]);

            // chartPaymentMonth
            int paymentCount = debtorsDataGridView.Rows.Count;
            Dictionary<string, double> paymentData = new Dictionary<string, double>();
            for (int i = 0; i < paymentCount; i++)
            {
                if (!paymentData.ContainsKey(Convert.ToString(debtorsDataGridView.Rows[i].Cells[3].Value)))
                {
                    paymentData.Add(Convert.ToString(debtorsDataGridView.Rows[i].Cells[3].Value), 1);
                }
                else
                    paymentData[Convert.ToString(debtorsDataGridView.Rows[i].Cells[3].Value)] += 1;
            }
            foreach (string i in paymentData.Keys)
                chartPaymentMonth.Series[0].Points.AddXY(i, paymentData[i]);            

            // chartActivity
            int activityCount = activitiesDataGridView.Rows.Count - 1;
            for (int i = 0; i < activityCount; i++)
            {
                chartActivity.Series[0].Points.AddXY(Convert.ToString(activitiesDataGridView.Rows[i].Cells[1].Value),
                    Convert.ToString(activitiesDataGridView.Rows[i].Cells[2].Value));
            }
        }
    }
}
