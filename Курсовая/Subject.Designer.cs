namespace Курсовая
{
    partial class Subject
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
            System.Windows.Forms.Label subject_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subject));
            this.Cancel_Subject = new System.Windows.Forms.Button();
            this.OK_Subject = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.SubjectTableAdapter();
            this.subject_abbrTextBox = new System.Windows.Forms.TextBox();
            this.subject_nameTextBox = new System.Windows.Forms.TextBox();
            subject_abbrLabel = new System.Windows.Forms.Label();
            subject_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // subject_abbrLabel
            // 
            subject_abbrLabel.AutoSize = true;
            subject_abbrLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            subject_abbrLabel.Location = new System.Drawing.Point(120, 45);
            subject_abbrLabel.Name = "subject_abbrLabel";
            subject_abbrLabel.Size = new System.Drawing.Size(161, 16);
            subject_abbrLabel.TabIndex = 12;
            subject_abbrLabel.Text = "Абревіатура предмету:";
            // 
            // subject_nameLabel
            // 
            subject_nameLabel.AutoSize = true;
            subject_nameLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            subject_nameLabel.Location = new System.Drawing.Point(120, 97);
            subject_nameLabel.Name = "subject_nameLabel";
            subject_nameLabel.Size = new System.Drawing.Size(120, 16);
            subject_nameLabel.TabIndex = 13;
            subject_nameLabel.Text = "Назва предмету:";
            // 
            // Cancel_Subject
            // 
            this.Cancel_Subject.Location = new System.Drawing.Point(367, 158);
            this.Cancel_Subject.Name = "Cancel_Subject";
            this.Cancel_Subject.Size = new System.Drawing.Size(99, 29);
            this.Cancel_Subject.TabIndex = 11;
            this.Cancel_Subject.Text = "Відміна";
            this.Cancel_Subject.UseVisualStyleBackColor = true;
            this.Cancel_Subject.Click += new System.EventHandler(this.Cancel_Subject_Click);
            // 
            // OK_Subject
            // 
            this.OK_Subject.Location = new System.Drawing.Point(176, 158);
            this.OK_Subject.Name = "OK_Subject";
            this.OK_Subject.Size = new System.Drawing.Size(99, 29);
            this.OK_Subject.TabIndex = 10;
            this.OK_Subject.Text = "ОК";
            this.OK_Subject.UseVisualStyleBackColor = true;
            this.OK_Subject.Click += new System.EventHandler(this.OK_Subject_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // subject_abbrTextBox
            // 
            this.subject_abbrTextBox.Location = new System.Drawing.Point(309, 41);
            this.subject_abbrTextBox.Name = "subject_abbrTextBox";
            this.subject_abbrTextBox.Size = new System.Drawing.Size(213, 22);
            this.subject_abbrTextBox.TabIndex = 13;
            // 
            // subject_nameTextBox
            // 
            this.subject_nameTextBox.Location = new System.Drawing.Point(309, 93);
            this.subject_nameTextBox.Name = "subject_nameTextBox";
            this.subject_nameTextBox.Size = new System.Drawing.Size(213, 22);
            this.subject_nameTextBox.TabIndex = 14;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject1;
            this.ClientSize = new System.Drawing.Size(572, 231);
            this.Controls.Add(subject_nameLabel);
            this.Controls.Add(this.subject_nameTextBox);
            this.Controls.Add(subject_abbrLabel);
            this.Controls.Add(this.subject_abbrTextBox);
            this.Controls.Add(this.Cancel_Subject);
            this.Controls.Add(this.OK_Subject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Навчальний предмет";
            this.Load += new System.EventHandler(this.Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Subject;
        private System.Windows.Forms.Button OK_Subject;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private SchoolCourseDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.TextBox subject_abbrTextBox;
        private System.Windows.Forms.TextBox subject_nameTextBox;
    }
}