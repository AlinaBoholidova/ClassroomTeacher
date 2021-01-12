namespace Курсовая
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.paymentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentRateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.rateDataGridView = new System.Windows.Forms.DataGridView();
            this.paymentRateIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentRatetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showAll_Payment = new System.Windows.Forms.Button();
            this.showAll_Rate = new System.Windows.Forms.Button();
            this.paymentTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentTableAdapter();
            this.paymentRateTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.back_Payments = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_Payment = new System.Windows.Forms.Button();
            this.edit_Payment = new System.Windows.Forms.Button();
            this.add_Payment = new System.Windows.Forms.Button();
            this.delete_Rate = new System.Windows.Forms.Button();
            this.edit_Rate = new System.Windows.Forms.Button();
            this.add_Rate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.payIDCheckBox_Payment = new System.Windows.Forms.CheckBox();
            this.allCheckBox_Payment = new System.Windows.Forms.CheckBox();
            this.pupilIDCheckBox_Payment = new System.Windows.Forms.CheckBox();
            this.toSearch_Payment = new System.Windows.Forms.Button();
            this.monthCheckBox_Payment = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Payment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rateIDCheckBox_Rate = new System.Windows.Forms.CheckBox();
            this.allCheckBox_Rate = new System.Windows.Forms.CheckBox();
            this.typeCheckBox_Rate = new System.Windows.Forms.CheckBox();
            this.toSearch_Rate = new System.Windows.Forms.Button();
            this.sumCheckBox_Rate = new System.Windows.Forms.CheckBox();
            this.searchTextBox_Rate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sortComboBox_Payment = new System.Windows.Forms.ComboBox();
            this.toSort_Payment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sortComboBox_Rate = new System.Windows.Forms.ComboBox();
            this.toSortButton_Rate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toFilter_Payment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toFilter_Rate = new System.Windows.Forms.Button();
            this.toNumericUpDown_Rate = new System.Windows.Forms.NumericUpDown();
            this.fromNumericUpDown_Rate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.noneRadioButton_Payment = new System.Windows.Forms.RadioButton();
            this.noRadioButton_Payment = new System.Windows.Forms.RadioButton();
            this.yesRadioButton_Payment = new System.Windows.Forms.RadioButton();
            this.monthComboBox_Payment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Payments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown_Rate)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AllowUserToAddRows = false;
            this.paymentDataGridView.AllowUserToDeleteRows = false;
            this.paymentDataGridView.AutoGenerateColumns = false;
            this.paymentDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentIDDataGridViewTextBoxColumn,
            this.pupilIDDataGridViewTextBoxColumn,
            this.paymentRateIDDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.paidDataGridViewCheckBoxColumn});
            this.paymentDataGridView.DataSource = this.paymentBindingSource;
            this.paymentDataGridView.Location = new System.Drawing.Point(126, 151);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.ReadOnly = true;
            this.paymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentDataGridView.Size = new System.Drawing.Size(414, 180);
            this.paymentDataGridView.TabIndex = 0;
            // 
            // paymentIDDataGridViewTextBoxColumn
            // 
            this.paymentIDDataGridViewTextBoxColumn.DataPropertyName = "Payment_ID";
            this.paymentIDDataGridViewTextBoxColumn.HeaderText = "ID оплати";
            this.paymentIDDataGridViewTextBoxColumn.Name = "paymentIDDataGridViewTextBoxColumn";
            this.paymentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paymentIDDataGridViewTextBoxColumn.Width = 70;
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
            // paymentRateIDDataGridViewTextBoxColumn
            // 
            this.paymentRateIDDataGridViewTextBoxColumn.DataPropertyName = "PaymentRate_ID";
            this.paymentRateIDDataGridViewTextBoxColumn.HeaderText = "ID тарифу";
            this.paymentRateIDDataGridViewTextBoxColumn.Name = "paymentRateIDDataGridViewTextBoxColumn";
            this.paymentRateIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentRateIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paymentRateIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Місяць";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.monthDataGridViewTextBoxColumn.Width = 80;
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "Сплачено";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            this.paidDataGridViewCheckBoxColumn.ReadOnly = true;
            this.paidDataGridViewCheckBoxColumn.Width = 80;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rateDataGridView
            // 
            this.rateDataGridView.AllowUserToAddRows = false;
            this.rateDataGridView.AllowUserToDeleteRows = false;
            this.rateDataGridView.AutoGenerateColumns = false;
            this.rateDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.rateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentRateIDDataGridViewTextBoxColumn1,
            this.paymentRatetypeDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.rateDataGridView.DataSource = this.rateBindingSource;
            this.rateDataGridView.Location = new System.Drawing.Point(843, 151);
            this.rateDataGridView.Name = "rateDataGridView";
            this.rateDataGridView.ReadOnly = true;
            this.rateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rateDataGridView.Size = new System.Drawing.Size(306, 180);
            this.rateDataGridView.TabIndex = 1;
            // 
            // paymentRateIDDataGridViewTextBoxColumn1
            // 
            this.paymentRateIDDataGridViewTextBoxColumn1.DataPropertyName = "PaymentRate_ID";
            this.paymentRateIDDataGridViewTextBoxColumn1.HeaderText = "ID тарифу";
            this.paymentRateIDDataGridViewTextBoxColumn1.Name = "paymentRateIDDataGridViewTextBoxColumn1";
            this.paymentRateIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.paymentRateIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paymentRateIDDataGridViewTextBoxColumn1.Width = 70;
            // 
            // paymentRatetypeDataGridViewTextBoxColumn
            // 
            this.paymentRatetypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentRate_type";
            this.paymentRatetypeDataGridViewTextBoxColumn.HeaderText = "Тип тарифу";
            this.paymentRatetypeDataGridViewTextBoxColumn.Name = "paymentRatetypeDataGridViewTextBoxColumn";
            this.paymentRatetypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentRatetypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paymentRatetypeDataGridViewTextBoxColumn.Width = 110;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Сума";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sumDataGridViewTextBoxColumn.Width = 80;
            // 
            // rateBindingSource
            // 
            this.rateBindingSource.DataMember = "PaymentRate";
            this.rateBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // showAll_Payment
            // 
            this.showAll_Payment.Location = new System.Drawing.Point(417, 118);
            this.showAll_Payment.Name = "showAll_Payment";
            this.showAll_Payment.Size = new System.Drawing.Size(109, 27);
            this.showAll_Payment.TabIndex = 57;
            this.showAll_Payment.Text = "Показати всі";
            this.showAll_Payment.UseVisualStyleBackColor = true;
            this.showAll_Payment.Click += new System.EventHandler(this.showAll_Payment_Click);
            // 
            // showAll_Rate
            // 
            this.showAll_Rate.Location = new System.Drawing.Point(1026, 118);
            this.showAll_Rate.Name = "showAll_Rate";
            this.showAll_Rate.Size = new System.Drawing.Size(109, 27);
            this.showAll_Rate.TabIndex = 61;
            this.showAll_Rate.Text = "Показати всі";
            this.showAll_Rate.UseVisualStyleBackColor = true;
            this.showAll_Rate.Click += new System.EventHandler(this.showAll_Rate_Click);
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // paymentRateTableAdapter
            // 
            this.paymentRateTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.payment;
            this.pictureBox5.Location = new System.Drawing.Point(107, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(121, 117);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 81;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(234, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 80;
            this.label11.Text = "Списки оплати";
            // 
            // back_Payments
            // 
            this.back_Payments.BackColor = System.Drawing.Color.Transparent;
            this.back_Payments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Payments.Image = global::Курсовая.Properties.Resources.goback;
            this.back_Payments.Location = new System.Drawing.Point(54, 637);
            this.back_Payments.Name = "back_Payments";
            this.back_Payments.Size = new System.Drawing.Size(56, 50);
            this.back_Payments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Payments.TabIndex = 92;
            this.back_Payments.TabStop = false;
            this.back_Payments.Click += new System.EventHandler(this.back_Payments_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Курсовая.Properties.Resources.payment;
            this.pictureBox1.Location = new System.Drawing.Point(798, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(925, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Тарифи оплати";
            // 
            // delete_Payment
            // 
            this.delete_Payment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_Payment.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Payment.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Payment.Location = new System.Drawing.Point(56, 275);
            this.delete_Payment.Name = "delete_Payment";
            this.delete_Payment.Size = new System.Drawing.Size(49, 45);
            this.delete_Payment.TabIndex = 97;
            this.delete_Payment.UseVisualStyleBackColor = false;
            this.delete_Payment.Click += new System.EventHandler(this.delete_Payment_Click);
            // 
            // edit_Payment
            // 
            this.edit_Payment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_Payment.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Payment.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Payment.Location = new System.Drawing.Point(56, 212);
            this.edit_Payment.Name = "edit_Payment";
            this.edit_Payment.Size = new System.Drawing.Size(49, 45);
            this.edit_Payment.TabIndex = 96;
            this.edit_Payment.UseVisualStyleBackColor = false;
            this.edit_Payment.Click += new System.EventHandler(this.edit_Payment_Click);
            // 
            // add_Payment
            // 
            this.add_Payment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Payment.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Payment.ForeColor = System.Drawing.Color.Wheat;
            this.add_Payment.Location = new System.Drawing.Point(56, 151);
            this.add_Payment.Name = "add_Payment";
            this.add_Payment.Size = new System.Drawing.Size(49, 45);
            this.add_Payment.TabIndex = 95;
            this.add_Payment.UseVisualStyleBackColor = false;
            this.add_Payment.Click += new System.EventHandler(this.add_Payment_Click);
            // 
            // delete_Rate
            // 
            this.delete_Rate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.delete_Rate.BackgroundImage = global::Курсовая.Properties.Resources.delete;
            this.delete_Rate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_Rate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_Rate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_Rate.ForeColor = System.Drawing.Color.Wheat;
            this.delete_Rate.Location = new System.Drawing.Point(779, 275);
            this.delete_Rate.Name = "delete_Rate";
            this.delete_Rate.Size = new System.Drawing.Size(49, 45);
            this.delete_Rate.TabIndex = 100;
            this.delete_Rate.UseVisualStyleBackColor = false;
            this.delete_Rate.Click += new System.EventHandler(this.delete_Rate_Click);
            // 
            // edit_Rate
            // 
            this.edit_Rate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.edit_Rate.BackgroundImage = global::Курсовая.Properties.Resources.edit;
            this.edit_Rate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.edit_Rate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Rate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_Rate.ForeColor = System.Drawing.Color.Wheat;
            this.edit_Rate.Location = new System.Drawing.Point(779, 212);
            this.edit_Rate.Name = "edit_Rate";
            this.edit_Rate.Size = new System.Drawing.Size(49, 45);
            this.edit_Rate.TabIndex = 99;
            this.edit_Rate.UseVisualStyleBackColor = false;
            this.edit_Rate.Click += new System.EventHandler(this.edit_Rate_Click);
            // 
            // add_Rate
            // 
            this.add_Rate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_Rate.BackgroundImage = global::Курсовая.Properties.Resources.add;
            this.add_Rate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_Rate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_Rate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Rate.ForeColor = System.Drawing.Color.Wheat;
            this.add_Rate.Location = new System.Drawing.Point(779, 151);
            this.add_Rate.Name = "add_Rate";
            this.add_Rate.Size = new System.Drawing.Size(49, 45);
            this.add_Rate.TabIndex = 98;
            this.add_Rate.UseVisualStyleBackColor = false;
            this.add_Rate.Click += new System.EventHandler(this.add_Rate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox2.Location = new System.Drawing.Point(730, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 705);
            this.pictureBox2.TabIndex = 120;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(608, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 18);
            this.label13.TabIndex = 127;
            this.label13.Text = "Пошук";
            // 
            // payIDCheckBox_Payment
            // 
            this.payIDCheckBox_Payment.AutoSize = true;
            this.payIDCheckBox_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payIDCheckBox_Payment.Location = new System.Drawing.Point(567, 198);
            this.payIDCheckBox_Payment.Name = "payIDCheckBox_Payment";
            this.payIDCheckBox_Payment.Size = new System.Drawing.Size(75, 17);
            this.payIDCheckBox_Payment.TabIndex = 126;
            this.payIDCheckBox_Payment.Text = "ID оплати";
            this.payIDCheckBox_Payment.UseVisualStyleBackColor = true;
            // 
            // allCheckBox_Payment
            // 
            this.allCheckBox_Payment.AutoSize = true;
            this.allCheckBox_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox_Payment.Location = new System.Drawing.Point(567, 172);
            this.allCheckBox_Payment.Name = "allCheckBox_Payment";
            this.allCheckBox_Payment.Size = new System.Drawing.Size(69, 17);
            this.allCheckBox_Payment.TabIndex = 125;
            this.allCheckBox_Payment.Text = "Усі поля";
            this.allCheckBox_Payment.UseVisualStyleBackColor = true;
            // 
            // pupilIDCheckBox_Payment
            // 
            this.pupilIDCheckBox_Payment.AutoSize = true;
            this.pupilIDCheckBox_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pupilIDCheckBox_Payment.Location = new System.Drawing.Point(567, 228);
            this.pupilIDCheckBox_Payment.Name = "pupilIDCheckBox_Payment";
            this.pupilIDCheckBox_Payment.Size = new System.Drawing.Size(62, 17);
            this.pupilIDCheckBox_Payment.TabIndex = 124;
            this.pupilIDCheckBox_Payment.Text = "ID учня";
            this.pupilIDCheckBox_Payment.UseVisualStyleBackColor = true;
            // 
            // toSearch_Payment
            // 
            this.toSearch_Payment.Location = new System.Drawing.Point(580, 334);
            this.toSearch_Payment.Name = "toSearch_Payment";
            this.toSearch_Payment.Size = new System.Drawing.Size(97, 27);
            this.toSearch_Payment.TabIndex = 123;
            this.toSearch_Payment.Text = "Знайти";
            this.toSearch_Payment.UseVisualStyleBackColor = true;
            // 
            // monthCheckBox_Payment
            // 
            this.monthCheckBox_Payment.AutoSize = true;
            this.monthCheckBox_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCheckBox_Payment.Location = new System.Drawing.Point(567, 265);
            this.monthCheckBox_Payment.Name = "monthCheckBox_Payment";
            this.monthCheckBox_Payment.Size = new System.Drawing.Size(61, 17);
            this.monthCheckBox_Payment.TabIndex = 122;
            this.monthCheckBox_Payment.Text = "Місяць";
            this.monthCheckBox_Payment.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Payment
            // 
            this.searchTextBox_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox_Payment.Location = new System.Drawing.Point(573, 288);
            this.searchTextBox_Payment.Name = "searchTextBox_Payment";
            this.searchTextBox_Payment.Size = new System.Drawing.Size(112, 20);
            this.searchTextBox_Payment.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1226, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 134;
            this.label1.Text = "Пошук";
            // 
            // rateIDCheckBox_Rate
            // 
            this.rateIDCheckBox_Rate.AutoSize = true;
            this.rateIDCheckBox_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateIDCheckBox_Rate.Location = new System.Drawing.Point(1194, 198);
            this.rateIDCheckBox_Rate.Name = "rateIDCheckBox_Rate";
            this.rateIDCheckBox_Rate.Size = new System.Drawing.Size(76, 17);
            this.rateIDCheckBox_Rate.TabIndex = 133;
            this.rateIDCheckBox_Rate.Text = "ID тарифу";
            this.rateIDCheckBox_Rate.UseVisualStyleBackColor = true;
            // 
            // allCheckBox_Rate
            // 
            this.allCheckBox_Rate.AutoSize = true;
            this.allCheckBox_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox_Rate.Location = new System.Drawing.Point(1194, 172);
            this.allCheckBox_Rate.Name = "allCheckBox_Rate";
            this.allCheckBox_Rate.Size = new System.Drawing.Size(69, 17);
            this.allCheckBox_Rate.TabIndex = 132;
            this.allCheckBox_Rate.Text = "Усі поля";
            this.allCheckBox_Rate.UseVisualStyleBackColor = true;
            // 
            // typeCheckBox_Rate
            // 
            this.typeCheckBox_Rate.AutoSize = true;
            this.typeCheckBox_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCheckBox_Rate.Location = new System.Drawing.Point(1194, 228);
            this.typeCheckBox_Rate.Name = "typeCheckBox_Rate";
            this.typeCheckBox_Rate.Size = new System.Drawing.Size(84, 17);
            this.typeCheckBox_Rate.TabIndex = 131;
            this.typeCheckBox_Rate.Text = "Тип тарифу";
            this.typeCheckBox_Rate.UseVisualStyleBackColor = true;
            // 
            // toSearch_Rate
            // 
            this.toSearch_Rate.Location = new System.Drawing.Point(1210, 319);
            this.toSearch_Rate.Name = "toSearch_Rate";
            this.toSearch_Rate.Size = new System.Drawing.Size(97, 27);
            this.toSearch_Rate.TabIndex = 130;
            this.toSearch_Rate.Text = "Знайти";
            this.toSearch_Rate.UseVisualStyleBackColor = true;
            // 
            // sumCheckBox_Rate
            // 
            this.sumCheckBox_Rate.AutoSize = true;
            this.sumCheckBox_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumCheckBox_Rate.Location = new System.Drawing.Point(1194, 258);
            this.sumCheckBox_Rate.Name = "sumCheckBox_Rate";
            this.sumCheckBox_Rate.Size = new System.Drawing.Size(52, 17);
            this.sumCheckBox_Rate.TabIndex = 129;
            this.sumCheckBox_Rate.Text = "Сума";
            this.sumCheckBox_Rate.UseVisualStyleBackColor = true;
            // 
            // searchTextBox_Rate
            // 
            this.searchTextBox_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox_Rate.Location = new System.Drawing.Point(1180, 284);
            this.searchTextBox_Rate.Name = "searchTextBox_Rate";
            this.searchTextBox_Rate.Size = new System.Drawing.Size(149, 20);
            this.searchTextBox_Rate.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(160, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 137;
            this.label2.Text = "Сортування";
            // 
            // sortComboBox_Payment
            // 
            this.sortComboBox_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox_Payment.FormattingEnabled = true;
            this.sortComboBox_Payment.Items.AddRange(new object[] {
            "ID оплати",
            "ID учня",
            "ID тарифу",
            "Місяць",
            "Сплачено"});
            this.sortComboBox_Payment.Location = new System.Drawing.Point(138, 451);
            this.sortComboBox_Payment.Name = "sortComboBox_Payment";
            this.sortComboBox_Payment.Size = new System.Drawing.Size(150, 21);
            this.sortComboBox_Payment.TabIndex = 136;
            // 
            // toSort_Payment
            // 
            this.toSort_Payment.Location = new System.Drawing.Point(163, 504);
            this.toSort_Payment.Name = "toSort_Payment";
            this.toSort_Payment.Size = new System.Drawing.Size(97, 27);
            this.toSort_Payment.TabIndex = 135;
            this.toSort_Payment.Text = "Сортувати";
            this.toSort_Payment.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(848, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 140;
            this.label4.Text = "Сортування";
            // 
            // sortComboBox_Rate
            // 
            this.sortComboBox_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox_Rate.FormattingEnabled = true;
            this.sortComboBox_Rate.Items.AddRange(new object[] {
            "ID тарифу",
            "Тип тарифу",
            "Сума"});
            this.sortComboBox_Rate.Location = new System.Drawing.Point(823, 451);
            this.sortComboBox_Rate.Name = "sortComboBox_Rate";
            this.sortComboBox_Rate.Size = new System.Drawing.Size(150, 21);
            this.sortComboBox_Rate.TabIndex = 139;
            // 
            // toSortButton_Rate
            // 
            this.toSortButton_Rate.Location = new System.Drawing.Point(851, 504);
            this.toSortButton_Rate.Name = "toSortButton_Rate";
            this.toSortButton_Rate.Size = new System.Drawing.Size(97, 27);
            this.toSortButton_Rate.TabIndex = 138;
            this.toSortButton_Rate.Text = "Сортувати";
            this.toSortButton_Rate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(445, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 147;
            this.label5.Text = "Фільтрація";
            // 
            // toFilter_Payment
            // 
            this.toFilter_Payment.Location = new System.Drawing.Point(442, 504);
            this.toFilter_Payment.Name = "toFilter_Payment";
            this.toFilter_Payment.Size = new System.Drawing.Size(97, 27);
            this.toFilter_Payment.TabIndex = 141;
            this.toFilter_Payment.Text = "Фільтрувати";
            this.toFilter_Payment.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1119, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 154;
            this.label6.Text = "Фільтрація";
            // 
            // toFilter_Rate
            // 
            this.toFilter_Rate.Location = new System.Drawing.Point(1119, 504);
            this.toFilter_Rate.Name = "toFilter_Rate";
            this.toFilter_Rate.Size = new System.Drawing.Size(97, 27);
            this.toFilter_Rate.TabIndex = 148;
            this.toFilter_Rate.Text = "Фільтрувати";
            this.toFilter_Rate.UseVisualStyleBackColor = true;
            // 
            // toNumericUpDown_Rate
            // 
            this.toNumericUpDown_Rate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.toNumericUpDown_Rate.Location = new System.Drawing.Point(1192, 463);
            this.toNumericUpDown_Rate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.toNumericUpDown_Rate.Minimum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.toNumericUpDown_Rate.Name = "toNumericUpDown_Rate";
            this.toNumericUpDown_Rate.Size = new System.Drawing.Size(54, 20);
            this.toNumericUpDown_Rate.TabIndex = 159;
            this.toNumericUpDown_Rate.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // fromNumericUpDown_Rate
            // 
            this.fromNumericUpDown_Rate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fromNumericUpDown_Rate.Location = new System.Drawing.Point(1102, 463);
            this.fromNumericUpDown_Rate.Maximum = new decimal(new int[] {
            990,
            0,
            0,
            0});
            this.fromNumericUpDown_Rate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fromNumericUpDown_Rate.Name = "fromNumericUpDown_Rate";
            this.fromNumericUpDown_Rate.Size = new System.Drawing.Size(54, 20);
            this.fromNumericUpDown_Rate.TabIndex = 158;
            this.fromNumericUpDown_Rate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1165, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 157;
            this.label10.Text = "та";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1058, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 156;
            this.label9.Text = "Між";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1102, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 155;
            this.label8.Text = "Сума за тарифом";
            // 
            // noneRadioButton_Payment
            // 
            this.noneRadioButton_Payment.AutoSize = true;
            this.noneRadioButton_Payment.Location = new System.Drawing.Point(598, 464);
            this.noneRadioButton_Payment.Name = "noneRadioButton_Payment";
            this.noneRadioButton_Payment.Size = new System.Drawing.Size(31, 17);
            this.noneRadioButton_Payment.TabIndex = 164;
            this.noneRadioButton_Payment.TabStop = true;
            this.noneRadioButton_Payment.Text = "—";
            this.noneRadioButton_Payment.UseVisualStyleBackColor = true;
            // 
            // noRadioButton_Payment
            // 
            this.noRadioButton_Payment.AutoSize = true;
            this.noRadioButton_Payment.Location = new System.Drawing.Point(549, 464);
            this.noRadioButton_Payment.Name = "noRadioButton_Payment";
            this.noRadioButton_Payment.Size = new System.Drawing.Size(35, 17);
            this.noRadioButton_Payment.TabIndex = 162;
            this.noRadioButton_Payment.TabStop = true;
            this.noRadioButton_Payment.Text = "Ні";
            this.noRadioButton_Payment.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton_Payment
            // 
            this.yesRadioButton_Payment.AutoSize = true;
            this.yesRadioButton_Payment.Location = new System.Drawing.Point(497, 464);
            this.yesRadioButton_Payment.Name = "yesRadioButton_Payment";
            this.yesRadioButton_Payment.Size = new System.Drawing.Size(44, 17);
            this.yesRadioButton_Payment.TabIndex = 160;
            this.yesRadioButton_Payment.TabStop = true;
            this.yesRadioButton_Payment.Text = "Так";
            this.yesRadioButton_Payment.UseVisualStyleBackColor = true;
            // 
            // monthComboBox_Payment
            // 
            this.monthComboBox_Payment.FormattingEnabled = true;
            this.monthComboBox_Payment.Items.AddRange(new object[] {
            "січень",
            "лютий",
            "березень",
            "квітень",
            "травень",
            "червень",
            "липень",
            "серпень",
            "вересень",
            "жовтень",
            "листопад",
            "грудень"});
            this.monthComboBox_Payment.Location = new System.Drawing.Point(496, 425);
            this.monthComboBox_Payment.Name = "monthComboBox_Payment";
            this.monthComboBox_Payment.Size = new System.Drawing.Size(130, 21);
            this.monthComboBox_Payment.TabIndex = 165;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 163;
            this.label7.Text = "Місяць";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 467);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 161;
            this.label12.Text = "Сплачено";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(567, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 166;
            this.checkBox1.Text = "ID тарифу";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 699);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.noneRadioButton_Payment);
            this.Controls.Add(this.noRadioButton_Payment);
            this.Controls.Add(this.yesRadioButton_Payment);
            this.Controls.Add(this.monthComboBox_Payment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.toNumericUpDown_Rate);
            this.Controls.Add(this.fromNumericUpDown_Rate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toFilter_Rate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toFilter_Payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sortComboBox_Rate);
            this.Controls.Add(this.toSortButton_Rate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortComboBox_Payment);
            this.Controls.Add(this.toSort_Payment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateIDCheckBox_Rate);
            this.Controls.Add(this.allCheckBox_Rate);
            this.Controls.Add(this.typeCheckBox_Rate);
            this.Controls.Add(this.toSearch_Rate);
            this.Controls.Add(this.sumCheckBox_Rate);
            this.Controls.Add(this.searchTextBox_Rate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.payIDCheckBox_Payment);
            this.Controls.Add(this.allCheckBox_Payment);
            this.Controls.Add(this.pupilIDCheckBox_Payment);
            this.Controls.Add(this.toSearch_Payment);
            this.Controls.Add(this.monthCheckBox_Payment);
            this.Controls.Add(this.searchTextBox_Payment);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.delete_Rate);
            this.Controls.Add(this.edit_Rate);
            this.Controls.Add(this.add_Rate);
            this.Controls.Add(this.delete_Payment);
            this.Controls.Add(this.edit_Payment);
            this.Controls.Add(this.add_Payment);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back_Payments);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.showAll_Rate);
            this.Controls.Add(this.showAll_Payment);
            this.Controls.Add(this.rateDataGridView);
            this.Controls.Add(this.paymentDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Payments_FormClosing);
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_Payments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toNumericUpDown_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown_Rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentDataGridView;
        private System.Windows.Forms.DataGridView rateDataGridView;
        private System.Windows.Forms.Button showAll_Payment;
        private System.Windows.Forms.Button showAll_Rate;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource rateBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter paymentRateTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox back_Payments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete_Payment;
        private System.Windows.Forms.Button edit_Payment;
        private System.Windows.Forms.Button add_Payment;
        private System.Windows.Forms.Button delete_Rate;
        private System.Windows.Forms.Button edit_Rate;
        private System.Windows.Forms.Button add_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentRateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentRateIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentRatetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox payIDCheckBox_Payment;
        private System.Windows.Forms.CheckBox allCheckBox_Payment;
        private System.Windows.Forms.CheckBox pupilIDCheckBox_Payment;
        private System.Windows.Forms.Button toSearch_Payment;
        private System.Windows.Forms.CheckBox monthCheckBox_Payment;
        private System.Windows.Forms.TextBox searchTextBox_Payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rateIDCheckBox_Rate;
        private System.Windows.Forms.CheckBox allCheckBox_Rate;
        private System.Windows.Forms.CheckBox typeCheckBox_Rate;
        private System.Windows.Forms.Button toSearch_Rate;
        private System.Windows.Forms.CheckBox sumCheckBox_Rate;
        private System.Windows.Forms.TextBox searchTextBox_Rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortComboBox_Payment;
        private System.Windows.Forms.Button toSort_Payment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sortComboBox_Rate;
        private System.Windows.Forms.Button toSortButton_Rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button toFilter_Payment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button toFilter_Rate;
        private System.Windows.Forms.NumericUpDown toNumericUpDown_Rate;
        private System.Windows.Forms.NumericUpDown fromNumericUpDown_Rate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton noneRadioButton_Payment;
        private System.Windows.Forms.RadioButton noRadioButton_Payment;
        private System.Windows.Forms.RadioButton yesRadioButton_Payment;
        private System.Windows.Forms.ComboBox monthComboBox_Payment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}