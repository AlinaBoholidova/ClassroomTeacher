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
    public partial class PupilData : Form
    {
        readonly bool edit;
        private readonly int id;
        public PupilData()
        {
            InitializeComponent();
            edit = false;
        }

        public PupilData(int id, string SNP, string gender, DateTime birthDate) : this()
        {
            edit = true;
            this.id = id;
            SNP_PupilData.Text = SNP;
            birthDate_PupilData.Value = birthDate;
            switch (gender.ToUpper())
            {
                case "Ч":
                    gender_PupilData.SelectedIndex = 0;
                    break;
                case "Ж":
                    gender_PupilData.SelectedIndex = 1;
                    break;
                default:
                    gender_PupilData.SelectedIndex = 0;
                    break;
            }
        }

        private void OK_PupilData_Click(object sender, EventArgs e)
        {
            if (ValidateAll(SNP_PupilData))
            {
                string gender = "";

                if (gender_PupilData.SelectedIndex == 0)
                {
                    gender = "Ч";
                }
                else if (gender_PupilData.SelectedIndex == 1)
                {
                    gender = "Ж";
                }
                if (edit)
                {
                    pupilTableAdapter.UpdateQuery(SNP_PupilData.Text, gender,
                        Convert.ToString(birthDate_PupilData.Value.Date), id);
                }
                else
                {
                    pupilTableAdapter.InsertQuery(SNP_PupilData.Text, gender,
                        Convert.ToString(birthDate_PupilData.Value.Date));
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

        private void PupilData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);
        }

        private void Cancel_PupilData_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
