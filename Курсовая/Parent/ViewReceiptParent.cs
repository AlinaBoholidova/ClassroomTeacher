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

namespace Курсовая.Parent
{
    public partial class ViewReceiptParent : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        User user;

        public ViewReceiptParent()
        {
            InitializeComponent();
        }

        public ViewReceiptParent(User user) : this()
        {
            this.user = user;
        }

        private void back_Receipt_Click(object sender, EventArgs e)
        {
            MainParent main = new MainParent(user);
            main.Show();
            this.Hide();
        }

        private void ViewReceiptParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainParent main = new MainParent(user);
            main.Show();
            this.Hide();
        }

        private void ViewReceiptParent_Load(object sender, EventArgs e)
        {
            try
            {
                string select = "SELECT Payment.Payment_ID, Pupil.SNP, PaymentRate.PaymentRate_type, " +
                "PaymentRate.Sum, Payment.Month " +
                "FROM Pupil INNER JOIN Payment ON Pupil.Pupil_ID = Payment.Pupil_ID INNER JOIN " +
                "PaymentRate ON Payment.PaymentRate_ID = PaymentRate.PaymentRate_ID " +
                $"WHERE Pupil_ID = {Convert.ToInt32(user.Password)} AND Payment.Paid = 0";

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
                MessageBox.Show("Ваша дитина не має боргів.", "Повідомлення");
            }
            
        }

        private void receiptPreviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.receiptReportViewer.RefreshReport();
                int id = Convert.ToInt32(paymentDataGridView.SelectedRows[0].Cells[0].Value);
                string select = "SELECT Payment.Payment_ID, Pupil.SNP, PaymentRate.PaymentRate_type, " +
                    "PaymentRate.Sum, Payment.Month " +
                    "FROM Pupil INNER JOIN Payment ON Pupil.Pupil_ID = Payment.Pupil_ID INNER JOIN " +
                    "PaymentRate ON Payment.PaymentRate_ID = PaymentRate.PaymentRate_ID " +
                    "WHERE Payment.Paid = 0 AND Payment.Pupil_ID = " +
                    $"(SELECT Pupil_ID FROM Payment WHERE Payment_ID = {id})";

                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlconn.Close();
                ReportDataSource pupilRDS = new ReportDataSource("pupilDataSet", dt);
                ReportDataSource paymentRDS = new ReportDataSource("paymentDataSet", dt);
                ReportDataSource paymentRateRDS = new ReportDataSource("paymentRateDataSet", dt);
                receiptReportViewer.LocalReport.ReportPath = @"Reports/Receipt.rdlc";
                receiptReportViewer.LocalReport.DataSources.Clear();
                receiptReportViewer.LocalReport.DataSources.Add(pupilRDS);
                receiptReportViewer.LocalReport.DataSources.Add(paymentRDS);
                receiptReportViewer.LocalReport.DataSources.Add(paymentRateRDS);
                receiptReportViewer.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Ваша дитина не має боргів.", "Повідомлення");
            }
            
        }

    }
}
