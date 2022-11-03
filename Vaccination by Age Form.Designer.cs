
namespace Project1b
{
    partial class Form5
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
            System.Windows.Forms.Label lblAge;
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.dtpTransmissionsDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lstAgeRange = new System.Windows.Forms.ListBox();
            this.lstNumVax = new System.Windows.Forms.ListBox();
            this.lblNumVax = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblNumVax1 = new System.Windows.Forms.Label();
            this.txtNumVax = new System.Windows.Forms.TextBox();
            lblAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new System.Drawing.Point(12, 129);
            lblAge.Name = "lblAge";
            lblAge.Size = new System.Drawing.Size(61, 13);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age Range";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(10, 33);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(74, 13);
            this.lblCounty.TabIndex = 1;
            this.lblCounty.Text = "County Name:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(141, 33);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(151, 20);
            this.txtCounty.TabIndex = 2;
            // 
            // dtpTransmissionsDatePicker
            // 
            this.dtpTransmissionsDatePicker.Location = new System.Drawing.Point(141, 69);
            this.dtpTransmissionsDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTransmissionsDatePicker.MaxDate = new System.DateTime(2029, 1, 1, 0, 0, 0, 0);
            this.dtpTransmissionsDatePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpTransmissionsDatePicker.Name = "dtpTransmissionsDatePicker";
            this.dtpTransmissionsDatePicker.Size = new System.Drawing.Size(151, 20);
            this.dtpTransmissionsDatePicker.TabIndex = 4;
            // 
            // lstAgeRange
            // 
            this.lstAgeRange.FormattingEnabled = true;
            this.lstAgeRange.Items.AddRange(new object[] {
            "5-11",
            "12-19",
            "20-29",
            "30-39",
            "40-49",
            "50-59",
            "60-64",
            "65+"});
            this.lstAgeRange.Location = new System.Drawing.Point(15, 145);
            this.lstAgeRange.Name = "lstAgeRange";
            this.lstAgeRange.Size = new System.Drawing.Size(120, 108);
            this.lstAgeRange.TabIndex = 9;
            // 
            // lstNumVax
            // 
            this.lstNumVax.FormattingEnabled = true;
            this.lstNumVax.Items.AddRange(new object[] {
            "---",
            "---",
            "---",
            "---",
            "---",
            "---",
            "---",
            "---"});
            this.lstNumVax.Location = new System.Drawing.Point(169, 145);
            this.lstNumVax.Name = "lstNumVax";
            this.lstNumVax.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstNumVax.Size = new System.Drawing.Size(120, 108);
            this.lstNumVax.TabIndex = 10;
            // 
            // lblNumVax
            // 
            this.lblNumVax.AutoSize = true;
            this.lblNumVax.Location = new System.Drawing.Point(169, 129);
            this.lblNumVax.Name = "lblNumVax";
            this.lblNumVax.Size = new System.Drawing.Size(120, 13);
            this.lblNumVax.TabIndex = 8;
            this.lblNumVax.Text = "Number of Vaccinations";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(9, 267);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(280, 139);
            this.lblOutput.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(4, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(109, 438);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(109, 409);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(214, 409);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Location = new System.Drawing.Point(13, 4);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(105, 13);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Vaccinations By Age";
            // 
            // lblNumVax1
            // 
            this.lblNumVax1.AutoSize = true;
            this.lblNumVax1.Location = new System.Drawing.Point(12, 106);
            this.lblNumVax1.Name = "lblNumVax1";
            this.lblNumVax1.Size = new System.Drawing.Size(120, 13);
            this.lblNumVax1.TabIndex = 5;
            this.lblNumVax1.Text = "Number of Vaccinations";
            // 
            // txtNumVax
            // 
            this.txtNumVax.Location = new System.Drawing.Point(142, 103);
            this.txtNumVax.Name = "txtNumVax";
            this.txtNumVax.Size = new System.Drawing.Size(150, 20);
            this.txtNumVax.TabIndex = 6;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 464);
            this.Controls.Add(this.txtNumVax);
            this.Controls.Add(this.lblNumVax1);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lstNumVax);
            this.Controls.Add(this.lblNumVax);
            this.Controls.Add(this.lstAgeRange);
            this.Controls.Add(this.dtpTransmissionsDatePicker);
            this.Controls.Add(lblAge);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCounty);
            this.Name = "Form5";
            this.Text = "Vaccinations By Age";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.DateTimePicker dtpTransmissionsDatePicker;
        private System.Windows.Forms.ListBox lstAgeRange;
        private System.Windows.Forms.ListBox lstNumVax;
        private System.Windows.Forms.Label lblNumVax;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblNumVax1;
        private System.Windows.Forms.TextBox txtNumVax;
    }
}