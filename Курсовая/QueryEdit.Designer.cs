namespace Курсовая
{
    partial class QueryEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryEdit));
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.sqlButton = new System.Windows.Forms.Button();
            this.queryDataGridView = new System.Windows.Forms.DataGridView();
            this.queryInput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(490, 115);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 33);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Повернутися";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(490, 76);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 33);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистити";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sqlButton
            // 
            this.sqlButton.Location = new System.Drawing.Point(490, 37);
            this.sqlButton.Name = "sqlButton";
            this.sqlButton.Size = new System.Drawing.Size(119, 33);
            this.sqlButton.TabIndex = 7;
            this.sqlButton.Text = "Виконати запит";
            this.sqlButton.UseVisualStyleBackColor = true;
            this.sqlButton.Click += new System.EventHandler(this.sqlButton_Click);
            // 
            // queryDataGridView
            // 
            this.queryDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.queryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataGridView.Location = new System.Drawing.Point(60, 178);
            this.queryDataGridView.Name = "queryDataGridView";
            this.queryDataGridView.Size = new System.Drawing.Size(549, 199);
            this.queryDataGridView.TabIndex = 6;
            // 
            // queryInput
            // 
            this.queryInput.Location = new System.Drawing.Point(60, 44);
            this.queryInput.Name = "queryInput";
            this.queryInput.Size = new System.Drawing.Size(385, 110);
            this.queryInput.TabIndex = 5;
            this.queryInput.Text = "SELECT ";
            // 
            // QueryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Курсовая.Properties.Resources.back_pupil;
            this.ClientSize = new System.Drawing.Size(671, 416);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sqlButton);
            this.Controls.Add(this.queryDataGridView);
            this.Controls.Add(this.queryInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запит до даних";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryEdit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button sqlButton;
        private System.Windows.Forms.DataGridView queryDataGridView;
        private System.Windows.Forms.RichTextBox queryInput;
    }
}