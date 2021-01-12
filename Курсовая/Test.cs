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
    public partial class Test : Form
    {
        readonly bool edit;
        private readonly int id;

        public Test()
        {
            InitializeComponent();
            edit = false;
        }

        public Test(int id, string abbr, DateTime testDate) : this()
        {
            edit = true;
            this.id = id;
            subject_abbrComboBox.SelectedIndex = subject_abbrComboBox.Items.IndexOf(abbr);
            test_dateDateTimePicker.Value = testDate;
        }

        private void OK_Test_Click(object sender, EventArgs e)
        {
            string abbr = "";

            if (subject_abbrComboBox.SelectedIndex > -1)
            {
                abbr = subject_abbrComboBox.Text;
            }
            if (edit)
            {
                testTableAdapter.UpdateQuery(abbr, Convert.ToString(test_dateDateTimePicker.Value.Date), id);
            }
            else
            {
                testTableAdapter.InsertQuery(abbr, Convert.ToString(test_dateDateTimePicker.Value.Date));
            }

            Close();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.schoolCourseDataSet.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.schoolCourseDataSet.Subject);
        }

        private void Cancel_Test_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
