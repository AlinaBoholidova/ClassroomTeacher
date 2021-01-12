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
    public partial class QueryEdit : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";
        readonly string status;

        public QueryEdit()
        {
            InitializeComponent();
        }

        public QueryEdit(string status) : this()
        {
            this.status = status;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Main main = new Main(status);
            main.Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            queryInput.Clear();
            queryInput.Text = "SELECT ";
        }

        private void sqlButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(queryInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                queryDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void QueryEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main(status);
            main.Show();
            this.Hide();
        }
    }
}
