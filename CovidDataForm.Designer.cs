
namespace Project1b
{
    partial class CovidDataForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleVaccinatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percent5VaccinatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casePositivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newPeopleVaccinatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCasePositivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casesPer100KPopulationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOVIDDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOVIDDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOVID_DBDataSet = new Project1b.COVID_DBDataSet();
            this.covidDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCountySearch = new System.Windows.Forms.Button();
            this.btnMinCaseAmt = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblMinCases = new System.Windows.Forms.Label();
            this.lblDisplayAll = new System.Windows.Forms.Label();
            this.txtCountySearch = new System.Windows.Forms.TextBox();
            this.txtMinCasesAmt = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cOVID_DataTableAdapter = new Project1b.COVID_DBDataSetTableAdapters.COVID_DataTableAdapter();
            this.countySearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.valueToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.valueToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.countySearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVIDDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVIDDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.countyIDDataGridViewTextBoxColumn,
            this.peopleVaccinatedDataGridViewTextBoxColumn,
            this.percent5VaccinatedDataGridViewTextBoxColumn,
            this.casesDataGridViewTextBoxColumn,
            this.casePositivityDataGridViewTextBoxColumn,
            this.newPeopleVaccinatedDataGridViewTextBoxColumn,
            this.newCasesDataGridViewTextBoxColumn,
            this.newCasePositivityDataGridViewTextBoxColumn,
            this.casesPer100KPopulationDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOVIDDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 391);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countyIDDataGridViewTextBoxColumn
            // 
            this.countyIDDataGridViewTextBoxColumn.DataPropertyName = "County_ID";
            this.countyIDDataGridViewTextBoxColumn.HeaderText = "County_ID";
            this.countyIDDataGridViewTextBoxColumn.Name = "countyIDDataGridViewTextBoxColumn";
            this.countyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peopleVaccinatedDataGridViewTextBoxColumn
            // 
            this.peopleVaccinatedDataGridViewTextBoxColumn.DataPropertyName = "People_Vaccinated";
            this.peopleVaccinatedDataGridViewTextBoxColumn.HeaderText = "People_Vaccinated";
            this.peopleVaccinatedDataGridViewTextBoxColumn.Name = "peopleVaccinatedDataGridViewTextBoxColumn";
            this.peopleVaccinatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percent5VaccinatedDataGridViewTextBoxColumn
            // 
            this.percent5VaccinatedDataGridViewTextBoxColumn.DataPropertyName = "Percent_5+_Vaccinated";
            this.percent5VaccinatedDataGridViewTextBoxColumn.HeaderText = "Percent_5+_Vaccinated";
            this.percent5VaccinatedDataGridViewTextBoxColumn.Name = "percent5VaccinatedDataGridViewTextBoxColumn";
            this.percent5VaccinatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // casesDataGridViewTextBoxColumn
            // 
            this.casesDataGridViewTextBoxColumn.DataPropertyName = "Cases";
            this.casesDataGridViewTextBoxColumn.HeaderText = "Cases";
            this.casesDataGridViewTextBoxColumn.Name = "casesDataGridViewTextBoxColumn";
            this.casesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // casePositivityDataGridViewTextBoxColumn
            // 
            this.casePositivityDataGridViewTextBoxColumn.DataPropertyName = "Case_Positivity";
            this.casePositivityDataGridViewTextBoxColumn.HeaderText = "Case_Positivity";
            this.casePositivityDataGridViewTextBoxColumn.Name = "casePositivityDataGridViewTextBoxColumn";
            this.casePositivityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newPeopleVaccinatedDataGridViewTextBoxColumn
            // 
            this.newPeopleVaccinatedDataGridViewTextBoxColumn.DataPropertyName = "New_People_Vaccinated";
            this.newPeopleVaccinatedDataGridViewTextBoxColumn.HeaderText = "New_People_Vaccinated";
            this.newPeopleVaccinatedDataGridViewTextBoxColumn.Name = "newPeopleVaccinatedDataGridViewTextBoxColumn";
            this.newPeopleVaccinatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newCasesDataGridViewTextBoxColumn
            // 
            this.newCasesDataGridViewTextBoxColumn.DataPropertyName = "New_Cases";
            this.newCasesDataGridViewTextBoxColumn.HeaderText = "New_Cases";
            this.newCasesDataGridViewTextBoxColumn.Name = "newCasesDataGridViewTextBoxColumn";
            this.newCasesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // newCasePositivityDataGridViewTextBoxColumn
            // 
            this.newCasePositivityDataGridViewTextBoxColumn.DataPropertyName = "New_Case_Positivity";
            this.newCasePositivityDataGridViewTextBoxColumn.HeaderText = "New_Case_Positivity";
            this.newCasePositivityDataGridViewTextBoxColumn.Name = "newCasePositivityDataGridViewTextBoxColumn";
            this.newCasePositivityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // casesPer100KPopulationDataGridViewTextBoxColumn
            // 
            this.casesPer100KPopulationDataGridViewTextBoxColumn.DataPropertyName = "Cases_Per_100K_Population";
            this.casesPer100KPopulationDataGridViewTextBoxColumn.HeaderText = "Cases_Per_100K_Population";
            this.casesPer100KPopulationDataGridViewTextBoxColumn.Name = "casesPer100KPopulationDataGridViewTextBoxColumn";
            this.casesPer100KPopulationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            this.reportDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOVIDDataBindingSource
            // 
            this.cOVIDDataBindingSource.DataMember = "COVID_Data";
            this.cOVIDDataBindingSource.DataSource = this.cOVIDDBDataSetBindingSource;
            // 
            // cOVIDDBDataSetBindingSource
            // 
            this.cOVIDDBDataSetBindingSource.DataSource = this.cOVID_DBDataSet;
            this.cOVIDDBDataSetBindingSource.Position = 0;
            // 
            // cOVID_DBDataSet
            // 
            this.cOVID_DBDataSet.DataSetName = "COVID_DBDataSet";
            this.cOVID_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCountySearch
            // 
            this.btnCountySearch.Location = new System.Drawing.Point(24, 523);
            this.btnCountySearch.Name = "btnCountySearch";
            this.btnCountySearch.Size = new System.Drawing.Size(75, 23);
            this.btnCountySearch.TabIndex = 7;
            this.btnCountySearch.Text = "Filter";
            this.btnCountySearch.UseVisualStyleBackColor = true;
            this.btnCountySearch.Click += new System.EventHandler(this.btnCountySearch_Click);
            // 
            // btnMinCaseAmt
            // 
            this.btnMinCaseAmt.Location = new System.Drawing.Point(180, 523);
            this.btnMinCaseAmt.Name = "btnMinCaseAmt";
            this.btnMinCaseAmt.Size = new System.Drawing.Size(75, 23);
            this.btnMinCaseAmt.TabIndex = 8;
            this.btnMinCaseAmt.Text = "Filter";
            this.btnMinCaseAmt.UseVisualStyleBackColor = true;
            this.btnMinCaseAmt.Click += new System.EventHandler(this.btnMinCaseAmt_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(336, 523);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayAll.TabIndex = 9;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(21, 467);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(91, 13);
            this.lblCounty.TabIndex = 2;
            this.lblCounty.Text = "Search by County";
            // 
            // lblMinCases
            // 
            this.lblMinCases.AutoSize = true;
            this.lblMinCases.Location = new System.Drawing.Point(154, 467);
            this.lblMinCases.Name = "lblMinCases";
            this.lblMinCases.Size = new System.Drawing.Size(114, 13);
            this.lblMinCases.TabIndex = 3;
            this.lblMinCases.Text = "Minimum Case Amount";
            // 
            // lblDisplayAll
            // 
            this.lblDisplayAll.AutoSize = true;
            this.lblDisplayAll.Location = new System.Drawing.Point(333, 467);
            this.lblDisplayAll.Name = "lblDisplayAll";
            this.lblDisplayAll.Size = new System.Drawing.Size(81, 13);
            this.lblDisplayAll.TabIndex = 4;
            this.lblDisplayAll.Text = "Display All Data";
            // 
            // txtCountySearch
            // 
            this.txtCountySearch.Location = new System.Drawing.Point(12, 497);
            this.txtCountySearch.Name = "txtCountySearch";
            this.txtCountySearch.Size = new System.Drawing.Size(121, 20);
            this.txtCountySearch.TabIndex = 5;
            // 
            // txtMinCasesAmt
            // 
            this.txtMinCasesAmt.Location = new System.Drawing.Point(157, 497);
            this.txtMinCasesAmt.Name = "txtMinCasesAmt";
            this.txtMinCasesAmt.Size = new System.Drawing.Size(121, 20);
            this.txtMinCasesAmt.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(457, 523);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cOVID_DataTableAdapter
            // 
            this.cOVID_DataTableAdapter.ClearBeforeFill = true;
            // 
            // countySearchToolStrip
            // 
            this.countySearchToolStrip.Location = new System.Drawing.Point(0, 0);
            this.countySearchToolStrip.Name = "countySearchToolStrip";
            this.countySearchToolStrip.Size = new System.Drawing.Size(1168, 25);
            this.countySearchToolStrip.TabIndex = 0;
            // 
            // valueToolStripLabel1
            // 
            this.valueToolStripLabel1.Name = "valueToolStripLabel1";
            this.valueToolStripLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // valueToolStripTextBox1
            // 
            this.valueToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.valueToolStripTextBox1.Name = "valueToolStripTextBox1";
            this.valueToolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // countySearchToolStripButton
            // 
            this.countySearchToolStripButton.Name = "countySearchToolStripButton";
            this.countySearchToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // CovidDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 566);
            this.Controls.Add(this.countySearchToolStrip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtMinCasesAmt);
            this.Controls.Add(this.txtCountySearch);
            this.Controls.Add(this.lblDisplayAll);
            this.Controls.Add(this.lblMinCases);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnMinCaseAmt);
            this.Controls.Add(this.btnCountySearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CovidDataForm";
            this.Text = "Covid Data Form";
            this.Load += new System.EventHandler(this.CovidDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVIDDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVIDDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource covidDataDataSetBindingSource;
        private System.Windows.Forms.BindingSource cOVIDDBDataSetBindingSource;
        private COVID_DBDataSet cOVID_DBDataSet;
        private System.Windows.Forms.BindingSource cOVIDDataBindingSource;
        private COVID_DBDataSetTableAdapters.COVID_DataTableAdapter cOVID_DataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleVaccinatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percent5VaccinatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casePositivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newPeopleVaccinatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newCasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newCasePositivityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casesPer100KPopulationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCountySearch;
        private System.Windows.Forms.Button btnMinCaseAmt;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblMinCases;
        private System.Windows.Forms.Label lblDisplayAll;
        private System.Windows.Forms.TextBox txtCountySearch;
        private System.Windows.Forms.TextBox txtMinCasesAmt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStrip countySearchToolStrip;
        private System.Windows.Forms.ToolStripLabel valueToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox valueToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton countySearchToolStripButton;
    }
}