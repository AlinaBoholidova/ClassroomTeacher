namespace Курсовая.Parent
{
    partial class ViewReceiptParent
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReceiptParent));
            this.back_Receipt = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.receiptPreviewButton = new System.Windows.Forms.Button();
            this.receiptReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.back_Receipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back_Receipt
            // 
            this.back_Receipt.BackColor = System.Drawing.Color.Transparent;
            this.back_Receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Receipt.Image = global::Курсовая.Properties.Resources.goback;
            this.back_Receipt.Location = new System.Drawing.Point(25, 548);
            this.back_Receipt.Name = "back_Receipt";
            this.back_Receipt.Size = new System.Drawing.Size(62, 55);
            this.back_Receipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Receipt.TabIndex = 89;
            this.back_Receipt.TabStop = false;
            this.back_Receipt.Click += new System.EventHandler(this.back_Receipt_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Курсовая.Properties.Resources.report;
            this.pictureBox5.Location = new System.Drawing.Point(39, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 120);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 88;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(173, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 20);
            this.label11.TabIndex = 87;
            this.label11.Text = "Квитанції для видачі";
            // 
            // receiptPreviewButton
            // 
            this.receiptPreviewButton.Location = new System.Drawing.Point(177, 393);
            this.receiptPreviewButton.Name = "receiptPreviewButton";
            this.receiptPreviewButton.Size = new System.Drawing.Size(145, 34);
            this.receiptPreviewButton.TabIndex = 86;
            this.receiptPreviewButton.Text = "Перегляд квитанції";
            this.receiptPreviewButton.UseVisualStyleBackColor = true;
            this.receiptPreviewButton.Click += new System.EventHandler(this.receiptPreviewButton_Click);
            // 
            // receiptReportViewer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = null;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = null;
            this.receiptReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.receiptReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.receiptReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.receiptReportViewer.LocalReport.ReportEmbeddedResource = "Курсовая.Receipt.rdlc";
            this.receiptReportViewer.Location = new System.Drawing.Point(489, 134);
            this.receiptReportViewer.Name = "receiptReportViewer";
            this.receiptReportViewer.ServerReport.BearerToken = null;
            this.receiptReportViewer.Size = new System.Drawing.Size(619, 432);
            this.receiptReportViewer.TabIndex = 85;
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AllowUserToAddRows = false;
            this.paymentDataGridView.AllowUserToDeleteRows = false;
            this.paymentDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Location = new System.Drawing.Point(39, 134);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.ReadOnly = true;
            this.paymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentDataGridView.Size = new System.Drawing.Size(432, 158);
            this.paymentDataGridView.TabIndex = 84;
            // 
            // ViewReceiptParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_pupil;
            this.ClientSize = new System.Drawing.Size(1132, 609);
            this.Controls.Add(this.back_Receipt);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.receiptPreviewButton);
            this.Controls.Add(this.receiptReportViewer);
            this.Controls.Add(this.paymentDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewReceiptParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квитанції";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewReceiptParent_FormClosing);
            this.Load += new System.EventHandler(this.ViewReceiptParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back_Receipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back_Receipt;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button receiptPreviewButton;
        private Microsoft.Reporting.WinForms.ReportViewer receiptReportViewer;
        private System.Windows.Forms.DataGridView paymentDataGridView;
    }
}