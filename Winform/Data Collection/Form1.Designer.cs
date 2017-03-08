namespace Asg2_axm160031
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbProofOfPurchase = new System.Windows.Forms.ComboBox();
            this.dtDateRecieved = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbDataView = new System.Windows.Forms.ListBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbNotification = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(396, 31);
            this.tbFirstName.MaxLength = 20;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(128, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Text = "\r\n";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(530, 31);
            this.tbMiddleName.MaxLength = 1;
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(25, 20);
            this.tbMiddleName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(561, 31);
            this.tbLastName.MaxLength = 20;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(133, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // tbAddress1
            // 
            this.tbAddress1.Location = new System.Drawing.Point(398, 71);
            this.tbAddress1.MaxLength = 35;
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(295, 20);
            this.tbAddress1.TabIndex = 4;
            // 
            // tbAddress2
            // 
            this.tbAddress2.Location = new System.Drawing.Point(398, 107);
            this.tbAddress2.MaxLength = 35;
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(296, 20);
            this.tbAddress2.TabIndex = 5;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(398, 145);
            this.tbCity.MaxLength = 25;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(205, 20);
            this.tbCity.TabIndex = 6;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(398, 187);
            this.tbState.MaxLength = 2;
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(29, 20);
            this.tbState.TabIndex = 7;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(451, 187);
            this.tbZipCode.MaxLength = 9;
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(84, 20);
            this.tbZipCode.TabIndex = 9;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(398, 227);
            this.tbPhone.MaxLength = 21;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(180, 20);
            this.tbPhone.TabIndex = 10;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(398, 271);
            this.tbEmail.MaxLength = 60;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(295, 20);
            this.tbEmail.TabIndex = 11;
            // 
            // cbProofOfPurchase
            // 
            this.cbProofOfPurchase.FormattingEnabled = true;
            this.cbProofOfPurchase.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbProofOfPurchase.Location = new System.Drawing.Point(398, 311);
            this.cbProofOfPurchase.Name = "cbProofOfPurchase";
            this.cbProofOfPurchase.Size = new System.Drawing.Size(49, 21);
            this.cbProofOfPurchase.TabIndex = 12;
            // 
            // dtDateRecieved
            // 
            this.dtDateRecieved.Location = new System.Drawing.Point(398, 355);
            this.dtDateRecieved.Name = "dtDateRecieved";
            this.dtDateRecieved.Size = new System.Drawing.Size(191, 20);
            this.dtDateRecieved.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(404, 406);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 37);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbDataView
            // 
            this.lbDataView.FormattingEnabled = true;
            this.lbDataView.Location = new System.Drawing.Point(22, 22);
            this.lbDataView.Name = "lbDataView";
            this.lbDataView.Size = new System.Drawing.Size(356, 394);
            this.lbDataView.Sorted = true;
            this.lbDataView.TabIndex = 16;
            this.lbDataView.SelectedIndexChanged += new System.EventHandler(this.lbDataView_SelectedIndexChanged);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(33, 434);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(88, 33);
            this.btnModify.TabIndex = 17;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(144, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 33);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(530, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 36);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbNotification
            // 
            this.tbNotification.BackColor = System.Drawing.SystemColors.Control;
            this.tbNotification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNotification.Location = new System.Drawing.Point(396, 465);
            this.tbNotification.Name = "tbNotification";
            this.tbNotification.Size = new System.Drawing.Size(287, 13);
            this.tbNotification.TabIndex = 20;
            this.tbNotification.Visible = false;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(255, 434);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(90, 33);
            this.btRefresh.TabIndex = 21;
            this.btRefresh.Text = "Refresh List";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 511);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.tbNotification);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lbDataView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDateRecieved);
            this.Controls.Add(this.cbProofOfPurchase);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.tbAddress1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbProofOfPurchase;
        private System.Windows.Forms.DateTimePicker dtDateRecieved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lbDataView;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbNotification;
        private System.Windows.Forms.Button btRefresh;
    }
}

