
namespace Project1b
{
    partial class CovidDataMaintenanceForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label county_IDLabel;
            System.Windows.Forms.Label people_VaccinatedLabel;
            System.Windows.Forms.Label percent_5__VaccinatedLabel;
            System.Windows.Forms.Label casesLabel;
            System.Windows.Forms.Label case_PositivityLabel;
            System.Windows.Forms.Label new_People_VaccinatedLabel;
            System.Windows.Forms.Label new_CasesLabel;
            System.Windows.Forms.Label new_Case_PositivityLabel;
            System.Windows.Forms.Label cases_Per_100K_PopulationLabel;
            System.Windows.Forms.Label report_DateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CovidDataMaintenanceForm));
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.cOVID_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOVID_DBDataSet = new Project1b.COVID_DBDataSet();
            this.county_IDTextBox = new System.Windows.Forms.TextBox();
            this.people_VaccinatedTextBox = new System.Windows.Forms.TextBox();
            this.percent_5__VaccinatedTextBox = new System.Windows.Forms.TextBox();
            this.casesTextBox = new System.Windows.Forms.TextBox();
            this.case_PositivityTextBox = new System.Windows.Forms.TextBox();
            this.new_People_VaccinatedTextBox = new System.Windows.Forms.TextBox();
            this.new_CasesTextBox = new System.Windows.Forms.TextBox();
            this.new_Case_PositivityTextBox = new System.Windows.Forms.TextBox();
            this.cases_Per_100K_PopulationTextBox = new System.Windows.Forms.TextBox();
            this.report_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nvgCovidData = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cOVID_DataTableAdapter = new Project1b.COVID_DBDataSetTableAdapters.COVID_DataTableAdapter();
            this.tableAdapterManager = new Project1b.COVID_DBDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            county_IDLabel = new System.Windows.Forms.Label();
            people_VaccinatedLabel = new System.Windows.Forms.Label();
            percent_5__VaccinatedLabel = new System.Windows.Forms.Label();
            casesLabel = new System.Windows.Forms.Label();
            case_PositivityLabel = new System.Windows.Forms.Label();
            new_People_VaccinatedLabel = new System.Windows.Forms.Label();
            new_CasesLabel = new System.Windows.Forms.Label();
            new_Case_PositivityLabel = new System.Windows.Forms.Label();
            cases_Per_100K_PopulationLabel = new System.Windows.Forms.Label();
            report_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgCovidData)).BeginInit();
            this.nvgCovidData.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 49);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // county_IDLabel
            // 
            county_IDLabel.AutoSize = true;
            county_IDLabel.Location = new System.Drawing.Point(27, 75);
            county_IDLabel.Name = "county_IDLabel";
            county_IDLabel.Size = new System.Drawing.Size(57, 13);
            county_IDLabel.TabIndex = 3;
            county_IDLabel.Text = "County ID:";
            // 
            // people_VaccinatedLabel
            // 
            people_VaccinatedLabel.AutoSize = true;
            people_VaccinatedLabel.Location = new System.Drawing.Point(27, 101);
            people_VaccinatedLabel.Name = "people_VaccinatedLabel";
            people_VaccinatedLabel.Size = new System.Drawing.Size(100, 13);
            people_VaccinatedLabel.TabIndex = 5;
            people_VaccinatedLabel.Text = "People Vaccinated:";
            // 
            // percent_5__VaccinatedLabel
            // 
            percent_5__VaccinatedLabel.AutoSize = true;
            percent_5__VaccinatedLabel.Location = new System.Drawing.Point(27, 127);
            percent_5__VaccinatedLabel.Name = "percent_5__VaccinatedLabel";
            percent_5__VaccinatedLabel.Size = new System.Drawing.Size(119, 13);
            percent_5__VaccinatedLabel.TabIndex = 7;
            percent_5__VaccinatedLabel.Text = "Percent 5+ Vaccinated:";
            // 
            // casesLabel
            // 
            casesLabel.AutoSize = true;
            casesLabel.Location = new System.Drawing.Point(27, 153);
            casesLabel.Name = "casesLabel";
            casesLabel.Size = new System.Drawing.Size(39, 13);
            casesLabel.TabIndex = 9;
            casesLabel.Text = "Cases:";
            // 
            // case_PositivityLabel
            // 
            case_PositivityLabel.AutoSize = true;
            case_PositivityLabel.Location = new System.Drawing.Point(27, 179);
            case_PositivityLabel.Name = "case_PositivityLabel";
            case_PositivityLabel.Size = new System.Drawing.Size(78, 13);
            case_PositivityLabel.TabIndex = 11;
            case_PositivityLabel.Text = "Case Positivity:";
            // 
            // new_People_VaccinatedLabel
            // 
            new_People_VaccinatedLabel.AutoSize = true;
            new_People_VaccinatedLabel.Location = new System.Drawing.Point(27, 205);
            new_People_VaccinatedLabel.Name = "new_People_VaccinatedLabel";
            new_People_VaccinatedLabel.Size = new System.Drawing.Size(125, 13);
            new_People_VaccinatedLabel.TabIndex = 13;
            new_People_VaccinatedLabel.Text = "New People Vaccinated:";
            // 
            // new_CasesLabel
            // 
            new_CasesLabel.AutoSize = true;
            new_CasesLabel.Location = new System.Drawing.Point(27, 231);
            new_CasesLabel.Name = "new_CasesLabel";
            new_CasesLabel.Size = new System.Drawing.Size(64, 13);
            new_CasesLabel.TabIndex = 15;
            new_CasesLabel.Text = "New Cases:";
            // 
            // new_Case_PositivityLabel
            // 
            new_Case_PositivityLabel.AutoSize = true;
            new_Case_PositivityLabel.Location = new System.Drawing.Point(27, 257);
            new_Case_PositivityLabel.Name = "new_Case_PositivityLabel";
            new_Case_PositivityLabel.Size = new System.Drawing.Size(103, 13);
            new_Case_PositivityLabel.TabIndex = 17;
            new_Case_PositivityLabel.Text = "New Case Positivity:";
            // 
            // cases_Per_100K_PopulationLabel
            // 
            cases_Per_100K_PopulationLabel.AutoSize = true;
            cases_Per_100K_PopulationLabel.Location = new System.Drawing.Point(27, 283);
            cases_Per_100K_PopulationLabel.Name = "cases_Per_100K_PopulationLabel";
            cases_Per_100K_PopulationLabel.Size = new System.Drawing.Size(139, 13);
            cases_Per_100K_PopulationLabel.TabIndex = 19;
            cases_Per_100K_PopulationLabel.Text = "Cases Per 100K Population:";
            // 
            // report_DateLabel
            // 
            report_DateLabel.AutoSize = true;
            report_DateLabel.Location = new System.Drawing.Point(27, 310);
            report_DateLabel.Name = "report_DateLabel";
            report_DateLabel.Size = new System.Drawing.Size(68, 13);
            report_DateLabel.TabIndex = 21;
            report_DateLabel.Text = "Report Date:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(172, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // cOVID_DataBindingSource
            // 
            this.cOVID_DataBindingSource.DataMember = "COVID_Data";
            this.cOVID_DataBindingSource.DataSource = this.cOVID_DBDataSet;
            // 
            // cOVID_DBDataSet
            // 
            this.cOVID_DBDataSet.DataSetName = "COVID_DBDataSet";
            this.cOVID_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // county_IDTextBox
            // 
            this.county_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "County_ID", true));
            this.county_IDTextBox.Location = new System.Drawing.Point(172, 72);
            this.county_IDTextBox.Name = "county_IDTextBox";
            this.county_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.county_IDTextBox.TabIndex = 4;
            // 
            // people_VaccinatedTextBox
            // 
            this.people_VaccinatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "People_Vaccinated", true));
            this.people_VaccinatedTextBox.Location = new System.Drawing.Point(172, 98);
            this.people_VaccinatedTextBox.Name = "people_VaccinatedTextBox";
            this.people_VaccinatedTextBox.Size = new System.Drawing.Size(200, 20);
            this.people_VaccinatedTextBox.TabIndex = 6;
            // 
            // percent_5__VaccinatedTextBox
            // 
            this.percent_5__VaccinatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Percent_5+_Vaccinated", true));
            this.percent_5__VaccinatedTextBox.Location = new System.Drawing.Point(172, 124);
            this.percent_5__VaccinatedTextBox.Name = "percent_5__VaccinatedTextBox";
            this.percent_5__VaccinatedTextBox.Size = new System.Drawing.Size(200, 20);
            this.percent_5__VaccinatedTextBox.TabIndex = 8;
            // 
            // casesTextBox
            // 
            this.casesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Cases", true));
            this.casesTextBox.Location = new System.Drawing.Point(172, 150);
            this.casesTextBox.Name = "casesTextBox";
            this.casesTextBox.Size = new System.Drawing.Size(200, 20);
            this.casesTextBox.TabIndex = 10;
            // 
            // case_PositivityTextBox
            // 
            this.case_PositivityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Case_Positivity", true));
            this.case_PositivityTextBox.Location = new System.Drawing.Point(172, 176);
            this.case_PositivityTextBox.Name = "case_PositivityTextBox";
            this.case_PositivityTextBox.Size = new System.Drawing.Size(200, 20);
            this.case_PositivityTextBox.TabIndex = 12;
            // 
            // new_People_VaccinatedTextBox
            // 
            this.new_People_VaccinatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "New_People_Vaccinated", true));
            this.new_People_VaccinatedTextBox.Location = new System.Drawing.Point(172, 202);
            this.new_People_VaccinatedTextBox.Name = "new_People_VaccinatedTextBox";
            this.new_People_VaccinatedTextBox.Size = new System.Drawing.Size(200, 20);
            this.new_People_VaccinatedTextBox.TabIndex = 14;
            // 
            // new_CasesTextBox
            // 
            this.new_CasesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "New_Cases", true));
            this.new_CasesTextBox.Location = new System.Drawing.Point(172, 228);
            this.new_CasesTextBox.Name = "new_CasesTextBox";
            this.new_CasesTextBox.Size = new System.Drawing.Size(200, 20);
            this.new_CasesTextBox.TabIndex = 16;
            // 
            // new_Case_PositivityTextBox
            // 
            this.new_Case_PositivityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "New_Case_Positivity", true));
            this.new_Case_PositivityTextBox.Location = new System.Drawing.Point(172, 254);
            this.new_Case_PositivityTextBox.Name = "new_Case_PositivityTextBox";
            this.new_Case_PositivityTextBox.Size = new System.Drawing.Size(200, 20);
            this.new_Case_PositivityTextBox.TabIndex = 18;
            // 
            // cases_Per_100K_PopulationTextBox
            // 
            this.cases_Per_100K_PopulationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Cases_Per_100K_Population", true));
            this.cases_Per_100K_PopulationTextBox.Location = new System.Drawing.Point(172, 280);
            this.cases_Per_100K_PopulationTextBox.Name = "cases_Per_100K_PopulationTextBox";
            this.cases_Per_100K_PopulationTextBox.Size = new System.Drawing.Size(200, 20);
            this.cases_Per_100K_PopulationTextBox.TabIndex = 20;
            // 
            // report_DateDateTimePicker
            // 
            this.report_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cOVID_DataBindingSource, "Report_Date", true));
            this.report_DateDateTimePicker.Location = new System.Drawing.Point(172, 306);
            this.report_DateDateTimePicker.Name = "report_DateDateTimePicker";
            this.report_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.report_DateDateTimePicker.TabIndex = 22;
            // 
            // nvgCovidData
            // 
            this.nvgCovidData.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nvgCovidData.BindingSource = this.cOVID_DataBindingSource;
            this.nvgCovidData.CountItem = this.bindingNavigatorCountItem;
            this.nvgCovidData.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nvgCovidData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.nvgCovidData.Location = new System.Drawing.Point(0, 0);
            this.nvgCovidData.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvgCovidData.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvgCovidData.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvgCovidData.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvgCovidData.Name = "nvgCovidData";
            this.nvgCovidData.PositionItem = this.bindingNavigatorPositionItem;
            this.nvgCovidData.Size = new System.Drawing.Size(800, 25);
            this.nvgCovidData.TabIndex = 0;
            this.nvgCovidData.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // cOVID_DataTableAdapter
            // 
            this.cOVID_DataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountiesTableAdapter = null;
            this.tableAdapterManager.COVID_DataTableAdapter = this.cOVID_DataTableAdapter;
            this.tableAdapterManager.PopulationsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project1b.COVID_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // CovidDataMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nvgCovidData);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(county_IDLabel);
            this.Controls.Add(this.county_IDTextBox);
            this.Controls.Add(people_VaccinatedLabel);
            this.Controls.Add(this.people_VaccinatedTextBox);
            this.Controls.Add(percent_5__VaccinatedLabel);
            this.Controls.Add(this.percent_5__VaccinatedTextBox);
            this.Controls.Add(casesLabel);
            this.Controls.Add(this.casesTextBox);
            this.Controls.Add(case_PositivityLabel);
            this.Controls.Add(this.case_PositivityTextBox);
            this.Controls.Add(new_People_VaccinatedLabel);
            this.Controls.Add(this.new_People_VaccinatedTextBox);
            this.Controls.Add(new_CasesLabel);
            this.Controls.Add(this.new_CasesTextBox);
            this.Controls.Add(new_Case_PositivityLabel);
            this.Controls.Add(this.new_Case_PositivityTextBox);
            this.Controls.Add(cases_Per_100K_PopulationLabel);
            this.Controls.Add(this.cases_Per_100K_PopulationTextBox);
            this.Controls.Add(report_DateLabel);
            this.Controls.Add(this.report_DateDateTimePicker);
            this.Name = "CovidDataMaintenanceForm";
            this.Text = "Covid Data Maintenance Form";
            this.Load += new System.EventHandler(this.CovidDataMaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgCovidData)).EndInit();
            this.nvgCovidData.ResumeLayout(false);
            this.nvgCovidData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private COVID_DBDataSet cOVID_DBDataSet;
        private System.Windows.Forms.BindingSource cOVID_DataBindingSource;
        private COVID_DBDataSetTableAdapters.COVID_DataTableAdapter cOVID_DataTableAdapter;
        private COVID_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox county_IDTextBox;
        private System.Windows.Forms.TextBox people_VaccinatedTextBox;
        private System.Windows.Forms.TextBox percent_5__VaccinatedTextBox;
        private System.Windows.Forms.TextBox casesTextBox;
        private System.Windows.Forms.TextBox case_PositivityTextBox;
        private System.Windows.Forms.TextBox new_People_VaccinatedTextBox;
        private System.Windows.Forms.TextBox new_CasesTextBox;
        private System.Windows.Forms.TextBox new_Case_PositivityTextBox;
        private System.Windows.Forms.TextBox cases_Per_100K_PopulationTextBox;
        private System.Windows.Forms.DateTimePicker report_DateDateTimePicker;
        private System.Windows.Forms.BindingNavigator nvgCovidData;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
    }
}