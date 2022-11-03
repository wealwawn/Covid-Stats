
namespace Project1b
{
    partial class DOHInfo_Maintenance
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
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeaderZipCode = new System.Windows.Forms.Label();
            this.lblHeaderState = new System.Windows.Forms.Label();
            this.lblHeaderCity = new System.Windows.Forms.Label();
            this.lblHeaderStreetAddress = new System.Windows.Forms.Label();
            this.lblHeaderPhoneNumber = new System.Windows.Forms.Label();
            this.lblHeaderDescription = new System.Windows.Forms.Label();
            this.lblHeaderCounty = new System.Windows.Forms.Label();
            this.diaOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.diaSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(118, 13);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(155, 20);
            this.txtCounty.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(118, 52);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(155, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(117, 91);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(155, 20);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(118, 135);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(155, 20);
            this.txtStreetAddress.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(118, 179);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(117, 224);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(155, 20);
            this.txtState.TabIndex = 11;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(118, 269);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(155, 20);
            this.txtZipCode.TabIndex = 13;
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(16, 310);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(256, 149);
            this.lblResults.TabIndex = 0;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(18, 478);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 23);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(149, 478);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(150, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeaderZipCode
            // 
            this.lblHeaderZipCode.AutoSize = true;
            this.lblHeaderZipCode.Location = new System.Drawing.Point(13, 278);
            this.lblHeaderZipCode.Name = "lblHeaderZipCode";
            this.lblHeaderZipCode.Size = new System.Drawing.Size(53, 13);
            this.lblHeaderZipCode.TabIndex = 12;
            this.lblHeaderZipCode.Text = "Zip Code:";
            // 
            // lblHeaderState
            // 
            this.lblHeaderState.AutoSize = true;
            this.lblHeaderState.Location = new System.Drawing.Point(12, 235);
            this.lblHeaderState.Name = "lblHeaderState";
            this.lblHeaderState.Size = new System.Drawing.Size(35, 13);
            this.lblHeaderState.TabIndex = 10;
            this.lblHeaderState.Text = "State:";
            // 
            // lblHeaderCity
            // 
            this.lblHeaderCity.AutoSize = true;
            this.lblHeaderCity.Location = new System.Drawing.Point(13, 185);
            this.lblHeaderCity.Name = "lblHeaderCity";
            this.lblHeaderCity.Size = new System.Drawing.Size(27, 13);
            this.lblHeaderCity.TabIndex = 8;
            this.lblHeaderCity.Text = "City:";
            // 
            // lblHeaderStreetAddress
            // 
            this.lblHeaderStreetAddress.AutoSize = true;
            this.lblHeaderStreetAddress.Location = new System.Drawing.Point(13, 137);
            this.lblHeaderStreetAddress.Name = "lblHeaderStreetAddress";
            this.lblHeaderStreetAddress.Size = new System.Drawing.Size(79, 13);
            this.lblHeaderStreetAddress.TabIndex = 6;
            this.lblHeaderStreetAddress.Text = "Street Address:";
            // 
            // lblHeaderPhoneNumber
            // 
            this.lblHeaderPhoneNumber.AutoSize = true;
            this.lblHeaderPhoneNumber.Location = new System.Drawing.Point(12, 92);
            this.lblHeaderPhoneNumber.Name = "lblHeaderPhoneNumber";
            this.lblHeaderPhoneNumber.Size = new System.Drawing.Size(84, 13);
            this.lblHeaderPhoneNumber.TabIndex = 4;
            this.lblHeaderPhoneNumber.Text = "Phone Number :";
            // 
            // lblHeaderDescription
            // 
            this.lblHeaderDescription.AutoSize = true;
            this.lblHeaderDescription.Location = new System.Drawing.Point(13, 52);
            this.lblHeaderDescription.Name = "lblHeaderDescription";
            this.lblHeaderDescription.Size = new System.Drawing.Size(63, 13);
            this.lblHeaderDescription.TabIndex = 2;
            this.lblHeaderDescription.Text = "Description:";
            // 
            // lblHeaderCounty
            // 
            this.lblHeaderCounty.AutoSize = true;
            this.lblHeaderCounty.Location = new System.Drawing.Point(13, 16);
            this.lblHeaderCounty.Name = "lblHeaderCounty";
            this.lblHeaderCounty.Size = new System.Drawing.Size(40, 13);
            this.lblHeaderCounty.TabIndex = 0;
            this.lblHeaderCounty.Text = "County";
            // 
            // diaOpenFile
            // 
            this.diaOpenFile.FileName = "diaOpenFile";
            // 
            // DOHInfo_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 555);
            this.Controls.Add(this.lblHeaderZipCode);
            this.Controls.Add(this.lblHeaderState);
            this.Controls.Add(this.lblHeaderCity);
            this.Controls.Add(this.lblHeaderStreetAddress);
            this.Controls.Add(this.lblHeaderPhoneNumber);
            this.Controls.Add(this.lblHeaderDescription);
            this.Controls.Add(this.lblHeaderCounty);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCounty);
            this.Name = "DOHInfo_Maintenance";
            this.Text = "DOH Info Maintentance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeaderZipCode;
        private System.Windows.Forms.Label lblHeaderState;
        private System.Windows.Forms.Label lblHeaderCity;
        private System.Windows.Forms.Label lblHeaderStreetAddress;
        private System.Windows.Forms.Label lblHeaderPhoneNumber;
        private System.Windows.Forms.Label lblHeaderDescription;
        private System.Windows.Forms.Label lblHeaderCounty;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.OpenFileDialog diaOpenFile;
        private System.Windows.Forms.SaveFileDialog diaSaveFile;
    }
}