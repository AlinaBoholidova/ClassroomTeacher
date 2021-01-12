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
    public partial class AdditionalActivity : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly string status;
        User user;

        public AdditionalActivity()
        {
            InitializeComponent();
        }

        public AdditionalActivity(User user, string status) : this()
        {
            this.user = user;
            this.status = status;
            if (status == "Класний керівник")
            {
                add_Activity.Enabled = false;
                edit_Activity.Enabled = false;
                delete_Activity.Enabled = false;
            }
            if (status == "Один з батьків/Опікун")
            {
                add_Activity.Hide();
                edit_Activity.Hide();
                delete_Activity.Hide();
                add_Participation.Hide();
                edit_Participation.Hide();
                delete_Participation.Hide();
            }
        }

        public AdditionalActivity(string status) : this()
        {
            this.status = status;
            if (status == "Класний керівник")
            {
                add_Activity.Enabled = false;
                edit_Activity.Enabled = false;
                delete_Activity.Enabled = false;
            }
            if (status == "Один з батьків/Опікун")
            {
                add_Activity.Hide();
                edit_Activity.Hide();
                delete_Activity.Hide();
                add_Participation.Hide();
                edit_Participation.Hide();
                delete_Participation.Hide();
            }
        }

        private void AdditionalActivity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.AdditionalActivity". При необходимости она может быть перемещена или удалена.
            this.additionalActivityTableAdapter.Fill(this.schoolCourseDataSet.AdditionalActivity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.AdditionalParticipation". При необходимости она может быть перемещена или удалена.
            this.additionalParticipationTableAdapter.Fill(this.schoolCourseDataSet.AdditionalParticipation);
        }

        // Додаткова участь
        private void showAll_Participation_Click(object sender, EventArgs e)
        {
            this.additionalParticipationTableAdapter.Fill(this.schoolCourseDataSet.AdditionalParticipation);
            participationDataGridView.DataSource = participationBindingSource;
        }

        private void add_Participation_Click(object sender, EventArgs e)
        {
            var add = new AdditionalParticipation();
            add.ShowDialog();
            additionalParticipationTableAdapter.Fill(schoolCourseDataSet.AdditionalParticipation);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Participation_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.AdditionalParticipationDataTable();
            additionalParticipationTableAdapter.FillBy2(ds,
                Convert.ToInt32(participationDataGridView.SelectedRows[0].Cells[0].Value),
                Convert.ToInt32(participationDataGridView.SelectedRows[0].Cells[1].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new AdditionalParticipation(Convert.ToInt32(row[0]),
                Convert.ToInt32(row[1]),
                Convert.ToInt32(row[2]));
            edt.ShowDialog();
            additionalParticipationTableAdapter.Fill(schoolCourseDataSet.AdditionalParticipation);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Participation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обрану участь?", "Видалення участі",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                additionalParticipationTableAdapter.DeleteQuery(
                    Convert.ToInt32(participationDataGridView.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(participationDataGridView.SelectedRows[0].Cells[1].Value));
                additionalParticipationTableAdapter.Fill(schoolCourseDataSet.AdditionalParticipation);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        // Додаткова активність
        private void showAll_Activity_Click(object sender, EventArgs e)
        {
            this.additionalActivityTableAdapter.Fill(this.schoolCourseDataSet.AdditionalActivity);
            activityDataGridView.DataSource = activityBindingSource;
        }

        private void add_Activity_Click(object sender, EventArgs e)
        {
            var add = new AdditionalActivityData();
            add.ShowDialog();
            additionalActivityTableAdapter.Fill(schoolCourseDataSet.AdditionalActivity);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_Activity_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.AdditionalActivityDataTable();
            additionalActivityTableAdapter.FillBy(ds, Convert.ToInt32(activityDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new AdditionalActivityData(Convert.ToInt32(row[0]),
                row[1].ToString(),
                Convert.ToDateTime(row[2]));
            edt.ShowDialog();
            additionalActivityTableAdapter.Fill(schoolCourseDataSet.AdditionalActivity);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_Activity_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити обрану активність?", "Видалення активності",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                additionalActivityTableAdapter.DeleteQuery(Convert.ToInt32(activityDataGridView.SelectedRows[0].Cells[0].Value));
                additionalActivityTableAdapter.Fill(schoolCourseDataSet.AdditionalActivity);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        private void back_AddActivity_Click(object sender, EventArgs e)
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

        private void AdditionalActivity_FormClosing(object sender, FormClosingEventArgs e)
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

        private void toSearch_Participation_Click(object sender, EventArgs e)
        {
            string toSearch = "";
            string select = "SELECT * FROM AdditionalParticipation WHERE ";

            if (searchTextBox_Participation.Text != "")
            {
                toSearch = searchTextBox_Participation.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_Participation.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(Pupil_ID, Activity_ID, Distribution_ID) " +
                            "LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        participationDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (pupilIDCheckBox_Participation.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Pupil_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        participationDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (actIDCheckBox_Participation.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Activity_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        participationDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (distrIDCheckBox_Participation.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Distribution_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        participationDataGridView.DataSource = dt;
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

        private void toSort_Participation_Click(object sender, EventArgs e)
        {
            string toSort = "";
            string select = "SELECT * FROM AdditionalParticipation ORDER BY ";

            if (sortComboBox_Participation.SelectedIndex > -1)
            {
                try
                {
                    if (sortComboBox_Participation.SelectedIndex == 0)
                    {
                        toSort = "Pupil_ID";
                    }
                    else if (sortComboBox_Participation.SelectedIndex == 1)
                    {
                        toSort = "Activity_ID";
                    }
                    else if (sortComboBox_Participation.SelectedIndex == 2)
                    {
                        toSort = "Distribution_ID";
                    }
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    participationDataGridView.DataSource = dt;
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

        private void toSearch_Activity_Click(object sender, EventArgs e)
        {
            string toSearch = "";
            string select = "SELECT * FROM AdditionalActivity WHERE ";

            if (searchTextBox_Activity.Text != "")
            {
                toSearch = searchTextBox_Activity.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_Activity.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(Activity_ID, Activity_name, CONVERT(varchar, Activity_date, 104)) " +
                            "LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        activityDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (pupilIDCheckBox_Activity.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Activity_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        activityDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (nameCheckBox_Activity.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Activity_name LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        activityDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (dateCheckBox_Activity.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONVERT(varchar, Activity_date, 104) LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        activityDataGridView.DataSource = dt;
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

        private void toSort_Activity_Click(object sender, EventArgs e)
        {
            string toSort = "";
            string select = "SELECT * FROM AdditionalActivity ORDER BY ";

            if (sortComboBox_Activity.SelectedIndex > -1)
            {
                try
                {
                    if (sortComboBox_Activity.SelectedIndex == 0)
                    {
                        toSort = "Activity_ID";
                    }
                    else if (sortComboBox_Activity.SelectedIndex == 1)
                    {
                        toSort = "Activity_name";
                    }
                    else if (sortComboBox_Activity.SelectedIndex == 2)
                    {
                        toSort = "Activity_date";
                    }
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    activityDataGridView.DataSource = dt;
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

        private void toFilter_Activity_Click(object sender, EventArgs e)
        {
            string fromDate = fromDateTimePicker.Value.ToString("yyyy-MM-dd");
            string toDate = toDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string select = "SELECT * FROM AdditionalActivity WHERE Activity_date " +
                $"BETWEEN CONVERT(datetime, '{fromDate}') AND CONVERT(datetime, '{toDate}')";

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(select, sqlconn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                activityDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }
    }
}
