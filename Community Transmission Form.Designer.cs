
namespace Project1b
{
    partial class Form4
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
            this.dtpTransmissionsDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblCountyName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNewCases = new System.Windows.Forms.Label();
            this.lblPositivityRate = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCountyName = new System.Windows.Forms.TextBox();
            this.txtNewCases = new System.Windows.Forms.TextBox();
            this.txtPositivityRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpTransmissionsDatePicker
            // 
            this.dtpTransmissionsDatePicker.Location = new System.Drawing.Point(128, 74);
            this.dtpTransmissionsDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTransmissionsDatePicker.MaxDate = new System.DateTime(2029, 1, 1, 0, 0, 0, 0);
            this.dtpTransmissionsDatePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpTransmissionsDatePicker.Name = "dtpTransmissionsDatePicker";
            this.dtpTransmissionsDatePicker.Size = new System.Drawing.Size(151, 20);
            this.dtpTransmissionsDatePicker.TabIndex = 4;
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Location = new System.Drawing.Point(10, 11);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(148, 13);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Community Transmission Form";
            // 
            // lblCountyName
            // 
            this.lblCountyName.AutoSize = true;
            this.lblCountyName.Location = new System.Drawing.Point(13, 45);
            this.lblCountyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountyName.Name = "lblCountyName";
            this.lblCountyName.Size = new System.Drawing.Size(74, 13);
            this.lblCountyName.TabIndex = 1;
            this.lblCountyName.Text = "County Name:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 74);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // lblNewCases
            // 
            this.lblNewCases.AutoSize = true;
            this.lblNewCases.Location = new System.Drawing.Point(9, 113);
            this.lblNewCases.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewCases.Name = "lblNewCases";
            this.lblNewCases.Size = new System.Drawing.Size(116, 13);
            this.lblNewCases.TabIndex = 5;
            this.lblNewCases.Text = "New Cases (Per 100k):";
            // 
            // lblPositivityRate
            // 
            this.lblPositivityRate.AutoSize = true;
            this.lblPositivityRate.Location = new System.Drawing.Point(10, 150);
            this.lblPositivityRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPositivityRate.Name = "lblPositivityRate";
            this.lblPositivityRate.Size = new System.Drawing.Size(77, 13);
            this.lblPositivityRate.TabIndex = 7;
            this.lblPositivityRate.Text = "Positivity Rate:";
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(26, 206);
            this.lblResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(253, 70);
            this.lblResults.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(26, 310);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(56, 19);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(121, 310);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 19);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(222, 310);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 19);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCountyName
            // 
            this.txtCountyName.Location = new System.Drawing.Point(128, 41);
            this.txtCountyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCountyName.Name = "txtCountyName";
            this.txtCountyName.Size = new System.Drawing.Size(151, 20);
            this.txtCountyName.TabIndex = 2;
            // 
            // txtNewCases
            // 
            this.txtNewCases.Location = new System.Drawing.Point(128, 113);
            this.txtNewCases.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewCases.Name = "txtNewCases";
            this.txtNewCases.Size = new System.Drawing.Size(151, 20);
            this.txtNewCases.TabIndex = 6;
            // 
            // txtPositivityRate
            // 
            this.txtPositivityRate.Location = new System.Drawing.Point(128, 147);
            this.txtPositivityRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPositivityRate.Name = "txtPositivityRate";
            this.txtPositivityRate.Size = new System.Drawing.Size(151, 20);
            this.txtPositivityRate.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 343);
            this.Controls.Add(this.txtPositivityRate);
            this.Controls.Add(this.txtNewCases);
            this.Controls.Add(this.txtCountyName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblPositivityRate);
            this.Controls.Add(this.lblNewCases);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCountyName);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.dtpTransmissionsDatePicker);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Community Transmission Form";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTransmissionsDatePicker;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblCountyName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNewCases;
        private System.Windows.Forms.Label lblPositivityRate;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtCountyName;
        private System.Windows.Forms.TextBox txtNewCases;
        private System.Windows.Forms.TextBox txtPositivityRate;
    }
}