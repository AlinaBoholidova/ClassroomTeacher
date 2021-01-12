namespace Курсовая
{
    partial class Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.statsTabControl = new System.Windows.Forms.TabControl();
            this.skipsTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.skipsDataGridView = new System.Windows.Forms.DataGridView();
            this.birthdaysTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartBirthMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.birthdaysDataGridView = new System.Windows.Forms.DataGridView();
            this.debtersTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chartPaymentMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.debtorsDataGridView = new System.Windows.Forms.DataGridView();
            this.activitiesTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chartActivity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.journalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.journalRecordTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.TestTableAdapter();
            this.paymentRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentRateTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentTableAdapter();
            this.statsTabControl.SuspendLayout();
            this.skipsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipsDataGridView)).BeginInit();
            this.birthdaysTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBirthMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdaysDataGridView)).BeginInit();
            this.debtersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsDataGridView)).BeginInit();
            this.activitiesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statsTabControl
            // 
            this.statsTabControl.Controls.Add(this.skipsTabPage);
            this.statsTabControl.Controls.Add(this.birthdaysTabPage);
            this.statsTabControl.Controls.Add(this.debtersTabPage);
            this.statsTabControl.Controls.Add(this.activitiesTabPage);
            this.statsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statsTabControl.Location = new System.Drawing.Point(12, 12);
            this.statsTabControl.Name = "statsTabControl";
            this.statsTabControl.SelectedIndex = 0;
            this.statsTabControl.Size = new System.Drawing.Size(1015, 509);
            this.statsTabControl.TabIndex = 0;
            // 
            // skipsTabPage
            // 
            this.skipsTabPage.Controls.Add(this.label1);
            this.skipsTabPage.Controls.Add(this.pictureBox5);
            this.skipsTabPage.Controls.Add(this.skipsDataGridView);
            this.skipsTabPage.Location = new System.Drawing.Point(4, 24);
            this.skipsTabPage.Name = "skipsTabPage";
            this.skipsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.skipsTabPage.Size = new System.Drawing.Size(1007, 481);
            this.skipsTabPage.TabIndex = 0;
            this.skipsTabPage.Text = "Пропуски контрольних";
            this.skipsTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Кількість пропущених контрольних учнями";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.file;
            this.pictureBox5.Location = new System.Drawing.Point(6, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(121, 117);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 82;
            this.pictureBox5.TabStop = false;
            // 
            // skipsDataGridView
            // 
            this.skipsDataGridView.AllowUserToAddRows = false;
            this.skipsDataGridView.AllowUserToDeleteRows = false;
            this.skipsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.skipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skipsDataGridView.Location = new System.Drawing.Point(157, 99);
            this.skipsDataGridView.Name = "skipsDataGridView";
            this.skipsDataGridView.ReadOnly = true;
            this.skipsDataGridView.Size = new System.Drawing.Size(488, 200);
            this.skipsDataGridView.TabIndex = 0;
            // 
            // birthdaysTabPage
            // 
            this.birthdaysTabPage.Controls.Add(this.label2);
            this.birthdaysTabPage.Controls.Add(this.pictureBox1);
            this.birthdaysTabPage.Controls.Add(this.chartBirthMonth);
            this.birthdaysTabPage.Controls.Add(this.birthdaysDataGridView);
            this.birthdaysTabPage.Location = new System.Drawing.Point(4, 24);
            this.birthdaysTabPage.Name = "birthdaysTabPage";
            this.birthdaysTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.birthdaysTabPage.Size = new System.Drawing.Size(1007, 481);
            this.birthdaysTabPage.TabIndex = 1;
            this.birthdaysTabPage.Text = "Дні народження";
            this.birthdaysTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(167, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Кількість учнів за місяцами народження";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Курсовая.Properties.Resources.file;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // chartBirthMonth
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBirthMonth.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBirthMonth.Legends.Add(legend1);
            this.chartBirthMonth.Location = new System.Drawing.Point(526, 125);
            this.chartBirthMonth.Name = "chartBirthMonth";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBirthMonth.Series.Add(series1);
            this.chartBirthMonth.Size = new System.Drawing.Size(373, 300);
            this.chartBirthMonth.TabIndex = 1;
            this.chartBirthMonth.Text = "chart1";
            // 
            // birthdaysDataGridView
            // 
            this.birthdaysDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.birthdaysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birthdaysDataGridView.Location = new System.Drawing.Point(36, 143);
            this.birthdaysDataGridView.Name = "birthdaysDataGridView";
            this.birthdaysDataGridView.Size = new System.Drawing.Size(424, 239);
            this.birthdaysDataGridView.TabIndex = 0;
            // 
            // debtersTabPage
            // 
            this.debtersTabPage.Controls.Add(this.label3);
            this.debtersTabPage.Controls.Add(this.pictureBox2);
            this.debtersTabPage.Controls.Add(this.chartPaymentMonth);
            this.debtersTabPage.Controls.Add(this.debtorsDataGridView);
            this.debtersTabPage.Location = new System.Drawing.Point(4, 24);
            this.debtersTabPage.Name = "debtersTabPage";
            this.debtersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.debtersTabPage.Size = new System.Drawing.Size(1007, 481);
            this.debtersTabPage.TabIndex = 2;
            this.debtersTabPage.Text = "Боржники по оплаті";
            this.debtersTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(167, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Список боржників по оплаті та статистика за місяцами";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Курсовая.Properties.Resources.file;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // chartPaymentMonth
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPaymentMonth.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPaymentMonth.Legends.Add(legend2);
            this.chartPaymentMonth.Location = new System.Drawing.Point(637, 118);
            this.chartPaymentMonth.Name = "chartPaymentMonth";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPaymentMonth.Series.Add(series2);
            this.chartPaymentMonth.Size = new System.Drawing.Size(319, 311);
            this.chartPaymentMonth.TabIndex = 1;
            this.chartPaymentMonth.Text = "chart1";
            // 
            // debtorsDataGridView
            // 
            this.debtorsDataGridView.AllowUserToAddRows = false;
            this.debtorsDataGridView.AllowUserToDeleteRows = false;
            this.debtorsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.debtorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtorsDataGridView.Location = new System.Drawing.Point(36, 143);
            this.debtorsDataGridView.Name = "debtorsDataGridView";
            this.debtorsDataGridView.ReadOnly = true;
            this.debtorsDataGridView.Size = new System.Drawing.Size(536, 228);
            this.debtorsDataGridView.TabIndex = 0;
            // 
            // activitiesTabPage
            // 
            this.activitiesTabPage.Controls.Add(this.label4);
            this.activitiesTabPage.Controls.Add(this.pictureBox3);
            this.activitiesTabPage.Controls.Add(this.chartActivity);
            this.activitiesTabPage.Controls.Add(this.activitiesDataGridView);
            this.activitiesTabPage.Location = new System.Drawing.Point(4, 24);
            this.activitiesTabPage.Name = "activitiesTabPage";
            this.activitiesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.activitiesTabPage.Size = new System.Drawing.Size(1007, 481);
            this.activitiesTabPage.TabIndex = 3;
            this.activitiesTabPage.Text = "Участь в активності";
            this.activitiesTabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(167, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Частота участі в додаткових активностях";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Курсовая.Properties.Resources.file;
            this.pictureBox3.Location = new System.Drawing.Point(6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(121, 117);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            // 
            // chartActivity
            // 
            chartArea3.Name = "ChartArea1";
            this.chartActivity.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TextWrapThreshold = 10;
            this.chartActivity.Legends.Add(legend3);
            this.chartActivity.Location = new System.Drawing.Point(538, 105);
            this.chartActivity.Name = "chartActivity";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartActivity.Series.Add(series3);
            this.chartActivity.Size = new System.Drawing.Size(452, 300);
            this.chartActivity.TabIndex = 1;
            this.chartActivity.Text = "chart1";
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Location = new System.Drawing.Point(36, 143);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.Size = new System.Drawing.Size(484, 202);
            this.activitiesDataGridView.TabIndex = 0;
            // 
            // journalRecordBindingSource
            // 
            this.journalRecordBindingSource.DataMember = "JournalRecord";
            this.journalRecordBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalRecordTableAdapter
            // 
            this.journalRecordTableAdapter.ClearBeforeFill = true;
            // 
            // pupilBindingSource
            // 
            this.pupilBindingSource.DataMember = "Pupil";
            this.pupilBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // pupilTableAdapter
            // 
            this.pupilTableAdapter.ClearBeforeFill = true;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "Test";
            this.testBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // paymentRateBindingSource
            // 
            this.paymentRateBindingSource.DataMember = "PaymentRate";
            this.paymentRateBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // paymentRateTableAdapter
            // 
            this.paymentRateTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1039, 533);
            this.Controls.Add(this.statsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.statsTabControl.ResumeLayout(false);
            this.skipsTabPage.ResumeLayout(false);
            this.skipsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skipsDataGridView)).EndInit();
            this.birthdaysTabPage.ResumeLayout(false);
            this.birthdaysTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBirthMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdaysDataGridView)).EndInit();
            this.debtersTabPage.ResumeLayout(false);
            this.debtersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPaymentMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtorsDataGridView)).EndInit();
            this.activitiesTabPage.ResumeLayout(false);
            this.activitiesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView skipsDataGridView;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource journalRecordBindingSource;
        private SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter journalRecordTableAdapter;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private System.Windows.Forms.BindingSource testBindingSource;
        private SchoolCourseDataSetTableAdapters.TestTableAdapter testTableAdapter;
        private System.Windows.Forms.DataGridView birthdaysDataGridView;
        private System.Windows.Forms.DataGridView debtorsDataGridView;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.BindingSource paymentRateBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter paymentRateTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBirthMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPaymentMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartActivity;
        public System.Windows.Forms.TabControl statsTabControl;
        public System.Windows.Forms.TabPage skipsTabPage;
        public System.Windows.Forms.TabPage birthdaysTabPage;
        public System.Windows.Forms.TabPage debtersTabPage;
        public System.Windows.Forms.TabPage activitiesTabPage;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}