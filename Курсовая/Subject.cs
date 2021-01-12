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
    public partial class Subject : Form
    {
        readonly bool edit;
        private readonly string abbr;

        public Subject()
        {
            InitializeComponent();
            edit = false;
        }

        public Subject(string abbr, string name) : this()
        {
            edit = true;
            this.abbr = abbr;
            subject_abbrTextBox.Text = abbr;
            subject_nameTextBox.Text = name;
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.schoolCourseDataSet.Subject);
        }

        private void Cancel_Subject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Subject_Click(object sender, EventArgs e)
        {
            if (ValidateAll(subject_nameTextBox)&&ValidateAll(subject_abbrTextBox))
            {
                string newAbbr = subject_abbrTextBox.Text;
                if (edit)
                {
                    subjectTableAdapter.UpdateQuery(newAbbr, Convert.ToString(subject_nameTextBox.Text), abbr);
                }
                else
                {
                    subjectTableAdapter.InsertQuery(abbr, Convert.ToString(subject_nameTextBox.Text));
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
