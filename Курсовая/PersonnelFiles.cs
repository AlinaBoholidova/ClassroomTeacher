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
    public partial class PersonnelFiles : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly string status;

        public PersonnelFiles()
        {
            InitializeComponent();
        }

        public PersonnelFiles(string status) : this()
        {
            this.status = status;
        }

        private void PersonnelFiles_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PersonnelFile". При необходимости она может быть перемещена или удалена.
            this.personnelFileTableAdapter.Fill(this.schoolCourseDataSet.PersonnelFile);
        }

        private void add_PersonnelFiles_Click(object sender, EventArgs e)
        {
            var add = new PersonnelFile();
            add.pupil_IDTextBox.ReadOnly = false;
            add.ShowDialog();
            personnelFileTableAdapter.Fill(schoolCourseDataSet.PersonnelFile);
            schoolCourseDataSet.AcceptChanges();
        }

        private void edit_PersonnelFiles_Click(object sender, EventArgs e)
        {
            var ds = new SchoolCourseDataSet.PersonnelFileDataTable();
            personnelFileTableAdapter.FillBy(ds, Convert.ToInt32(pfilesDataGridView.SelectedRows[0].Cells[0].Value));
            object[] row = ds.Rows[0].ItemArray;
            var edt = new PersonnelFile(Convert.ToInt32(row[0]),
                row[1].ToString(),
                row[2].ToString(),
                row[3].ToString(),
                row[4].ToString(),
                row[5].ToString());
            edt.ShowDialog();
            personnelFileTableAdapter.Fill(schoolCourseDataSet.PersonnelFile);
            schoolCourseDataSet.AcceptChanges();
        }

        private void delete_PersonnelFiles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити особову справу учня?", "Видалення особової справи",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                personnelFileTableAdapter.DeleteQuery(Convert.ToInt32(pfilesDataGridView.SelectedRows[0].Cells[0].Value));
                personnelFileTableAdapter.Fill(schoolCourseDataSet.PersonnelFile);
                schoolCourseDataSet.AcceptChanges();
            }
        }

        private void showAll_PersonnelFiles_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PersonnelFile". При необходимости она может быть перемещена или удалена.
            this.personnelFileTableAdapter.Fill(this.schoolCourseDataSet.PersonnelFile);
            pfilesDataGridView.DataSource = pfileBindingSource;
        }

        private void toSort_PersonnelFiles_Click(object sender, EventArgs e)
        {
            string toSort = "";
            string select = "SELECT * FROM PersonnelFile ORDER BY ";

            if (sortComboBox_PersonnelFiles.SelectedIndex == 0)
            {
                toSort = "Pupil_ID";
            }
            else if (sortComboBox_PersonnelFiles.SelectedIndex == 1)
            {
                toSort = "SNP_father";
            }
            else if (sortComboBox_PersonnelFiles.SelectedIndex == 2)
            {
                toSort = "SNP_mother";
            }
            else if (sortComboBox_PersonnelFiles.SelectedIndex == 3)
            {
                toSort = "SNP_custodian";
            }
            else if (sortComboBox_PersonnelFiles.SelectedIndex == 4)
            {
                toSort = "Address";
            }
            else
            {
                toSort = "Phone";
            }

            if (sortComboBox_PersonnelFiles.SelectedIndex > -1)
            {
                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(select + toSort, sqlconn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    pfilesDataGridView.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            } 
        }

        private void toSearch_Pupils_Click(object sender, EventArgs e)
        {
            string toSearch = "";
            string select = "SELECT * FROM PersonnelFile WHERE ";

            if (searchTextBox_PersonnelFiles.Text != "")
            {
                toSearch = searchTextBox_PersonnelFiles.Text;

                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    if (allCheckBox_PersonnelFiles.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(Pupil_ID, SNP_father, SNP_mother, SNP_custodian, Address," +
                            "Phone) LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pfilesDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (idCheckBox_PersonnelFiles.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Pupil_ID LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pfilesDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (snpCheckBox_PersonnelFiles.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "CONCAT(SNP_father, SNP_mother, SNP_custodian) LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pfilesDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (addressCheckBox_PersonnelFiles.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Address LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pfilesDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                    else if (phoneCheckBox_PersonnelFiles.Checked)
                    {
                        SqlDataAdapter oda = new SqlDataAdapter(select +
                            "Phone LIKE '%" + toSearch + "%'", sqlconn);
                        DataTable dt = new DataTable();
                        oda.Fill(dt);
                        pfilesDataGridView.DataSource = dt;
                        sqlconn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
        }

        private void back_PersonnelFiles_Click(object sender, EventArgs e)
        {
            Main main = new Main(status);
            main.Show();
            this.Hide();
        }

        private void PersonnelFiles_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main(status);
            main.Show();
            this.Hide();
        }
    }
}
