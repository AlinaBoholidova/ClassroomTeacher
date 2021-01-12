namespace Курсовая
{
    partial class AdditionalActivityData
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
            System.Windows.Forms.Label activity_nameLabel;
            System.Windows.Forms.Label activity_dateLabel;
            this.Cancel_AddActivity = new System.Windows.Forms.Button();
            this.OK_AddActivity = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.additionalActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additionalActivityTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter();
            this.tableAdapterManager = new Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager();
            this.activity_nameTextBox = new System.Windows.Forms.TextBox();
            this.activity_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            activity_nameLabel = new System.Windows.Forms.Label();
            activity_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalActivityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activity_nameLabel
            // 
            activity_nameLabel.AutoSize = true;
            activity_nameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            activity_nameLabel.Location = new System.Drawing.Point(120, 58);
            activity_nameLabel.Name = "activity_nameLabel";
            activity_nameLabel.Size = new System.Drawing.Size(127, 16);
            activity_nameLabel.TabIndex = 16;
            activity_nameLabel.Text = "Назва активності:";
            // 
            // activity_dateLabel
            // 
            activity_dateLabel.AutoSize = true;
            activity_dateLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            activity_dateLabel.Location = new System.Drawing.Point(120, 132);
            activity_dateLabel.Name = "activity_dateLabel";
            activity_dateLabel.Size = new System.Drawing.Size(125, 16);
            activity_dateLabel.TabIndex = 17;
            activity_dateLabel.Text = "Дата проведення:";
            // 
            // Cancel_AddActivity
            // 
            this.Cancel_AddActivity.Location = new System.Drawing.Point(392, 187);
            this.Cancel_AddActivity.Name = "Cancel_AddActivity";
            this.Cancel_AddActivity.Size = new System.Drawing.Size(99, 29);
            this.Cancel_AddActivity.TabIndex = 15;
            this.Cancel_AddActivity.Text = "Відміна";
            this.Cancel_AddActivity.UseVisualStyleBackColor = true;
            this.Cancel_AddActivity.Click += new System.EventHandler(this.Cancel_AddActivity_Click);
            // 
            // OK_AddActivity
            // 
            this.OK_AddActivity.Location = new System.Drawing.Point(201, 187);
            this.OK_AddActivity.Name = "OK_AddActivity";
            this.OK_AddActivity.Size = new System.Drawing.Size(99, 29);
            this.OK_AddActivity.TabIndex = 14;
            this.OK_AddActivity.Text = "ОК";
            this.OK_AddActivity.UseVisualStyleBackColor = true;
            this.OK_AddActivity.Click += new System.EventHandler(this.OK_AddActivity_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // additionalActivityBindingSource
            // 
            this.additionalActivityBindingSource.DataMember = "AdditionalActivity";
            this.additionalActivityBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // additionalActivityTableAdapter
            // 
            this.additionalActivityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionalActivityTableAdapter = this.additionalActivityTableAdapter;
            this.tableAdapterManager.AdditionalParticipationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JournalRecordTableAdapter = null;
            this.tableAdapterManager.PaymentRateTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PersonnelFileTableAdapter = null;
            this.tableAdapterManager.PointsDistributionTableAdapter = null;
            this.tableAdapterManager.PupilTableAdapter = null;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // activity_nameTextBox
            // 
            this.activity_nameTextBox.Location = new System.Drawing.Point(251, 56);
            this.activity_nameTextBox.Name = "activity_nameTextBox";
            this.activity_nameTextBox.Size = new System.Drawing.Size(318, 22);
            this.activity_nameTextBox.TabIndex = 17;
            // 
            // activity_dateDateTimePicker
            // 
            this.activity_dateDateTimePicker.Location = new System.Drawing.Point(251, 130);
            this.activity_dateDateTimePicker.MaxDate = new System.DateTime(2021, 5, 28, 0, 0, 0, 0);
            this.activity_dateDateTimePicker.MinDate = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            this.activity_dateDateTimePicker.Name = "activity_dateDateTimePicker";
            this.activity_dateDateTimePicker.Size = new System.Drawing.Size(318, 22);
            this.activity_dateDateTimePicker.TabIndex = 18;
            // 
            // AdditionalActivityData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(609, 270);
            this.Controls.Add(activity_dateLabel);
            this.Controls.Add(this.activity_dateDateTimePicker);
            this.Controls.Add(activity_nameLabel);
            this.Controls.Add(this.activity_nameTextBox);
            this.Controls.Add(this.Cancel_AddActivity);
            this.Controls.Add(this.OK_AddActivity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AdditionalActivityData";
            this.Text = "Додаткова активність";
            this.Load += new System.EventHandler(this.AdditionalActivityData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalActivityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_AddActivity;
        private System.Windows.Forms.Button OK_AddActivity;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource additionalActivityBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter additionalActivityTableAdapter;
        private SchoolCourseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox activity_nameTextBox;
        private System.Windows.Forms.DateTimePicker activity_dateDateTimePicker;
    }
}