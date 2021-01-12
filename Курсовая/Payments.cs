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
    public partial class Payments : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PaymentRate". При необходимости она может быть перемещена или удалена.
            this.paymentRateTableAdapter.Fill(this.schoolCourseDataSet.PaymentRate);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.schoolCourseDataSet.Payment);
        }

        private void showAll_Payment_Click(object sender, EventArgs e)
        {
            this.paymentTableAdapter.Fill(this.schoolCourseDataSet.Payment);
            paymentDataGridView.DataSource = paymentBindingSource;
        }

        private void showAll_Rate_Click(object sender, EventArgs e)
        {
            this.paymentRateTableAdapter.Fill(this.schoolCourseDataSet.PaymentRate);
            rateDataGridView.DataSource = rateBindingSource;
        }

        private void back_Payments_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void add_Payment_Click(object sender, EventArgs e)
        {
            var add = new PaymentData();
            add.ShowDialog();
            paymentTableAdapter.Fill(schoolCourseDataSet.Payment);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Payment_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.PaymentDataTable();
            paymentTableAdapter.FillBy1(ds, Convert.ToInt32(paymentDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new PaymentData(Convert.ToInt32(row[0]),
                Convert.ToInt32(row[1]),
                Convert.ToInt32(row[2]),
                Convert.ToString(row[3]),
                Convert.ToBoolean(row[4]));
            edt.ShowDialog();
            paymentTableAdapter.Fill(schoolCourseDataSet.Payment);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Payment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обрану оплату?", "Видалення оплати",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                paymentTableAdapter.DeleteQuery(Convert.ToInt32(paymentDataGridView.SelectedRows[0].Cells[0].Value));
                paymentTableAdapter.Fill(schoolCourseDataSet.Payment);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        private void add_Rate_Click(object sender, EventArgs e)
        {
            var add = new PaymentRate();
            add.ShowDialog();
            paymentRateTableAdapter.Fill(schoolCourseDataSet.PaymentRate);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Rate_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.PaymentRateDataTable();
            paymentRateTableAdapter.FillBy(ds, Convert.ToInt32(rateDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new PaymentRate(Convert.ToInt32(row[0]),
                row[1].ToString(),
                Convert.ToInt32(row[2]));
            edt.ShowDialog();
            paymentRateTableAdapter.Fill(schoolCourseDataSet.PaymentRate);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Rate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обраний тариф?", "Видалення тарифу",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                paymentRateTableAdapter.DeleteQuery(Convert.ToInt32(rateDataGridView.SelectedRows[0].Cells[0].Value));
                paymentRateTableAdapter.Fill(schoolCourseDataSet.PaymentRate);
                schoolCourseDataSet.AcceptChanges();
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
                            "CONCAT(Payment_ID, Pupil_ID, PaymentRate_ID, Month) " +
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
                    else if (pupilIDCheckBox_Payment.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Pupil_ID LIKE '%" + toSearch + "%'", sqlconn);
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
                        toSort = "Pupil_ID";
                    }
                    else if (sortComboBox_Payment.SelectedIndex == 2)
                    {
                        toSort = "PaymentRate_ID";
                    }
                    else if (sortComboBox_Payment.SelectedIndex == 3)
                    {
                        toSort = "Month";
                    }
                    else if (sortComboBox_Payment.SelectedIndex == 4)
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
                        SqlDataAdapter da = new SqlDataAdapter(select + select_paid + paid + "' AND " +
                            select_month + month, sqlconn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        paymentDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (paid != 2 && month == "")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(select + select_paid + paid + "'", sqlconn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        paymentDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (paid == 2 && month != "")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(select + select_month + month, sqlconn);
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
    }
}
