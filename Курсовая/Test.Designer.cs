namespace Курсовая
{
    partial class Test
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
            System.Windows.Forms.Label subject_abbrLabel;
            System.Windows.Forms.Label test_dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.Cancel_Test = new System.Windows.Forms.Button();
            this.OK_Test = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.subject_abbrComboBox = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subjectTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.SubjectTableAdapter();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.TestTableAdapter();
            subject_abbrLabel = new System.Windows.Forms.Label();
            test_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // subject_abbrLabel
            // 
            subject_abbrLabel.AutoSize = true;
            subject_abbrLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            subject_abbrLabel.Location = new System.Drawing.Point(129, 35);
            subject_abbrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            subject_abbrLabel.Name = "subject_abbrLabel";
            subject_abbrLabel.Size = new System.Drawing.Size(161, 16);
            subject_abbrLabel.TabIndex = 10;
            subject_abbrLabel.Text = "Абревіатура предмету:";
            // 
            // test_dateLabel
            // 
            test_dateLabel.AutoSize = true;
            test_dateLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            test_dateLabel.Location = new System.Drawing.Point(129, 97);
            test_dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            test_dateLabel.Name = "test_dateLabel";
            test_dateLabel.Size = new System.Drawing.Size(126, 16);
            test_dateLabel.TabIndex = 11;
            test_dateLabel.Text = "Дата контрольної:";
            // 
            // Cancel_Test
            // 
            this.Cancel_Test.Location = new System.Drawing.Point(397, 157);
            this.Cancel_Test.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Test.Name = "Cancel_Test";
            this.Cancel_Test.Size = new System.Drawing.Size(100, 28);
            this.Cancel_Test.TabIndex = 9;
            this.Cancel_Test.Text = "Відміна";
            this.Cancel_Test.UseVisualStyleBackColor = true;
            this.Cancel_Test.Click += new System.EventHandler(this.Cancel_Test_Click);
            // 
            // OK_Test
            // 
            this.OK_Test.Location = new System.Drawing.Point(206, 157);
            this.OK_Test.Margin = new System.Windows.Forms.Padding(4);
            this.OK_Test.Name = "OK_Test";
            this.OK_Test.Size = new System.Drawing.Size(100, 28);
            this.OK_Test.TabIndex = 8;
            this.OK_Test.Text = "ОК";
            this.OK_Test.UseVisualStyleBackColor = true;
            this.OK_Test.Click += new System.EventHandler(this.OK_Test_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subject_abbrComboBox
            // 
            this.subject_abbrComboBox.DataSource = this.subjectBindingSource;
            this.subject_abbrComboBox.DisplayMember = "Subject_abbr";
            this.subject_abbrComboBox.FormattingEnabled = true;
            this.subject_abbrComboBox.Location = new System.Drawing.Point(300, 32);
            this.subject_abbrComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subject_abbrComboBox.Name = "subject_abbrComboBox";
            this.subject_abbrComboBox.Size = new System.Drawing.Size(265, 24);
            this.subject_abbrComboBox.TabIndex = 11;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // test_dateDateTimePicker
            // 
            this.test_dateDateTimePicker.Location = new System.Drawing.Point(300, 90);
            this.test_dateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.test_dateDateTimePicker.Name = "test_dateDateTimePicker";
            this.test_dateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.test_dateDateTimePicker.TabIndex = 12;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
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
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject1;
            this.ClientSize = new System.Drawing.Size(620, 217);
            this.Controls.Add(test_dateLabel);
            this.Controls.Add(this.test_dateDateTimePicker);
            this.Controls.Add(subject_abbrLabel);
            this.Controls.Add(this.subject_abbrComboBox);
            this.Controls.Add(this.Cancel_Test);
            this.Controls.Add(this.OK_Test);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контрольна робота";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Test;
        private System.Windows.Forms.Button OK_Test;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.ComboBox subject_abbrComboBox;
        private System.Windows.Forms.DateTimePicker test_dateDateTimePicker;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private SchoolCourseDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.BindingSource testBindingSource;
        private SchoolCourseDataSetTableAdapters.TestTableAdapter testTableAdapter;
    }
}