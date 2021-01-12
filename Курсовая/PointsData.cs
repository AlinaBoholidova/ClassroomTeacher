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
    public partial class PointsData : Form
    {
        readonly bool edit;
        private readonly int id;

        public PointsData()
        {
            InitializeComponent();
        }

        public PointsData(int id, string place, int points) : this()
        {
            edit = true;
            this.id = id;
            placeTextBox.Text = place;
            pointsNumericUpDown.Value = points;
        }

        private void Points_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PointsDistribution". При необходимости она может быть перемещена или удалена.
            this.pointsDistributionTableAdapter.Fill(this.schoolCourseDataSet.PointsDistribution);

        }

        private void Cancel_Points_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Points_Click(object sender, EventArgs e)
        {
            if (ValidateAll(placeTextBox))
            {
                string place = placeTextBox.Text;
                int points = Convert.ToInt32(pointsNumericUpDown.Value);

                if (edit)
                {
                    pointsDistributionTableAdapter.UpdateQuery(place, points, id);
                }
                else
                {
                    pointsDistributionTableAdapter.InsertQuery(place, points);
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
