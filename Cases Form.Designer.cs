
namespace Project1b
{
    partial class frmCases
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
            this.lblCasesForm = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtNumCasesInput = new System.Windows.Forms.TextBox();
            this.txtPopulationInput = new System.Windows.Forms.TextBox();
            this.lblNumCasesInput = new System.Windows.Forms.Label();
            this.lblPopulationInput = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResultCasesPer = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCasesForm
            // 
            this.lblCasesForm.AutoSize = true;
            this.lblCasesForm.Location = new System.Drawing.Point(13, 9);
            this.lblCasesForm.Name = "lblCasesForm";
            this.lblCasesForm.Size = new System.Drawing.Size(131, 13);
            this.lblCasesForm.TabIndex = 0;
            this.lblCasesForm.Text = "Cases per 100k Calculator";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtNumCasesInput);
            this.grpInput.Controls.Add(this.txtPopulationInput);
            this.grpInput.Controls.Add(this.lblNumCasesInput);
            this.grpInput.Controls.Add(this.lblPopulationInput);
            this.grpInput.Location = new System.Drawing.Point(12, 74);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(320, 107);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // txtNumCasesInput
            // 
            this.txtNumCasesInput.Location = new System.Drawing.Point(168, 65);
            this.txtNumCasesInput.Name = "txtNumCasesInput";
            this.txtNumCasesInput.Size = new System.Drawing.Size(146, 20);
            this.txtNumCasesInput.TabIndex = 3;
            // 
            // txtPopulationInput
            // 
            this.txtPopulationInput.Location = new System.Drawing.Point(168, 25);
            this.txtPopulationInput.Name = "txtPopulationInput";
            this.txtPopulationInput.Size = new System.Drawing.Size(146, 20);
            this.txtPopulationInput.TabIndex = 1;
            // 
            // lblNumCasesInput
            // 
            this.lblNumCasesInput.AutoSize = true;
            this.lblNumCasesInput.Location = new System.Drawing.Point(1, 65);
            this.lblNumCasesInput.Name = "lblNumCasesInput";
            this.lblNumCasesInput.Size = new System.Drawing.Size(91, 13);
            this.lblNumCasesInput.TabIndex = 2;
            this.lblNumCasesInput.Text = "Number of Cases:";
            this.lblNumCasesInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPopulationInput
            // 
            this.lblPopulationInput.AutoSize = true;
            this.lblPopulationInput.Location = new System.Drawing.Point(1, 25);
            this.lblPopulationInput.Name = "lblPopulationInput";
            this.lblPopulationInput.Size = new System.Drawing.Size(60, 13);
            this.lblPopulationInput.TabIndex = 0;
            this.lblPopulationInput.Text = "Population:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 362);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.casesSubmitButton_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(180, 362);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.casesClearButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(357, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.casesExitButton_Click);
            // 
            // lblResultCasesPer
            // 
            this.lblResultCasesPer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultCasesPer.Location = new System.Drawing.Point(13, 207);
            this.lblResultCasesPer.MaximumSize = new System.Drawing.Size(500, 500);
            this.lblResultCasesPer.Name = "lblResultCasesPer";
            this.lblResultCasesPer.Padding = new System.Windows.Forms.Padding(2);
            this.lblResultCasesPer.Size = new System.Drawing.Size(319, 121);
            this.lblResultCasesPer.TabIndex = 2;
            // 
            // frmCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.lblResultCasesPer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblCasesForm);
            this.Name = "frmCases";
            this.Text = "Cases Form";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCasesForm;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtNumCasesInput;
        private System.Windows.Forms.TextBox txtPopulationInput;
        private System.Windows.Forms.Label lblNumCasesInput;
        private System.Windows.Forms.Label lblPopulationInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResultCasesPer;
    }
}