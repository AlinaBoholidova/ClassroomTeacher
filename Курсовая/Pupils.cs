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
    public partial class Pupils : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly string status;
        User user;

        public Pupils()
        {
            InitializeComponent();
        }

        public Pupils(string status) : this()
        {
            this.status = status;
        }

        public Pupils(User user, string status) : this()
        {
            this.status = status;
            this.user = user;
            if (status == "Один з батьків/Опікун")
            {
                personnelFileButton_Pupils.Hide();
                add_Pupils.Hide();
                edit_Pupils.Hide();
                delete_Pupils.Hide();
            }
        }

        private void Учні_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PersonnelFile". При необходимости она может быть перемещена или удалена.
            this.personnelFileTableAdapter.Fill(this.schoolCourseDataSet.PersonnelFile);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Pupil". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);
        }

        // Додати учня
        private void add_Pupils_Click(object sender, EventArgs e)
        {
            var add = new PupilData();
            add.ShowDialog();
            pupilTableAdapter.Fill(schoolCourseDataSet.Pupil);
            schoolCourseDataSet.AcceptChanges();
            if (add.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Не забудьте заповнити особову справу учня!", "Повідомлення");
            }
        }

        // Змінити дані учня
        private void edit_Pupils_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.PupilDataTable();
            pupilTableAdapter.FillBy(ds, Convert.ToInt32(pupilDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new PupilData(Convert.ToInt32(row[0]),
                row[1].ToString(),
                row[2].ToString(),
                Convert.ToDateTime(row[3]));
            edt.ShowDialog();
            pupilTableAdapter.Fill(schoolCourseDataSet.Pupil);
            schoolCourseDataSet.AcceptChanges();
        }

        // Видалити учня
        private void delete_Pupils_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити учня та всі пов'язані з ним дані?", "Видалення учня",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pupilTableAdapter.DeleteQuery(Convert.ToInt32(pupilDataGridView.SelectedRows[0].Cells[0].Value));
                pupilTableAdapter.Fill(schoolCourseDataSet.Pupil);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        // Показати всіх учнів
        private void showAll_Pupils_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.Учні". При необходимости она может быть перемещена или удалена.
            this.pupilTableAdapter.Fill(this.schoolCourseDataSet.Pupil);
            pupilDataGridView.DataSource = pupilBindingSource;
        }

        // Відкрити особову справу
        private void personnelFileButton_Pupils_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.PersonnelFileDataTable();
            personnelFileTableAdapter.FillBy(ds, Convert.ToInt32(pupilDataGridView.SelectedRows[0].Cells[0].Value));

            try
            {
                object[] row = ds.Rows[0].ItemArray;
                var edit_file = new PersonnelFile(Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString());
                edit_file.ShowDialog();
            }
            catch
            {
                var create_file = new PersonnelFile(Convert.ToInt32(pupilDataGridView.SelectedRows[0].Cells[0].Value));
                create_file.ShowDialog();
            }

            personnelFileTableAdapter.Fill(schoolCourseDataSet.PersonnelFile);
            schoolCourseDataSet.AcceptChanges();
        }

        // Пошук
        private void toSearch_Pupils_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM Pupil WHERE ";
            string toSearch = "";

            if (searchTextBox_Pupils.Text != "")
            {
                toSearch = searchTextBox_Pupils.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_Pupils.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(Pupil_ID, SNP, CONVERT(varchar, BirthDate, 104)) " +
                            "LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pupilDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (idCheckBox_Pupils.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Pupil_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pupilDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (snpCheckBox_Pupils.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "ПІБ LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pupilDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (birthCheckBox_Pupils.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONVERT(varchar, BirthDate, 104) LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pupilDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        // Сортування
        private void toSort_Pupils_Click(object sender, EventArgs e)
        {
            string toSort;
            string select = "SELECT * FROM Pupil ORDER BY ";
            
            if (sortComboBox_Pupils.SelectedIndex == 0)
            {
                toSort = "Pupil_ID";
            }
            else if (sortComboBox_Pupils.SelectedIndex == 1)
            {
                toSort = "SNP";
            }
            else if (sortComboBox_Pupils.SelectedIndex == 2)
            {
                toSort = "Gender";
            }
            else
            {
                toSort = "BirthDate";
            }

            if (sortComboBox_Pupils.SelectedIndex > -1)
            {
                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    pupilDataGridView.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        // Фільтрація
        private void toFilter_Pupils_Click(object sender, EventArgs e)
        {
            string month = "";
            string gender = "";
            string select = "SELECT * FROM Pupil WHERE ";
            string select_month = "MONTH(BirthDate) = ";
            string select_gender = "Gender = '";

            if (maleRadioButton_Pupils.Checked || femaleRadioButton_Pupils.Checked || monthComboBox_Pupils.Text != "")
            {
                if (monthComboBox_Pupils.Text != "")
                {
                    month = monthComboBox_Pupils.SelectedItem.ToString().Remove(2, 
                        monthComboBox_Pupils.SelectedItem.ToString().Length - 2);
                }
                if (maleRadioButton_Pupils.Checked)
                {
                    gender = "Ч";
                }
                else if (femaleRadioButton_Pupils.Checked)
                {
                    gender = "Ж";
                }
                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (gender != "" && month != "")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(select + select_gender + gender + "' AND " +
                            select_month + month, sqlconn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        pupilDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (gender != "" && month == "")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(select + select_gender + gender + "'", sqlconn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        pupilDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (gender == "" && month != "")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(select + select_month + month, sqlconn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        pupilDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void back_Pupils_Click(object sender, EventArgs e)
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

        private void Pupils_FormClosing(object sender, FormClosingEventArgs e)
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
