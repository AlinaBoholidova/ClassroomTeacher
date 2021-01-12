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
    public partial class Points : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        public Points()
        {
            InitializeComponent();
        }

        private void showAll_Points_Click(object sender, EventArgs e)
        {
            this.pointsDistributionTableAdapter.Fill(this.schoolCourseDataSet.PointsDistribution);
            pointsDataGridView.DataSource = pointsBindingSource;
        }

        private void Points_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PointsDistribution". При необходимости она может быть перемещена или удалена.
            this.pointsDistributionTableAdapter.Fill(this.schoolCourseDataSet.PointsDistribution);
        }

        private void back_Points_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }

        private void add_Points_Click(object sender, EventArgs e)
        {
            var add = new PointsData();
            add.ShowDialog();
            pointsDistributionTableAdapter.Fill(schoolCourseDataSet.PointsDistribution);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Points_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.PointsDistributionDataTable();
            pointsDistributionTableAdapter.FillBy(ds,
                Convert.ToInt32(pointsDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new PointsData(Convert.ToInt32(row[0]),
                row[1].ToString(),
                Convert.ToInt32(row[2]));
            edt.ShowDialog();
            pointsDistributionTableAdapter.Fill(schoolCourseDataSet.PointsDistribution);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Points_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обрану розбаловку?", "Видалення розбаловки",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pointsDistributionTableAdapter.DeleteQuery(
                    Convert.ToInt32(pointsDataGridView.SelectedRows[0].Cells[0].Value));
                pointsDistributionTableAdapter.Fill(schoolCourseDataSet.PointsDistribution);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        private void toSearch_Points_Click(object sender, EventArgs e)
        {
            string toSearch = "";
            string select = "SELECT * FROM AdditionalActivity WHERE ";

            if (searchTextBox_Points.Text != "")
            {
                toSearch = searchTextBox_Points.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_Points.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(Distribution_ID, Place, Points) " +
                            "LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pointsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (disrtIDCheckBox_Points.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Distribution_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pointsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (placeCheckBox_Points.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Place LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pointsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (pointsCheckBox_Points.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Points LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pointsDataGridView.DataSource = dt;
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

        private void toSort_Points_Click(object sender, EventArgs e)
        {
            string toSort = "";
            string select = "SELECT * FROM PointsDistribution ORDER BY ";

            if (sortComboBox_Points.SelectedIndex > -1)
            {
                try
                {
                    if (sortComboBox_Points.SelectedIndex == 0)
                    {
                        toSort = "Distribution_ID";
                    }
                    else if (sortComboBox_Points.SelectedIndex == 1)
                    {
                        toSort = "Place";
                    }
                    else if (sortComboBox_Points.SelectedIndex == 2)
                    {
                        toSort = "Points";
                    }
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    pointsDataGridView.DataSource = dt;
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

        private void toFilter_Points_Click(object sender, EventArgs e)
        {
            int fromPoints = Convert.ToInt32(fromNumericUpDown_Points.Value);
            int toPoints = Convert.ToInt32(toNumericUpDown_Points.Value);
            string select = "SELECT * FROM PointsDistribution WHERE Points " +
                $"BETWEEN {fromPoints} AND {toPoints}";

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                pointsDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void fromNumericUpDown_Points_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
