namespace TestWebService
{
    partial class uxForm
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
            this.uxSearch = new System.Windows.Forms.Button();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxNameList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxNameList)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSearch
            // 
            this.uxSearch.Location = new System.Drawing.Point(324, 26);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(75, 23);
            this.uxSearch.TabIndex = 0;
            this.uxSearch.Text = "Search";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(148, 28);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(170, 20);
            this.uxFirstName.TabIndex = 1;
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Location = new System.Drawing.Point(85, 31);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(57, 13);
            this.uxNameLabel.TabIndex = 2;
            this.uxNameLabel.Text = "First Name";
            // 
            // uxNameList
            // 
            this.uxNameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxNameList.Location = new System.Drawing.Point(12, 55);
            this.uxNameList.Name = "uxNameList";
            this.uxNameList.Size = new System.Drawing.Size(576, 278);
            this.uxNameList.TabIndex = 3;
            // 
            // uxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 345);
            this.Controls.Add(this.uxNameList);
            this.Controls.Add(this.uxNameLabel);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.uxSearch);
            this.Name = "uxForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uxNameList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSearch;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.DataGridView uxNameList;
    }
}

