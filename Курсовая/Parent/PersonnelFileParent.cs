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

namespace Курсовая.Parent
{
    public partial class PersonnelFileParent : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        User user;

        public PersonnelFileParent()
        {
            InitializeComponent();
        }

        public PersonnelFileParent(User user) : this()
        {
            this.user = user;
        }

        private void PersonnelFileParent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolCourseDataSet.PersonnelFile". При необходимости она может быть перемещена или удалена.
            this.personnelFileTableAdapter.Fill(this.schoolCourseDataSet.PersonnelFile);

            string select = $"SELECT * FROM PersonnelFile WHERE Pupil_ID = {Convert.ToInt32(user.Password)}";

            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            SqlDataAdapter skipsDA = new SqlDataAdapter(select, sqlconn);
            DataTable skipsDT = new DataTable();
            skipsDA.Fill(skipsDT);
            pfilesDataGridView.DataSource = skipsDT;

            pfilesDataGridView.Columns[0].HeaderText = "ID учня";
            pfilesDataGridView.Columns[1].HeaderText = "ПІБ матері";
            pfilesDataGridView.Columns[2].HeaderText = "ПІБ батька";
            pfilesDataGridView.Columns[3].HeaderText = "ПІБ опікуна";
            pfilesDataGridView.Columns[4].HeaderText = "Адреса";
            pfilesDataGridView.Columns[5].HeaderText = "Телефон";
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

        private void back_PersonnelFiles_Click(object sender, EventArgs e)
        {
            MainParent mainParent = new MainParent(user);
            mainParent.Show();
            this.Hide();
        }

        private void PersonnelFileParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainParent mainParent = new MainParent(user);
            mainParent.Show();
            this.Hide();
        }
    }
}
