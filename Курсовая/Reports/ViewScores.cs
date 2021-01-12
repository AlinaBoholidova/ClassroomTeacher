using Microsoft.Reporting.WinForms;
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
    public partial class ViewScores : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        public ViewScores()
        {
            InitializeComponent();
        }

        private void ViewScores_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);

            int id = Convert.ToInt32(idComboBox.Text);
            string SNPSelect = $"SELECT SNP FROM Pupil WHERE Pupil_ID = {id}";
            string scoresSelect = "SELECT JournalRecord.Record_ID, Pupil.SNP, Test.Test_date, " +
                "Test.Subject_abbr, JournalRecord.Score " +
                "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID " +
                "LEFT OUTER JOIN Test ON JournalRecord.Test_ID = Test.Test_ID " +
                $"WHERE JournalRecord.Pupil_ID = {id}";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand(SNPSelect, sqlconn);
            SqlDataReader myreader;
            sqlconn.Open();
            SqlDataAdapter da = new SqlDataAdapter(scoresSelect, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            scoresDataGridView.DataSource = dt;
            myreader = command.ExecuteReader();
            List<String> lstSNP = new List<String>();
            while (myreader.Read())
            {
                lstSNP.Add(myreader[0].ToString());
            }
            sqlconn.Close();

            scoresDataGridView.Columns[0].HeaderText = "ID запису";
            scoresDataGridView.Columns[1].HeaderText = "ПІБ учня";
            scoresDataGridView.Columns[2].HeaderText = "Дата контрольної";
            scoresDataGridView.Columns[3].HeaderText = "Предмет";
            scoresDataGridView.Columns[4].HeaderText = "Оцінка";
            SNPlabel.Text = lstSNP[0];
        }

        private void idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idComboBox.Text);
                string SNPSelect = $"SELECT SNP FROM Pupil WHERE Pupil_ID = {id}";
                string scoresSelect = "SELECT JournalRecord.Record_ID, Pupil.SNP, Test.Test_date, " +
                    "Test.Subject_abbr, JournalRecord.Score " +
                    "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID " +
                    "LEFT OUTER JOIN Test ON JournalRecord.Test_ID = Test.Test_ID " +
                    $"WHERE JournalRecord.Pupil_ID = {id}";

                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                SqlCommand command = new SqlCommand(SNPSelect, sqlconn);
                SqlDataReader myreader;
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(scoresSelect, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                scoresDataGridView.DataSource = dt;
                myreader = command.ExecuteReader();
                List<String> lstSNP = new List<String>();
                while (myreader.Read())
                {
                    lstSNP.Add(myreader[0].ToString());
                }
                sqlconn.Close();

                SNPlabel.Text = lstSNP[0];
            }
            catch
            {

            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            this.scoresReportViewer.RefreshReport();
            int id = Convert.ToInt32(idComboBox.Text);
            string select = "";
            string fromDate = fromDateTimePicker.Value.ToString("yyyy-MM-dd");
            string toDate = toDateTimePicker.Value.Date.ToString("yyyy-MM-dd");

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            if (timeCheckBox.Checked)
            {
                reportParameters.Add(new ReportParameter("fromDateReportParameter", timeCheckBox.Text));
                reportParameters.Add(new ReportParameter("toDateReportParameter", " "));
                reportParameters.Add(new ReportParameter("SNPReportParameter", SNPlabel.Text));
            }
            else
            {
                reportParameters.Add(new ReportParameter("fromDateReportParameter", fromDate));
                reportParameters.Add(new ReportParameter("toDateReportParameter", toDate));
                reportParameters.Add(new ReportParameter("SNPReportParameter", SNPlabel.Text));
            }            

            if (timeCheckBox.Checked)
            {
                select = "SELECT JournalRecord.Record_ID, Pupil.SNP, Test.Test_date, Test.Subject_abbr, " +
                    "JournalRecord.Score " +
                    "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID " +
                    "LEFT OUTER JOIN Test ON JournalRecord.Test_ID = Test.Test_ID " +
                    $"WHERE JournalRecord.Pupil_ID = {id} ";
            }
            else
            {
                select = "SELECT JournalRecord.Record_ID, Pupil.SNP, Test.Test_date, Test.Subject_abbr, " +
                    "JournalRecord.Score " +
                    "FROM Pupil LEFT OUTER JOIN JournalRecord ON Pupil.Pupil_ID = JournalRecord.Pupil_ID " +
                    "LEFT OUTER JOIN Test ON JournalRecord.Test_ID = Test.Test_ID " +
                    $"WHERE JournalRecord.Pupil_ID = {id} " +
                    $"AND Test.Test_date BETWEEN CONVERT(datetime, '{fromDate}') AND CONVERT(datetime, '{toDate}')";
            }
            
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlconn.Close();
            ReportDataSource pupilRDS = new ReportDataSource("scoresDataSet", dt);
            scoresReportViewer.LocalReport.ReportPath = @"Reports/Scores.rdlc";
            scoresReportViewer.LocalReport.DataSources.Clear();
            scoresReportViewer.LocalReport.DataSources.Add(pupilRDS);
            scoresReportViewer.LocalReport.SetParameters(reportParameters);
            scoresReportViewer.RefreshReport();
        }

        private void ViewScores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Scores_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
