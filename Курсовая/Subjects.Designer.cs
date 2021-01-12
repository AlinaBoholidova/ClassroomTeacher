namespace Курсовая
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.subjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.testsDataGridView = new System.Windows.Forms.DataGridView();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allCheckBox_Subjects = new System.Windows.Forms.CheckBox();
            this.abbrCheckBox_Subjects = new System.Windows.Forms.CheckBox();
            this.toSearch_Subjects = new System.Windows.Forms.Button();
            this.nameCheckBox_Subjects = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Subjects = new System.Windows.Forms.TextBox();
            this.allCheckBox_Tests = new System.Windows.Forms.CheckBox();
            this.abbrCheckBox_Tests = new System.Windows.Forms.CheckBox();
            this.toSearch_Tests = new System.Windows.Forms.Button();
            this.dateCheckBox_Tests = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Tests = new System.Windows.Forms.TextBox();
            this.idCheckBox_Tests = new System.Windows.Forms.CheckBox();
            this.sortComboBox_Tests = new System.Windows.Forms.ComboBox();
            this.toSort_Tests = new System.Windows.Forms.Button();
            this.sortComboBox_Subjects = new System.Windows.Forms.ComboBox();
            this.toSort_Subjects = new System.Windows.Forms.Button();
            this.showAll_Tests = new System.Windows.Forms.Button();
            this.showAll_Subjects = new System.Windows.Forms.Button();
            this.subjectTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.SubjectTableAdapter();
            this.testTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.TestTableAdapter();
            this.toFilter_Tests = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.delete_Tests = new System.Windows.Forms.Button();
            this.edit_Tests = new System.Windows.Forms.Button();
            this.add_Tests = new System.Windows.Forms.Button();
            this.delete_Subjects = new System.Windows.Forms.Button();
            this.edit_Subjects = new System.Windows.Forms.Button();
            this.add_Subjects = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.back_Subjects = new System.Windows.Forms.PictureBox();
            this.subjectabbrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectabbrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Subjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectsDataGridView
            // 
            this.subjectsDataGridView.AllowUserToAddRows = false;
            this.subjectsDataGridView.AllowUserToDeleteRows = false;
            this.subjectsDataGridView.AutoGenerateColumns = false;
            this.subjectsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.subjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectabbrDataGridViewTextBoxColumn,
            this.subjectnameDataGridViewTextBoxColumn});
            this.subjectsDataGridView.DataSource = this.subjectBindingSource;
            this.subjectsDataGridView.Location = new System.Drawing.Point(931, 151);
            this.subjectsDataGridView.Name = "subjectsDataGridView";
            this.subjectsDataGridView.ReadOnly = true;
            this.subjectsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectsDataGridView.Size = new System.Drawing.Size(293, 226);
            this.subjectsDataGridView.TabIndex = 0;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.AllowUserToAddRows = false;
            this.testsDataGridView.AllowUserToDeleteRows = false;
            this.testsDataGridView.AutoGenerateColumns = false;
            this.testsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testIDDataGridViewTextBoxColumn,
            this.subjectabbrDataGridViewTextBoxColumn1,
            this.testdateDataGridViewTextBoxColumn});
            this.testsDataGridView.DataSource = this.testBindingSource;
            this.testsDataGridView.Location = new System.Drawing.Point(188, 151);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.ReadOnly = true;
            this.testsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testsDataGridView.Size = new System.Drawing.Size(373, 226);
            this.testsDataGridView.TabIndex = 1;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataMember = "Test";
            this.testBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // allCheckBox_Subjects
            // 
            this.allCheckBox_Subjects.AutoSize = true;
            this.allCheckBox_Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox_Subjects.Location = new System.Drawing.Point(874, 433);
            this.allCheckBox_Subjects.Name = "allCheckBox_Subjects";
            this.allCheckBox_Subjects.Size = new System.Drawing.Size(74, 19);
            this.allCheckBox_Subjects.TabIndex = 38;
            this.allCheckBox_Subjects.Text = "Усі поля";
            this.allCheckBox_Subjects.UseVisualStyleBackColor = true;
            // 
            // abbrCheckBox_Subjects
            // 
            this.abbrCheckBox_Subjects.AutoSize = true;
            this.abbrCheckBox_Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.abbrCheckBox_Subjects.Location = new System.Drawing.Point(874, 459);
            this.abbrCheckBox_Subjects.Name = "abbrCheckBox_Subjects";
            this.abbrCheckBox_Subjects.Size = new System.Drawing.Size(156, 19);
            this.abbrCheckBox_Subjects.TabIndex = 37;
            this.abbrCheckBox_Subjects.Text = "Абревіатура предмету";
            this.abbrCheckBox_Subjects.UseVisualStyleBackColor = true;
            // 
            // toSearch_Subjects
            // 
            this.toSearch_Subjects.Location = new System.Drawing.Point(896, 537);
            this.toSearch_Subjects.Name = "toSearch_Subjects";
            this.toSearch_Subjects.Size = new System.Drawing.Size(113, 31);
            this.toSearch_Subjects.TabIndex = 36;
            this.toSearch_Subjects.Text = "Знайти";
            this.toSearch_Subjects.UseVisualStyleBackColor = true;
            this.toSearch_Subjects.Click += new System.EventHandler(this.toSearch_Subjects_Click);
            // 
            // nameCheckBox_Subjects
            // 
            this.nameCheckBox_Subjects.AutoSize = true;
            this.nameCheckBox_Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCheckBox_Subjects.Location = new System.Drawing.Point(874, 484);
            this.nameCheckBox_Subjects.Name = "nameCheckBox_Subjects";
            this.nameCheckBox_Subjects.Size = new System.Drawing.Size(121, 19);
            this.nameCheckBox_Subjects.TabIndex = 35;
            this.nameCheckBox_Subjects.Text = "Назва предмету";
            this.nameCheckBox_Subjects.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Subjects
            // 
            this.searchTextBox_Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox_Subjects.Location = new System.Drawing.Point(843, 510);
            this.searchTextBox_Subjects.Name = "searchTextBox_Subjects";
            this.searchTextBox_Subjects.Size = new System.Drawing.Size(227, 21);
            this.searchTextBox_Subjects.TabIndex = 34;
            // 
            // allCheckBox_Tests
            // 
            this.allCheckBox_Tests.AutoSize = true;
            this.allCheckBox_Tests.Location = new System.Drawing.Point(593, 200);
            this.allCheckBox_Tests.Name = "allCheckBox_Tests";
            this.allCheckBox_Tests.Size = new System.Drawing.Size(74, 19);
            this.allCheckBox_Tests.TabIndex = 44;
            this.allCheckBox_Tests.Text = "Усі поля";
            this.allCheckBox_Tests.UseVisualStyleBackColor = true;
            // 
            // abbrCheckBox_Tests
            // 
            this.abbrCheckBox_Tests.AutoSize = true;
            this.abbrCheckBox_Tests.Location = new System.Drawing.Point(593, 248);
            this.abbrCheckBox_Tests.Name = "abbrCheckBox_Tests";
            this.abbrCheckBox_Tests.Size = new System.Drawing.Size(156, 19);
            this.abbrCheckBox_Tests.TabIndex = 43;
            this.abbrCheckBox_Tests.Text = "Абревіатура предмету";
            this.abbrCheckBox_Tests.UseVisualStyleBackColor = true;
            // 
            // toSearch_Tests
            // 
            this.toSearch_Tests.Location = new System.Drawing.Point(631, 330);
            this.toSearch_Tests.Name = "toSearch_Tests";
            this.toSearch_Tests.Size = new System.Drawing.Size(113, 31);
            this.toSearch_Tests.TabIndex = 42;
            this.toSearch_Tests.Text = "Знайти";
            this.toSearch_Tests.UseVisualStyleBackColor = true;
            this.toSearch_Tests.Click += new System.EventHandler(this.toSearch_Tests_Click);
            // 
            // dateCheckBox_Tests
            // 
            this.dateCheckBox_Tests.AutoSize = true;
            this.dateCheckBox_Tests.Location = new System.Drawing.Point(593, 274);
            this.dateCheckBox_Tests.Name = "dateCheckBox_Tests";
            this.dateCheckBox_Tests.Size = new System.Drawing.Size(121, 19);
            this.dateCheckBox_Tests.TabIndex = 41;
            this.dateCheckBox_Tests.Text = "Дата написання";
            this.dateCheckBox_Tests.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Tests
            // 
            this.searchTextBox_Tests.Location = new System.Drawing.Point(568, 300);
            this.searchTextBox_Tests.Name = "searchTextBox_Tests";
            this.searchTextBox_Tests.Size = new System.Drawing.Size(227, 21);
            this.searchTextBox_Tests.TabIndex = 40;
            // 
            // idCheckBox_Tests
            // 
            this.idCheckBox_Tests.AutoSize = true;
            this.idCheckBox_Tests.Location = new System.Drawing.Point(593, 222);
            this.idCheckBox_Tests.Name = "idCheckBox_Tests";
            this.idCheckBox_Tests.Size = new System.Drawing.Size(113, 19);
            this.idCheckBox_Tests.TabIndex = 45;
            this.idCheckBox_Tests.Text = "ID контрольної";
            this.idCheckBox_Tests.UseVisualStyleBackColor = true;
            // 
            // sortComboBox_Tests
            // 
            this.sortComboBox_Tests.FormattingEnabled = true;
            this.sortComboBox_Tests.Items.AddRange(new object[] {
            "ID контрольної",
            "Абревіатура предмету",
            "Дата написання"});
            this.sortComboBox_Tests.Location = new System.Drawing.Point(163, 480);
            this.sortComboBox_Tests.Name = "sortComboBox_Tests";
            this.sortComboBox_Tests.Size = new System.Drawing.Size(163, 23);
            this.sortComboBox_Tests.TabIndex = 48;
            // 
            // toSort_Tests
            // 
            this.toSort_Tests.Location = new System.Drawing.Point(188, 546);
            this.toSort_Tests.Name = "toSort_Tests";
            this.toSort_Tests.Size = new System.Drawing.Size(113, 31);
            this.toSort_Tests.TabIndex = 47;
            this.toSort_Tests.Text = "Сортувати";
            this.toSort_Tests.UseVisualStyleBackColor = true;
            this.toSort_Tests.Click += new System.EventHandler(this.toSort_Tests_Click);
            // 
            // sortComboBox_Subjects
            // 
            this.sortComboBox_Subjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox_Subjects.FormattingEnabled = true;
            this.sortComboBox_Subjects.Items.AddRange(new object[] {
            "Абревіатура предмету",
            "Назва предмету"});
            this.sortComboBox_Subjects.Location = new System.Drawing.Point(1111, 465);
            this.sortComboBox_Subjects.Name = "sortComboBox_Subjects";
            this.sortComboBox_Subjects.Size = new System.Drawing.Size(163, 23);
            this.sortComboBox_Subjects.TabIndex = 51;
            // 
            // toSort_Subjects
            // 
            this.toSort_Subjects.Location = new System.Drawing.Point(1134, 537);
            this.toSort_Subjects.Name = "toSort_Subjects";
            this.toSort_Subjects.Size = new System.Drawing.Size(113, 31);
            this.toSort_Subjects.TabIndex = 50;
            this.toSort_Subjects.Text = "Сортувати";
            this.toSort_Subjects.UseVisualStyleBackColor = true;
            this.toSort_Subjects.Click += new System.EventHandler(this.toSort_Subjects_Click);
            // 
            // showAll_Tests
            // 
            this.showAll_Tests.Location = new System.Drawing.Point(415, 114);
            this.showAll_Tests.Name = "showAll_Tests";
            this.showAll_Tests.Size = new System.Drawing.Size(127, 31);
            this.showAll_Tests.TabIndex = 52;
            this.showAll_Tests.Text = "Показати всі";
            this.showAll_Tests.UseVisualStyleBackColor = true;
            this.showAll_Tests.Click += new System.EventHandler(this.showAll_Tests_Click);
            // 
            // showAll_Subjects
            // 
            this.showAll_Subjects.Location = new System.Drawing.Point(1080, 113);
            this.showAll_Subjects.Name = "showAll_Subjects";
            this.showAll_Subjects.Size = new System.Drawing.Size(127, 31);
            this.showAll_Subjects.TabIndex = 53;
            this.showAll_Subjects.Text = "Показати всі";
            this.showAll_Subjects.UseVisualStyleBackColor = true;
            this.showAll_Subjects.Click += new System.EventHandler(this.showAll_Subjects_Click);
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // testTableAdapter
            // 
            this.testTableAdapter.ClearBeforeFill = true;
            // 
            // toFilter_Tests
            // 
            this.toFilter_Tests.Location = new System.Drawing.Point(456, 546);
            this.toFilter_Tests.Name = "toFilter_Tests";
            this.toFilter_Tests.Size = new System.Drawing.Size(113, 31);
            this.toFilter_Tests.TabIndex = 61;
            this.toFilter_Tests.Text = "Фільтрувати";
            this.toFilter_Tests.UseVisualStyleBackColor = true;
            this.toFilter_Tests.Click += new System.EventHandler(this.toFilter_Tests_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(456, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Дата написання";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 63;
            this.label9.Text = "Між";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 64;
            this.label10.Text = "та";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(404, 473);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(233, 21);
            this.fromDateTimePicker.TabIndex = 65;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(404, 508);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(233, 21);
            this.toDateTimePicker.TabIndex = 66;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.subject;
            this.pictureBox5.Location = new System.Drawing.Point(107, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 120);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 68;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(243, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Контрольні роботи";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Курсовая.Properties.Resources.subject;
            this.pictureBox1.Location = new System.Drawing.Point(832, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(967, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 20);
            this.label12.TabIndex = 69;
            this.label12.Text = "Навчальні предмети";
            // 
            // delete_Tests
            // 
            this.delete_Tests.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_Tests.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Tests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Tests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Tests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Tests.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Tests.Location = new System.Drawing.Point(123, 304);
            this.delete_Tests.Name = "delete_Tests";
            this.delete_Tests.Size = new System.Drawing.Size(46, 46);
            this.delete_Tests.TabIndex = 73;
            this.delete_Tests.UseVisualStyleBackColor = false;
            this.delete_Tests.Click += new System.EventHandler(this.delete_Tests_Click);
            // 
            // edit_Tests
            // 
            this.edit_Tests.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_Tests.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Tests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Tests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Tests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Tests.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Tests.Location = new System.Drawing.Point(123, 237);
            this.edit_Tests.Name = "edit_Tests";
            this.edit_Tests.Size = new System.Drawing.Size(46, 46);
            this.edit_Tests.TabIndex = 72;
            this.edit_Tests.UseVisualStyleBackColor = false;
            this.edit_Tests.Click += new System.EventHandler(this.edit_Tests_Click);
            // 
            // add_Tests
            // 
            this.add_Tests.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Tests.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Tests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Tests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Tests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Tests.ForeColor = System.Drawing.Color.Wheat;
            this.add_Tests.Location = new System.Drawing.Point(123, 170);
            this.add_Tests.Name = "add_Tests";
            this.add_Tests.Size = new System.Drawing.Size(46, 46);
            this.add_Tests.TabIndex = 71;
            this.add_Tests.UseVisualStyleBackColor = false;
            this.add_Tests.Click += new System.EventHandler(this.add_Tests_Click);
            // 
            // delete_Subjects
            // 
            this.delete_Subjects.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_Subjects.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Subjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Subjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Subjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Subjects.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Subjects.Location = new System.Drawing.Point(860, 306);
            this.delete_Subjects.Name = "delete_Subjects";
            this.delete_Subjects.Size = new System.Drawing.Size(46, 46);
            this.delete_Subjects.TabIndex = 76;
            this.delete_Subjects.UseVisualStyleBackColor = false;
            this.delete_Subjects.Click += new System.EventHandler(this.delete_Subjects_Click);
            // 
            // edit_Subjects
            // 
            this.edit_Subjects.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_Subjects.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Subjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Subjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Subjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Subjects.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Subjects.Location = new System.Drawing.Point(860, 239);
            this.edit_Subjects.Name = "edit_Subjects";
            this.edit_Subjects.Size = new System.Drawing.Size(46, 46);
            this.edit_Subjects.TabIndex = 75;
            this.edit_Subjects.UseVisualStyleBackColor = false;
            this.edit_Subjects.Click += new System.EventHandler(this.edit_Subjects_Click);
            // 
            // add_Subjects
            // 
            this.add_Subjects.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Subjects.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Subjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Subjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Subjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Subjects.ForeColor = System.Drawing.Color.Wheat;
            this.add_Subjects.Location = new System.Drawing.Point(860, 172);
            this.add_Subjects.Name = "add_Subjects";
            this.add_Subjects.Size = new System.Drawing.Size(46, 46);
            this.add_Subjects.TabIndex = 74;
            this.add_Subjects.UseVisualStyleBackColor = false;
            this.add_Subjects.Click += new System.EventHandler(this.add_Subjects_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(468, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 79;
            this.label1.Text = "Фільтрація";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(201, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 78;
            this.label2.Text = "Сортування";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(655, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 18);
            this.label13.TabIndex = 77;
            this.label13.Text = "Пошук";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(921, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "Пошук";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1137, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Сортування";
            // 
            // back_Subjects
            // 
            this.back_Subjects.BackColor = System.Drawing.Color.Transparent;
            this.back_Subjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Subjects.Image = global::Курсовая.Properties.Resources.goback;
            this.back_Subjects.Location = new System.Drawing.Point(49, 597);
            this.back_Subjects.Name = "back_Subjects";
            this.back_Subjects.Size = new System.Drawing.Size(62, 55);
            this.back_Subjects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Subjects.TabIndex = 82;
            this.back_Subjects.TabStop = false;
            this.back_Subjects.Click += new System.EventHandler(this.back_Subjects_Click);
            // 
            // subjectabbrDataGridViewTextBoxColumn
            // 
            this.subjectabbrDataGridViewTextBoxColumn.DataPropertyName = "Subject_abbr";
            this.subjectabbrDataGridViewTextBoxColumn.HeaderText = "Абревіатура предмету";
            this.subjectabbrDataGridViewTextBoxColumn.Name = "subjectabbrDataGridViewTextBoxColumn";
            this.subjectabbrDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectabbrDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // subjectnameDataGridViewTextBoxColumn
            // 
            this.subjectnameDataGridViewTextBoxColumn.DataPropertyName = "Subject_name";
            this.subjectnameDataGridViewTextBoxColumn.HeaderText = "Назва предмету";
            this.subjectnameDataGridViewTextBoxColumn.Name = "subjectnameDataGridViewTextBoxColumn";
            this.subjectnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectnameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.subjectnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // testIDDataGridViewTextBoxColumn
            // 
            this.testIDDataGridViewTextBoxColumn.DataPropertyName = "Test_ID";
            this.testIDDataGridViewTextBoxColumn.HeaderText = "ID контрольної";
            this.testIDDataGridViewTextBoxColumn.Name = "testIDDataGridViewTextBoxColumn";
            this.testIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.testIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // subjectabbrDataGridViewTextBoxColumn1
            // 
            this.subjectabbrDataGridViewTextBoxColumn1.DataPropertyName = "Subject_abbr";
            this.subjectabbrDataGridViewTextBoxColumn1.HeaderText = "Абревіатура предмету";
            this.subjectabbrDataGridViewTextBoxColumn1.Name = "subjectabbrDataGridViewTextBoxColumn1";
            this.subjectabbrDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subjectabbrDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // testdateDataGridViewTextBoxColumn
            // 
            this.testdateDataGridViewTextBoxColumn.DataPropertyName = "Test_date";
            this.testdateDataGridViewTextBoxColumn.HeaderText = "Дата написання";
            this.testdateDataGridViewTextBoxColumn.Name = "testdateDataGridViewTextBoxColumn";
            this.testdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.testdateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.testdateDataGridViewTextBoxColumn.Width = 110;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox2.Location = new System.Drawing.Point(804, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 680);
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 670);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.back_Subjects);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.delete_Subjects);
            this.Controls.Add(this.edit_Subjects);
            this.Controls.Add(this.add_Subjects);
            this.Controls.Add(this.delete_Tests);
            this.Controls.Add(this.edit_Tests);
            this.Controls.Add(this.add_Tests);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toFilter_Tests);
            this.Controls.Add(this.showAll_Subjects);
            this.Controls.Add(this.showAll_Tests);
            this.Controls.Add(this.sortComboBox_Subjects);
            this.Controls.Add(this.toSort_Subjects);
            this.Controls.Add(this.sortComboBox_Tests);
            this.Controls.Add(this.toSort_Tests);
            this.Controls.Add(this.idCheckBox_Tests);
            this.Controls.Add(this.allCheckBox_Tests);
            this.Controls.Add(this.abbrCheckBox_Tests);
            this.Controls.Add(this.toSearch_Tests);
            this.Controls.Add(this.dateCheckBox_Tests);
            this.Controls.Add(this.searchTextBox_Tests);
            this.Controls.Add(this.allCheckBox_Subjects);
            this.Controls.Add(this.abbrCheckBox_Subjects);
            this.Controls.Add(this.toSearch_Subjects);
            this.Controls.Add(this.nameCheckBox_Subjects);
            this.Controls.Add(this.searchTextBox_Subjects);
            this.Controls.Add(this.testsDataGridView);
            this.Controls.Add(this.subjectsDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предмети  та контрольні";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subjects_FormClosing);
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Subjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView subjectsDataGridView;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private SchoolCourseDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.DataGridView testsDataGridView;
        private System.Windows.Forms.BindingSource testBindingSource;
        private SchoolCourseDataSetTableAdapters.TestTableAdapter testTableAdapter;
        private System.Windows.Forms.CheckBox allCheckBox_Subjects;
        private System.Windows.Forms.CheckBox abbrCheckBox_Subjects;
        private System.Windows.Forms.Button toSearch_Subjects;
        private System.Windows.Forms.CheckBox nameCheckBox_Subjects;
        private System.Windows.Forms.TextBox searchTextBox_Subjects;
        private System.Windows.Forms.CheckBox allCheckBox_Tests;
        private System.Windows.Forms.CheckBox abbrCheckBox_Tests;
        private System.Windows.Forms.Button toSearch_Tests;
        private System.Windows.Forms.CheckBox dateCheckBox_Tests;
        private System.Windows.Forms.TextBox searchTextBox_Tests;
        private System.Windows.Forms.CheckBox idCheckBox_Tests;
        private System.Windows.Forms.ComboBox sortComboBox_Tests;
        private System.Windows.Forms.Button toSort_Tests;
        private System.Windows.Forms.ComboBox sortComboBox_Subjects;
        private System.Windows.Forms.Button toSort_Subjects;
        private System.Windows.Forms.Button showAll_Tests;
        private System.Windows.Forms.Button showAll_Subjects;
        private System.Windows.Forms.Button toFilter_Tests;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button delete_Tests;
        private System.Windows.Forms.Button edit_Tests;
        private System.Windows.Forms.Button add_Tests;
        private System.Windows.Forms.Button delete_Subjects;
        private System.Windows.Forms.Button edit_Subjects;
        private System.Windows.Forms.Button add_Subjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox back_Subjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectabbrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectabbrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}