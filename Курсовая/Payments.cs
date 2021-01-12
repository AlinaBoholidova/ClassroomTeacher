using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Payments : Form
    {
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
    }
}
