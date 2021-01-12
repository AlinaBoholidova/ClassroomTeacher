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
    public partial class AdditionalParticipation : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly bool edit;
        private readonly int pupil_id;
        private readonly int activity_id;

        public AdditionalParticipation()
        {
            InitializeComponent();
        }

        public AdditionalParticipation(int pupil_id, int activity_id, int distribution_id) : this()
        {
            edit = true;
            this.pupil_id = pupil_id;
            this.activity_id = activity_id;

            pupil_IDComboBox.Text = pupil_id.ToString();
            activity_IDComboBox.Text = activity_id.ToString();
            distribution_IDComboBox.SelectedIndex = distribution_IDComboBox.Items.IndexOf(distribution_id);
        }

        private void AdditionalParticipation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PointsDistribution". При необходимости она может быть перемещена или удалена.
            this.pointsDistributionTableAdapter.Fill(this.schoolCourseDataSet.PointsDistribution);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.AdditionalActivity". При необходимости она может быть перемещена или удалена.
            this.additionalActivityTableAdapter.Fill(this.schoolCourseDataSet.AdditionalActivity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.AdditionalParticipation". При необходимости она может быть перемещена или удалена.
            this.additionalParticipationTableAdapter.Fill(this.schoolCourseDataSet.AdditionalParticipation);

            int pupil_id = Convert.ToInt32(pupil_IDComboBox.Text);
            int activity_id = Convert.ToInt32(activity_IDComboBox.Text);
            int distribution_id = Convert.ToInt32(distribution_IDComboBox.Text);

            string pupilSNPSelect = $"SELECT SNP FROM Pupil WHERE Pupil_ID = {pupil_id}";
            string activityNameSelect = $"SELECT Activity_name FROM AdditionalActivity WHERE Activity_ID = {activity_id}";
            string placeSelect = $"SELECT Place FROM PointsDistribution WHERE Distribution_ID = {distribution_id}";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlCommand pupilSNPCommand = new SqlCommand(pupilSNPSelect, sqlconn);
            SqlCommand activityNameCommand = new SqlCommand(activityNameSelect, sqlconn);
            SqlCommand placeCommand = new SqlCommand(placeSelect, sqlconn);
            SqlDataReader pupilSNPReader;
            SqlDataReader activityNameReader;
            SqlDataReader placeReader;
            List<string> lstpupilSNP = new List<string>();
            sqlconn.Open();
            pupilSNPReader = pupilSNPCommand.ExecuteReader();
            while (pupilSNPReader.Read())
            {
                lstpupilSNP.Add(pupilSNPReader[0].ToString());
            }
            sqlconn.Close();
            List<string> lstActivityName = new List<string>();
            sqlconn.Open();
            activityNameReader = activityNameCommand.ExecuteReader();
            while (activityNameReader.Read())
            {
                lstActivityName.Add(activityNameReader[0].ToString());
            }
            sqlconn.Close();
            List<string> lstPlace = new List<string>();
            sqlconn.Open();
            placeReader = placeCommand.ExecuteReader();
            while (placeReader.Read())
            {
                lstPlace.Add(placeReader[0].ToString());
            }
            sqlconn.Close();
            pupil_IDLabel.Text = lstpupilSNP[0];
            activity_IDLabel.Text = lstActivityName[0];
            distribution_IDLabel.Text = lstPlace[0];
        }

        private void pupil_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pupilID = Convert.ToInt32(pupil_IDComboBox.Text);
            string pupilSNPSelect = $"SELECT SNP FROM Pupil WHERE Pupil_ID = {pupilID}";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlCommand pupilSNPCommand = new SqlCommand(pupilSNPSelect, sqlconn);
            SqlDataReader pupilSNPReader;
            List<string> lstpupilSNP = new List<string>();
            sqlconn.Open();
            pupilSNPReader = pupilSNPCommand.ExecuteReader();
            while (pupilSNPReader.Read())
            {
                lstpupilSNP.Add(pupilSNPReader[0].ToString());
            }
            sqlconn.Close();
            pupil_IDLabel.Text = lstpupilSNP[0];
        }

        private void activity_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int activityID = Convert.ToInt32(activity_IDComboBox.Text);
            string activityNameSelect = $"SELECT Activity_name FROM AdditionalActivity WHERE Activity_ID = {activityID}";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlCommand activityNameCommand = new SqlCommand(activityNameSelect, sqlconn);
            SqlDataReader activityNameReader;
            List<string> lstActivityName = new List<string>();
            sqlconn.Open();
            activityNameReader = activityNameCommand.ExecuteReader();
            while (activityNameReader.Read())
            {
                lstActivityName.Add(activityNameReader[0].ToString());
            }
            sqlconn.Close();
            activity_IDLabel.Text = lstActivityName[0];
        }

        private void distribution_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int distribution_id = Convert.ToInt32(distribution_IDComboBox.Text);
            string placeSelect = $"SELECT Place FROM PointsDistribution WHERE Distribution_ID = {distribution_id}";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlCommand placeCommand = new SqlCommand(placeSelect, sqlconn);
            SqlDataReader placeReader;
            List<string> lstPlace = new List<string>();
            sqlconn.Open();
            placeReader = placeCommand.ExecuteReader();
            while (placeReader.Read())
            {
                lstPlace.Add(placeReader[0].ToString());
            }
            sqlconn.Close();
            distribution_IDLabel.Text = lstPlace[0];
        }

        private void Cancel_Participation_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Participation_Click(object sender, EventArgs e)
        {
            int pupilID = Convert.ToInt32(pupil_IDComboBox.Text);
            int activityID = Convert.ToInt32(activity_IDComboBox.Text);
            int distributionID = Convert.ToInt32(distribution_IDComboBox.Text);

            if (edit)
            {
                additionalParticipationTableAdapter.UpdateQuery(pupilID, activityID, distributionID, 
                    pupil_id, activity_id);
            }
            else
            {
                additionalParticipationTableAdapter.InsertQuery(pupilID, activityID, distributionID);
            }

            Close();
        }
    }
}
