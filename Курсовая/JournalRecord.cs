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
using Курсовая.Parent;

namespace Курсовая
{
    public partial class JournalRecord : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly string status;
        User user;

        public JournalRecord()
        {
            InitializeComponent();
        }

        public JournalRecord(string status) : this()
        {
            this.status = status;
        }

        public JournalRecord(User user, string status) : this()
        {
            this.user = user;
            this.status = status;
            if (status == "Один з батьків/Опікун")
            {
                add_Record.Hide();
                edit_Record.Hide();
                delete_Record.Hide();
            }
        }

        private void JournalRecord_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.JournalRecord". При необходимости она может быть перемещена или удалена.
            this.journalRecordTableAdapter.Fill(this.schoolCourseDataSet.JournalRecord);

        }

        private void back_Record_Click(object sender, EventArgs e)
        {
            if (status == "Один з батьків/Опікун")
            {
                MainParent main = new MainParent(user, status);
                main.Show();
                this.Hide();
            }
            else
            {
                Main main = new Main(status);
                main.Show();
                this.Hide();
            }
        }

        private void add_Record_Click(object sender, EventArgs e)
        {
            var add = new JournalRecordData();
            add.ShowDialog();
            journalRecordTableAdapter.Fill(schoolCourseDataSet.JournalRecord);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Record_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.JournalRecordDataTable();
            journalRecordTableAdapter.FillBy2(ds, Convert.ToInt32(recordsDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new JournalRecordData(Convert.ToInt32(row[0]),
                Convert.ToInt32(row[1]),
                Convert.ToInt32(row[2]),
                Convert.ToInt32(row[3]));
            edt.ShowDialog();
            journalRecordTableAdapter.Fill(schoolCourseDataSet.JournalRecord);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Record_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обраний запис?", "Видалення запису журналу",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                journalRecordTableAdapter.DeleteQuery(Convert.ToInt32(recordsDataGridView.SelectedRows[0].Cells[0].Value));
                journalRecordTableAdapter.Fill(schoolCourseDataSet.JournalRecord);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        private void showAll_Record_Click(object sender, EventArgs e)
        {
            this.journalRecordTableAdapter.Fill(this.schoolCourseDataSet.JournalRecord);
            recordsDataGridView.DataSource = recordBindingSource;
        }

        private void toSearch_Records_Click(object sender, EventArgs e)
        {
            string toSearch = "";
            string select = "SELECT * FROM JournalRecord WHERE ";

            if (searchTextBox_Records.Text != "")
            {
                toSearch = searchTextBox_Records.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_Record.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(Record_ID, Pupil_ID, Test_ID, Score) " +
                            "LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        recordsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (recIDCheckBox_Record.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Record_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        recordsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (pupilIDCheckBox_Record.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Pupil_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        recordsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (testIDCheckBox_Record.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Test_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        recordsDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (scoreCheckBox_Record.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Score LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        recordsDataGridView.DataSource = dt;
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

        private void toSort_Records_Click(object sender, EventArgs e)
        {
            string toSort = "";
            string select = "SELECT * FROM JournalRecord ORDER BY ";

            if (sortComboBox_Records.SelectedIndex > -1)
            {
                try
                {
                    if (sortComboBox_Records.SelectedIndex == 0)
                    {
                        toSort = "Record_ID";
                    }
                    else if (sortComboBox_Records.SelectedIndex == 1)
                    {
                        toSort = "Pupil_ID";
                    }
                    else if (sortComboBox_Records.SelectedIndex == 2)
                    {
                        toSort = "Test_ID";
                    }
                    else if (sortComboBox_Records.SelectedIndex == 3)
                    {
                        toSort = "Score";
                    }
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    recordsDataGridView.DataSource = dt;
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

        private void toFilter_Records_Click(object sender, EventArgs e)
        {
            int fromPoints = Convert.ToInt32(fromNumericUpDown_Points.Value);
            int toPoints = Convert.ToInt32(toNumericUpDown_Points.Value);
            string select = "SELECT * FROM JournalRecord WHERE Score " +
                $"BETWEEN {fromPoints} AND {toPoints}";

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                recordsDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void JournalRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (status == "Один з батьків/Опікун")
            {
                MainParent main = new MainParent(user, status);
                main.Show();
                this.Hide();
            }
            else
            {
                Main main = new Main(status);
                main.Show();
                this.Hide();
            }
        }
    }
}
