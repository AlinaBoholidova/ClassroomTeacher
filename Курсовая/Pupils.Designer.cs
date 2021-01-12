namespace Курсовая
{
    partial class Pupils
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pupils));
            this.label1 = new System.Windows.Forms.Label();
            this.pupilDataGridView = new System.Windows.Forms.DataGridView();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showAll_Pupils = new System.Windows.Forms.Button();
            this.searchTextBox_Pupils = new System.Windows.Forms.TextBox();
            this.toSort_Pupils = new System.Windows.Forms.Button();
            this.toFilter_Pupils = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthComboBox_Pupils = new System.Windows.Forms.ComboBox();
            this.sortComboBox_Pupils = new System.Windows.Forms.ComboBox();
            this.snpCheckBox_Pupils = new System.Windows.Forms.CheckBox();
            this.birthCheckBox_Pupils = new System.Windows.Forms.CheckBox();
            this.toSearch_Pupils = new System.Windows.Forms.Button();
            this.maleRadioButton_Pupils = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton_Pupils = new System.Windows.Forms.RadioButton();
            this.idCheckBox_Pupils = new System.Windows.Forms.CheckBox();
            this.allCheckBox_Pupils = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.personnelFileButton_Pupils = new System.Windows.Forms.Button();
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.pfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelFileTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.back_Pupils = new System.Windows.Forms.PictureBox();
            this.add_Pupils = new System.Windows.Forms.Button();
            this.edit_Pupils = new System.Windows.Forms.Button();
            this.delete_Pupils = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pupilDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Pupils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список учнів";
            // 
            // pupilDataGridView
            // 
            this.pupilDataGridView.AllowUserToAddRows = false;
            this.pupilDataGridView.AllowUserToDeleteRows = false;
            this.pupilDataGridView.AutoGenerateColumns = false;
            this.pupilDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pupilDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pupilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pupilDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pupilIDDataGridViewTextBoxColumn,
            this.sNPDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn});
            this.pupilDataGridView.DataSource = this.pupilBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pupilDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.pupilDataGridView.EnableHeadersVisualStyles = false;
            this.pupilDataGridView.Location = new System.Drawing.Point(106, 158);
            this.pupilDataGridView.Name = "pupilDataGridView";
            this.pupilDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pupilDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pupilDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.pupilDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pupilDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            this.pupilDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.pupilDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pupilDataGridView.Size = new System.Drawing.Size(500, 216);
            this.pupilDataGridView.TabIndex = 6;
            // 
            // pupilIDDataGridViewTextBoxColumn
            // 
            this.pupilIDDataGridViewTextBoxColumn.DataPropertyName = "Pupil_ID";
            this.pupilIDDataGridViewTextBoxColumn.HeaderText = "ID учня";
            this.pupilIDDataGridViewTextBoxColumn.Name = "pupilIDDataGridViewTextBoxColumn";
            this.pupilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pupilIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pupilIDDataGridViewTextBoxColumn.Width = 53;
            // 
            // sNPDataGridViewTextBoxColumn
            // 
            this.sNPDataGridViewTextBoxColumn.DataPropertyName = "SNP";
            this.sNPDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.sNPDataGridViewTextBoxColumn.Name = "sNPDataGridViewTextBoxColumn";
            this.sNPDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sNPDataGridViewTextBoxColumn.Width = 240;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Стать";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.genderDataGridViewTextBoxColumn.Width = 49;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.birthDateDataGridViewTextBoxColumn.Width = 115;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(726, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пошук";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(136, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сортування";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(405, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фільтрація";
            // 
            // showAll_Pupils
            // 
            this.showAll_Pupils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAll_Pupils.Location = new System.Drawing.Point(118, 112);
            this.showAll_Pupils.Name = "showAll_Pupils";
            this.showAll_Pupils.Size = new System.Drawing.Size(112, 31);
            this.showAll_Pupils.TabIndex = 4;
            this.showAll_Pupils.Text = "Показати всіх";
            this.showAll_Pupils.UseVisualStyleBackColor = true;
            this.showAll_Pupils.Click += new System.EventHandler(this.showAll_Pupils_Click);
            // 
            // searchTextBox_Pupils
            // 
            this.searchTextBox_Pupils.Location = new System.Drawing.Point(654, 313);
            this.searchTextBox_Pupils.Name = "searchTextBox_Pupils";
            this.searchTextBox_Pupils.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.searchTextBox_Pupils.Size = new System.Drawing.Size(208, 21);
            this.searchTextBox_Pupils.TabIndex = 10;
            // 
            // toSort_Pupils
            // 
            this.toSort_Pupils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toSort_Pupils.Location = new System.Drawing.Point(139, 519);
            this.toSort_Pupils.Name = "toSort_Pupils";
            this.toSort_Pupils.Size = new System.Drawing.Size(97, 27);
            this.toSort_Pupils.TabIndex = 13;
            this.toSort_Pupils.Text = "Сортувати";
            this.toSort_Pupils.UseVisualStyleBackColor = true;
            this.toSort_Pupils.Click += new System.EventHandler(this.toSort_Pupils_Click);
            // 
            // toFilter_Pupils
            // 
            this.toFilter_Pupils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toFilter_Pupils.Location = new System.Drawing.Point(408, 519);
            this.toFilter_Pupils.Name = "toFilter_Pupils";
            this.toFilter_Pupils.Size = new System.Drawing.Size(97, 27);
            this.toFilter_Pupils.TabIndex = 18;
            this.toFilter_Pupils.Text = "Фільтрувати";
            this.toFilter_Pupils.UseVisualStyleBackColor = true;
            this.toFilter_Pupils.Click += new System.EventHandler(this.toFilter_Pupils_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Стать";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Місяць народження";
            // 
            // monthComboBox_Pupils
            // 
            this.monthComboBox_Pupils.FormattingEnabled = true;
            this.monthComboBox_Pupils.Items.AddRange(new object[] {
            "01 (січень)",
            "02 (лютий)",
            "03 (березень)",
            "04 (квітень)",
            "05 (травень)",
            "06 (червень)",
            "07 (липень)",
            "08 (серпень)",
            "09 (вересень)",
            "10 (жовтень)",
            "11 (листопад)",
            "12 (грудень)"});
            this.monthComboBox_Pupils.Location = new System.Drawing.Point(455, 472);
            this.monthComboBox_Pupils.Name = "monthComboBox_Pupils";
            this.monthComboBox_Pupils.Size = new System.Drawing.Size(130, 23);
            this.monthComboBox_Pupils.TabIndex = 17;
            // 
            // sortComboBox_Pupils
            // 
            this.sortComboBox_Pupils.FormattingEnabled = true;
            this.sortComboBox_Pupils.Items.AddRange(new object[] {
            "ID учня",
            "ПІБ",
            "Стать",
            "Дата народження"});
            this.sortComboBox_Pupils.Location = new System.Drawing.Point(121, 451);
            this.sortComboBox_Pupils.Name = "sortComboBox_Pupils";
            this.sortComboBox_Pupils.Size = new System.Drawing.Size(127, 23);
            this.sortComboBox_Pupils.TabIndex = 12;
            // 
            // snpCheckBox_Pupils
            // 
            this.snpCheckBox_Pupils.AutoSize = true;
            this.snpCheckBox_Pupils.Location = new System.Drawing.Point(654, 251);
            this.snpCheckBox_Pupils.Name = "snpCheckBox_Pupils";
            this.snpCheckBox_Pupils.Size = new System.Drawing.Size(46, 19);
            this.snpCheckBox_Pupils.TabIndex = 8;
            this.snpCheckBox_Pupils.Text = "ПІБ";
            this.snpCheckBox_Pupils.UseVisualStyleBackColor = true;
            // 
            // birthCheckBox_Pupils
            // 
            this.birthCheckBox_Pupils.AutoSize = true;
            this.birthCheckBox_Pupils.Location = new System.Drawing.Point(654, 278);
            this.birthCheckBox_Pupils.Name = "birthCheckBox_Pupils";
            this.birthCheckBox_Pupils.Size = new System.Drawing.Size(131, 19);
            this.birthCheckBox_Pupils.TabIndex = 9;
            this.birthCheckBox_Pupils.Text = "Дата народження";
            this.birthCheckBox_Pupils.UseVisualStyleBackColor = true;
            // 
            // toSearch_Pupils
            // 
            this.toSearch_Pupils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toSearch_Pupils.Location = new System.Drawing.Point(712, 340);
            this.toSearch_Pupils.Name = "toSearch_Pupils";
            this.toSearch_Pupils.Size = new System.Drawing.Size(97, 27);
            this.toSearch_Pupils.TabIndex = 11;
            this.toSearch_Pupils.Text = "Знайти";
            this.toSearch_Pupils.UseVisualStyleBackColor = true;
            this.toSearch_Pupils.Click += new System.EventHandler(this.toSearch_Pupils_Click);
            // 
            // maleRadioButton_Pupils
            // 
            this.maleRadioButton_Pupils.AutoSize = true;
            this.maleRadioButton_Pupils.Location = new System.Drawing.Point(455, 422);
            this.maleRadioButton_Pupils.Name = "maleRadioButton_Pupils";
            this.maleRadioButton_Pupils.Size = new System.Drawing.Size(33, 19);
            this.maleRadioButton_Pupils.TabIndex = 14;
            this.maleRadioButton_Pupils.TabStop = true;
            this.maleRadioButton_Pupils.Text = "Ч";
            this.maleRadioButton_Pupils.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton_Pupils
            // 
            this.femaleRadioButton_Pupils.AutoSize = true;
            this.femaleRadioButton_Pupils.Location = new System.Drawing.Point(507, 422);
            this.femaleRadioButton_Pupils.Name = "femaleRadioButton_Pupils";
            this.femaleRadioButton_Pupils.Size = new System.Drawing.Size(36, 19);
            this.femaleRadioButton_Pupils.TabIndex = 15;
            this.femaleRadioButton_Pupils.TabStop = true;
            this.femaleRadioButton_Pupils.Text = "Ж";
            this.femaleRadioButton_Pupils.UseVisualStyleBackColor = true;
            // 
            // idCheckBox_Pupils
            // 
            this.idCheckBox_Pupils.AutoSize = true;
            this.idCheckBox_Pupils.Location = new System.Drawing.Point(654, 226);
            this.idCheckBox_Pupils.Name = "idCheckBox_Pupils";
            this.idCheckBox_Pupils.Size = new System.Drawing.Size(38, 19);
            this.idCheckBox_Pupils.TabIndex = 7;
            this.idCheckBox_Pupils.Text = "ID";
            this.idCheckBox_Pupils.UseVisualStyleBackColor = true;
            // 
            // allCheckBox_Pupils
            // 
            this.allCheckBox_Pupils.AutoSize = true;
            this.allCheckBox_Pupils.Location = new System.Drawing.Point(654, 199);
            this.allCheckBox_Pupils.Name = "allCheckBox_Pupils";
            this.allCheckBox_Pupils.Size = new System.Drawing.Size(74, 19);
            this.allCheckBox_Pupils.TabIndex = 6;
            this.allCheckBox_Pupils.Text = "Усі поля";
            this.allCheckBox_Pupils.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(556, 422);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 19);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "—";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // personnelFileButton_Pupils
            // 
            this.personnelFileButton_Pupils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personnelFileButton_Pupils.Location = new System.Drawing.Point(484, 112);
            this.personnelFileButton_Pupils.Name = "personnelFileButton_Pupils";
            this.personnelFileButton_Pupils.Size = new System.Drawing.Size(112, 31);
            this.personnelFileButton_Pupils.TabIndex = 5;
            this.personnelFileButton_Pupils.Text = "Особова справа";
            this.personnelFileButton_Pupils.UseVisualStyleBackColor = true;
            this.personnelFileButton_Pupils.Click += new System.EventHandler(this.personnelFileButton_Pupils_Click);
            // 
            // pupilTableAdapter
            // 
            this.pupilTableAdapter.ClearBeforeFill = true;
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
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.folder;
            this.pictureBox5.Location = new System.Drawing.Point(14, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 104);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // back_Pupils
            // 
            this.back_Pupils.BackColor = System.Drawing.Color.Transparent;
            this.back_Pupils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Pupils.Image = global::Курсовая.Properties.Resources.goback;
            this.back_Pupils.Location = new System.Drawing.Point(14, 562);
            this.back_Pupils.Name = "back_Pupils";
            this.back_Pupils.Size = new System.Drawing.Size(53, 48);
            this.back_Pupils.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Pupils.TabIndex = 31;
            this.back_Pupils.TabStop = false;
            this.back_Pupils.Click += new System.EventHandler(this.back_Pupils_Click);
            // 
            // add_Pupils
            // 
            this.add_Pupils.BackColor = System.Drawing.Color.Wheat;
            this.add_Pupils.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Pupils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Pupils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Pupils.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Pupils.ForeColor = System.Drawing.Color.Wheat;
            this.add_Pupils.Location = new System.Drawing.Point(31, 176);
            this.add_Pupils.Name = "add_Pupils";
            this.add_Pupils.Size = new System.Drawing.Size(45, 43);
            this.add_Pupils.TabIndex = 1;
            this.add_Pupils.UseVisualStyleBackColor = false;
            this.add_Pupils.Click += new System.EventHandler(this.add_Pupils_Click);
            // 
            // edit_Pupils
            // 
            this.edit_Pupils.BackColor = System.Drawing.Color.Wheat;
            this.edit_Pupils.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Pupils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Pupils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Pupils.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Pupils.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Pupils.Location = new System.Drawing.Point(31, 234);
            this.edit_Pupils.Name = "edit_Pupils";
            this.edit_Pupils.Size = new System.Drawing.Size(45, 43);
            this.edit_Pupils.TabIndex = 2;
            this.edit_Pupils.UseVisualStyleBackColor = false;
            this.edit_Pupils.Click += new System.EventHandler(this.edit_Pupils_Click);
            // 
            // delete_Pupils
            // 
            this.delete_Pupils.BackColor = System.Drawing.Color.Wheat;
            this.delete_Pupils.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Pupils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Pupils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Pupils.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Pupils.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Pupils.Location = new System.Drawing.Point(31, 292);
            this.delete_Pupils.Name = "delete_Pupils";
            this.delete_Pupils.Size = new System.Drawing.Size(45, 43);
            this.delete_Pupils.TabIndex = 3;
            this.delete_Pupils.UseVisualStyleBackColor = false;
            this.delete_Pupils.Click += new System.EventHandler(this.delete_Pupils_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Курсовая.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(816, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(760, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Школа";
            // 
            // Pupils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_pupil;
            this.ClientSize = new System.Drawing.Size(892, 623);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.delete_Pupils);
            this.Controls.Add(this.edit_Pupils);
            this.Controls.Add(this.add_Pupils);
            this.Controls.Add(this.back_Pupils);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.personnelFileButton_Pupils);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.allCheckBox_Pupils);
            this.Controls.Add(this.idCheckBox_Pupils);
            this.Controls.Add(this.femaleRadioButton_Pupils);
            this.Controls.Add(this.maleRadioButton_Pupils);
            this.Controls.Add(this.toSearch_Pupils);
            this.Controls.Add(this.birthCheckBox_Pupils);
            this.Controls.Add(this.snpCheckBox_Pupils);
            this.Controls.Add(this.sortComboBox_Pupils);
            this.Controls.Add(this.monthComboBox_Pupils);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toFilter_Pupils);
            this.Controls.Add(this.toSort_Pupils);
            this.Controls.Add(this.searchTextBox_Pupils);
            this.Controls.Add(this.showAll_Pupils);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pupilDataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pupils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учні";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pupils_FormClosing);
            this.Load += new System.EventHandler(this.Учні_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pupilDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Pupils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pupilDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showAll_Pupils;
        private System.Windows.Forms.TextBox searchTextBox_Pupils;
        private System.Windows.Forms.Button toSort_Pupils;
        private System.Windows.Forms.Button toFilter_Pupils;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox monthComboBox_Pupils;
        private System.Windows.Forms.ComboBox sortComboBox_Pupils;
        private System.Windows.Forms.CheckBox snpCheckBox_Pupils;
        private System.Windows.Forms.CheckBox birthCheckBox_Pupils;
        private System.Windows.Forms.Button toSearch_Pupils;
        private System.Windows.Forms.RadioButton maleRadioButton_Pupils;
        private System.Windows.Forms.RadioButton femaleRadioButton_Pupils;
        private System.Windows.Forms.CheckBox idCheckBox_Pupils;
        private System.Windows.Forms.CheckBox allCheckBox_Pupils;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button personnelFileButton_Pupils;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSet schoolCourseDataSet;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private System.Windows.Forms.BindingSource pfileBindingSource;
        private SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter personnelFileTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox back_Pupils;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button add_Pupils;
        private System.Windows.Forms.Button edit_Pupils;
        private System.Windows.Forms.Button delete_Pupils;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}