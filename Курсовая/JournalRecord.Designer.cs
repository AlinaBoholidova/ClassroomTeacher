namespace Курсовая
{
    partial class JournalRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalRecord));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.delete_Record = new System.Windows.Forms.Button();
            this.edit_Record = new System.Windows.Forms.Button();
            this.add_Record = new System.Windows.Forms.Button();
            this.showAll_Record = new System.Windows.Forms.Button();
            this.recordsDataGridView = new System.Windows.Forms.DataGridView();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.journalRecordTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter();
            this.back_Record = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortComboBox_Records = new System.Windows.Forms.ComboBox();
            this.toSort_Records = new System.Windows.Forms.Button();
            this.toNumericUpDown_Points = new System.Windows.Forms.NumericUpDown();
            this.fromNumericUpDown_Points = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toFilter_Records = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.scoreCheckBox_Record = new System.Windows.Forms.CheckBox();
            this.testIDCheckBox_Record = new System.Windows.Forms.CheckBox();
            this.allCheckBox_Record = new System.Windows.Forms.CheckBox();
            this.recIDCheckBox_Record = new System.Windows.Forms.CheckBox();
            this.toSearch_Records = new System.Windows.Forms.Button();
            this.pupilIDCheckBox_Record = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Records = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown_Points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown_Points)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.subject;
            this.pictureBox5.Location = new System.Drawing.Point(94, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 120);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(230, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 69;
            this.label11.Text = "Записи журналу";
            // 
            // delete_Record
            // 
            this.delete_Record.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_Record.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Record.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Record.Location = new System.Drawing.Point(112, 299);
            this.delete_Record.Name = "delete_Record";
            this.delete_Record.Size = new System.Drawing.Size(46, 46);
            this.delete_Record.TabIndex = 78;
            this.delete_Record.UseVisualStyleBackColor = false;
            this.delete_Record.Click += new System.EventHandler(this.delete_Record_Click);
            // 
            // edit_Record
            // 
            this.edit_Record.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_Record.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Record.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Record.Location = new System.Drawing.Point(112, 232);
            this.edit_Record.Name = "edit_Record";
            this.edit_Record.Size = new System.Drawing.Size(46, 46);
            this.edit_Record.TabIndex = 77;
            this.edit_Record.UseVisualStyleBackColor = false;
            this.edit_Record.Click += new System.EventHandler(this.edit_Record_Click);
            // 
            // add_Record
            // 
            this.add_Record.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Record.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Record.ForeColor = System.Drawing.Color.Wheat;
            this.add_Record.Location = new System.Drawing.Point(112, 165);
            this.add_Record.Name = "add_Record";
            this.add_Record.Size = new System.Drawing.Size(46, 46);
            this.add_Record.TabIndex = 76;
            this.add_Record.UseVisualStyleBackColor = false;
            this.add_Record.Click += new System.EventHandler(this.add_Record_Click);
            // 
            // showAll_Record
            // 
            this.showAll_Record.Location = new System.Drawing.Point(478, 109);
            this.showAll_Record.Name = "showAll_Record";
            this.showAll_Record.Size = new System.Drawing.Size(127, 31);
            this.showAll_Record.TabIndex = 75;
            this.showAll_Record.Text = "Показати всі";
            this.showAll_Record.UseVisualStyleBackColor = true;
            this.showAll_Record.Click += new System.EventHandler(this.showAll_Record_Click);
            // 
            // recordsDataGridView
            // 
            this.recordsDataGridView.AllowUserToAddRows = false;
            this.recordsDataGridView.AllowUserToDeleteRows = false;
            this.recordsDataGridView.AutoGenerateColumns = false;
            this.recordsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.recordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.pupilIDDataGridViewTextBoxColumn,
            this.testIDDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.recordsDataGridView.DataSource = this.recordBindingSource;
            this.recordsDataGridView.Location = new System.Drawing.Point(177, 146);
            this.recordsDataGridView.Name = "recordsDataGridView";
            this.recordsDataGridView.ReadOnly = true;
            this.recordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordsDataGridView.Size = new System.Drawing.Size(446, 226);
            this.recordsDataGridView.TabIndex = 74;
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "Record_ID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "ID запису";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pupilIDDataGridViewTextBoxColumn
            // 
            this.pupilIDDataGridViewTextBoxColumn.DataPropertyName = "Pupil_ID";
            this.pupilIDDataGridViewTextBoxColumn.HeaderText = "ID учня";
            this.pupilIDDataGridViewTextBoxColumn.Name = "pupilIDDataGridViewTextBoxColumn";
            this.pupilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pupilIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // testIDDataGridViewTextBoxColumn
            // 
            this.testIDDataGridViewTextBoxColumn.DataPropertyName = "Test_ID";
            this.testIDDataGridViewTextBoxColumn.HeaderText = "ID контрольної";
            this.testIDDataGridViewTextBoxColumn.Name = "testIDDataGridViewTextBoxColumn";
            this.testIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.testIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Оцінка";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.scoreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataMember = "JournalRecord";
            this.recordBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalRecordTableAdapter
            // 
            this.journalRecordTableAdapter.ClearBeforeFill = true;
            // 
            // back_Record
            // 
            this.back_Record.BackColor = System.Drawing.Color.Transparent;
            this.back_Record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Record.Image = global::Курсовая.Properties.Resources.goback;
            this.back_Record.Location = new System.Drawing.Point(39, 551);
            this.back_Record.Name = "back_Record";
            this.back_Record.Size = new System.Drawing.Size(52, 48);
            this.back_Record.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Record.TabIndex = 83;
            this.back_Record.TabStop = false;
            this.back_Record.Click += new System.EventHandler(this.back_Record_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(236, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "Сортування";
            // 
            // sortComboBox_Records
            // 
            this.sortComboBox_Records.FormattingEnabled = true;
            this.sortComboBox_Records.Items.AddRange(new object[] {
            "ID запису",
            "ID учня",
            "ID контрольної",
            "Оцінка"});
            this.sortComboBox_Records.Location = new System.Drawing.Point(200, 444);
            this.sortComboBox_Records.Name = "sortComboBox_Records";
            this.sortComboBox_Records.Size = new System.Drawing.Size(163, 21);
            this.sortComboBox_Records.TabIndex = 85;
            // 
            // toSort_Records
            // 
            this.toSort_Records.Location = new System.Drawing.Point(231, 502);
            this.toSort_Records.Name = "toSort_Records";
            this.toSort_Records.Size = new System.Drawing.Size(97, 27);
            this.toSort_Records.TabIndex = 84;
            this.toSort_Records.Text = "Сортувати";
            this.toSort_Records.UseVisualStyleBackColor = true;
            this.toSort_Records.Click += new System.EventHandler(this.toSort_Records_Click);
            // 
            // toNumericUpDown_Points
            // 
            this.toNumericUpDown_Points.Location = new System.Drawing.Point(558, 459);
            this.toNumericUpDown_Points.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.toNumericUpDown_Points.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.toNumericUpDown_Points.Name = "toNumericUpDown_Points";
            this.toNumericUpDown_Points.Size = new System.Drawing.Size(54, 20);
            this.toNumericUpDown_Points.TabIndex = 135;
            this.toNumericUpDown_Points.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.toNumericUpDown_Points.ValueChanged += new System.EventHandler(this.toNumericUpDown_Points_ValueChanged);
            // 
            // fromNumericUpDown_Points
            // 
            this.fromNumericUpDown_Points.Location = new System.Drawing.Point(468, 459);
            this.fromNumericUpDown_Points.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.fromNumericUpDown_Points.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromNumericUpDown_Points.Name = "fromNumericUpDown_Points";
            this.fromNumericUpDown_Points.Size = new System.Drawing.Size(54, 20);
            this.fromNumericUpDown_Points.TabIndex = 134;
            this.fromNumericUpDown_Points.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromNumericUpDown_Points.ValueChanged += new System.EventHandler(this.fromNumericUpDown_Points_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(471, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 133;
            this.label4.Text = "Фільтрація";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(531, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 132;
            this.label10.Text = "та";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(424, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 131;
            this.label9.Text = "Між";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(497, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 130;
            this.label8.Text = "Оцінка";
            // 
            // toFilter_Records
            // 
            this.toFilter_Records.Location = new System.Drawing.Point(478, 502);
            this.toFilter_Records.Name = "toFilter_Records";
            this.toFilter_Records.Size = new System.Drawing.Size(97, 27);
            this.toFilter_Records.TabIndex = 129;
            this.toFilter_Records.Text = "Фільтрувати";
            this.toFilter_Records.UseVisualStyleBackColor = true;
            this.toFilter_Records.Click += new System.EventHandler(this.toFilter_Records_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(756, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 143;
            this.label5.Text = "Пошук";
            // 
            // scoreCheckBox_Record
            // 
            this.scoreCheckBox_Record.AutoSize = true;
            this.scoreCheckBox_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreCheckBox_Record.Location = new System.Drawing.Point(688, 289);
            this.scoreCheckBox_Record.Name = "scoreCheckBox_Record";
            this.scoreCheckBox_Record.Size = new System.Drawing.Size(65, 19);
            this.scoreCheckBox_Record.TabIndex = 142;
            this.scoreCheckBox_Record.Text = "Оцінка";
            this.scoreCheckBox_Record.UseVisualStyleBackColor = true;
            // 
            // testIDCheckBox_Record
            // 
            this.testIDCheckBox_Record.AutoSize = true;
            this.testIDCheckBox_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testIDCheckBox_Record.Location = new System.Drawing.Point(688, 265);
            this.testIDCheckBox_Record.Name = "testIDCheckBox_Record";
            this.testIDCheckBox_Record.Size = new System.Drawing.Size(113, 19);
            this.testIDCheckBox_Record.TabIndex = 141;
            this.testIDCheckBox_Record.Text = "ID контрольної";
            this.testIDCheckBox_Record.UseVisualStyleBackColor = true;
            // 
            // allCheckBox_Record
            // 
            this.allCheckBox_Record.AutoSize = true;
            this.allCheckBox_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox_Record.Location = new System.Drawing.Point(688, 196);
            this.allCheckBox_Record.Name = "allCheckBox_Record";
            this.allCheckBox_Record.Size = new System.Drawing.Size(74, 19);
            this.allCheckBox_Record.TabIndex = 140;
            this.allCheckBox_Record.Text = "Усі поля";
            this.allCheckBox_Record.UseVisualStyleBackColor = true;
            // 
            // recIDCheckBox_Record
            // 
            this.recIDCheckBox_Record.AutoSize = true;
            this.recIDCheckBox_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recIDCheckBox_Record.Location = new System.Drawing.Point(688, 219);
            this.recIDCheckBox_Record.Name = "recIDCheckBox_Record";
            this.recIDCheckBox_Record.Size = new System.Drawing.Size(79, 19);
            this.recIDCheckBox_Record.TabIndex = 139;
            this.recIDCheckBox_Record.Text = "ID запису";
            this.recIDCheckBox_Record.UseVisualStyleBackColor = true;
            // 
            // toSearch_Records
            // 
            this.toSearch_Records.Location = new System.Drawing.Point(731, 349);
            this.toSearch_Records.Name = "toSearch_Records";
            this.toSearch_Records.Size = new System.Drawing.Size(97, 27);
            this.toSearch_Records.TabIndex = 138;
            this.toSearch_Records.Text = "Знайти";
            this.toSearch_Records.UseVisualStyleBackColor = true;
            this.toSearch_Records.Click += new System.EventHandler(this.toSearch_Records_Click);
            // 
            // pupilIDCheckBox_Record
            // 
            this.pupilIDCheckBox_Record.AutoSize = true;
            this.pupilIDCheckBox_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pupilIDCheckBox_Record.Location = new System.Drawing.Point(688, 241);
            this.pupilIDCheckBox_Record.Name = "pupilIDCheckBox_Record";
            this.pupilIDCheckBox_Record.Size = new System.Drawing.Size(66, 19);
            this.pupilIDCheckBox_Record.TabIndex = 137;
            this.pupilIDCheckBox_Record.Text = "ID учня";
            this.pupilIDCheckBox_Record.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Records
            // 
            this.searchTextBox_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox_Records.Location = new System.Drawing.Point(731, 314);
            this.searchTextBox_Records.Name = "searchTextBox_Records";
            this.searchTextBox_Records.Size = new System.Drawing.Size(97, 21);
            this.searchTextBox_Records.TabIndex = 136;
            // 
            // JournalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(933, 616);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scoreCheckBox_Record);
            this.Controls.Add(this.testIDCheckBox_Record);
            this.Controls.Add(this.allCheckBox_Record);
            this.Controls.Add(this.recIDCheckBox_Record);
            this.Controls.Add(this.toSearch_Records);
            this.Controls.Add(this.pupilIDCheckBox_Record);
            this.Controls.Add(this.searchTextBox_Records);
            this.Controls.Add(this.toNumericUpDown_Points);
            this.Controls.Add(this.fromNumericUpDown_Points);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toFilter_Records);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortComboBox_Records);
            this.Controls.Add(this.toSort_Records);
            this.Controls.Add(this.back_Record);
            this.Controls.Add(this.delete_Record);
            this.Controls.Add(this.edit_Record);
            this.Controls.Add(this.add_Record);
            this.Controls.Add(this.showAll_Record);
            this.Controls.Add(this.recordsDataGridView);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JournalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записи журналу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JournalRecord_FormClosing);
            this.Load += new System.EventHandler(this.JournalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown_Points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown_Points)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button delete_Record;
        private System.Windows.Forms.Button edit_Record;
        private System.Windows.Forms.Button add_Record;
        private System.Windows.Forms.Button showAll_Record;
        private System.Windows.Forms.DataGridView recordsDataGridView;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource recordBindingSource;
        private SchoolCourseDataSetTableAdapters.JournalRecordTableAdapter journalRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox back_Record;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortComboBox_Records;
        private System.Windows.Forms.Button toSort_Records;
        private System.Windows.Forms.NumericUpDown toNumericUpDown_Points;
        private System.Windows.Forms.NumericUpDown fromNumericUpDown_Points;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button toFilter_Records;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox scoreCheckBox_Record;
        private System.Windows.Forms.CheckBox testIDCheckBox_Record;
        private System.Windows.Forms.CheckBox allCheckBox_Record;
        private System.Windows.Forms.CheckBox recIDCheckBox_Record;
        private System.Windows.Forms.Button toSearch_Records;
        private System.Windows.Forms.CheckBox pupilIDCheckBox_Record;
        private System.Windows.Forms.TextBox searchTextBox_Records;
    }
}