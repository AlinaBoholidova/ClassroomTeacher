namespace Курсовая
{
    partial class PersonnelFile
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
            System.Windows.Forms.Label pupil_IDLab;
            System.Windows.Forms.Label sNP_fatherLabel;
            System.Windows.Forms.Label sNP_motherLabel;
            System.Windows.Forms.Label sNP_custodianLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelFile));
            this.pupil_IDTextBox = new System.Windows.Forms.TextBox();
            this.SNP_fatherTextBox = new System.Windows.Forms.TextBox();
            this.SNP_motherTextBox = new System.Windows.Forms.TextBox();
            this.SNP_custodianTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.OK_PersonnelFile = new System.Windows.Forms.Button();
            this.Cancel_PersonnelFile = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelFileTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter();
            pupil_IDLab = new System.Windows.Forms.Label();
            sNP_fatherLabel = new System.Windows.Forms.Label();
            sNP_motherLabel = new System.Windows.Forms.Label();
            sNP_custodianLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pupil_IDLab
            // 
            pupil_IDLab.AutoSize = true;
            pupil_IDLab.BackColor = System.Drawing.Color.Wheat;
            pupil_IDLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            pupil_IDLab.Location = new System.Drawing.Point(60, 32);
            pupil_IDLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pupil_IDLab.Name = "pupil_IDLab";
            pupil_IDLab.Size = new System.Drawing.Size(58, 16);
            pupil_IDLab.TabIndex = 1;
            pupil_IDLab.Text = "ID учня:";
            // 
            // sNP_fatherLabel
            // 
            sNP_fatherLabel.AutoSize = true;
            sNP_fatherLabel.BackColor = System.Drawing.Color.Wheat;
            sNP_fatherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sNP_fatherLabel.Location = new System.Drawing.Point(60, 64);
            sNP_fatherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sNP_fatherLabel.Name = "sNP_fatherLabel";
            sNP_fatherLabel.Size = new System.Drawing.Size(81, 16);
            sNP_fatherLabel.TabIndex = 3;
            sNP_fatherLabel.Text = "ПІБ батька:";
            // 
            // sNP_motherLabel
            // 
            sNP_motherLabel.AutoSize = true;
            sNP_motherLabel.BackColor = System.Drawing.Color.Wheat;
            sNP_motherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sNP_motherLabel.Location = new System.Drawing.Point(60, 96);
            sNP_motherLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sNP_motherLabel.Name = "sNP_motherLabel";
            sNP_motherLabel.Size = new System.Drawing.Size(79, 16);
            sNP_motherLabel.TabIndex = 5;
            sNP_motherLabel.Text = "ПІБ матері:";
            // 
            // sNP_custodianLabel
            // 
            sNP_custodianLabel.AutoSize = true;
            sNP_custodianLabel.BackColor = System.Drawing.Color.Wheat;
            sNP_custodianLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sNP_custodianLabel.Location = new System.Drawing.Point(60, 128);
            sNP_custodianLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sNP_custodianLabel.Name = "sNP_custodianLabel";
            sNP_custodianLabel.Size = new System.Drawing.Size(86, 16);
            sNP_custodianLabel.TabIndex = 7;
            sNP_custodianLabel.Text = "ПІБ опікуна:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Wheat;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(60, 160);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(59, 16);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Адреса:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = System.Drawing.Color.Wheat;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(60, 192);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(71, 16);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Телефон:";
            // 
            // pupil_IDTextBox
            // 
            this.pupil_IDTextBox.Location = new System.Drawing.Point(176, 28);
            this.pupil_IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pupil_IDTextBox.Name = "pupil_IDTextBox";
            this.pupil_IDTextBox.ReadOnly = true;
            this.pupil_IDTextBox.Size = new System.Drawing.Size(244, 22);
            this.pupil_IDTextBox.TabIndex = 1;
            // 
            // SNP_fatherTextBox
            // 
            this.SNP_fatherTextBox.Location = new System.Drawing.Point(176, 60);
            this.SNP_fatherTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SNP_fatherTextBox.Name = "SNP_fatherTextBox";
            this.SNP_fatherTextBox.Size = new System.Drawing.Size(244, 22);
            this.SNP_fatherTextBox.TabIndex = 2;
            // 
            // SNP_motherTextBox
            // 
            this.SNP_motherTextBox.Location = new System.Drawing.Point(176, 92);
            this.SNP_motherTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SNP_motherTextBox.Name = "SNP_motherTextBox";
            this.SNP_motherTextBox.Size = new System.Drawing.Size(244, 22);
            this.SNP_motherTextBox.TabIndex = 3;
            // 
            // SNP_custodianTextBox
            // 
            this.SNP_custodianTextBox.Location = new System.Drawing.Point(176, 124);
            this.SNP_custodianTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SNP_custodianTextBox.Name = "SNP_custodianTextBox";
            this.SNP_custodianTextBox.Size = new System.Drawing.Size(244, 22);
            this.SNP_custodianTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(176, 156);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(244, 22);
            this.addressTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(176, 188);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(244, 22);
            this.phoneTextBox.TabIndex = 6;
            // 
            // OK_PersonnelFile
            // 
            this.OK_PersonnelFile.Location = new System.Drawing.Point(122, 246);
            this.OK_PersonnelFile.Margin = new System.Windows.Forms.Padding(4);
            this.OK_PersonnelFile.Name = "OK_PersonnelFile";
            this.OK_PersonnelFile.Size = new System.Drawing.Size(100, 28);
            this.OK_PersonnelFile.TabIndex = 7;
            this.OK_PersonnelFile.Text = "OK";
            this.OK_PersonnelFile.UseVisualStyleBackColor = true;
            this.OK_PersonnelFile.Click += new System.EventHandler(this.OK_PersonnelFile_Click);
            // 
            // Cancel_PersonnelFile
            // 
            this.Cancel_PersonnelFile.Location = new System.Drawing.Point(271, 246);
            this.Cancel_PersonnelFile.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_PersonnelFile.Name = "Cancel_PersonnelFile";
            this.Cancel_PersonnelFile.Size = new System.Drawing.Size(100, 28);
            this.Cancel_PersonnelFile.TabIndex = 8;
            this.Cancel_PersonnelFile.Text = "Відміна";
            this.Cancel_PersonnelFile.UseVisualStyleBackColor = true;
            this.Cancel_PersonnelFile.Click += new System.EventHandler(this.Cancel_PersonnelFile_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pfileBindingSource
            // 
            this.pfileBindingSource.DataMember = "PersonnelFile";
            this.pfileBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // personnelFileTableAdapter
            // 
            this.personnelFileTableAdapter.ClearBeforeFill = true;
            // 
            // PersonnelFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_pupil;
            this.ClientSize = new System.Drawing.Size(495, 307);
            this.Controls.Add(this.Cancel_PersonnelFile);
            this.Controls.Add(this.OK_PersonnelFile);
            this.Controls.Add(pupil_IDLab);
            this.Controls.Add(this.pupil_IDTextBox);
            this.Controls.Add(sNP_fatherLabel);
            this.Controls.Add(this.SNP_fatherTextBox);
            this.Controls.Add(sNP_motherLabel);
            this.Controls.Add(this.SNP_motherTextBox);
            this.Controls.Add(sNP_custodianLabel);
            this.Controls.Add(this.SNP_custodianTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonnelFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особова справа";
            this.Load += new System.EventHandler(this.PersonnelFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SNP_fatherTextBox;
        private System.Windows.Forms.TextBox SNP_motherTextBox;
        private System.Windows.Forms.TextBox SNP_custodianTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button OK_PersonnelFile;
        private System.Windows.Forms.Button Cancel_PersonnelFile;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pfileBindingSource;
        private SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter personnelFileTableAdapter;
        public System.Windows.Forms.TextBox pupil_IDTextBox;
    }
}