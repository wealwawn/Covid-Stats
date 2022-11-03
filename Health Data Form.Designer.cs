
namespace Project1b
{
    partial class frmHealthData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHealthData));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picWelcomeBanner = new System.Windows.Forms.PictureBox();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripChooseCases = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripDeveloperLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCasesPer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVaccinated = new System.Windows.Forms.Button();
            this.btnTransmission = new System.Windows.Forms.Button();
            this.btnVaxByAge = new System.Windows.Forms.Button();
            this.btnCovidData = new System.Windows.Forms.Button();
            this.mnuHealthDataStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCasesPe100k = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommunityTransmission = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVaccinationsByAge = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVaccinated = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCovidData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCountyData = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCovidDataMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCountyDataMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dOHInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDOHInfo = new System.Windows.Forms.Button();
            this.dOHInfoMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcomeBanner)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.mnuHealthDataStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(90, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(164, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Justin\'s Health Data!";
            // 
            // picWelcomeBanner
            // 
            this.picWelcomeBanner.Image = ((System.Drawing.Image)(resources.GetObject("picWelcomeBanner.Image")));
            this.picWelcomeBanner.Location = new System.Drawing.Point(92, 47);
            this.picWelcomeBanner.Name = "picWelcomeBanner";
            this.picWelcomeBanner.Size = new System.Drawing.Size(182, 76);
            this.picWelcomeBanner.TabIndex = 1;
            this.picWelcomeBanner.TabStop = false;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripChooseCases,
            this.stripDeveloperLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 388);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(361, 22);
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // stripChooseCases
            // 
            this.stripChooseCases.Name = "stripChooseCases";
            this.stripChooseCases.Size = new System.Drawing.Size(177, 17);
            this.stripChooseCases.Text = "Click the Cases button for more!";
            // 
            // stripDeveloperLabel
            // 
            this.stripDeveloperLabel.Name = "stripDeveloperLabel";
            this.stripDeveloperLabel.Size = new System.Drawing.Size(94, 17);
            this.stripDeveloperLabel.Text = "by Justin Nunley";
            this.stripDeveloperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCasesPer
            // 
            this.btnCasesPer.Location = new System.Drawing.Point(10, 138);
            this.btnCasesPer.Name = "btnCasesPer";
            this.btnCasesPer.Size = new System.Drawing.Size(87, 70);
            this.btnCasesPer.TabIndex = 1;
            this.btnCasesPer.Text = "Cases Per 100k";
            this.btnCasesPer.UseVisualStyleBackColor = true;
            this.btnCasesPer.Click += new System.EventHandler(this.CasesButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(248, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // btnVaccinated
            // 
            this.btnVaccinated.Location = new System.Drawing.Point(123, 138);
            this.btnVaccinated.Name = "btnVaccinated";
            this.btnVaccinated.Size = new System.Drawing.Size(87, 70);
            this.btnVaccinated.TabIndex = 4;
            this.btnVaccinated.Text = "Vaccinated";
            this.btnVaccinated.UseVisualStyleBackColor = true;
            this.btnVaccinated.Click += new System.EventHandler(this.btnVaccinated_Click);
            // 
            // btnTransmission
            // 
            this.btnTransmission.Location = new System.Drawing.Point(10, 221);
            this.btnTransmission.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransmission.Name = "btnTransmission";
            this.btnTransmission.Size = new System.Drawing.Size(87, 70);
            this.btnTransmission.TabIndex = 5;
            this.btnTransmission.Text = "Community Transmission";
            this.btnTransmission.UseVisualStyleBackColor = true;
            this.btnTransmission.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVaxByAge
            // 
            this.btnVaxByAge.Location = new System.Drawing.Point(123, 221);
            this.btnVaxByAge.Name = "btnVaxByAge";
            this.btnVaxByAge.Size = new System.Drawing.Size(87, 70);
            this.btnVaxByAge.TabIndex = 6;
            this.btnVaxByAge.Text = "Vaccinations by Age";
            this.btnVaxByAge.UseVisualStyleBackColor = true;
            this.btnVaxByAge.Click += new System.EventHandler(this.btnVaxByAge_Click);
            // 
            // btnCovidData
            // 
            this.btnCovidData.Location = new System.Drawing.Point(248, 221);
            this.btnCovidData.Name = "btnCovidData";
            this.btnCovidData.Size = new System.Drawing.Size(87, 70);
            this.btnCovidData.TabIndex = 7;
            this.btnCovidData.Text = "COVID Data";
            this.btnCovidData.UseVisualStyleBackColor = true;
            this.btnCovidData.Click += new System.EventHandler(this.btnCovidData_Click);
            // 
            // mnuHealthDataStrip
            // 
            this.mnuHealthDataStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formsToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuHealthDataStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuHealthDataStrip.Name = "mnuHealthDataStrip";
            this.mnuHealthDataStrip.Size = new System.Drawing.Size(361, 24);
            this.mnuHealthDataStrip.TabIndex = 8;
            this.mnuHealthDataStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(93, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCasesPe100k,
            this.mnuCommunityTransmission,
            this.mnuVaccinationsByAge,
            this.mnuVaccinated,
            this.mnuCovidData,
            this.mnuCountyData,
            this.dOHInfoToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // mnuCasesPe100k
            // 
            this.mnuCasesPe100k.Name = "mnuCasesPe100k";
            this.mnuCasesPe100k.Size = new System.Drawing.Size(209, 22);
            this.mnuCasesPe100k.Text = "Cases Per 100k";
            this.mnuCasesPe100k.Click += new System.EventHandler(this.CasesButton_Click);
            // 
            // mnuCommunityTransmission
            // 
            this.mnuCommunityTransmission.Name = "mnuCommunityTransmission";
            this.mnuCommunityTransmission.Size = new System.Drawing.Size(209, 22);
            this.mnuCommunityTransmission.Text = "Community Transmission";
            this.mnuCommunityTransmission.Click += new System.EventHandler(this.button1_Click);
            // 
            // mnuVaccinationsByAge
            // 
            this.mnuVaccinationsByAge.Name = "mnuVaccinationsByAge";
            this.mnuVaccinationsByAge.Size = new System.Drawing.Size(209, 22);
            this.mnuVaccinationsByAge.Text = "Vaccinations by Age";
            this.mnuVaccinationsByAge.Click += new System.EventHandler(this.btnVaxByAge_Click);
            // 
            // mnuVaccinated
            // 
            this.mnuVaccinated.Name = "mnuVaccinated";
            this.mnuVaccinated.Size = new System.Drawing.Size(209, 22);
            this.mnuVaccinated.Text = "Vaccinated";
            this.mnuVaccinated.Click += new System.EventHandler(this.btnVaccinated_Click);
            // 
            // mnuCovidData
            // 
            this.mnuCovidData.Name = "mnuCovidData";
            this.mnuCovidData.Size = new System.Drawing.Size(209, 22);
            this.mnuCovidData.Text = "COVID Data";
            this.mnuCovidData.Click += new System.EventHandler(this.btnCovidData_Click);
            // 
            // mnuCountyData
            // 
            this.mnuCountyData.Name = "mnuCountyData";
            this.mnuCountyData.Size = new System.Drawing.Size(209, 22);
            this.mnuCountyData.Text = "County Data";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuCovidDataMaintenance,
            this.mnuCountyDataMaintenance,
            this.dOHInfoMaintenanceToolStripMenuItem,
            this.mnuLogout});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(212, 22);
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // mnuCovidDataMaintenance
            // 
            this.mnuCovidDataMaintenance.Name = "mnuCovidDataMaintenance";
            this.mnuCovidDataMaintenance.Size = new System.Drawing.Size(212, 22);
            this.mnuCovidDataMaintenance.Text = "COVID Data Maintenance";
            this.mnuCovidDataMaintenance.Visible = false;
            this.mnuCovidDataMaintenance.Click += new System.EventHandler(this.cOVIDDataToolStripMenuItem_Click);
            // 
            // mnuCountyDataMaintenance
            // 
            this.mnuCountyDataMaintenance.Name = "mnuCountyDataMaintenance";
            this.mnuCountyDataMaintenance.Size = new System.Drawing.Size(212, 22);
            this.mnuCountyDataMaintenance.Text = "County Data Maintenance";
            this.mnuCountyDataMaintenance.Visible = false;
            this.mnuCountyDataMaintenance.Click += new System.EventHandler(this.mnuCountyDataMaintenance_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Enabled = false;
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(212, 22);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dOHInfoToolStripMenuItem
            // 
            this.dOHInfoToolStripMenuItem.Name = "dOHInfoToolStripMenuItem";
            this.dOHInfoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.dOHInfoToolStripMenuItem.Text = "DOH Info";
            // 
            // btnDOHInfo
            // 
            this.btnDOHInfo.Location = new System.Drawing.Point(10, 306);
            this.btnDOHInfo.Name = "btnDOHInfo";
            this.btnDOHInfo.Size = new System.Drawing.Size(87, 70);
            this.btnDOHInfo.TabIndex = 9;
            this.btnDOHInfo.Text = "DOH Info";
            this.btnDOHInfo.UseVisualStyleBackColor = true;
            this.btnDOHInfo.Click += new System.EventHandler(this.btnDOHInfo_Click);
            // 
            // dOHInfoMaintenanceToolStripMenuItem
            // 
            this.dOHInfoMaintenanceToolStripMenuItem.Name = "dOHInfoMaintenanceToolStripMenuItem";
            this.dOHInfoMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.dOHInfoMaintenanceToolStripMenuItem.Text = "DOH Info Maintenance";
            this.dOHInfoMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.dOHInfoMaintenanceToolStripMenuItem_Click);
            // 
            // frmHealthData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 410);
            this.Controls.Add(this.btnDOHInfo);
            this.Controls.Add(this.btnCovidData);
            this.Controls.Add(this.btnVaxByAge);
            this.Controls.Add(this.btnTransmission);
            this.Controls.Add(this.btnVaccinated);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCasesPer);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.mnuHealthDataStrip);
            this.Controls.Add(this.picWelcomeBanner);
            this.Controls.Add(this.lblWelcome);
            this.MainMenuStrip = this.mnuHealthDataStrip;
            this.Name = "frmHealthData";
            this.Text = "Health Data";
            ((System.ComponentModel.ISupportInitialize)(this.picWelcomeBanner)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.mnuHealthDataStrip.ResumeLayout(false);
            this.mnuHealthDataStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picWelcomeBanner;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.Button btnCasesPer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripStatusLabel stripChooseCases;
        private System.Windows.Forms.ToolStripStatusLabel stripDeveloperLabel;
        private System.Windows.Forms.Button btnVaccinated;
        private System.Windows.Forms.Button btnTransmission;
        private System.Windows.Forms.Button btnVaxByAge;
        private System.Windows.Forms.Button btnCovidData;
        private System.Windows.Forms.MenuStrip mnuHealthDataStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCasesPe100k;
        private System.Windows.Forms.ToolStripMenuItem mnuCommunityTransmission;
        private System.Windows.Forms.ToolStripMenuItem mnuVaccinationsByAge;
        private System.Windows.Forms.ToolStripMenuItem mnuVaccinated;
        private System.Windows.Forms.ToolStripMenuItem mnuCovidData;
        private System.Windows.Forms.ToolStripMenuItem mnuCovidDataMaintenance;
        private System.Windows.Forms.ToolStripMenuItem mnuCountyDataMaintenance;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuCountyData;
        private System.Windows.Forms.ToolStripMenuItem dOHInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnDOHInfo;
        private System.Windows.Forms.ToolStripMenuItem dOHInfoMaintenanceToolStripMenuItem;
    }
}

