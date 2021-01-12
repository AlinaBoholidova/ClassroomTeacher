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
    public partial class AdditionalActivityData : Form
    {
        readonly bool edit;
        private readonly int id;

        public AdditionalActivityData()
        {
            InitializeComponent();
        }

        public AdditionalActivityData(int id, string name, DateTime date) : this()
        {
            edit = true;
            this.id = id;
            activity_nameTextBox.Text = name;
            activity_dateDateTimePicker.Value = date;
        }

        private void Cancel_AddActivity_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdditionalActivityData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.AdditionalActivity". При необходимости она может быть перемещена или удалена.
            this.additionalActivityTableAdapter.Fill(this.schoolCourseDataSet.AdditionalActivity);

        }

        private void OK_AddActivity_Click(object sender, EventArgs e)
        {
            if (ValidateAll(activity_nameTextBox))
            {
                string name = activity_nameTextBox.Text;
                string date = Convert.ToString(activity_dateDateTimePicker.Value.Date);

                if (edit)
                {
                    additionalActivityTableAdapter.UpdateQuery(name, date, id);
                }
                else
                {
                    additionalActivityTableAdapter.InsertQuery(name, date);
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
    }
}
