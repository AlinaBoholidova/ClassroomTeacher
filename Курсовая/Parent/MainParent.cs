using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая.Parent
{
    public partial class MainParent : Form
    {
        readonly string status = "Один з батьків/Опікун";
        User user;

        public MainParent()
        {
            InitializeComponent();
        }

        public MainParent(User user) : this()
        {
            this.user = user;
        }

        public MainParent(User user, string status) : this()
        {
            this.user = user;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти з програми?", "Вихід",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void pupilsButton_Main_Click(object sender, EventArgs e)
        {
            Pupils pupils = new Pupils(user, status);
            pupils.Show();
            this.Hide();
        }

        private void pfilesButton_Main_Click(object sender, EventArgs e)
        {
            PersonnelFileParent personnelFileParent = new PersonnelFileParent(user);
            personnelFileParent.Show();
            this.Hide();
        }

        private void testsSubjectsButton_Main_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects(user, status);
            subjects.Show();
            this.Hide();
        }

        private void journalRecordsButton_Click(object sender, EventArgs e)
        {
            JournalRecord journal = new JournalRecord(user, status);
            journal.Show();
            this.Hide();
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            AdditionalActivity activity = new AdditionalActivity(user, status);
            activity.Show();
            this.Hide();
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            PaymentsParent paymentsParent = new PaymentsParent(user);
            paymentsParent.Show();
            this.Hide();
        }

        private void paymentRatesButton_Click(object sender, EventArgs e)
        {
            PaymentsParent paymentsParent = new PaymentsParent(user);
            paymentsParent.Show();
            this.Hide();
        }

        private void receiptsButton_Click(object sender, EventArgs e)
        {
            ViewReceiptParent viewReceiptParent = new ViewReceiptParent(user);
            viewReceiptParent.Show();
            this.Hide();
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            ViewScores subjects = new ViewScores(user, status);
            subjects.Show();
            this.Hide();
        }

        private void MainParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти з програми?", "Вихід",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
