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

namespace Курсовая.Parent
{
    public partial class PaymentsParent : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        User user;

        public PaymentsParent()
        {
            InitializeComponent();
        }

        public PaymentsParent(User user) : this()
        {
            this.user = user;
        }

        private void back_Payments_Click(object sender, EventArgs e)
        {
            MainParent mainParent = new MainParent(user);
            mainParent.Show();
            this.Hide();
        }

        private void PaymentsParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainParent mainParent = new MainParent(user);
            mainParent.Show();
            this.Hide();
        }

        private void PaymentsParent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PaymentRate". При необходимости она может быть перемещена или удалена.
            this.paymentRateTableAdapter.Fill(this.schoolCourseDataSet.PaymentRate);
            try
            {
                string select = $"SELECT * From Payment WHERE Pupil_ID = {Convert.ToInt32(user.Password)}";

                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                paymentDataGridView.DataSource = dt;
                sqlconn.Close();

                paymentDataGridView.Columns[0].HeaderText = "№ квитанції";
                paymentDataGridView.Columns[1].HeaderText = "ПІБ учня";
                paymentDataGridView.Columns[2].HeaderText = "Тип тарифу";
                paymentDataGridView.Columns[3].HeaderText = "Сума";
                paymentDataGridView.Columns[4].HeaderText = "Місяць";
            }
            catch
            {
                MessageBox.Show("Ваша дитина не має оплати.", "Повідомлення");
            }
        }

        private void showAll_Payment_Click(object sender, EventArgs e)
        {
            try
            {
                string select = $"SELECT * From Payment WHERE Pupil_ID = {Convert.ToInt32(user.Password)}";

                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                paymentDataGridView.DataSource = dt;
                sqlconn.Close();

                paymentDataGridView.Columns[0].HeaderText = "№ квитанції";
                paymentDataGridView.Columns[1].HeaderText = "ПІБ учня";
                paymentDataGridView.Columns[2].HeaderText = "Тип тарифу";
                paymentDataGridView.Columns[3].HeaderText = "Сума";
                paymentDataGridView.Columns[4].HeaderText = "Місяць";
            }
            catch
            {
                MessageBox.Show("Ваша дитина не має оплати.", "Повідомлення");
            }
        }

        private void showAll_Rate_Click(object sender, EventArgs e)
        {
            this.paymentRateTableAdapter.Fill(this.schoolCourseDataSet.PaymentRate);
            rateDataGridView.DataSource = rateBindingSource;
        }

        private void toSearch_Rate_Click(object sender, EventArgs e)
        {
            string toSearch = "";
            string select = "SELECT * FROM PaymentRate WHERE ";

            if (searchTextBox_Rate.Text != "")
            {
                toSearch = searchTextBox_Rate.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_Rate.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(PaymentRate_ID, PaymentRate_type, Sum) " +
                            "LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        rateDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (rateIDCheckBox_Rate.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "PaymentRate_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        rateDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (typeCheckBox_Rate.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "PaymentRate_type LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        rateDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (sumCheckBox_Rate.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Sum LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        rateDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введіть текст для пошуку.", "Повідомлення");
            }
        }

        private void toSortButton_Rate_Click(object sender, EventArgs e)
        {
            string toSort = "";
            string select = "SELECT * FROM PaymentRate ORDER BY ";

            if (sortComboBox_Rate.SelectedIndex > -1)
            {
                try
                {
                    if (sortComboBox_Rate.SelectedIndex == 0)
                    {
                        toSort = "PaymentRate_ID";
                    }
                    else if (sortComboBox_Rate.SelectedIndex == 1)
                    {
                        toSort = "PaymentRate_type";
                    }
                    else if (sortComboBox_Rate.SelectedIndex == 2)
                    {
                        toSort = "Sum";
                    }
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    rateDataGridView.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Оберіть параметр для сортування.", "Повідомлення");
            }
        }

        private void toFilter_Rate_Click(object sender, EventArgs e)
        {
            int fromSum = Convert.ToInt32(fromNumericUpDown_Rate.Value);
            int toSum = Convert.ToInt32(toNumericUpDown_Rate.Value);
            string select = "SELECT * FROM PaymentRate WHERE Sum " +
                $"BETWEEN {fromSum} AND {toSum}";

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rateDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void toSearch_Payment_Click(object sender, EventArgs e)
        {
            string toSearch = "";
            string select = "SELECT * FROM Payment WHERE ";

            if (searchTextBox_Payment.Text != "")
            {
                toSearch = searchTextBox_Payment.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_Payment.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(Payment_ID, PaymentRate_ID, Month) " +
                            "LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        paymentDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (payIDCheckBox_Payment.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Payment_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        paymentDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (rateIDCheckBox_Payment.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "PaymentRate_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        paymentDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (monthCheckBox_Payment.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Month LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        paymentDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введіть текст для пошуку.", "Повідомлення");
            }
        }

        private void toSort_Payment_Click(object sender, EventArgs e)
        {
            string toSort = "";
            string select = "SELECT * FROM Payment ORDER BY ";

            if (sortComboBox_Payment.SelectedIndex > -1)
            {
                try
                {
                    if (sortComboBox_Payment.SelectedIndex == 0)
                    {
                        toSort = "Payment_ID";
                    }
                    else if (sortComboBox_Payment.SelectedIndex == 1)
                    {
                        toSort = "PaymentRate_ID";
                    }
                    else if (sortComboBox_Payment.SelectedIndex == 2)
                    {
                        toSort = "Month";
                    }
                    else if (sortComboBox_Payment.SelectedIndex == 3)
                    {
                        toSort = "Paid";
                    }
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentDataGridView.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Оберіть параметр для сортування.", "Повідомлення");
            }
        }

        private void toFilter_Payment_Click(object sender, EventArgs e)
        {
            string month = "";
            int paid = 2;
            string select = "SELECT * FROM Payment WHERE ";
            string select_month = "Month = '";
            string select_paid = "Paid = ";

            if (yesRadioButton_Payment.Checked || noRadioButton_Payment.Checked || monthComboBox_Payment.Text != "")
            {
                if (monthComboBox_Payment.Text != "")
                {
                    month = monthComboBox_Payment.Text;
                }
                if (yesRadioButton_Payment.Checked)
                {
                    paid = 1;
                }
                else if (noRadioButton_Payment.Checked)
                {
                    paid = 0;
                }
                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (month != "" && paid != 2)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(select + select_month + month + "' AND " +
                            select_paid + paid, sqlconn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        paymentDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (paid != 2 && month == "")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(select + select_paid + paid, sqlconn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        paymentDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (paid == 2 && month != "")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(select + select_month + month + "'", sqlconn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        paymentDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void fromNumericUpDown_Rate_ValueChanged(object sender, EventArgs e)
        {
            if (toNumericUpDown_Rate.Value < fromNumericUpDown_Rate.Value)
            {
                MessageBox.Show("Некоректні суми.");
                fromNumericUpDown_Rate.Value = 100;
                toNumericUpDown_Rate.Value = 110;
            }
        }

        private void toNumericUpDown_Rate_ValueChanged(object sender, EventArgs e)
        {
            if (toNumericUpDown_Rate.Value < fromNumericUpDown_Rate.Value)
            {
                MessageBox.Show("Некоректні суми.");
                fromNumericUpDown_Rate.Value = 100;
                toNumericUpDown_Rate.Value = 110;
            }
        }
    }
}
