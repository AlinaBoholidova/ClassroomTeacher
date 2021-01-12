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
            this.exitButton.Location = new System.Drawing.Point(442, 98);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Повернутися";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(442, 68);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(113, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Очистити";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sqlButton
            // 
            this.sqlButton.Location = new System.Drawing.Point(442, 38);
            this.sqlButton.Name = "sqlButton";
            this.sqlButton.Size = new System.Drawing.Size(113, 23);
            this.sqlButton.TabIndex = 7;
            this.sqlButton.Text = "Виконати запит";
            this.sqlButton.UseVisualStyleBackColor = true;
            this.sqlButton.Click += new System.EventHandler(this.sqlButton_Click);
            // 
            // queryDataGridView
            // 
            this.queryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataGridView.Location = new System.Drawing.Point(26, 133);
            this.queryDataGridView.Name = "queryDataGridView";
            this.queryDataGridView.Size = new System.Drawing.Size(549, 199);
            this.queryDataGridView.TabIndex = 6;
            // 
            // queryInput
            // 
            this.queryInput.Location = new System.Drawing.Point(26, 36);
            this.queryInput.Name = "queryInput";
            this.queryInput.Size = new System.Drawing.Size(385, 91);
            this.queryInput.TabIndex = 5;
            this.queryInput.Text = "SELECT ";
            // 
            // QueryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 369);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sqlButton);
            this.Controls.Add(this.queryDataGridView);
            this.Controls.Add(this.queryInput);
            this.Name = "QueryEdit";
            this.Text = "Запит до даних";
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