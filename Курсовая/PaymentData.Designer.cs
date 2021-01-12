namespace Курсовая
{
    partial class PaymentData
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
            System.Windows.Forms.Label pupil_IDLabel;
            System.Windows.Forms.Label paymentRate_IDLabel;
            System.Windows.Forms.Label monthLabel;
            System.Windows.Forms.Label paidLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentData));
            this.Cancel_Payment = new System.Windows.Forms.Button();
            this.OK_Payment = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.pupil_IDComboBox = new System.Windows.Forms.ComboBox();
            this.pupilBbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentRate_IDComboBox = new System.Windows.Forms.ComboBox();
            this.rateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.paidCheckBox = new System.Windows.Forms.CheckBox();
            this.pupil = new System.Windows.Forms.Label();
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.paymentRateTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentTableAdapter();
            this.paymentRate_ID = new System.Windows.Forms.Label();
            pupil_IDLabel = new System.Windows.Forms.Label();
            paymentRate_IDLabel = new System.Windows.Forms.Label();
            monthLabel = new System.Windows.Forms.Label();
            paidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pupil_IDLabel
            // 
            pupil_IDLabel.AutoSize = true;
            pupil_IDLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            pupil_IDLabel.Location = new System.Drawing.Point(113, 42);
            pupil_IDLabel.Name = "pupil_IDLabel";
            pupil_IDLabel.Size = new System.Drawing.Size(50, 15);
            pupil_IDLabel.TabIndex = 14;
            pupil_IDLabel.Text = "ID учня:";
            // 
            // paymentRate_IDLabel
            // 
            paymentRate_IDLabel.AutoSize = true;
            paymentRate_IDLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            paymentRate_IDLabel.Location = new System.Drawing.Point(112, 88);
            paymentRate_IDLabel.Name = "paymentRate_IDLabel";
            paymentRate_IDLabel.Size = new System.Drawing.Size(69, 15);
            paymentRate_IDLabel.TabIndex = 15;
            paymentRate_IDLabel.Text = "ID тарифу:";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            monthLabel.Location = new System.Drawing.Point(113, 140);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new System.Drawing.Size(51, 15);
            monthLabel.TabIndex = 16;
            monthLabel.Text = "Місяць:";
            // 
            // paidLabel
            // 
            paidLabel.AutoSize = true;
            paidLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            paidLabel.Location = new System.Drawing.Point(112, 188);
            paidLabel.Name = "paidLabel";
            paidLabel.Size = new System.Drawing.Size(83, 15);
            paidLabel.TabIndex = 17;
            paidLabel.Text = "Стан сплати:";
            // 
            // Cancel_Payment
            // 
            this.Cancel_Payment.Location = new System.Drawing.Point(437, 233);
            this.Cancel_Payment.Name = "Cancel_Payment";
            this.Cancel_Payment.Size = new System.Drawing.Size(87, 27);
            this.Cancel_Payment.TabIndex = 13;
            this.Cancel_Payment.Text = "Відміна";
            this.Cancel_Payment.UseVisualStyleBackColor = true;
            this.Cancel_Payment.Click += new System.EventHandler(this.Cancel_Payment_Click);
            // 
            // OK_Payment
            // 
            this.OK_Payment.Location = new System.Drawing.Point(270, 233);
            this.OK_Payment.Name = "OK_Payment";
            this.OK_Payment.Size = new System.Drawing.Size(87, 27);
            this.OK_Payment.TabIndex = 12;
            this.OK_Payment.Text = "ОК";
            this.OK_Payment.UseVisualStyleBackColor = true;
            this.OK_Payment.Click += new System.EventHandler(this.OK_Payment_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pupil_IDComboBox
            // 
            this.pupil_IDComboBox.DataSource = this.pupilBbindingSource;
            this.pupil_IDComboBox.DisplayMember = "Pupil_ID";
            this.pupil_IDComboBox.FormattingEnabled = true;
            this.pupil_IDComboBox.Location = new System.Drawing.Point(235, 38);
            this.pupil_IDComboBox.Name = "pupil_IDComboBox";
            this.pupil_IDComboBox.Size = new System.Drawing.Size(140, 23);
            this.pupil_IDComboBox.TabIndex = 15;
            this.pupil_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.pupil_IDComboBox_SelectedIndexChanged);
            // 
            // pupilBbindingSource
            // 
            this.pupilBbindingSource.DataMember = "Pupil";
            this.pupilBbindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // paymentRate_IDComboBox
            // 
            this.paymentRate_IDComboBox.DataSource = this.rateBindingSource;
            this.paymentRate_IDComboBox.DisplayMember = "PaymentRate_ID";
            this.paymentRate_IDComboBox.FormattingEnabled = true;
            this.paymentRate_IDComboBox.Location = new System.Drawing.Point(235, 85);
            this.paymentRate_IDComboBox.Name = "paymentRate_IDComboBox";
            this.paymentRate_IDComboBox.Size = new System.Drawing.Size(140, 23);
            this.paymentRate_IDComboBox.TabIndex = 16;
            this.paymentRate_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentRate_IDComboBox_SelectedIndexChanged);
            // 
            // rateBindingSource
            // 
            this.rateBindingSource.DataMember = "PaymentRate";
            this.rateBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
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
            this.monthComboBox.Location = new System.Drawing.Point(235, 137);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(140, 23);
            this.monthComboBox.TabIndex = 17;
            // 
            // paidCheckBox
            // 
            this.paidCheckBox.Location = new System.Drawing.Point(235, 182);
            this.paidCheckBox.Name = "paidCheckBox";
            this.paidCheckBox.Size = new System.Drawing.Size(121, 28);
            this.paidCheckBox.TabIndex = 18;
            this.paidCheckBox.Text = "Сплачено";
            this.paidCheckBox.UseVisualStyleBackColor = true;
            // 
            // pupil
            // 
            this.pupil.AutoSize = true;
            this.pupil.Location = new System.Drawing.Point(394, 42);
            this.pupil.Name = "pupil";
            this.pupil.Size = new System.Drawing.Size(84, 15);
            this.pupil.TabIndex = 19;
            this.pupil.Text = "pupil_IDLabel";
            // 
            // pupilTableAdapter
            // 
            this.pupilTableAdapter.ClearBeforeFill = true;
            // 
            // paymentRateTableAdapter
            // 
            this.paymentRateTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // paymentRate_ID
            // 
            this.paymentRate_ID.AutoSize = true;
            this.paymentRate_ID.Location = new System.Drawing.Point(394, 88);
            this.paymentRate_ID.Name = "paymentRate_ID";
            this.paymentRate_ID.Size = new System.Drawing.Size(130, 15);
            this.paymentRate_ID.TabIndex = 20;
            this.paymentRate_ID.Text = "paymentRate_IDLabel";
            // 
            // PaymentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(713, 304);
            this.Controls.Add(this.paymentRate_ID);
            this.Controls.Add(this.pupil);
            this.Controls.Add(paidLabel);
            this.Controls.Add(this.paidCheckBox);
            this.Controls.Add(monthLabel);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(paymentRate_IDLabel);
            this.Controls.Add(this.paymentRate_IDComboBox);
            this.Controls.Add(pupil_IDLabel);
            this.Controls.Add(this.pupil_IDComboBox);
            this.Controls.Add(this.Cancel_Payment);
            this.Controls.Add(this.OK_Payment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про оплату";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Payment;
        private System.Windows.Forms.Button OK_Payment;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.ComboBox pupil_IDComboBox;
        private System.Windows.Forms.ComboBox paymentRate_IDComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.CheckBox paidCheckBox;
        private System.Windows.Forms.Label pupil;
        private System.Windows.Forms.BindingSource pupilBbindingSource;
        private System.Windows.Forms.BindingSource rateBindingSource;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter paymentRateTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.Label paymentRate_ID;
    }
}