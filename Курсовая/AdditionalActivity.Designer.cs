namespace Курсовая
{
    partial class AdditionalActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalActivity));
            this.showAll_Activity = new System.Windows.Forms.Button();
            this.showAll_Participation = new System.Windows.Forms.Button();
            this.activityDataGridView = new System.Windows.Forms.DataGridView();
            this.activityIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.participationDataGridView = new System.Windows.Forms.DataGridView();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additionalParticipationTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalParticipationTableAdapter();
            this.additionalActivityTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_Participation = new System.Windows.Forms.Button();
            this.edit_Participation = new System.Windows.Forms.Button();
            this.add_Participation = new System.Windows.Forms.Button();
            this.delete_Activity = new System.Windows.Forms.Button();
            this.edit_Activity = new System.Windows.Forms.Button();
            this.add_Activity = new System.Windows.Forms.Button();
            this.back_AddActivity = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortComboBox_Participation = new System.Windows.Forms.ComboBox();
            this.toSort_Participation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sortComboBox_Activity = new System.Windows.Forms.ComboBox();
            this.toSort_Activity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toFilter_Activity = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pupilIDCheckBox_Participation = new System.Windows.Forms.CheckBox();
            this.allCheckBox_Participation = new System.Windows.Forms.CheckBox();
            this.actIDCheckBox_Participation = new System.Windows.Forms.CheckBox();
            this.toSearch_Participation = new System.Windows.Forms.Button();
            this.distrIDCheckBox_Participation = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Participation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pupilIDCheckBox_Activity = new System.Windows.Forms.CheckBox();
            this.allCheckBox_Activity = new System.Windows.Forms.CheckBox();
            this.nameCheckBox_Activity = new System.Windows.Forms.CheckBox();
            this.toSearch_Activity = new System.Windows.Forms.Button();
            this.dateCheckBox_Activity = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Activity = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_AddActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // showAll_Activity
            // 
            this.showAll_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAll_Activity.Location = new System.Drawing.Point(967, 102);
            this.showAll_Activity.Name = "showAll_Activity";
            this.showAll_Activity.Size = new System.Drawing.Size(127, 31);
            this.showAll_Activity.TabIndex = 73;
            this.showAll_Activity.Text = "Показати всі";
            this.showAll_Activity.UseVisualStyleBackColor = true;
            this.showAll_Activity.Click += new System.EventHandler(this.showAll_Activity_Click);
            // 
            // showAll_Participation
            // 
            this.showAll_Participation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAll_Participation.Location = new System.Drawing.Point(385, 99);
            this.showAll_Participation.Name = "showAll_Participation";
            this.showAll_Participation.Size = new System.Drawing.Size(127, 31);
            this.showAll_Participation.TabIndex = 69;
            this.showAll_Participation.Text = "Показати всі";
            this.showAll_Participation.UseVisualStyleBackColor = true;
            this.showAll_Participation.Click += new System.EventHandler(this.showAll_Participation_Click);
            // 
            // activityDataGridView
            // 
            this.activityDataGridView.AllowUserToAddRows = false;
            this.activityDataGridView.AllowUserToDeleteRows = false;
            this.activityDataGridView.AutoGenerateColumns = false;
            this.activityDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.activityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activityIDDataGridViewTextBoxColumn1,
            this.activitynameDataGridViewTextBoxColumn,
            this.activitydateDataGridViewTextBoxColumn});
            this.activityDataGridView.DataSource = this.activityBindingSource;
            this.activityDataGridView.Location = new System.Drawing.Point(667, 146);
            this.activityDataGridView.Name = "activityDataGridView";
            this.activityDataGridView.ReadOnly = true;
            this.activityDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activityDataGridView.Size = new System.Drawing.Size(444, 208);
            this.activityDataGridView.TabIndex = 66;
            // 
            // activityIDDataGridViewTextBoxColumn1
            // 
            this.activityIDDataGridViewTextBoxColumn1.DataPropertyName = "Activity_ID";
            this.activityIDDataGridViewTextBoxColumn1.HeaderText = "ID активності";
            this.activityIDDataGridViewTextBoxColumn1.Name = "activityIDDataGridViewTextBoxColumn1";
            this.activityIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.activityIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activitynameDataGridViewTextBoxColumn
            // 
            this.activitynameDataGridViewTextBoxColumn.DataPropertyName = "Activity_name";
            this.activitynameDataGridViewTextBoxColumn.HeaderText = "Назва активності";
            this.activitynameDataGridViewTextBoxColumn.Name = "activitynameDataGridViewTextBoxColumn";
            this.activitynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.activitynameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.activitynameDataGridViewTextBoxColumn.Width = 200;
            // 
            // activitydateDataGridViewTextBoxColumn
            // 
            this.activitydateDataGridViewTextBoxColumn.DataPropertyName = "Activity_date";
            this.activitydateDataGridViewTextBoxColumn.HeaderText = "Дата активності";
            this.activitydateDataGridViewTextBoxColumn.Name = "activitydateDataGridViewTextBoxColumn";
            this.activitydateDataGridViewTextBoxColumn.ReadOnly = true;
            this.activitydateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "AdditionalActivity";
            this.activityBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participationDataGridView
            // 
            this.participationDataGridView.AllowUserToAddRows = false;
            this.participationDataGridView.AllowUserToDeleteRows = false;
            this.participationDataGridView.AutoGenerateColumns = false;
            this.participationDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.participationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pupilIDDataGridViewTextBoxColumn,
            this.activityIDDataGridViewTextBoxColumn,
            this.distributionIDDataGridViewTextBoxColumn});
            this.participationDataGridView.DataSource = this.participationBindingSource;
            this.participationDataGridView.Location = new System.Drawing.Point(184, 144);
            this.participationDataGridView.Name = "participationDataGridView";
            this.participationDataGridView.ReadOnly = true;
            this.participationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.participationDataGridView.Size = new System.Drawing.Size(344, 208);
            this.participationDataGridView.TabIndex = 65;
            // 
            // pupilIDDataGridViewTextBoxColumn
            // 
            this.pupilIDDataGridViewTextBoxColumn.DataPropertyName = "Pupil_ID";
            this.pupilIDDataGridViewTextBoxColumn.HeaderText = "ID учня";
            this.pupilIDDataGridViewTextBoxColumn.Name = "pupilIDDataGridViewTextBoxColumn";
            this.pupilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pupilIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // activityIDDataGridViewTextBoxColumn
            // 
            this.activityIDDataGridViewTextBoxColumn.DataPropertyName = "Activity_ID";
            this.activityIDDataGridViewTextBoxColumn.HeaderText = "ID активності";
            this.activityIDDataGridViewTextBoxColumn.Name = "activityIDDataGridViewTextBoxColumn";
            this.activityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // distributionIDDataGridViewTextBoxColumn
            // 
            this.distributionIDDataGridViewTextBoxColumn.DataPropertyName = "Distribution_ID";
            this.distributionIDDataGridViewTextBoxColumn.HeaderText = "ID розбаловки";
            this.distributionIDDataGridViewTextBoxColumn.Name = "distributionIDDataGridViewTextBoxColumn";
            this.distributionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.distributionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // participationBindingSource
            // 
            this.participationBindingSource.DataMember = "AdditionalParticipation";
            this.participationBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // additionalParticipationTableAdapter
            // 
            this.additionalParticipationTableAdapter.ClearBeforeFill = true;
            // 
            // additionalActivityTableAdapter
            // 
            this.additionalActivityTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.activity;
            this.pictureBox5.Location = new System.Drawing.Point(104, -5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(149, 138);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 79;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(262, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "Додаткова участь";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Курсовая.Properties.Resources.activity;
            this.pictureBox1.Location = new System.Drawing.Point(593, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(751, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Додаткова активність";
            // 
            // delete_Participation
            // 
            this.delete_Participation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_Participation.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Participation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Participation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Participation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Participation.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Participation.Location = new System.Drawing.Point(121, 303);
            this.delete_Participation.Name = "delete_Participation";
            this.delete_Participation.Size = new System.Drawing.Size(49, 45);
            this.delete_Participation.TabIndex = 84;
            this.delete_Participation.UseVisualStyleBackColor = false;
            this.delete_Participation.Click += new System.EventHandler(this.delete_Participation_Click);
            // 
            // edit_Participation
            // 
            this.edit_Participation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_Participation.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Participation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Participation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Participation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Participation.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Participation.Location = new System.Drawing.Point(121, 226);
            this.edit_Participation.Name = "edit_Participation";
            this.edit_Participation.Size = new System.Drawing.Size(49, 45);
            this.edit_Participation.TabIndex = 83;
            this.edit_Participation.UseVisualStyleBackColor = false;
            this.edit_Participation.Click += new System.EventHandler(this.edit_Participation_Click);
            // 
            // add_Participation
            // 
            this.add_Participation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Participation.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Participation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Participation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Participation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Participation.ForeColor = System.Drawing.Color.Wheat;
            this.add_Participation.Location = new System.Drawing.Point(121, 148);
            this.add_Participation.Name = "add_Participation";
            this.add_Participation.Size = new System.Drawing.Size(49, 45);
            this.add_Participation.TabIndex = 82;
            this.add_Participation.UseVisualStyleBackColor = false;
            this.add_Participation.Click += new System.EventHandler(this.add_Participation_Click);
            // 
            // delete_Activity
            // 
            this.delete_Activity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_Activity.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Activity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Activity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Activity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Activity.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Activity.Location = new System.Drawing.Point(604, 304);
            this.delete_Activity.Name = "delete_Activity";
            this.delete_Activity.Size = new System.Drawing.Size(49, 45);
            this.delete_Activity.TabIndex = 87;
            this.delete_Activity.UseVisualStyleBackColor = false;
            this.delete_Activity.Click += new System.EventHandler(this.delete_Activity_Click);
            // 
            // edit_Activity
            // 
            this.edit_Activity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_Activity.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Activity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Activity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Activity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Activity.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Activity.Location = new System.Drawing.Point(604, 227);
            this.edit_Activity.Name = "edit_Activity";
            this.edit_Activity.Size = new System.Drawing.Size(49, 45);
            this.edit_Activity.TabIndex = 86;
            this.edit_Activity.UseVisualStyleBackColor = false;
            this.edit_Activity.Click += new System.EventHandler(this.edit_Activity_Click);
            // 
            // add_Activity
            // 
            this.add_Activity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Activity.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Activity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Activity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Activity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Activity.ForeColor = System.Drawing.Color.Wheat;
            this.add_Activity.Location = new System.Drawing.Point(604, 149);
            this.add_Activity.Name = "add_Activity";
            this.add_Activity.Size = new System.Drawing.Size(49, 45);
            this.add_Activity.TabIndex = 85;
            this.add_Activity.UseVisualStyleBackColor = false;
            this.add_Activity.Click += new System.EventHandler(this.add_Activity_Click);
            // 
            // back_AddActivity
            // 
            this.back_AddActivity.BackColor = System.Drawing.Color.Transparent;
            this.back_AddActivity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_AddActivity.Image = global::Курсовая.Properties.Resources.goback;
            this.back_AddActivity.Location = new System.Drawing.Point(58, 609);
            this.back_AddActivity.Name = "back_AddActivity";
            this.back_AddActivity.Size = new System.Drawing.Size(56, 50);
            this.back_AddActivity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_AddActivity.TabIndex = 91;
            this.back_AddActivity.TabStop = false;
            this.back_AddActivity.Click += new System.EventHandler(this.back_AddActivity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(403, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Сортування";
            // 
            // sortComboBox_Participation
            // 
            this.sortComboBox_Participation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox_Participation.FormattingEnabled = true;
            this.sortComboBox_Participation.Items.AddRange(new object[] {
            "ID учня",
            "ID активності",
            "ID розбаловки"});
            this.sortComboBox_Participation.Location = new System.Drawing.Point(378, 465);
            this.sortComboBox_Participation.Name = "sortComboBox_Participation";
            this.sortComboBox_Participation.Size = new System.Drawing.Size(150, 21);
            this.sortComboBox_Participation.TabIndex = 93;
            // 
            // toSort_Participation
            // 
            this.toSort_Participation.Location = new System.Drawing.Point(406, 568);
            this.toSort_Participation.Name = "toSort_Participation";
            this.toSort_Participation.Size = new System.Drawing.Size(97, 27);
            this.toSort_Participation.TabIndex = 92;
            this.toSort_Participation.Text = "Сортувати";
            this.toSort_Participation.UseVisualStyleBackColor = true;
            this.toSort_Participation.Click += new System.EventHandler(this.toSort_Participation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(692, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 97;
            this.label1.Text = "Сортування";
            // 
            // sortComboBox_Activity
            // 
            this.sortComboBox_Activity.FormattingEnabled = true;
            this.sortComboBox_Activity.Items.AddRange(new object[] {
            "ID активності",
            "Назва активності",
            "Дата активності"});
            this.sortComboBox_Activity.Location = new System.Drawing.Point(647, 463);
            this.sortComboBox_Activity.Name = "sortComboBox_Activity";
            this.sortComboBox_Activity.Size = new System.Drawing.Size(189, 23);
            this.sortComboBox_Activity.TabIndex = 96;
            // 
            // toSort_Activity
            // 
            this.toSort_Activity.Location = new System.Drawing.Point(695, 532);
            this.toSort_Activity.Name = "toSort_Activity";
            this.toSort_Activity.Size = new System.Drawing.Size(97, 27);
            this.toSort_Activity.TabIndex = 95;
            this.toSort_Activity.Text = "Сортувати";
            this.toSort_Activity.UseVisualStyleBackColor = true;
            this.toSort_Activity.Click += new System.EventHandler(this.toSort_Activity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(979, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 104;
            this.label4.Text = "Фільтрація";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDateTimePicker.Location = new System.Drawing.Point(904, 490);
            this.toDateTimePicker.MaxDate = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            this.toDateTimePicker.MinDate = new System.DateTime(2020, 9, 2, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(271, 21);
            this.toDateTimePicker.TabIndex = 103;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDateTimePicker.Location = new System.Drawing.Point(904, 450);
            this.fromDateTimePicker.MaxDate = new System.DateTime(2021, 5, 27, 0, 0, 0, 0);
            this.fromDateTimePicker.MinDate = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(271, 21);
            this.fromDateTimePicker.TabIndex = 102;
            this.fromDateTimePicker.Value = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(870, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 101;
            this.label10.Text = "та";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(861, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 100;
            this.label9.Text = "Між";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(965, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 99;
            this.label8.Text = "Дата проведення";
            // 
            // toFilter_Activity
            // 
            this.toFilter_Activity.Location = new System.Drawing.Point(965, 532);
            this.toFilter_Activity.Name = "toFilter_Activity";
            this.toFilter_Activity.Size = new System.Drawing.Size(97, 27);
            this.toFilter_Activity.TabIndex = 98;
            this.toFilter_Activity.Text = "Фільтрувати";
            this.toFilter_Activity.UseVisualStyleBackColor = true;
            this.toFilter_Activity.Click += new System.EventHandler(this.toFilter_Activity_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(231, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 18);
            this.label13.TabIndex = 111;
            this.label13.Text = "Пошук";
            // 
            // pupilIDCheckBox_Participation
            // 
            this.pupilIDCheckBox_Participation.AutoSize = true;
            this.pupilIDCheckBox_Participation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pupilIDCheckBox_Participation.Location = new System.Drawing.Point(190, 436);
            this.pupilIDCheckBox_Participation.Name = "pupilIDCheckBox_Participation";
            this.pupilIDCheckBox_Participation.Size = new System.Drawing.Size(62, 17);
            this.pupilIDCheckBox_Participation.TabIndex = 110;
            this.pupilIDCheckBox_Participation.Text = "ID учня";
            this.pupilIDCheckBox_Participation.UseVisualStyleBackColor = true;
            // 
            // allCheckBox_Participation
            // 
            this.allCheckBox_Participation.AutoSize = true;
            this.allCheckBox_Participation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox_Participation.Location = new System.Drawing.Point(190, 410);
            this.allCheckBox_Participation.Name = "allCheckBox_Participation";
            this.allCheckBox_Participation.Size = new System.Drawing.Size(69, 17);
            this.allCheckBox_Participation.TabIndex = 109;
            this.allCheckBox_Participation.Text = "Усі поля";
            this.allCheckBox_Participation.UseVisualStyleBackColor = true;
            // 
            // actIDCheckBox_Participation
            // 
            this.actIDCheckBox_Participation.AutoSize = true;
            this.actIDCheckBox_Participation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actIDCheckBox_Participation.Location = new System.Drawing.Point(190, 466);
            this.actIDCheckBox_Participation.Name = "actIDCheckBox_Participation";
            this.actIDCheckBox_Participation.Size = new System.Drawing.Size(94, 17);
            this.actIDCheckBox_Participation.TabIndex = 108;
            this.actIDCheckBox_Participation.Text = "ID активності";
            this.actIDCheckBox_Participation.UseVisualStyleBackColor = true;
            // 
            // toSearch_Participation
            // 
            this.toSearch_Participation.Location = new System.Drawing.Point(215, 568);
            this.toSearch_Participation.Name = "toSearch_Participation";
            this.toSearch_Participation.Size = new System.Drawing.Size(97, 27);
            this.toSearch_Participation.TabIndex = 107;
            this.toSearch_Participation.Text = "Знайти";
            this.toSearch_Participation.UseVisualStyleBackColor = true;
            this.toSearch_Participation.Click += new System.EventHandler(this.toSearch_Participation_Click);
            // 
            // distrIDCheckBox_Participation
            // 
            this.distrIDCheckBox_Participation.AutoSize = true;
            this.distrIDCheckBox_Participation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distrIDCheckBox_Participation.Location = new System.Drawing.Point(190, 496);
            this.distrIDCheckBox_Participation.Name = "distrIDCheckBox_Participation";
            this.distrIDCheckBox_Participation.Size = new System.Drawing.Size(100, 17);
            this.distrIDCheckBox_Participation.TabIndex = 106;
            this.distrIDCheckBox_Participation.Text = "ID розбаловки";
            this.distrIDCheckBox_Participation.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Participation
            // 
            this.searchTextBox_Participation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox_Participation.Location = new System.Drawing.Point(230, 525);
            this.searchTextBox_Participation.Name = "searchTextBox_Participation";
            this.searchTextBox_Participation.Size = new System.Drawing.Size(72, 20);
            this.searchTextBox_Participation.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1209, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 118;
            this.label5.Text = "Пошук";
            // 
            // pupilIDCheckBox_Activity
            // 
            this.pupilIDCheckBox_Activity.AutoSize = true;
            this.pupilIDCheckBox_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pupilIDCheckBox_Activity.Location = new System.Drawing.Point(1144, 206);
            this.pupilIDCheckBox_Activity.Name = "pupilIDCheckBox_Activity";
            this.pupilIDCheckBox_Activity.Size = new System.Drawing.Size(94, 17);
            this.pupilIDCheckBox_Activity.TabIndex = 117;
            this.pupilIDCheckBox_Activity.Text = "ID активності";
            this.pupilIDCheckBox_Activity.UseVisualStyleBackColor = true;
            // 
            // allCheckBox_Activity
            // 
            this.allCheckBox_Activity.AutoSize = true;
            this.allCheckBox_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox_Activity.Location = new System.Drawing.Point(1144, 181);
            this.allCheckBox_Activity.Name = "allCheckBox_Activity";
            this.allCheckBox_Activity.Size = new System.Drawing.Size(69, 17);
            this.allCheckBox_Activity.TabIndex = 116;
            this.allCheckBox_Activity.Text = "Усі поля";
            this.allCheckBox_Activity.UseVisualStyleBackColor = true;
            // 
            // nameCheckBox_Activity
            // 
            this.nameCheckBox_Activity.AutoSize = true;
            this.nameCheckBox_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCheckBox_Activity.Location = new System.Drawing.Point(1144, 236);
            this.nameCheckBox_Activity.Name = "nameCheckBox_Activity";
            this.nameCheckBox_Activity.Size = new System.Drawing.Size(115, 17);
            this.nameCheckBox_Activity.TabIndex = 115;
            this.nameCheckBox_Activity.Text = "Назва активності";
            this.nameCheckBox_Activity.UseVisualStyleBackColor = true;
            // 
            // toSearch_Activity
            // 
            this.toSearch_Activity.Location = new System.Drawing.Point(1189, 321);
            this.toSearch_Activity.Name = "toSearch_Activity";
            this.toSearch_Activity.Size = new System.Drawing.Size(97, 27);
            this.toSearch_Activity.TabIndex = 114;
            this.toSearch_Activity.Text = "Знайти";
            this.toSearch_Activity.UseVisualStyleBackColor = true;
            this.toSearch_Activity.Click += new System.EventHandler(this.toSearch_Activity_Click);
            // 
            // dateCheckBox_Activity
            // 
            this.dateCheckBox_Activity.AutoSize = true;
            this.dateCheckBox_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCheckBox_Activity.Location = new System.Drawing.Point(1144, 266);
            this.dateCheckBox_Activity.Name = "dateCheckBox_Activity";
            this.dateCheckBox_Activity.Size = new System.Drawing.Size(109, 17);
            this.dateCheckBox_Activity.TabIndex = 113;
            this.dateCheckBox_Activity.Text = "Дата активності";
            this.dateCheckBox_Activity.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Activity
            // 
            this.searchTextBox_Activity.Location = new System.Drawing.Point(1133, 292);
            this.searchTextBox_Activity.Name = "searchTextBox_Activity";
            this.searchTextBox_Activity.Size = new System.Drawing.Size(218, 21);
            this.searchTextBox_Activity.TabIndex = 112;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox2.Location = new System.Drawing.Point(570, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 680);
            this.pictureBox2.TabIndex = 119;
            this.pictureBox2.TabStop = false;
            // 
            // AdditionalActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1365, 668);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pupilIDCheckBox_Activity);
            this.Controls.Add(this.allCheckBox_Activity);
            this.Controls.Add(this.nameCheckBox_Activity);
            this.Controls.Add(this.toSearch_Activity);
            this.Controls.Add(this.dateCheckBox_Activity);
            this.Controls.Add(this.searchTextBox_Activity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pupilIDCheckBox_Participation);
            this.Controls.Add(this.allCheckBox_Participation);
            this.Controls.Add(this.actIDCheckBox_Participation);
            this.Controls.Add(this.toSearch_Participation);
            this.Controls.Add(this.distrIDCheckBox_Participation);
            this.Controls.Add(this.searchTextBox_Participation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.toFilter_Activity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortComboBox_Activity);
            this.Controls.Add(this.toSort_Activity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortComboBox_Participation);
            this.Controls.Add(this.toSort_Participation);
            this.Controls.Add(this.back_AddActivity);
            this.Controls.Add(this.delete_Activity);
            this.Controls.Add(this.edit_Activity);
            this.Controls.Add(this.add_Activity);
            this.Controls.Add(this.delete_Participation);
            this.Controls.Add(this.edit_Participation);
            this.Controls.Add(this.add_Participation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.showAll_Activity);
            this.Controls.Add(this.showAll_Participation);
            this.Controls.Add(this.activityDataGridView);
            this.Controls.Add(this.participationDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdditionalActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додаткова активність та участь";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdditionalActivity_FormClosing);
            this.Load += new System.EventHandler(this.AdditionalActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_AddActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showAll_Activity;
        private System.Windows.Forms.Button showAll_Participation;
        private System.Windows.Forms.DataGridView activityDataGridView;
        private System.Windows.Forms.DataGridView participationDataGridView;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource participationBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalParticipationTableAdapter additionalParticipationTableAdapter;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter additionalActivityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distributionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete_Participation;
        private System.Windows.Forms.Button edit_Participation;
        private System.Windows.Forms.Button add_Participation;
        private System.Windows.Forms.Button delete_Activity;
        private System.Windows.Forms.Button edit_Activity;
        private System.Windows.Forms.Button add_Activity;
        private System.Windows.Forms.PictureBox back_AddActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activitydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortComboBox_Participation;
        private System.Windows.Forms.Button toSort_Participation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sortComboBox_Activity;
        private System.Windows.Forms.Button toSort_Activity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button toFilter_Activity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox pupilIDCheckBox_Participation;
        private System.Windows.Forms.CheckBox allCheckBox_Participation;
        private System.Windows.Forms.CheckBox actIDCheckBox_Participation;
        private System.Windows.Forms.Button toSearch_Participation;
        private System.Windows.Forms.CheckBox distrIDCheckBox_Participation;
        private System.Windows.Forms.TextBox searchTextBox_Participation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox pupilIDCheckBox_Activity;
        private System.Windows.Forms.CheckBox allCheckBox_Activity;
        private System.Windows.Forms.CheckBox nameCheckBox_Activity;
        private System.Windows.Forms.Button toSearch_Activity;
        private System.Windows.Forms.CheckBox dateCheckBox_Activity;
        private System.Windows.Forms.TextBox searchTextBox_Activity;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}