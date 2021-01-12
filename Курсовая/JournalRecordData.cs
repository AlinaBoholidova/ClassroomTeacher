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
    public partial class JournalRecordData : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly bool edit;
        private readonly int id;
        public JournalRecordData()
        {
            InitializeComponent();
            edit = false;
        }

        public JournalRecordData(int rec_id, int pupil_id, int test_id, int score) : this()
        {
            edit = true;
            this.id = rec_id;
            pupil_IDComboBox.Text = pupil_id.ToString();
            test_IDComboBox.Text = test_id.ToString();
            scoreNumericUpDown.Value = score;
        }

        private void JournalRecordData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.schoolCourseDataSet.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.JournalRecord". При необходимости она может быть перемещена или удалена.
            this.journalRecordTableAdapter.Fill(this.schoolCourseDataSet.JournalRecord);

            int pupil_id = Convert.ToInt32(pupil_IDComboBox.Text);
            int test_id = Convert.ToInt32(test_IDComboBox.Text);

            string pupilSNPSelect = $"SELECT SNP FROM Pupil WHERE Pupil_ID = {pupil_id}";
            string subjSelect = $"SELECT Subject_abbr FROM Test " +
                $"WHERE Test_ID = {test_id}";
            string dateSelect = $"SELECT CONVERT(varchar, Test_date, 104) FROM Test " +
                $"WHERE Test_ID = {test_id}";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlCommand pupilSNPCommand = new SqlCommand(pupilSNPSelect, sqlconn);
            SqlCommand testCommand = new SqlCommand(subjSelect, sqlconn);
            SqlCommand dateCommand = new SqlCommand(dateSelect, sqlconn);
            SqlDataReader pupilSNPReader;
            SqlDataReader subjReader;
            SqlDataReader dateReader;
            sqlconn.Open();
            pupilSNPReader = pupilSNPCommand.ExecuteReader();
            List<string> lstpupilSNP = new List<string>();
            while (pupilSNPReader.Read())
            {
                lstpupilSNP.Add(pupilSNPReader[0].ToString());
            }
            sqlconn.Close();
            sqlconn.Open();
            subjReader = testCommand.ExecuteReader();
            List<string> lstSubj = new List<string>();
            while (subjReader.Read())
            {
                lstSubj.Add(subjReader[0].ToString());
            }
            sqlconn.Close();
            sqlconn.Open();
            dateReader = dateCommand.ExecuteReader();
            List<string> lstDate = new List<string>();
            while (dateReader.Read())
            {
                lstDate.Add(dateReader[0].ToString());
            }
            sqlconn.Close();
            pupil_IDLabel.Text = lstpupilSNP[0];
            test_IDLabel.Text = lstSubj[0];
            test_IDLabel.Text += " " + lstDate[0];
        }

        private void OK_Record_Click(object sender, EventArgs e)
        {
            int pupil_ID = Convert.ToInt32(pupil_IDComboBox.Text);
            int test_ID = Convert.ToInt32(test_IDComboBox.Text);
            int score = Convert.ToInt32(scoreNumericUpDown.Value);

            if (edit)
            {
                journalRecordTableAdapter.UpdateQuery(pupil_ID, test_ID, score, id);
            }
            else
            {
                journalRecordTableAdapter.InsertQuery(pupil_ID, test_ID, score);
            }
            Close();
        }

        private void Cancel_Record_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pupil_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pupil_id = Convert.ToInt32(pupil_IDComboBox.Text);

                string pupilSNPSelect = $"SELECT SNP FROM Pupil WHERE Pupil_ID = {pupil_id}";
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                SqlCommand pupilSNPCommand = new SqlCommand(pupilSNPSelect, sqlconn);
                SqlDataReader pupilSNPReader;
                sqlconn.Open();
                pupilSNPReader = pupilSNPCommand.ExecuteReader();
                List<string> lstPupilSNP = new List<string>();
                while (pupilSNPReader.Read())
                {
                    lstPupilSNP.Add(pupilSNPReader[0].ToString());
                }
                sqlconn.Close();
                pupil_IDLabel.Text = lstPupilSNP[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void test_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int test_id = Convert.ToInt32(test_IDComboBox.Text);

                string subjSelect = $"SELECT Subject_abbr FROM Test " +
                $"WHERE Test_ID = {test_id}";
                string dateSelect = $"SELECT CONVERT(varchar, Test_date, 104) FROM Test " +
                    $"WHERE Test_ID = {test_id}";
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                SqlCommand testCommand = new SqlCommand(subjSelect, sqlconn);
                SqlCommand dateCommand = new SqlCommand(dateSelect, sqlconn);
                SqlDataReader subjReader;
                SqlDataReader dateReader;
                sqlconn.Open();
                subjReader = testCommand.ExecuteReader();
                List<string> lstSubj = new List<string>();
                while (subjReader.Read())
                {
                    lstSubj.Add(subjReader[0].ToString());
                }
                sqlconn.Close();
                sqlconn.Open();
                dateReader = dateCommand.ExecuteReader();
                List<string> lstDate = new List<string>();
                while (dateReader.Read())
                {
                    lstDate.Add(dateReader[0].ToString());
                }
                sqlconn.Close();
                test_IDLabel.Text = lstSubj[0];
                test_IDLabel.Text += " " + lstDate[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
