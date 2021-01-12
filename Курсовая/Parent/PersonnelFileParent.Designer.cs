namespace Курсовая.Parent
{
    partial class PersonnelFileParent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelFileParent));
            this.back_PersonnelFiles = new System.Windows.Forms.PictureBox();
            this.edit_PersonnelFiles = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pfilesDataGridView = new System.Windows.Forms.DataGridView();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelFileTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.back_PersonnelFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfilesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // back_PersonnelFiles
            // 
            this.back_PersonnelFiles.BackColor = System.Drawing.Color.Transparent;
            this.back_PersonnelFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_PersonnelFiles.Image = global::Курсовая.Properties.Resources.goback;
            this.back_PersonnelFiles.Location = new System.Drawing.Point(2, 366);
            this.back_PersonnelFiles.Name = "back_PersonnelFiles";
            this.back_PersonnelFiles.Size = new System.Drawing.Size(53, 48);
            this.back_PersonnelFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_PersonnelFiles.TabIndex = 71;
            this.back_PersonnelFiles.TabStop = false;
            this.back_PersonnelFiles.Click += new System.EventHandler(this.back_PersonnelFiles_Click);
            // 
            // edit_PersonnelFiles
            // 
            this.edit_PersonnelFiles.BackColor = System.Drawing.Color.Wheat;
            this.edit_PersonnelFiles.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_PersonnelFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_PersonnelFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_PersonnelFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_PersonnelFiles.ForeColor = System.Drawing.Color.Wheat;
            this.edit_PersonnelFiles.Location = new System.Drawing.Point(23, 204);
            this.edit_PersonnelFiles.Name = "edit_PersonnelFiles";
            this.edit_PersonnelFiles.Size = new System.Drawing.Size(45, 43);
            this.edit_PersonnelFiles.TabIndex = 67;
            this.edit_PersonnelFiles.UseVisualStyleBackColor = false;
            this.edit_PersonnelFiles.Click += new System.EventHandler(this.edit_PersonnelFiles_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(742, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 65;
            this.label7.Text = "Школа";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Курсовая.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(798, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(128, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Особовa справa";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.folder;
            this.pictureBox5.Location = new System.Drawing.Point(13, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 104);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 62;
            this.pictureBox5.TabStop = false;
            // 
            // pfilesDataGridView
            // 
            this.pfilesDataGridView.AllowUserToAddRows = false;
            this.pfilesDataGridView.AllowUserToDeleteRows = false;
            this.pfilesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pfilesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pfilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pfilesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.pfilesDataGridView.EnableHeadersVisualStyles = false;
            this.pfilesDataGridView.Location = new System.Drawing.Point(98, 142);
            this.pfilesDataGridView.Name = "pfilesDataGridView";
            this.pfilesDataGridView.ReadOnly = true;
            this.pfilesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.pfilesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pfilesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            this.pfilesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.pfilesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pfilesDataGridView.Size = new System.Drawing.Size(749, 167);
            this.pfilesDataGridView.TabIndex = 51;
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
            // PersonnelFileParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_pupil;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 430);
            this.Controls.Add(this.back_PersonnelFiles);
            this.Controls.Add(this.edit_PersonnelFiles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pfilesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonnelFileParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особова справа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonnelFileParent_FormClosing);
            this.Load += new System.EventHandler(this.PersonnelFileParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back_PersonnelFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfilesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back_PersonnelFiles;
        private System.Windows.Forms.Button edit_PersonnelFiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView pfilesDataGridView;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pfileBindingSource;
        private SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter personnelFileTableAdapter;
    }
}