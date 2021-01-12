namespace Курсовая
{
    partial class PaymentRate
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
            System.Windows.Forms.Label paymentRate_typeLabel;
            System.Windows.Forms.Label sumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentRate));
            this.Cancel_PaymentRate = new System.Windows.Forms.Button();
            this.OK_PaymentRate = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.paymentRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentRateTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter();
            this.tableAdapterManager = new Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager();
            this.paymentRate_typeTextBox = new System.Windows.Forms.TextBox();
            this.sumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            paymentRate_typeLabel = new System.Windows.Forms.Label();
            sumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentRate_typeLabel
            // 
            paymentRate_typeLabel.AutoSize = true;
            paymentRate_typeLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            paymentRate_typeLabel.Location = new System.Drawing.Point(126, 58);
            paymentRate_typeLabel.Name = "paymentRate_typeLabel";
            paymentRate_typeLabel.Size = new System.Drawing.Size(78, 15);
            paymentRate_typeLabel.TabIndex = 16;
            paymentRate_typeLabel.Text = "Тип тарифу:";
            // 
            // sumLabel
            // 
            sumLabel.AutoSize = true;
            sumLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            sumLabel.Location = new System.Drawing.Point(126, 117);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(39, 15);
            sumLabel.TabIndex = 17;
            sumLabel.Text = "Сума:";
            // 
            // Cancel_PaymentRate
            // 
            this.Cancel_PaymentRate.Location = new System.Drawing.Point(350, 183);
            this.Cancel_PaymentRate.Name = "Cancel_PaymentRate";
            this.Cancel_PaymentRate.Size = new System.Drawing.Size(87, 27);
            this.Cancel_PaymentRate.TabIndex = 15;
            this.Cancel_PaymentRate.Text = "Відміна";
            this.Cancel_PaymentRate.UseVisualStyleBackColor = true;
            this.Cancel_PaymentRate.Click += new System.EventHandler(this.Cancel_PaymentRate_Click);
            // 
            // OK_PaymentRate
            // 
            this.OK_PaymentRate.Location = new System.Drawing.Point(184, 183);
            this.OK_PaymentRate.Name = "OK_PaymentRate";
            this.OK_PaymentRate.Size = new System.Drawing.Size(87, 27);
            this.OK_PaymentRate.TabIndex = 14;
            this.OK_PaymentRate.Text = "ОК";
            this.OK_PaymentRate.UseVisualStyleBackColor = true;
            this.OK_PaymentRate.Click += new System.EventHandler(this.OK_PaymentRate_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentRateBindingSource
            // 
            this.paymentRateBindingSource.DataMember = "PaymentRate";
            this.paymentRateBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // paymentRateTableAdapter
            // 
            this.paymentRateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionalActivityTableAdapter = null;
            this.tableAdapterManager.AdditionalParticipationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JournalRecordTableAdapter = null;
            this.tableAdapterManager.PaymentRateTableAdapter = this.paymentRateTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PersonnelFileTableAdapter = null;
            this.tableAdapterManager.PointsDistributionTableAdapter = null;
            this.tableAdapterManager.PupilTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // paymentRate_typeTextBox
            // 
            this.paymentRate_typeTextBox.Location = new System.Drawing.Point(237, 55);
            this.paymentRate_typeTextBox.Name = "paymentRate_typeTextBox";
            this.paymentRate_typeTextBox.Size = new System.Drawing.Size(186, 21);
            this.paymentRate_typeTextBox.TabIndex = 17;
            // 
            // sumNumericUpDown
            // 
            this.sumNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sumNumericUpDown.Location = new System.Drawing.Point(237, 115);
            this.sumNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sumNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.sumNumericUpDown.Name = "sumNumericUpDown";
            this.sumNumericUpDown.Size = new System.Drawing.Size(94, 21);
            this.sumNumericUpDown.TabIndex = 18;
            this.sumNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "грн.";
            // 
            // PaymentRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(535, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(sumLabel);
            this.Controls.Add(this.sumNumericUpDown);
            this.Controls.Add(paymentRate_typeLabel);
            this.Controls.Add(this.paymentRate_typeTextBox);
            this.Controls.Add(this.Cancel_PaymentRate);
            this.Controls.Add(this.OK_PaymentRate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тариф оплати";
            this.Load += new System.EventHandler(this.PaymentRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentRateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_PaymentRate;
        private System.Windows.Forms.Button OK_PaymentRate;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource paymentRateBindingSource;
        private SchoolCourseDataSetTableAdapters.PaymentRateTableAdapter paymentRateTableAdapter;
        private SchoolCourseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox paymentRate_typeTextBox;
        private System.Windows.Forms.NumericUpDown sumNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}