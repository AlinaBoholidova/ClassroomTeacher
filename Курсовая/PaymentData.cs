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
    public partial class PaymentData : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly bool edit;
        private readonly int id;

        public PaymentData()
        {
            InitializeComponent();
            edit = false;
        }

        public PaymentData(int id, int pupil_id, int rate_id, string month, bool paid) : this()
        {
            edit = true;
            this.id = id;

            pupil_IDComboBox.Text = pupil_id.ToString();
            paymentRate_IDComboBox.Text = rate_id.ToString();
            monthComboBox.SelectedIndex = monthComboBox.Items.IndexOf(month);
            if (paid)
            {
                paidCheckBox.Checked = true;
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.schoolCourseDataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PaymentRate". При необходимости она может быть перемещена или удалена.
            this.paymentRateTableAdapter.Fill(this.schoolCourseDataSet.PaymentRate);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);

            int pupil_id = Convert.ToInt32(pupil_IDComboBox.Text);
            int rate_id = Convert.ToInt32(paymentRate_IDComboBox.Text);

            string pupilSNPSelect = $"SELECT SNP FROM Pupil WHERE Pupil_ID = {pupil_id}";
            string paymentRateTypeSelect = $"SELECT PaymentRate_type FROM PaymentRate " +
                $"WHERE PaymentRate_ID = {rate_id}";
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            SqlCommand pupilSNPCommand = new SqlCommand(pupilSNPSelect, sqlconn);
            SqlCommand paymentRateTypeCommand = new SqlCommand(paymentRateTypeSelect, sqlconn);
            SqlDataReader pupilSNPReader;
            SqlDataReader paymentRateTypeReader;
            sqlconn.Open();
            pupilSNPReader = pupilSNPCommand.ExecuteReader();
            List<string> lstpupilSNP = new List<string>();
            while (pupilSNPReader.Read())
            {
                lstpupilSNP.Add(pupilSNPReader[0].ToString());
            }
            sqlconn.Close();
            sqlconn.Open();
            paymentRateTypeReader = paymentRateTypeCommand.ExecuteReader();
            List<string> lstpaymentRateType = new List<string>();
            while (paymentRateTypeReader.Read())
            {
                lstpaymentRateType.Add(paymentRateTypeReader[0].ToString());
            }
            sqlconn.Close();
            pupil.Text = lstpupilSNP[0];
            paymentRate_ID.Text = lstpaymentRateType[0];
        }


        private void Cancel_Payment_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Payment_Click(object sender, EventArgs e)
        {
            if (ValidateAll(monthComboBox))
            {
                int pupil_ID = Convert.ToInt32(pupil_IDComboBox.Text);
                int paymentRate_ID = Convert.ToInt32(paymentRate_IDComboBox.Text);
                string month = monthComboBox.Text;
                bool paid = false;
                if (paidCheckBox.Checked == true)
                {
                    paid = true;
                }

                if (edit)
                {
                    paymentTableAdapter.UpdateQuery(pupil_ID, paymentRate_ID, month, paid, id);
                }
                else
                {
                    paymentTableAdapter.InsertQuery(pupil_ID, paymentRate_ID, month, paid);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Перевірте заповненість полів.", "Повідомлення");
            }

        }
        private bool ValidateAll(Control c1)
        {
            if (string.IsNullOrWhiteSpace(c1.Text))
            {
                return false;
            }
            else return true;
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
                pupil.Text = lstPupilSNP[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void paymentRate_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int rate_id = Convert.ToInt32(paymentRate_IDComboBox.Text);

                string paymentRateTypeSelect = $"SELECT PaymentRate_type FROM PaymentRate " +
                $"WHERE PaymentRate_ID = {rate_id}";
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                SqlCommand paymentRateTypeCommand = new SqlCommand(paymentRateTypeSelect, sqlconn);
                SqlDataReader paymentRateTypeReader;
                sqlconn.Open();
                paymentRateTypeReader = paymentRateTypeCommand.ExecuteReader();
                List<string> lstpaymentRateType = new List<string>();
                while (paymentRateTypeReader.Read())
                {
                    lstpaymentRateType.Add(paymentRateTypeReader[0].ToString());
                }
                sqlconn.Close();
                paymentRate_ID.Text = lstpaymentRateType[0];
            }
            catch
            {

            }
        }
    }
}
