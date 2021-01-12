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
    public partial class Subjects : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly string status;

        public Subjects()
        {
            InitializeComponent();
        }

        public Subjects(string status) : this()
        {
            this.status = status;
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.schoolCourseDataSet.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.schoolCourseDataSet.Subject);
        }

        private void Subjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main(status);
            main.Show();
            this.Hide();
        }

        // Tests
        private void showAll_Tests_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.schoolCourseDataSet.Test);
            testsDataGridView.DataSource = testBindingSource;
        }

        private void toSearch_Tests_Click(object sender, EventArgs e)
        {
            string toSearch = "";
            string select = "SELECT * FROM Test WHERE ";

            if (searchTextBox_Tests.Text != "")
            {
                toSearch = searchTextBox_Tests.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_Tests.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(Test_ID, Subject_abbr, CONVERT(varchar, Test_date, 104)) " +
                            "LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        testsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (idCheckBox_Tests.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Test_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        testsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (abbrCheckBox_Tests.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Subject_abbr LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        testsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (dateCheckBox_Tests.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONVERT(varchar, Test_date, 104) LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        testsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void toSort_Tests_Click(object sender, EventArgs e)
        {
            string toSort = "";
            string select = "SELECT * FROM Test ORDER BY ";

            if (sortComboBox_Tests.SelectedIndex == 0)
            {
                toSort = "Test_ID";
            }
            else if (sortComboBox_Tests.SelectedIndex == 1)
            {
                toSort = "Subject_abbr";
            }
            else
            {
                toSort = "Test_date";
            }

            if (sortComboBox_Tests.SelectedIndex > -1)
            {
                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    testsDataGridView.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }



        // Subjects
        private void showAll_Subjects_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.schoolCourseDataSet.Subject);
            subjectsDataGridView.DataSource = subjectBindingSource;
        }

        private void toSearch_Subjects_Click(object sender, EventArgs e)
        {
            string toSearch = "";
            string select = "SELECT * FROM Subject WHERE ";

            if (searchTextBox_Subjects.Text != "")
            {
                toSearch = searchTextBox_Subjects.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_Subjects.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(Subject_abbr, Subject_name) LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        subjectsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (abbrCheckBox_Subjects.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Subject_abbr LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        subjectsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (nameCheckBox_Subjects.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Subject_name LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        subjectsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void toSort_Subjects_Click(object sender, EventArgs e)
        {
            string toSort = "";
            string select = "SELECT * FROM Subject ORDER BY ";

            if (sortComboBox_Tests.SelectedIndex == 0)
            {
                toSort = "Subject_abbr";
            }
            else
            {
                toSort = "Subject_name";
            }

            if (sortComboBox_Subjects.SelectedIndex > -1)
            {
                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    subjectsDataGridView.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void toFilter_Tests_Click(object sender, EventArgs e)
        {
            string fromDate = fromDateTimePicker.Value.ToString("yyyy-MM-dd");
            string toDate = toDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string select = "SELECT * FROM Test WHERE Test_date " +
                $"BETWEEN CONVERT(datetime, '{fromDate}') AND CONVERT(datetime, '{toDate}')";

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                testsDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }


        private void add_Tests_Click(object sender, EventArgs e)
        {
            var add = new Test();
            add.ShowDialog();
            testTableAdapter.Fill(schoolCourseDataSet.Test);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Tests_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.TestDataTable();
            testTableAdapter.FillBy(ds, Convert.ToInt32(testsDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new Test(Convert.ToInt32(row[0]),
                row[1].ToString(),
                Convert.ToDateTime(row[2]));
            edt.ShowDialog();
            testTableAdapter.Fill(schoolCourseDataSet.Test);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Tests_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обрану контрольну роботу?", "Видалення контрольної роботи",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                testTableAdapter.DeleteQuery(Convert.ToInt32(testsDataGridView.SelectedRows[0].Cells[0].Value));
                testTableAdapter.Fill(schoolCourseDataSet.Test);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        private void add_Subjects_Click(object sender, EventArgs e)
        {
            var add = new Subject();
            add.ShowDialog();
            subjectTableAdapter.Fill(schoolCourseDataSet.Subject);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Subjects_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.SubjectDataTable();
            subjectTableAdapter.FillBy(ds, Convert.ToString(subjectsDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new Subject(row[0].ToString(),
                row[1].ToString());
            edt.ShowDialog();
            subjectTableAdapter.Fill(schoolCourseDataSet.Subject);
            testTableAdapter.Fill(schoolCourseDataSet.Test);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Subjects_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обраний предмет?", "Видалення навчального предмету",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                subjectTableAdapter.DeleteQuery(Convert.ToString(subjectsDataGridView.SelectedRows[0].Cells[0].Value));
                subjectTableAdapter.Fill(schoolCourseDataSet.Subject);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        private void back_Subjects_Click(object sender, EventArgs e)
        {
            Main main = new Main(status);
            main.Show();
            this.Hide();
        }
    }
}
