namespace Курсовая
{
    partial class JournalRecordData
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
            System.Windows.Forms.Label paymentRate_IDLabel;
            System.Windows.Forms.Label pupil_ID;
            System.Windows.Forms.Label scoreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalRecordData));
            this.test_IDLabel = new System.Windows.Forms.Label();
            this.pupil_IDLabel = new System.Windows.Forms.Label();
            this.test_IDComboBox = new System.Windows.Forms.ComboBox();
            this.pupil_IDComboBox = new System.Windows.Forms.ComboBox();
            this.Cancel_Record = new System.Windows.Forms.Button();
            this.OK_Record = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.journalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalRecordTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter();
            this.scoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.TestTableAdapter();
            paymentRate_IDLabel = new System.Windows.Forms.Label();
            pupil_ID = new System.Windows.Forms.Label();
            scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentRate_IDLabel
            // 
            paymentRate_IDLabel.AutoSize = true;
            paymentRate_IDLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            paymentRate_IDLabel.Location = new System.Drawing.Point(127, 135);
            paymentRate_IDLabel.Name = "paymentRate_IDLabel";
            paymentRate_IDLabel.Size = new System.Drawing.Size(97, 15);
            paymentRate_IDLabel.TabIndex = 22;
            paymentRate_IDLabel.Text = "ID контрольної:";
            // 
            // pupil_ID
            // 
            pupil_ID.AutoSize = true;
            pupil_ID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            pupil_ID.Location = new System.Drawing.Point(128, 82);
            pupil_ID.Name = "pupil_ID";
            pupil_ID.Size = new System.Drawing.Size(50, 15);
            pupil_ID.TabIndex = 21;
            pupil_ID.Text = "ID учня:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            scoreLabel.Location = new System.Drawing.Point(128, 189);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(49, 15);
            scoreLabel.TabIndex = 29;
            scoreLabel.Text = "Оцінка:";
            // 
            // test_IDLabel
            // 
            this.test_IDLabel.AutoSize = true;
            this.test_IDLabel.Location = new System.Drawing.Point(391, 135);
            this.test_IDLabel.Name = "test_IDLabel";
            this.test_IDLabel.Size = new System.Drawing.Size(109, 15);
            this.test_IDLabel.TabIndex = 26;
            this.test_IDLabel.Text = "АнглМ 07.11.2020";
            // 
            // pupil_IDLabel
            // 
            this.pupil_IDLabel.AutoSize = true;
            this.pupil_IDLabel.Location = new System.Drawing.Point(391, 82);
            this.pupil_IDLabel.Name = "pupil_IDLabel";
            this.pupil_IDLabel.Size = new System.Drawing.Size(165, 15);
            this.pupil_IDLabel.TabIndex = 25;
            this.pupil_IDLabel.Text = "Єгоров Максим Микитович";
            // 
            // test_IDComboBox
            // 
            this.test_IDComboBox.DataSource = this.testBindingSource;
            this.test_IDComboBox.DisplayMember = "Test_ID";
            this.test_IDComboBox.FormattingEnabled = true;
            this.test_IDComboBox.Location = new System.Drawing.Point(271, 132);
            this.test_IDComboBox.Name = "test_IDComboBox";
            this.test_IDComboBox.Size = new System.Drawing.Size(74, 23);
            this.test_IDComboBox.TabIndex = 24;
            this.test_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.test_IDComboBox_SelectedIndexChanged);
            // 
            // pupil_IDComboBox
            // 
            this.pupil_IDComboBox.DataSource = this.pupilBindingSource;
            this.pupil_IDComboBox.DisplayMember = "Pupil_ID";
            this.pupil_IDComboBox.FormattingEnabled = true;
            this.pupil_IDComboBox.Location = new System.Drawing.Point(271, 77);
            this.pupil_IDComboBox.Name = "pupil_IDComboBox";
            this.pupil_IDComboBox.Size = new System.Drawing.Size(74, 23);
            this.pupil_IDComboBox.TabIndex = 23;
            this.pupil_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.pupil_IDComboBox_SelectedIndexChanged);
            // 
            // Cancel_Record
            // 
            this.Cancel_Record.Location = new System.Drawing.Point(435, 256);
            this.Cancel_Record.Name = "Cancel_Record";
            this.Cancel_Record.Size = new System.Drawing.Size(101, 31);
            this.Cancel_Record.TabIndex = 28;
            this.Cancel_Record.Text = "Відміна";
            this.Cancel_Record.UseVisualStyleBackColor = true;
            this.Cancel_Record.Click += new System.EventHandler(this.Cancel_Record_Click);
            // 
            // OK_Record
            // 
            this.OK_Record.Location = new System.Drawing.Point(240, 256);
            this.OK_Record.Name = "OK_Record";
            this.OK_Record.Size = new System.Drawing.Size(101, 31);
            this.OK_Record.TabIndex = 27;
            this.OK_Record.Text = "ОК";
            this.OK_Record.UseVisualStyleBackColor = true;
            this.OK_Record.Click += new System.EventHandler(this.OK_Record_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalRecordBindingSource
            // 
            this.journalRecordBindingSource.DataMember = "JournalRecord";
            this.journalRecordBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // journalRecordTableAdapter
            // 
            this.journalRecordTableAdapter.ClearBeforeFill = true;
            // 
            // scoreNumericUpDown
            // 
            this.scoreNumericUpDown.Location = new System.Drawing.Point(271, 187);
            this.scoreNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.scoreNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scoreNumericUpDown.Name = "scoreNumericUpDown";
            this.scoreNumericUpDown.Size = new System.Drawing.Size(75, 21);
            this.scoreNumericUpDown.TabIndex = 30;
            this.scoreNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // JournalRecordData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(639, 327);
            this.Controls.Add(scoreLabel);
            this.Controls.Add(this.scoreNumericUpDown);
            this.Controls.Add(this.Cancel_Record);
            this.Controls.Add(this.OK_Record);
            this.Controls.Add(this.test_IDLabel);
            this.Controls.Add(this.pupil_IDLabel);
            this.Controls.Add(paymentRate_IDLabel);
            this.Controls.Add(this.test_IDComboBox);
            this.Controls.Add(pupil_ID);
            this.Controls.Add(this.pupil_IDComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JournalRecordData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані запису журналу";
            this.Load += new System.EventHandler(this.JournalRecordData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test_IDLabel;
        private System.Windows.Forms.Label pupil_IDLabel;
        private System.Windows.Forms.ComboBox test_IDComboBox;
        private System.Windows.Forms.ComboBox pupil_IDComboBox;
        private System.Windows.Forms.Button Cancel_Record;
        private System.Windows.Forms.Button OK_Record;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource journalRecordBindingSource;
        private SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter journalRecordTableAdapter;
        private System.Windows.Forms.NumericUpDown scoreNumericUpDown;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private System.Windows.Forms.BindingSource testBindingSource;
        private SchoolCourseDataSetTableAdapters.TestTableAdapter testTableAdapter;
    }
}