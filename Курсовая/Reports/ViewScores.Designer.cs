namespace Курсовая
{
    partial class ViewScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewScores));
            this.scoresDataGridView = new System.Windows.Forms.DataGridView();
            this.scoresReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.SNPlabel = new System.Windows.Forms.Label();
            this.previewButton = new System.Windows.Forms.Button();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeCheckBox = new System.Windows.Forms.CheckBox();
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.back_Scores = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Scores)).BeginInit();
            this.SuspendLayout();
            // 
            // scoresDataGridView
            // 
            this.scoresDataGridView.AllowUserToAddRows = false;
            this.scoresDataGridView.AllowUserToDeleteRows = false;
            this.scoresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scoresDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.scoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scoresDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.scoresDataGridView.Location = new System.Drawing.Point(26, 298);
            this.scoresDataGridView.Name = "scoresDataGridView";
            this.scoresDataGridView.ReadOnly = true;
            this.scoresDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scoresDataGridView.Size = new System.Drawing.Size(469, 233);
            this.scoresDataGridView.TabIndex = 0;
            // 
            // scoresReportViewer
            // 
            this.scoresReportViewer.LocalReport.ReportEmbeddedResource = "Курсовая.Scores.rdlc";
            this.scoresReportViewer.Location = new System.Drawing.Point(540, 138);
            this.scoresReportViewer.Name = "scoresReportViewer";
            this.scoresReportViewer.ServerReport.BearerToken = null;
            this.scoresReportViewer.Size = new System.Drawing.Size(557, 393);
            this.scoresReportViewer.TabIndex = 1;
            // 
            // idComboBox
            // 
            this.idComboBox.DataSource = this.pupilBindingSource;
            this.idComboBox.DisplayMember = "Pupil_ID";
            this.idComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(100, 138);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(55, 23);
            this.idComboBox.TabIndex = 2;
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // pupilBindingSource
            // 
            this.pupilBindingSource.DataMember = "Pupil";
            this.pupilBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SNPlabel
            // 
            this.SNPlabel.AutoSize = true;
            this.SNPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNPlabel.Location = new System.Drawing.Point(170, 144);
            this.SNPlabel.Name = "SNPlabel";
            this.SNPlabel.Size = new System.Drawing.Size(41, 15);
            this.SNPlabel.TabIndex = 3;
            this.SNPlabel.Text = "label1";
            // 
            // previewButton
            // 
            this.previewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previewButton.Location = new System.Drawing.Point(358, 186);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(110, 47);
            this.previewButton.TabIndex = 4;
            this.previewButton.Text = "Перегляд виписки оцінок";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDateTimePicker.Location = new System.Drawing.Point(83, 186);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(227, 21);
            this.fromDateTimePicker.TabIndex = 5;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDateTimePicker.Location = new System.Drawing.Point(83, 212);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(227, 21);
            this.toDateTimePicker.TabIndex = 6;
            // 
            // timeCheckBox
            // 
            this.timeCheckBox.AutoSize = true;
            this.timeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeCheckBox.Location = new System.Drawing.Point(51, 247);
            this.timeCheckBox.Name = "timeCheckBox";
            this.timeCheckBox.Size = new System.Drawing.Size(93, 19);
            this.timeCheckBox.TabIndex = 9;
            this.timeCheckBox.Text = "За весь час";
            this.timeCheckBox.UseVisualStyleBackColor = true;
            // 
            // pupilTableAdapter
            // 
            this.pupilTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID учня:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Між";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "та";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.report;
            this.pictureBox5.Location = new System.Drawing.Point(26, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 120);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 72;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(160, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 71;
            this.label11.Text = "Виписки оцінок";
            // 
            // back_Scores
            // 
            this.back_Scores.BackColor = System.Drawing.Color.Transparent;
            this.back_Scores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Scores.Image = global::Курсовая.Properties.Resources.goback;
            this.back_Scores.Location = new System.Drawing.Point(12, 553);
            this.back_Scores.Name = "back_Scores";
            this.back_Scores.Size = new System.Drawing.Size(62, 55);
            this.back_Scores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Scores.TabIndex = 84;
            this.back_Scores.TabStop = false;
            this.back_Scores.Click += new System.EventHandler(this.back_Scores_Click);
            // 
            // ViewScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_pupil;
            this.ClientSize = new System.Drawing.Size(1129, 620);
            this.Controls.Add(this.back_Scores);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeCheckBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.SNPlabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.scoresReportViewer);
            this.Controls.Add(this.scoresDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оцінки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewScores_FormClosing);
            this.Load += new System.EventHandler(this.ViewScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Scores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scoresDataGridView;
        private Microsoft.Reporting.WinForms.ReportViewer scoresReportViewer;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label SNPlabel;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.CheckBox timeCheckBox;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox back_Scores;
    }
}