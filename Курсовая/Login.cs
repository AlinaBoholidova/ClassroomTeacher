using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.Parent;

namespace Курсовая
{
    public partial class Login : Form
    {
        const string ConnectionString = @"Data Source=DESKTOP-ELHNV9J\SQLEXPRESS;Initial Catalog=SchoolCourse;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
        }

        private void signIn_Login_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(ConnectionString);
            Table<User> users = db.GetTable<User>();

            try
            {
                User user = db.GetTable<User>().Where(t => t.Login == loginTextBox_Login.Text && 
                    t.Password == passwordTextBox_Login.Text).Single();
                string status = user.Status;
                if (user.Status == "Один з батьків/Опікун")
                {
                    MainParent main = new MainParent(user, status);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    Main main = new Main(status);
                    this.Hide();
                    main.Show();
                }
            }
            catch
            {
                MessageBox.Show("Користувача з такими даними не існує.", "Повідомлення");
                loginTextBox_Login.Clear();
                passwordTextBox_Login.Clear();
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox_Login.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '•';
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
