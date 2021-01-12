namespace Курсовая
{
    partial class PupilData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PupilData));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SNP_PupilData = new System.Windows.Forms.TextBox();
            this.birthDate_PupilData = new System.Windows.Forms.DateTimePicker();
            this.gender_PupilData = new System.Windows.Forms.ComboBox();
            this.OK_PupilData = new System.Windows.Forms.Button();
            this.Cancel_PupilData = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПІБ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стать:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата народження:";
            // 
            // SNP_PupilData
            // 
            this.SNP_PupilData.Location = new System.Drawing.Point(191, 26);
            this.SNP_PupilData.Name = "SNP_PupilData";
            this.SNP_PupilData.Size = new System.Drawing.Size(276, 21);
            this.SNP_PupilData.TabIndex = 1;
            // 
            // birthDate_PupilData
            // 
            this.birthDate_PupilData.Location = new System.Drawing.Point(191, 125);
            this.birthDate_PupilData.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.birthDate_PupilData.MinDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.birthDate_PupilData.Name = "birthDate_PupilData";
            this.birthDate_PupilData.Size = new System.Drawing.Size(276, 21);
            this.birthDate_PupilData.TabIndex = 3;
            this.birthDate_PupilData.Value = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            // 
            // gender_PupilData
            // 
            this.gender_PupilData.FormattingEnabled = true;
            this.gender_PupilData.Items.AddRange(new object[] {
            "Ч",
            "Ж"});
            this.gender_PupilData.Location = new System.Drawing.Point(191, 72);
            this.gender_PupilData.Name = "gender_PupilData";
            this.gender_PupilData.Size = new System.Drawing.Size(49, 23);
            this.gender_PupilData.TabIndex = 2;
            // 
            // OK_PupilData
            // 
            this.OK_PupilData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK_PupilData.Location = new System.Drawing.Point(117, 180);
            this.OK_PupilData.Name = "OK_PupilData";
            this.OK_PupilData.Size = new System.Drawing.Size(87, 27);
            this.OK_PupilData.TabIndex = 4;
            this.OK_PupilData.Text = "ОК";
            this.OK_PupilData.UseVisualStyleBackColor = true;
            this.OK_PupilData.Click += new System.EventHandler(this.OK_PupilData_Click);
            // 
            // Cancel_PupilData
            // 
            this.Cancel_PupilData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_PupilData.Location = new System.Drawing.Point(284, 180);
            this.Cancel_PupilData.Name = "Cancel_PupilData";
            this.Cancel_PupilData.Size = new System.Drawing.Size(87, 27);
            this.Cancel_PupilData.TabIndex = 5;
            this.Cancel_PupilData.Text = "Відміна";
            this.Cancel_PupilData.UseVisualStyleBackColor = true;
            this.Cancel_PupilData.Click += new System.EventHandler(this.Cancel_PupilData_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // PupilData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_pupil;
            this.ClientSize = new System.Drawing.Size(504, 241);
            this.Controls.Add(this.Cancel_PupilData);
            this.Controls.Add(this.OK_PupilData);
            this.Controls.Add(this.gender_PupilData);
            this.Controls.Add(this.birthDate_PupilData);
            this.Controls.Add(this.SNP_PupilData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PupilData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Дані учня";
            this.Load += new System.EventHandler(this.PupilData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SNP_PupilData;
        private System.Windows.Forms.DateTimePicker birthDate_PupilData;
        private System.Windows.Forms.ComboBox gender_PupilData;
        private System.Windows.Forms.Button OK_PupilData;
        private System.Windows.Forms.Button Cancel_PupilData;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
    }
}