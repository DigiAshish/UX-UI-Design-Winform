namespace Asg4_axm160031
{
    partial class Form1
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
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.Filename = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(83, 35);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(445, 20);
            this.tbFilename.TabIndex = 0;
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(83, 72);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(444, 20);
            this.tbKeyword.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(563, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 24);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(563, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.Location = new System.Drawing.Point(23, 129);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(681, 329);
            this.lbDisplay.TabIndex = 4;
            // 
            // Filename
            // 
            this.Filename.AutoSize = true;
            this.Filename.Location = new System.Drawing.Point(18, 38);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(49, 13);
            this.Filename.TabIndex = 5;
            this.Filename.Text = "Filename";
            // 
            // keyword
            // 
            this.keyword.AutoSize = true;
            this.keyword.Location = new System.Drawing.Point(19, 79);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(48, 13);
            this.keyword.TabIndex = 6;
            this.keyword.Text = "Keyword";
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(89, 103);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 13);
            this.lblNotification.TabIndex = 7;
            this.lblNotification.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 485);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.tbFilename);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.Label Filename;
        private System.Windows.Forms.Label keyword;
        private System.Windows.Forms.Label lblNotification;
    }
}

