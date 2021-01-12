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
        public Main()
        {
            InitializeComponent();
        }

        private void pupilsButton_Main_Click(object sender, EventArgs e)
        {
            Pupils pupils = new Pupils();
            this.Hide();
            pupils.Show();
        }

        private void pfilesButton_Main_Click(object sender, EventArgs e)
        {
            PersonnelFiles pfiles = new PersonnelFiles();
            this.Hide();
            pfiles.Show();
        }

        private void testsSubjectsButton_Main_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            this.Hide();
            subjects.Show();
        }

        private void journalRecordsButton_Click(object sender, EventArgs e)
        {
            JournalRecord journal = new JournalRecord();
            this.Hide();
            journal.Show();
        }

        private void addActivityButton_Click(object sender, EventArgs e)
        {
            AdditionalActivity activity = new AdditionalActivity();
            this.Hide();
            activity.Show();
        }

        private void distributionButton_Click(object sender, EventArgs e)
        {
            Points points = new Points();
            this.Hide();
            points.Show();
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            this.Hide();
            payments.Show();
        }

        private void paymentRatesButton_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
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
            QueryEdit queryEdit = new QueryEdit();
            this.Hide();
            queryEdit.Show();
        }

        private void receiptsButton_Click(object sender, EventArgs e)
        {
            ViewReceipt subjects = new ViewReceipt();
            this.Hide();
            subjects.Show();
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            ViewScores subjects = new ViewScores();
            this.Hide();
            subjects.Show();
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            Rating subjects = new Rating();
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
