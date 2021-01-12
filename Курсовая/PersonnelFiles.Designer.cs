namespace Курсовая
{
    partial class PersonnelFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelFiles));
            this.pfilesDataGridView = new System.Windows.Forms.DataGridView();
            this.pfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.showAll_PersonnelFiles = new System.Windows.Forms.Button();
            this.sortComboBox_PersonnelFiles = new System.Windows.Forms.ComboBox();
            this.toSort_PersonnelFiles = new System.Windows.Forms.Button();
            this.allCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.idCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.toSearch_Pupils = new System.Windows.Forms.Button();
            this.snpCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.searchTextBox_PersonnelFiles = new System.Windows.Forms.TextBox();
            this.addressCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.phoneCheckBox_PersonnelFiles = new System.Windows.Forms.CheckBox();
            this.personnelFileTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.delete_PersonnelFiles = new System.Windows.Forms.Button();
            this.edit_PersonnelFiles = new System.Windows.Forms.Button();
            this.add_PersonnelFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNPfatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNPmotherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNPcustodianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_PersonnelFiles = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pfilesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_PersonnelFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // pfilesDataGridView
            // 
            this.pfilesDataGridView.AllowUserToAddRows = false;
            this.pfilesDataGridView.AllowUserToDeleteRows = false;
            this.pfilesDataGridView.AutoGenerateColumns = false;
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
            this.pfilesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pupilIDDataGridViewTextBoxColumn,
            this.sNPfatherDataGridViewTextBoxColumn,
            this.sNPmotherDataGridViewTextBoxColumn,
            this.sNPcustodianDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.pfilesDataGridView.DataSource = this.pfileBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pfilesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.pfilesDataGridView.EnableHeadersVisualStyles = false;
            this.pfilesDataGridView.Location = new System.Drawing.Point(101, 140);
            this.pfilesDataGridView.Name = "pfilesDataGridView";
            this.pfilesDataGridView.ReadOnly = true;
            this.pfilesDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.pfilesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pfilesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.BlanchedAlmond;
            this.pfilesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.pfilesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pfilesDataGridView.Size = new System.Drawing.Size(749, 167);
            this.pfilesDataGridView.TabIndex = 1;
            // 
            // pfileBindingSource
            // 
            this.pfileBindingSource.DataMember = "PersonnelFile";
            this.pfileBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showAll_PersonnelFiles
            // 
            this.showAll_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAll_PersonnelFiles.Location = new System.Drawing.Point(726, 101);
            this.showAll_PersonnelFiles.Name = "showAll_PersonnelFiles";
            this.showAll_PersonnelFiles.Size = new System.Drawing.Size(112, 31);
            this.showAll_PersonnelFiles.TabIndex = 14;
            this.showAll_PersonnelFiles.Text = "Показати всі";
            this.showAll_PersonnelFiles.UseVisualStyleBackColor = true;
            this.showAll_PersonnelFiles.Click += new System.EventHandler(this.showAll_PersonnelFiles_Click);
            // 
            // sortComboBox_PersonnelFiles
            // 
            this.sortComboBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox_PersonnelFiles.FormattingEnabled = true;
            this.sortComboBox_PersonnelFiles.Items.AddRange(new object[] {
            "ID учня",
            "ПІБ батька",
            "ПІБ матері",
            "ПІБ опікуна",
            "Адреса",
            "Телефон"});
            this.sortComboBox_PersonnelFiles.Location = new System.Drawing.Point(534, 371);
            this.sortComboBox_PersonnelFiles.Name = "sortComboBox_PersonnelFiles";
            this.sortComboBox_PersonnelFiles.Size = new System.Drawing.Size(140, 23);
            this.sortComboBox_PersonnelFiles.TabIndex = 22;
            // 
            // toSort_PersonnelFiles
            // 
            this.toSort_PersonnelFiles.Location = new System.Drawing.Point(562, 417);
            this.toSort_PersonnelFiles.Name = "toSort_PersonnelFiles";
            this.toSort_PersonnelFiles.Size = new System.Drawing.Size(97, 27);
            this.toSort_PersonnelFiles.TabIndex = 21;
            this.toSort_PersonnelFiles.Text = "Сортувати";
            this.toSort_PersonnelFiles.UseVisualStyleBackColor = true;
            this.toSort_PersonnelFiles.Click += new System.EventHandler(this.toSort_PersonnelFiles_Click);
            // 
            // allCheckBox_PersonnelFiles
            // 
            this.allCheckBox_PersonnelFiles.AutoSize = true;
            this.allCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox_PersonnelFiles.Location = new System.Drawing.Point(234, 350);
            this.allCheckBox_PersonnelFiles.Name = "allCheckBox_PersonnelFiles";
            this.allCheckBox_PersonnelFiles.Size = new System.Drawing.Size(74, 19);
            this.allCheckBox_PersonnelFiles.TabIndex = 32;
            this.allCheckBox_PersonnelFiles.Text = "Усі поля";
            this.allCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // idCheckBox_PersonnelFiles
            // 
            this.idCheckBox_PersonnelFiles.AutoSize = true;
            this.idCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCheckBox_PersonnelFiles.Location = new System.Drawing.Point(234, 373);
            this.idCheckBox_PersonnelFiles.Name = "idCheckBox_PersonnelFiles";
            this.idCheckBox_PersonnelFiles.Size = new System.Drawing.Size(66, 19);
            this.idCheckBox_PersonnelFiles.TabIndex = 31;
            this.idCheckBox_PersonnelFiles.Text = "ID учня";
            this.idCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // toSearch_Pupils
            // 
            this.toSearch_Pupils.Location = new System.Drawing.Point(277, 503);
            this.toSearch_Pupils.Name = "toSearch_Pupils";
            this.toSearch_Pupils.Size = new System.Drawing.Size(97, 27);
            this.toSearch_Pupils.TabIndex = 30;
            this.toSearch_Pupils.Text = "Знайти";
            this.toSearch_Pupils.UseVisualStyleBackColor = true;
            this.toSearch_Pupils.Click += new System.EventHandler(this.toSearch_Pupils_Click);
            // 
            // snpCheckBox_PersonnelFiles
            // 
            this.snpCheckBox_PersonnelFiles.AutoSize = true;
            this.snpCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.snpCheckBox_PersonnelFiles.Location = new System.Drawing.Point(234, 395);
            this.snpCheckBox_PersonnelFiles.Name = "snpCheckBox_PersonnelFiles";
            this.snpCheckBox_PersonnelFiles.Size = new System.Drawing.Size(46, 19);
            this.snpCheckBox_PersonnelFiles.TabIndex = 29;
            this.snpCheckBox_PersonnelFiles.Text = "ПІБ";
            this.snpCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_PersonnelFiles
            // 
            this.searchTextBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox_PersonnelFiles.Location = new System.Drawing.Point(219, 468);
            this.searchTextBox_PersonnelFiles.Name = "searchTextBox_PersonnelFiles";
            this.searchTextBox_PersonnelFiles.Size = new System.Drawing.Size(216, 21);
            this.searchTextBox_PersonnelFiles.TabIndex = 28;
            // 
            // addressCheckBox_PersonnelFiles
            // 
            this.addressCheckBox_PersonnelFiles.AutoSize = true;
            this.addressCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressCheckBox_PersonnelFiles.Location = new System.Drawing.Point(234, 419);
            this.addressCheckBox_PersonnelFiles.Name = "addressCheckBox_PersonnelFiles";
            this.addressCheckBox_PersonnelFiles.Size = new System.Drawing.Size(67, 19);
            this.addressCheckBox_PersonnelFiles.TabIndex = 33;
            this.addressCheckBox_PersonnelFiles.Text = "Адреса";
            this.addressCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // phoneCheckBox_PersonnelFiles
            // 
            this.phoneCheckBox_PersonnelFiles.AutoSize = true;
            this.phoneCheckBox_PersonnelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneCheckBox_PersonnelFiles.Location = new System.Drawing.Point(234, 443);
            this.phoneCheckBox_PersonnelFiles.Name = "phoneCheckBox_PersonnelFiles";
            this.phoneCheckBox_PersonnelFiles.Size = new System.Drawing.Size(79, 19);
            this.phoneCheckBox_PersonnelFiles.TabIndex = 34;
            this.phoneCheckBox_PersonnelFiles.Text = "Телефон";
            this.phoneCheckBox_PersonnelFiles.UseVisualStyleBackColor = true;
            // 
            // personnelFileTableAdapter
            // 
            this.personnelFileTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.folder;
            this.pictureBox5.Location = new System.Drawing.Point(16, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 104);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 35;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(745, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Школа";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Курсовая.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(801, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(131, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Особові справи";
            // 
            // delete_PersonnelFiles
            // 
            this.delete_PersonnelFiles.BackColor = System.Drawing.Color.Wheat;
            this.delete_PersonnelFiles.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_PersonnelFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_PersonnelFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_PersonnelFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_PersonnelFiles.ForeColor = System.Drawing.Color.Wheat;
            this.delete_PersonnelFiles.Location = new System.Drawing.Point(26, 260);
            this.delete_PersonnelFiles.Name = "delete_PersonnelFiles";
            this.delete_PersonnelFiles.Size = new System.Drawing.Size(45, 43);
            this.delete_PersonnelFiles.TabIndex = 46;
            this.delete_PersonnelFiles.UseVisualStyleBackColor = false;
            this.delete_PersonnelFiles.Click += new System.EventHandler(this.delete_PersonnelFiles_Click);
            // 
            // edit_PersonnelFiles
            // 
            this.edit_PersonnelFiles.BackColor = System.Drawing.Color.Wheat;
            this.edit_PersonnelFiles.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_PersonnelFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_PersonnelFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_PersonnelFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_PersonnelFiles.ForeColor = System.Drawing.Color.Wheat;
            this.edit_PersonnelFiles.Location = new System.Drawing.Point(26, 202);
            this.edit_PersonnelFiles.Name = "edit_PersonnelFiles";
            this.edit_PersonnelFiles.Size = new System.Drawing.Size(45, 43);
            this.edit_PersonnelFiles.TabIndex = 44;
            this.edit_PersonnelFiles.UseVisualStyleBackColor = false;
            this.edit_PersonnelFiles.Click += new System.EventHandler(this.edit_PersonnelFiles_Click);
            // 
            // add_PersonnelFiles
            // 
            this.add_PersonnelFiles.BackColor = System.Drawing.Color.Wheat;
            this.add_PersonnelFiles.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_PersonnelFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_PersonnelFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_PersonnelFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_PersonnelFiles.ForeColor = System.Drawing.Color.Wheat;
            this.add_PersonnelFiles.Location = new System.Drawing.Point(26, 144);
            this.add_PersonnelFiles.Name = "add_PersonnelFiles";
            this.add_PersonnelFiles.Size = new System.Drawing.Size(45, 43);
            this.add_PersonnelFiles.TabIndex = 43;
            this.add_PersonnelFiles.UseVisualStyleBackColor = false;
            this.add_PersonnelFiles.Click += new System.EventHandler(this.add_PersonnelFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(555, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Сортування";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(302, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Пошук";
            // 
            // pupilIDDataGridViewTextBoxColumn
            // 
            this.pupilIDDataGridViewTextBoxColumn.DataPropertyName = "Pupil_ID";
            this.pupilIDDataGridViewTextBoxColumn.HeaderText = "ID учня";
            this.pupilIDDataGridViewTextBoxColumn.Name = "pupilIDDataGridViewTextBoxColumn";
            this.pupilIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pupilIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pupilIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // sNPfatherDataGridViewTextBoxColumn
            // 
            this.sNPfatherDataGridViewTextBoxColumn.DataPropertyName = "SNP_father";
            this.sNPfatherDataGridViewTextBoxColumn.HeaderText = "ПІБ батька";
            this.sNPfatherDataGridViewTextBoxColumn.Name = "sNPfatherDataGridViewTextBoxColumn";
            this.sNPfatherDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNPfatherDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sNPfatherDataGridViewTextBoxColumn.Width = 210;
            // 
            // sNPmotherDataGridViewTextBoxColumn
            // 
            this.sNPmotherDataGridViewTextBoxColumn.DataPropertyName = "SNP_mother";
            this.sNPmotherDataGridViewTextBoxColumn.HeaderText = "ПІБ матері";
            this.sNPmotherDataGridViewTextBoxColumn.Name = "sNPmotherDataGridViewTextBoxColumn";
            this.sNPmotherDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNPmotherDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sNPmotherDataGridViewTextBoxColumn.Width = 210;
            // 
            // sNPcustodianDataGridViewTextBoxColumn
            // 
            this.sNPcustodianDataGridViewTextBoxColumn.DataPropertyName = "SNP_custodian";
            this.sNPcustodianDataGridViewTextBoxColumn.HeaderText = "ПІБ опікуна";
            this.sNPcustodianDataGridViewTextBoxColumn.Name = "sNPcustodianDataGridViewTextBoxColumn";
            this.sNPcustodianDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNPcustodianDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.addressDataGridViewTextBoxColumn.Width = 180;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // back_PersonnelFiles
            // 
            this.back_PersonnelFiles.BackColor = System.Drawing.Color.Transparent;
            this.back_PersonnelFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_PersonnelFiles.Image = global::Курсовая.Properties.Resources.goback;
            this.back_PersonnelFiles.Location = new System.Drawing.Point(9, 520);
            this.back_PersonnelFiles.Name = "back_PersonnelFiles";
            this.back_PersonnelFiles.Size = new System.Drawing.Size(53, 48);
            this.back_PersonnelFiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_PersonnelFiles.TabIndex = 50;
            this.back_PersonnelFiles.TabStop = false;
            this.back_PersonnelFiles.Click += new System.EventHandler(this.back_PersonnelFiles_Click);
            // 
            // PersonnelFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_pupil;
            this.ClientSize = new System.Drawing.Size(879, 575);
            this.Controls.Add(this.back_PersonnelFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete_PersonnelFiles);
            this.Controls.Add(this.edit_PersonnelFiles);
            this.Controls.Add(this.add_PersonnelFiles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.phoneCheckBox_PersonnelFiles);
            this.Controls.Add(this.addressCheckBox_PersonnelFiles);
            this.Controls.Add(this.allCheckBox_PersonnelFiles);
            this.Controls.Add(this.idCheckBox_PersonnelFiles);
            this.Controls.Add(this.toSearch_Pupils);
            this.Controls.Add(this.snpCheckBox_PersonnelFiles);
            this.Controls.Add(this.searchTextBox_PersonnelFiles);
            this.Controls.Add(this.sortComboBox_PersonnelFiles);
            this.Controls.Add(this.toSort_PersonnelFiles);
            this.Controls.Add(this.showAll_PersonnelFiles);
            this.Controls.Add(this.pfilesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonnelFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Особові справи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonnelFiles_FormClosing);
            this.Load += new System.EventHandler(this.PersonnelFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pfilesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_PersonnelFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView pfilesDataGridView;
        private System.Windows.Forms.Button showAll_PersonnelFiles;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource pfileBindingSource;
        private SchoolCourseDataSetTableAdapters.PersonnelFileTableAdapter personnelFileTableAdapter;
        private System.Windows.Forms.ComboBox sortComboBox_PersonnelFiles;
        private System.Windows.Forms.Button toSort_PersonnelFiles;
        private System.Windows.Forms.CheckBox allCheckBox_PersonnelFiles;
        private System.Windows.Forms.CheckBox idCheckBox_PersonnelFiles;
        private System.Windows.Forms.Button toSearch_Pupils;
        private System.Windows.Forms.CheckBox snpCheckBox_PersonnelFiles;
        private System.Windows.Forms.TextBox searchTextBox_PersonnelFiles;
        private System.Windows.Forms.CheckBox addressCheckBox_PersonnelFiles;
        private System.Windows.Forms.CheckBox phoneCheckBox_PersonnelFiles;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete_PersonnelFiles;
        private System.Windows.Forms.Button edit_PersonnelFiles;
        private System.Windows.Forms.Button add_PersonnelFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNPfatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNPmotherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNPcustodianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox back_PersonnelFiles;
    }
}