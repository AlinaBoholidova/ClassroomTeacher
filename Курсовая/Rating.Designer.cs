namespace Курсовая
{
    partial class Rating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rating));
            this.scoresDataGridView = new System.Windows.Forms.DataGridView();
            this.pointsDataGridView = new System.Windows.Forms.DataGridView();
            this.back_Subjects = new System.Windows.Forms.Button();
            this.ratingDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createRateButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // scoresDataGridView
            // 
            this.scoresDataGridView.AllowUserToAddRows = false;
            this.scoresDataGridView.AllowUserToDeleteRows = false;
            this.scoresDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.scoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoresDataGridView.Location = new System.Drawing.Point(420, 145);
            this.scoresDataGridView.Name = "scoresDataGridView";
            this.scoresDataGridView.ReadOnly = true;
            this.scoresDataGridView.Size = new System.Drawing.Size(344, 130);
            this.scoresDataGridView.TabIndex = 0;
            // 
            // pointsDataGridView
            // 
            this.pointsDataGridView.AllowUserToAddRows = false;
            this.pointsDataGridView.AllowUserToDeleteRows = false;
            this.pointsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.pointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsDataGridView.Location = new System.Drawing.Point(43, 145);
            this.pointsDataGridView.Name = "pointsDataGridView";
            this.pointsDataGridView.ReadOnly = true;
            this.pointsDataGridView.Size = new System.Drawing.Size(344, 130);
            this.pointsDataGridView.TabIndex = 1;
            // 
            // back_Subjects
            // 
            this.back_Subjects.Location = new System.Drawing.Point(12, 515);
            this.back_Subjects.Name = "back_Subjects";
            this.back_Subjects.Size = new System.Drawing.Size(105, 31);
            this.back_Subjects.TabIndex = 4;
            this.back_Subjects.Text = "Повернутися";
            this.back_Subjects.UseVisualStyleBackColor = true;
            this.back_Subjects.Click += new System.EventHandler(this.back_Subjects_Click);
            // 
            // ratingDataGridView
            // 
            this.ratingDataGridView.AllowUserToAddRows = false;
            this.ratingDataGridView.AllowUserToDeleteRows = false;
            this.ratingDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ratingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.ratingDataGridView.Location = new System.Drawing.Point(43, 310);
            this.ratingDataGridView.Name = "ratingDataGridView";
            this.ratingDataGridView.ReadOnly = true;
            this.ratingDataGridView.Size = new System.Drawing.Size(344, 130);
            this.ratingDataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID учня";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Рейтинговий бал";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // createRateButton
            // 
            this.createRateButton.Location = new System.Drawing.Point(552, 346);
            this.createRateButton.Name = "createRateButton";
            this.createRateButton.Size = new System.Drawing.Size(112, 52);
            this.createRateButton.TabIndex = 6;
            this.createRateButton.Text = "Сформувати рейтинг";
            this.createRateButton.UseVisualStyleBackColor = true;
            this.createRateButton.Click += new System.EventHandler(this.createRateButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.rating;
            this.pictureBox5.Location = new System.Drawing.Point(43, 0);
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
            this.label11.Location = new System.Drawing.Point(177, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 20);
            this.label11.TabIndex = 71;
            this.label11.Text = "Формуваня рейтингу";
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_pupil;
            this.ClientSize = new System.Drawing.Size(812, 558);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.createRateButton);
            this.Controls.Add(this.ratingDataGridView);
            this.Controls.Add(this.back_Subjects);
            this.Controls.Add(this.pointsDataGridView);
            this.Controls.Add(this.scoresDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рейтинг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rating_FormClosing);
            this.Load += new System.EventHandler(this.Rating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scoresDataGridView;
        private System.Windows.Forms.DataGridView pointsDataGridView;
        private System.Windows.Forms.Button back_Subjects;
        private System.Windows.Forms.DataGridView ratingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button createRateButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
    }
}