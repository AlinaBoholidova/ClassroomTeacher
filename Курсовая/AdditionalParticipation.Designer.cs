namespace Курсовая
{
    partial class AdditionalParticipation
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
            System.Windows.Forms.Label pupil_ID;
            System.Windows.Forms.Label activity_ID;
            System.Windows.Forms.Label distribution_ID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalParticipation));
            this.Cancel_Participation = new System.Windows.Forms.Button();
            this.OK_Participation = new System.Windows.Forms.Button();
            this.schoolCourseDataSet = new Курсовая.SchoolCourseDataSet();
            this.additionalParticipationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.additionalParticipationTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalParticipationTableAdapter();
            this.tableAdapterManager = new Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager();
            this.additionalActivityTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter();
            this.pointsDistributionTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter();
            this.pupilTableAdapter = new Курсовая.SchoolCourseDataSetTableAdapters.PupilTableAdapter();
            this.pupil_IDComboBox = new System.Windows.Forms.ComboBox();
            this.pupilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activity_IDComboBox = new System.Windows.Forms.ComboBox();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distribution_IDComboBox = new System.Windows.Forms.ComboBox();
            this.distributionBndingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pupil_IDLabel = new System.Windows.Forms.Label();
            this.activity_IDLabel = new System.Windows.Forms.Label();
            this.distribution_IDLabel = new System.Windows.Forms.Label();
            pupil_ID = new System.Windows.Forms.Label();
            activity_ID = new System.Windows.Forms.Label();
            distribution_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalParticipationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionBndingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pupil_ID
            // 
            pupil_ID.AutoSize = true;
            pupil_ID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            pupil_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            pupil_ID.Location = new System.Drawing.Point(99, 44);
            pupil_ID.Name = "pupil_ID";
            pupil_ID.Size = new System.Drawing.Size(50, 15);
            pupil_ID.TabIndex = 16;
            pupil_ID.Text = "ID учня:";
            // 
            // activity_ID
            // 
            activity_ID.AutoSize = true;
            activity_ID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            activity_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            activity_ID.Location = new System.Drawing.Point(99, 90);
            activity_ID.Name = "activity_ID";
            activity_ID.Size = new System.Drawing.Size(89, 15);
            activity_ID.TabIndex = 17;
            activity_ID.Text = "ID активності:";
            // 
            // distribution_ID
            // 
            distribution_ID.AutoSize = true;
            distribution_ID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            distribution_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            distribution_ID.Location = new System.Drawing.Point(99, 132);
            distribution_ID.Name = "distribution_ID";
            distribution_ID.Size = new System.Drawing.Size(93, 15);
            distribution_ID.TabIndex = 18;
            distribution_ID.Text = "ID розбаловки:";
            // 
            // Cancel_Participation
            // 
            this.Cancel_Participation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_Participation.Location = new System.Drawing.Point(414, 188);
            this.Cancel_Participation.Name = "Cancel_Participation";
            this.Cancel_Participation.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Participation.TabIndex = 15;
            this.Cancel_Participation.Text = "Відміна";
            this.Cancel_Participation.UseVisualStyleBackColor = true;
            this.Cancel_Participation.Click += new System.EventHandler(this.Cancel_Participation_Click);
            // 
            // OK_Participation
            // 
            this.OK_Participation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK_Participation.Location = new System.Drawing.Point(271, 188);
            this.OK_Participation.Name = "OK_Participation";
            this.OK_Participation.Size = new System.Drawing.Size(75, 23);
            this.OK_Participation.TabIndex = 14;
            this.OK_Participation.Text = "ОК";
            this.OK_Participation.UseVisualStyleBackColor = true;
            this.OK_Participation.Click += new System.EventHandler(this.OK_Participation_Click);
            // 
            // schoolCourseDataSet
            // 
            this.schoolCourseDataSet.DataSetName = "SchoolCourseDataSet";
            this.schoolCourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // additionalParticipationBindingSource
            // 
            this.additionalParticipationBindingSource.DataMember = "AdditionalParticipation";
            this.additionalParticipationBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // additionalParticipationTableAdapter
            // 
            this.additionalParticipationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdditionalActivityTableAdapter = this.additionalActivityTableAdapter;
            this.tableAdapterManager.AdditionalParticipationTableAdapter = this.additionalParticipationTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JournalRecordTableAdapter = null;
            this.tableAdapterManager.PaymentRateTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PersonnelFileTableAdapter = null;
            this.tableAdapterManager.PointsDistributionTableAdapter = this.pointsDistributionTableAdapter;
            this.tableAdapterManager.PupilTableAdapter = this.pupilTableAdapter;
            this.tableAdapterManager.SubjectTableAdapter = null;
            this.tableAdapterManager.TestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Курсовая.SchoolCourseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // additionalActivityTableAdapter
            // 
            this.additionalActivityTableAdapter.ClearBeforeFill = true;
            // 
            // pointsDistributionTableAdapter
            // 
            this.pointsDistributionTableAdapter.ClearBeforeFill = true;
            // 
            // pupilTableAdapter
            // 
            this.pupilTableAdapter.ClearBeforeFill = true;
            // 
            // pupil_IDComboBox
            // 
            this.pupil_IDComboBox.DataSource = this.pupilBindingSource;
            this.pupil_IDComboBox.DisplayMember = "Pupil_ID";
            this.pupil_IDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pupil_IDComboBox.FormattingEnabled = true;
            this.pupil_IDComboBox.Location = new System.Drawing.Point(205, 41);
            this.pupil_IDComboBox.Name = "pupil_IDComboBox";
            this.pupil_IDComboBox.Size = new System.Drawing.Size(61, 23);
            this.pupil_IDComboBox.TabIndex = 17;
            this.pupil_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.pupil_IDComboBox_SelectedIndexChanged);
            // 
            // pupilBindingSource
            // 
            this.pupilBindingSource.DataMember = "Pupil";
            this.pupilBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // activity_IDComboBox
            // 
            this.activity_IDComboBox.DataSource = this.activityBindingSource;
            this.activity_IDComboBox.DisplayMember = "Activity_ID";
            this.activity_IDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activity_IDComboBox.FormattingEnabled = true;
            this.activity_IDComboBox.Location = new System.Drawing.Point(205, 85);
            this.activity_IDComboBox.Name = "activity_IDComboBox";
            this.activity_IDComboBox.Size = new System.Drawing.Size(61, 23);
            this.activity_IDComboBox.TabIndex = 18;
            this.activity_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.activity_IDComboBox_SelectedIndexChanged);
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataMember = "AdditionalActivity";
            this.activityBindingSource.DataSource = this.schoolCourseDataSet;
            // 
            // distribution_IDComboBox
            // 
            this.distribution_IDComboBox.DataSource = this.distributionBndingSource;
            this.distribution_IDComboBox.DisplayMember = "Distribution_ID";
            this.distribution_IDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distribution_IDComboBox.FormattingEnabled = true;
            this.distribution_IDComboBox.Location = new System.Drawing.Point(205, 132);
            this.distribution_IDComboBox.Name = "distribution_IDComboBox";
            this.distribution_IDComboBox.Size = new System.Drawing.Size(61, 23);
            this.distribution_IDComboBox.TabIndex = 19;
            this.distribution_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.distribution_IDComboBox_SelectedIndexChanged);
            // 
            // distributionBndingSource
            // 
            this.distributionBndingSource.DataMember = "PointsDistribution";
            this.distributionBndingSource.DataSource = this.schoolCourseDataSet;
            // 
            // pupil_IDLabel
            // 
            this.pupil_IDLabel.AutoSize = true;
            this.pupil_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pupil_IDLabel.Location = new System.Drawing.Point(292, 46);
            this.pupil_IDLabel.Name = "pupil_IDLabel";
            this.pupil_IDLabel.Size = new System.Drawing.Size(41, 15);
            this.pupil_IDLabel.TabIndex = 20;
            this.pupil_IDLabel.Text = "label1";
            // 
            // activity_IDLabel
            // 
            this.activity_IDLabel.AutoSize = true;
            this.activity_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activity_IDLabel.Location = new System.Drawing.Point(292, 90);
            this.activity_IDLabel.Name = "activity_IDLabel";
            this.activity_IDLabel.Size = new System.Drawing.Size(41, 15);
            this.activity_IDLabel.TabIndex = 21;
            this.activity_IDLabel.Text = "label2";
            // 
            // distribution_IDLabel
            // 
            this.distribution_IDLabel.AutoSize = true;
            this.distribution_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distribution_IDLabel.Location = new System.Drawing.Point(292, 137);
            this.distribution_IDLabel.Name = "distribution_IDLabel";
            this.distribution_IDLabel.Size = new System.Drawing.Size(41, 15);
            this.distribution_IDLabel.TabIndex = 22;
            this.distribution_IDLabel.Text = "label3";
            // 
            // AdditionalParticipation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_subject;
            this.ClientSize = new System.Drawing.Size(618, 250);
            this.Controls.Add(this.distribution_IDLabel);
            this.Controls.Add(this.activity_IDLabel);
            this.Controls.Add(this.pupil_IDLabel);
            this.Controls.Add(distribution_ID);
            this.Controls.Add(this.distribution_IDComboBox);
            this.Controls.Add(activity_ID);
            this.Controls.Add(this.activity_IDComboBox);
            this.Controls.Add(pupil_ID);
            this.Controls.Add(this.pupil_IDComboBox);
            this.Controls.Add(this.Cancel_Participation);
            this.Controls.Add(this.OK_Participation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdditionalParticipation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додаткова участь";
            this.Load += new System.EventHandler(this.AdditionalParticipation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolCourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalParticipationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributionBndingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Participation;
        private System.Windows.Forms.Button OK_Participation;
        private SchoolCourseDataSet schoolCourseDataSet;
        private System.Windows.Forms.BindingSource additionalParticipationBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalParticipationTableAdapter additionalParticipationTableAdapter;
        private SchoolCourseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox pupil_IDComboBox;
        private System.Windows.Forms.ComboBox activity_IDComboBox;
        private System.Windows.Forms.ComboBox distribution_IDComboBox;
        private System.Windows.Forms.Label pupil_IDLabel;
        private System.Windows.Forms.Label activity_IDLabel;
        private System.Windows.Forms.Label distribution_IDLabel;
        private SchoolCourseDataSetTableAdapters.PupilTableAdapter pupilTableAdapter;
        private System.Windows.Forms.BindingSource pupilBindingSource;
        private SchoolCourseDataSetTableAdapters.AdditionalActivityTableAdapter additionalActivityTableAdapter;
        private System.Windows.Forms.BindingSource activityBindingSource;
        private SchoolCourseDataSetTableAdapters.PointsDistributionTableAdapter pointsDistributionTableAdapter;
        private System.Windows.Forms.BindingSource distributionBndingSource;
    }
}