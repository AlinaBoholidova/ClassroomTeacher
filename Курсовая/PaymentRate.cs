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
    public partial class PaymentRate : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly bool edit;
        private readonly int id;

        public PaymentRate()
        {
            InitializeComponent();
            edit = false;
        }

        public PaymentRate(int id, string type, int sum) : this()
        {
            edit = true;
            this.id = id;
            paymentRate_typeTextBox.Text = type;
            sumNumericUpDown.Value = sum;
        }

        private void PaymentRate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PaymentRate". При необходимости она может быть перемещена или удалена.
            this.paymentRateTableAdapter.Fill(this.schoolCourseDataSet.PaymentRate);
        }

        private void Cancel_PaymentRate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_PaymentRate_Click(object sender, EventArgs e)
        {
            string type = paymentRate_typeTextBox.Text;
            int sum = Convert.ToInt32(sumNumericUpDown.Value);
            if (edit)
            {
                paymentRateTableAdapter.UpdateQuery(type, sum, id);
            }
            else
            {
                paymentRateTableAdapter.InsertQuery(type, sum);
            }
            Close();
        }
    }
}
