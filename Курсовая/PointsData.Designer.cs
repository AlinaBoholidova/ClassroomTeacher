namespace Курсовая
{
    partial class PointsData
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
            System.Windows.Forms.Label placeLabel;
            System.Windows.Forms.Label pointsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointsData));
            this.Cancel_Points = new System.Windows.Forms.Button();
            this.OK_Points = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pointsDistributionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointsDistributionTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.pointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            placeLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDistributionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            placeLabel.Location = new System.Drawing.Point(110, 57);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new System.Drawing.Size(44, 15);
            placeLabel.TabIndex = 18;
            placeLabel.Text = "Місце:";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            pointsLabel.Location = new System.Drawing.Point(110, 117);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(98, 15);
            pointsLabel.TabIndex = 19;
            pointsLabel.Text = "Кількість балів:";
            // 
            // Cancel_Points
            // 
            this.Cancel_Points.Location = new System.Drawing.Point(313, 185);
            this.Cancel_Points.Name = "Cancel_Points";
            this.Cancel_Points.Size = new System.Drawing.Size(87, 27);
            this.Cancel_Points.TabIndex = 17;
            this.Cancel_Points.Text = "Відміна";
            this.Cancel_Points.UseVisualStyleBackColor = true;
            this.Cancel_Points.Click += new System.EventHandler(this.Cancel_Points_Click);
            // 
            // OK_Points
            // 
            this.OK_Points.Location = new System.Drawing.Point(147, 185);
            this.OK_Points.Name = "OK_Points";
            this.OK_Points.Size = new System.Drawing.Size(87, 27);
            this.OK_Points.TabIndex = 16;
            this.OK_Points.Text = "ОК";
            this.OK_Points.UseVisualStyleBackColor = true;
            this.OK_Points.Click += new System.EventHandler(this.OK_Points_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointsDistributionBindingSource
            // 
            this.pointsDistributionBindingSource.DataMember = "PointsDistribution";
            this.pointsDistributionBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // pointsDistributionTableAdapter
            // 
            this.pointsDistributionTableAdapter.ClearBeforeFill = true;
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(225, 57);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(217, 21);
            this.placeTextBox.TabIndex = 19;
            // 
            // pointsNumericUpDown
            // 
            this.pointsNumericUpDown.Location = new System.Drawing.Point(225, 117);
            this.pointsNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pointsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointsNumericUpDown.Name = "pointsNumericUpDown";
            this.pointsNumericUpDown.Size = new System.Drawing.Size(56, 21);
            this.pointsNumericUpDown.TabIndex = 20;
            this.pointsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PointsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(464, 242);
            this.Controls.Add(pointsLabel);
            this.Controls.Add(this.pointsNumericUpDown);
            this.Controls.Add(placeLabel);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.Cancel_Points);
            this.Controls.Add(this.OK_Points);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PointsData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Розбаловка";
            this.Load += new System.EventHandler(this.Points_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDistributionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Points;
        private System.Windows.Forms.Button OK_Points;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pointsDistributionBindingSource;
        private SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter pointsDistributionTableAdapter;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.NumericUpDown pointsNumericUpDown;
    }
}