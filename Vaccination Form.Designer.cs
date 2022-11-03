
namespace Project1b
{
    partial class VaccinationForm
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
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblCountyName = new System.Windows.Forms.Label();
            this.lblPopulationTotal = new System.Windows.Forms.Label();
            this.lblNumVax = new System.Windows.Forms.Label();
            this.txtCountyName = new System.Windows.Forms.TextBox();
            this.txtPopulationTotal = new System.Windows.Forms.TextBox();
            this.txtNumVax = new System.Windows.Forms.TextBox();
            this.lblVaxResults = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Location = new System.Drawing.Point(9, 7);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(89, 13);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Vaccination Form";
            // 
            // lblCountyName
            // 
            this.lblCountyName.AutoSize = true;
            this.lblCountyName.Location = new System.Drawing.Point(11, 32);
            this.lblCountyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountyName.Name = "lblCountyName";
            this.lblCountyName.Size = new System.Drawing.Size(74, 13);
            this.lblCountyName.TabIndex = 1;
            this.lblCountyName.Text = "County Name:";
            // 
            // lblPopulationTotal
            // 
            this.lblPopulationTotal.AutoSize = true;
            this.lblPopulationTotal.Location = new System.Drawing.Point(11, 61);
            this.lblPopulationTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPopulationTotal.Name = "lblPopulationTotal";
            this.lblPopulationTotal.Size = new System.Drawing.Size(60, 13);
            this.lblPopulationTotal.TabIndex = 3;
            this.lblPopulationTotal.Text = "Population:";
            // 
            // lblNumVax
            // 
            this.lblNumVax.AutoSize = true;
            this.lblNumVax.Location = new System.Drawing.Point(11, 90);
            this.lblNumVax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumVax.Name = "lblNumVax";
            this.lblNumVax.Size = new System.Drawing.Size(104, 13);
            this.lblNumVax.TabIndex = 5;
            this.lblNumVax.Text = "Number Vaccinated:";
            // 
            // txtCountyName
            // 
            this.txtCountyName.Location = new System.Drawing.Point(130, 29);
            this.txtCountyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountyName.Name = "txtCountyName";
            this.txtCountyName.Size = new System.Drawing.Size(150, 20);
            this.txtCountyName.TabIndex = 2;
            this.txtCountyName.Text = " ";
            // 
            // txtPopulationTotal
            // 
            this.txtPopulationTotal.Location = new System.Drawing.Point(130, 58);
            this.txtPopulationTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPopulationTotal.Name = "txtPopulationTotal";
            this.txtPopulationTotal.Size = new System.Drawing.Size(150, 20);
            this.txtPopulationTotal.TabIndex = 4;
            // 
            // txtNumVax
            // 
            this.txtNumVax.Location = new System.Drawing.Point(130, 87);
            this.txtNumVax.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumVax.Name = "txtNumVax";
            this.txtNumVax.Size = new System.Drawing.Size(150, 20);
            this.txtNumVax.TabIndex = 6;
            // 
            // lblVaxResults
            // 
            this.lblVaxResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVaxResults.Location = new System.Drawing.Point(14, 120);
            this.lblVaxResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVaxResults.Name = "lblVaxResults";
            this.lblVaxResults.Size = new System.Drawing.Size(266, 84);
            this.lblVaxResults.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(11, 219);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(71, 19);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(109, 219);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 19);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(211, 219);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 19);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Clos&e";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // VaccinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 249);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblVaxResults);
            this.Controls.Add(this.txtNumVax);
            this.Controls.Add(this.txtPopulationTotal);
            this.Controls.Add(this.txtCountyName);
            this.Controls.Add(this.lblNumVax);
            this.Controls.Add(this.lblPopulationTotal);
            this.Controls.Add(this.lblCountyName);
            this.Controls.Add(this.lblFormName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VaccinationForm";
            this.Text = "Vaccination Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblCountyName;
        private System.Windows.Forms.Label lblPopulationTotal;
        private System.Windows.Forms.Label lblNumVax;
        private System.Windows.Forms.TextBox txtCountyName;
        private System.Windows.Forms.TextBox txtPopulationTotal;
        private System.Windows.Forms.TextBox txtNumVax;
        private System.Windows.Forms.Label lblVaxResults;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}