namespace Курсовая
{
    partial class Points
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Points));
            this.pointsDataGridView = new System.Windows.Forms.DataGridView();
            this.distributionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.showAll_Points = new System.Windows.Forms.Button();
            this.pointsDistributionTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.delete_Points = new System.Windows.Forms.Button();
            this.edit_Points = new System.Windows.Forms.Button();
            this.add_Points = new System.Windows.Forms.Button();
            this.back_Points = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.disrtIDCheckBox_Points = new System.Windows.Forms.CheckBox();
            this.allCheckBox_Points = new System.Windows.Forms.CheckBox();
            this.placeCheckBox_Points = new System.Windows.Forms.CheckBox();
            this.toSearch_Points = new System.Windows.Forms.Button();
            this.pointsCheckBox_Points = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Points = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortComboBox_Points = new System.Windows.Forms.ComboBox();
            this.toSort_Points = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toFilter_Points = new System.Windows.Forms.Button();
            this.fromNumericUpDown_Points = new System.Windows.Forms.NumericUpDown();
            this.toNumericUpDown_Points = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown_Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown_Points)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsDataGridView
            // 
            this.pointsDataGridView.AllowUserToAddRows = false;
            this.pointsDataGridView.AllowUserToDeleteRows = false;
            this.pointsDataGridView.AutoGenerateColumns = false;
            this.pointsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.pointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distributionIDDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn});
            this.pointsDataGridView.DataSource = this.pointsBindingSource;
            this.pointsDataGridView.Location = new System.Drawing.Point(223, 159);
            this.pointsDataGridView.Name = "pointsDataGridView";
            this.pointsDataGridView.ReadOnly = true;
            this.pointsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pointsDataGridView.Size = new System.Drawing.Size(344, 215);
            this.pointsDataGridView.TabIndex = 0;
            // 
            // distributionIDDataGridViewTextBoxColumn
            // 
            this.distributionIDDataGridViewTextBoxColumn.DataPropertyName = "Distribution_ID";
            this.distributionIDDataGridViewTextBoxColumn.HeaderText = "ID розбаловки";
            this.distributionIDDataGridViewTextBoxColumn.Name = "distributionIDDataGridViewTextBoxColumn";
            this.distributionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.distributionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Місце";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            this.placeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Бали";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pointsBindingSource
            // 
            this.pointsBindingSource.DataMember = "PointsDistribution";
            this.pointsBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showAll_Points
            // 
            this.showAll_Points.Location = new System.Drawing.Point(430, 122);
            this.showAll_Points.Name = "showAll_Points";
            this.showAll_Points.Size = new System.Drawing.Size(127, 31);
            this.showAll_Points.TabIndex = 73;
            this.showAll_Points.Text = "Показати всі";
            this.showAll_Points.UseVisualStyleBackColor = true;
            this.showAll_Points.Click += new System.EventHandler(this.showAll_Points_Click);
            // 
            // pointsDistributionTableAdapter
            // 
            this.pointsDistributionTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.activity;
            this.pictureBox5.Location = new System.Drawing.Point(101, -3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(143, 141);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 81;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(252, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 80;
            this.label11.Text = "Розподіл балів";
            // 
            // delete_Points
            // 
            this.delete_Points.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_Points.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Points.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Points.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Points.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Points.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Points.Location = new System.Drawing.Point(134, 299);
            this.delete_Points.Name = "delete_Points";
            this.delete_Points.Size = new System.Drawing.Size(48, 46);
            this.delete_Points.TabIndex = 87;
            this.delete_Points.UseVisualStyleBackColor = false;
            this.delete_Points.Click += new System.EventHandler(this.delete_Points_Click);
            // 
            // edit_Points
            // 
            this.edit_Points.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_Points.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Points.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Points.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Points.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Points.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Points.Location = new System.Drawing.Point(134, 236);
            this.edit_Points.Name = "edit_Points";
            this.edit_Points.Size = new System.Drawing.Size(48, 46);
            this.edit_Points.TabIndex = 86;
            this.edit_Points.UseVisualStyleBackColor = false;
            this.edit_Points.Click += new System.EventHandler(this.edit_Points_Click);
            // 
            // add_Points
            // 
            this.add_Points.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Points.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Points.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Points.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Points.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Points.ForeColor = System.Drawing.Color.Wheat;
            this.add_Points.Location = new System.Drawing.Point(134, 171);
            this.add_Points.Name = "add_Points";
            this.add_Points.Size = new System.Drawing.Size(48, 46);
            this.add_Points.TabIndex = 85;
            this.add_Points.UseVisualStyleBackColor = false;
            this.add_Points.Click += new System.EventHandler(this.add_Points_Click);
            // 
            // back_Points
            // 
            this.back_Points.BackColor = System.Drawing.Color.Transparent;
            this.back_Points.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Points.Image = global::Курсовая.Properties.Resources.goback;
            this.back_Points.Location = new System.Drawing.Point(33, 602);
            this.back_Points.Name = "back_Points";
            this.back_Points.Size = new System.Drawing.Size(56, 50);
            this.back_Points.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Points.TabIndex = 92;
            this.back_Points.TabStop = false;
            this.back_Points.Click += new System.EventHandler(this.back_Points_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(667, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 18);
            this.label13.TabIndex = 121;
            this.label13.Text = "Пошук";
            // 
            // disrtIDCheckBox_Points
            // 
            this.disrtIDCheckBox_Points.AutoSize = true;
            this.disrtIDCheckBox_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disrtIDCheckBox_Points.Location = new System.Drawing.Point(626, 218);
            this.disrtIDCheckBox_Points.Name = "disrtIDCheckBox_Points";
            this.disrtIDCheckBox_Points.Size = new System.Drawing.Size(100, 17);
            this.disrtIDCheckBox_Points.TabIndex = 120;
            this.disrtIDCheckBox_Points.Text = "ID розбаловки";
            this.disrtIDCheckBox_Points.UseVisualStyleBackColor = true;
            // 
            // allCheckBox_Points
            // 
            this.allCheckBox_Points.AutoSize = true;
            this.allCheckBox_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox_Points.Location = new System.Drawing.Point(626, 192);
            this.allCheckBox_Points.Name = "allCheckBox_Points";
            this.allCheckBox_Points.Size = new System.Drawing.Size(69, 17);
            this.allCheckBox_Points.TabIndex = 119;
            this.allCheckBox_Points.Text = "Усі поля";
            this.allCheckBox_Points.UseVisualStyleBackColor = true;
            // 
            // placeCheckBox_Points
            // 
            this.placeCheckBox_Points.AutoSize = true;
            this.placeCheckBox_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placeCheckBox_Points.Location = new System.Drawing.Point(626, 248);
            this.placeCheckBox_Points.Name = "placeCheckBox_Points";
            this.placeCheckBox_Points.Size = new System.Drawing.Size(55, 17);
            this.placeCheckBox_Points.TabIndex = 118;
            this.placeCheckBox_Points.Text = "Місце";
            this.placeCheckBox_Points.UseVisualStyleBackColor = true;
            // 
            // toSearch_Points
            // 
            this.toSearch_Points.Location = new System.Drawing.Point(643, 339);
            this.toSearch_Points.Name = "toSearch_Points";
            this.toSearch_Points.Size = new System.Drawing.Size(97, 27);
            this.toSearch_Points.TabIndex = 117;
            this.toSearch_Points.Text = "Знайти";
            this.toSearch_Points.UseVisualStyleBackColor = true;
            this.toSearch_Points.Click += new System.EventHandler(this.toSearch_Points_Click);
            // 
            // pointsCheckBox_Points
            // 
            this.pointsCheckBox_Points.AutoSize = true;
            this.pointsCheckBox_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsCheckBox_Points.Location = new System.Drawing.Point(626, 278);
            this.pointsCheckBox_Points.Name = "pointsCheckBox_Points";
            this.pointsCheckBox_Points.Size = new System.Drawing.Size(51, 17);
            this.pointsCheckBox_Points.TabIndex = 116;
            this.pointsCheckBox_Points.Text = "Бали";
            this.pointsCheckBox_Points.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Points
            // 
            this.searchTextBox_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox_Points.Location = new System.Drawing.Point(617, 307);
            this.searchTextBox_Points.Name = "searchTextBox_Points";
            this.searchTextBox_Points.Size = new System.Drawing.Size(154, 20);
            this.searchTextBox_Points.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(221, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 114;
            this.label2.Text = "Сортування";
            // 
            // sortComboBox_Points
            // 
            this.sortComboBox_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox_Points.FormattingEnabled = true;
            this.sortComboBox_Points.Items.AddRange(new object[] {
            "ID розбаловки",
            "Місце",
            "Бали"});
            this.sortComboBox_Points.Location = new System.Drawing.Point(199, 461);
            this.sortComboBox_Points.Name = "sortComboBox_Points";
            this.sortComboBox_Points.Size = new System.Drawing.Size(150, 21);
            this.sortComboBox_Points.TabIndex = 113;
            // 
            // toSort_Points
            // 
            this.toSort_Points.Location = new System.Drawing.Point(224, 519);
            this.toSort_Points.Name = "toSort_Points";
            this.toSort_Points.Size = new System.Drawing.Size(97, 27);
            this.toSort_Points.TabIndex = 112;
            this.toSort_Points.Text = "Сортувати";
            this.toSort_Points.UseVisualStyleBackColor = true;
            this.toSort_Points.Click += new System.EventHandler(this.toSort_Points_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(470, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 126;
            this.label4.Text = "Фільтрація";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(530, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 125;
            this.label10.Text = "та";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(423, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 124;
            this.label9.Text = "Між";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(467, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 123;
            this.label8.Text = "Кількість балів";
            // 
            // toFilter_Points
            // 
            this.toFilter_Points.Location = new System.Drawing.Point(477, 518);
            this.toFilter_Points.Name = "toFilter_Points";
            this.toFilter_Points.Size = new System.Drawing.Size(97, 27);
            this.toFilter_Points.TabIndex = 122;
            this.toFilter_Points.Text = "Фільтрувати";
            this.toFilter_Points.UseVisualStyleBackColor = true;
            this.toFilter_Points.Click += new System.EventHandler(this.toFilter_Points_Click);
            // 
            // fromNumericUpDown_Points
            // 
            this.fromNumericUpDown_Points.Location = new System.Drawing.Point(467, 475);
            this.fromNumericUpDown_Points.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.fromNumericUpDown_Points.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromNumericUpDown_Points.Name = "fromNumericUpDown_Points";
            this.fromNumericUpDown_Points.Size = new System.Drawing.Size(54, 21);
            this.fromNumericUpDown_Points.TabIndex = 127;
            this.fromNumericUpDown_Points.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromNumericUpDown_Points.ValueChanged += new System.EventHandler(this.fromNumericUpDown_Points_ValueChanged);
            // 
            // toNumericUpDown_Points
            // 
            this.toNumericUpDown_Points.Location = new System.Drawing.Point(557, 475);
            this.toNumericUpDown_Points.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.toNumericUpDown_Points.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.toNumericUpDown_Points.Name = "toNumericUpDown_Points";
            this.toNumericUpDown_Points.Size = new System.Drawing.Size(54, 21);
            this.toNumericUpDown_Points.TabIndex = 128;
            this.toNumericUpDown_Points.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Points
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(835, 657);
            this.Controls.Add(this.toNumericUpDown_Points);
            this.Controls.Add(this.fromNumericUpDown_Points);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toFilter_Points);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.disrtIDCheckBox_Points);
            this.Controls.Add(this.allCheckBox_Points);
            this.Controls.Add(this.placeCheckBox_Points);
            this.Controls.Add(this.toSearch_Points);
            this.Controls.Add(this.pointsCheckBox_Points);
            this.Controls.Add(this.searchTextBox_Points);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortComboBox_Points);
            this.Controls.Add(this.toSort_Points);
            this.Controls.Add(this.back_Points);
            this.Controls.Add(this.delete_Points);
            this.Controls.Add(this.edit_Points);
            this.Controls.Add(this.add_Points);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.showAll_Points);
            this.Controls.Add(this.pointsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Points";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Розподіл балів";
            this.Load += new System.EventHandler(this.Points_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown_Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown_Points)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pointsDataGridView;
        private System.Windows.Forms.Button showAll_Points;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pointsBindingSource;
        private SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter pointsDistributionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button delete_Points;
        private System.Windows.Forms.Button edit_Points;
        private System.Windows.Forms.Button add_Points;
        private System.Windows.Forms.PictureBox back_Points;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox disrtIDCheckBox_Points;
        private System.Windows.Forms.CheckBox allCheckBox_Points;
        private System.Windows.Forms.CheckBox placeCheckBox_Points;
        private System.Windows.Forms.Button toSearch_Points;
        private System.Windows.Forms.CheckBox pointsCheckBox_Points;
        private System.Windows.Forms.TextBox searchTextBox_Points;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortComboBox_Points;
        private System.Windows.Forms.Button toSort_Points;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button toFilter_Points;
        private System.Windows.Forms.NumericUpDown fromNumericUpDown_Points;
        private System.Windows.Forms.NumericUpDown toNumericUpDown_Points;
    }
}