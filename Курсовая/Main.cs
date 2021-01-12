using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
    public partial class Main : Form
    {
        readonly string status;
        public Main()
        {
            InitializeComponent();
        }

        public Main(string status) : this()
        {
            this.status = status;
        }

        private void pupilsButton_Main_Click(object sender, EventArgs e)
        {
            Pupils pupils = new Pupils(status);
            this.Hide();
            pupils.Show();
        }

        private void pfilesButton_Main_Click(object sender, EventArgs e)
        {
            PersonnelFiles pfiles = new PersonnelFiles(status);
            this.Hide();
            pfiles.Show();
        }

        private void testsSubjectsButton_Main_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects(status);
            this.Hide();
            subjects.Show();
        }

        private void journalRecordsButton_Click(object sender, EventArgs e)
        {
            JournalRecord journal = new JournalRecord(status);
            this.Hide();
            journal.Show();
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            AdditionalActivity activity = new AdditionalActivity(status);
            this.Hide();
            activity.Show();
        }

        private void distributionButton_Click(object sender, EventArgs e)
        {
            Points points = new Points(status);
            this.Hide();
            points.Show();
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(status);
            this.Hide();
            payments.Show();
        }

        private void paymentRatesButton_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(status);
            this.Hide();
            payments.Show();
        }

        private void birthdaysButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.statsTabControl.SelectedTab = statistics.birthdaysTabPage;
            statistics.Show();
        }

        private void skipsButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.statsTabControl.SelectedTab = statistics.skipsTabPage;
            statistics.Show();
        }

        private void activititesButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.statsTabControl.SelectedTab = statistics.activitiesTabPage;
            statistics.Show();
        }

        private void debtersButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.statsTabControl.SelectedTab = statistics.debtersTabPage;
            statistics.Show();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            QueryEdit queryEdit = new QueryEdit(status);
            this.Hide();
            queryEdit.Show();
        }

        private void receiptsButton_Click(object sender, EventArgs e)
        {
            ViewReceipt subjects = new ViewReceipt(status);
            this.Hide();
            subjects.Show();
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            ViewScores subjects = new ViewScores(status);
            this.Hide();
            subjects.Show();
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            Rating subjects = new Rating(status);
            this.Hide();
            subjects.Show();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете вийти з програми?", "Вихід",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

    }
}
