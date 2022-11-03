
namespace Project1b
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.cOVID_DBDataSet = new Project1b.COVID_DBDataSet();
            this.cOVID_DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOVID_DataTableAdapter = new Project1b.COVID_DBDataSetTableAdapters.COVID_DataTableAdapter();
            this.tableAdapterManager = new Project1b.COVID_DBDataSetTableAdapters.TableAdapterManager();
            this.cOVID_DataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cOVID_DataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DataBindingNavigator)).BeginInit();
            this.cOVID_DataBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cOVID_DBDataSet
            // 
            this.cOVID_DBDataSet.DataSetName = "COVID_DBDataSet";
            this.cOVID_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOVID_DataBindingSource
            // 
            this.cOVID_DataBindingSource.DataMember = "COVID_Data";
            this.cOVID_DataBindingSource.DataSource = this.cOVID_DBDataSet;
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
            // cOVID_DataBindingNavigator
            // 
            this.cOVID_DataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cOVID_DataBindingNavigator.BindingSource = this.cOVID_DataBindingSource;
            this.cOVID_DataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cOVID_DataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cOVID_DataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cOVID_DataBindingNavigatorSaveItem});
            this.cOVID_DataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cOVID_DataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cOVID_DataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cOVID_DataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cOVID_DataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cOVID_DataBindingNavigator.Name = "cOVID_DataBindingNavigator";
            this.cOVID_DataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cOVID_DataBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cOVID_DataBindingNavigator.TabIndex = 0;
            this.cOVID_DataBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cOVID_DataBindingNavigatorSaveItem
            // 
            this.cOVID_DataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cOVID_DataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cOVID_DataBindingNavigatorSaveItem.Image")));
            this.cOVID_DataBindingNavigatorSaveItem.Name = "cOVID_DataBindingNavigatorSaveItem";
            this.cOVID_DataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cOVID_DataBindingNavigatorSaveItem.Text = "Save Data";
            this.cOVID_DataBindingNavigatorSaveItem.Click += new System.EventHandler(this.cOVID_DataBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(255, 181);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(400, 178);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // county_IDLabel
            // 
            county_IDLabel.AutoSize = true;
            county_IDLabel.Location = new System.Drawing.Point(255, 207);
            county_IDLabel.Name = "county_IDLabel";
            county_IDLabel.Size = new System.Drawing.Size(57, 13);
            county_IDLabel.TabIndex = 3;
            county_IDLabel.Text = "County ID:";
            // 
            // county_IDTextBox
            // 
            this.county_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "County_ID", true));
            this.county_IDTextBox.Location = new System.Drawing.Point(400, 204);
            this.county_IDTextBox.Name = "county_IDTextBox";
            this.county_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.county_IDTextBox.TabIndex = 4;
            // 
            // people_VaccinatedLabel
            // 
            people_VaccinatedLabel.AutoSize = true;
            people_VaccinatedLabel.Location = new System.Drawing.Point(255, 233);
            people_VaccinatedLabel.Name = "people_VaccinatedLabel";
            people_VaccinatedLabel.Size = new System.Drawing.Size(100, 13);
            people_VaccinatedLabel.TabIndex = 5;
            people_VaccinatedLabel.Text = "People Vaccinated:";
            // 
            // people_VaccinatedTextBox
            // 
            this.people_VaccinatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "People_Vaccinated", true));
            this.people_VaccinatedTextBox.Location = new System.Drawing.Point(400, 230);
            this.people_VaccinatedTextBox.Name = "people_VaccinatedTextBox";
            this.people_VaccinatedTextBox.Size = new System.Drawing.Size(200, 20);
            this.people_VaccinatedTextBox.TabIndex = 6;
            // 
            // percent_5__VaccinatedLabel
            // 
            percent_5__VaccinatedLabel.AutoSize = true;
            percent_5__VaccinatedLabel.Location = new System.Drawing.Point(255, 259);
            percent_5__VaccinatedLabel.Name = "percent_5__VaccinatedLabel";
            percent_5__VaccinatedLabel.Size = new System.Drawing.Size(119, 13);
            percent_5__VaccinatedLabel.TabIndex = 7;
            percent_5__VaccinatedLabel.Text = "Percent 5+ Vaccinated:";
            // 
            // percent_5__VaccinatedTextBox
            // 
            this.percent_5__VaccinatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Percent_5+_Vaccinated", true));
            this.percent_5__VaccinatedTextBox.Location = new System.Drawing.Point(400, 256);
            this.percent_5__VaccinatedTextBox.Name = "percent_5__VaccinatedTextBox";
            this.percent_5__VaccinatedTextBox.Size = new System.Drawing.Size(200, 20);
            this.percent_5__VaccinatedTextBox.TabIndex = 8;
            // 
            // casesLabel
            // 
            casesLabel.AutoSize = true;
            casesLabel.Location = new System.Drawing.Point(255, 285);
            casesLabel.Name = "casesLabel";
            casesLabel.Size = new System.Drawing.Size(39, 13);
            casesLabel.TabIndex = 9;
            casesLabel.Text = "Cases:";
            // 
            // casesTextBox
            // 
            this.casesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Cases", true));
            this.casesTextBox.Location = new System.Drawing.Point(400, 282);
            this.casesTextBox.Name = "casesTextBox";
            this.casesTextBox.Size = new System.Drawing.Size(200, 20);
            this.casesTextBox.TabIndex = 10;
            // 
            // case_PositivityLabel
            // 
            case_PositivityLabel.AutoSize = true;
            case_PositivityLabel.Location = new System.Drawing.Point(255, 311);
            case_PositivityLabel.Name = "case_PositivityLabel";
            case_PositivityLabel.Size = new System.Drawing.Size(78, 13);
            case_PositivityLabel.TabIndex = 11;
            case_PositivityLabel.Text = "Case Positivity:";
            // 
            // case_PositivityTextBox
            // 
            this.case_PositivityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Case_Positivity", true));
            this.case_PositivityTextBox.Location = new System.Drawing.Point(400, 308);
            this.case_PositivityTextBox.Name = "case_PositivityTextBox";
            this.case_PositivityTextBox.Size = new System.Drawing.Size(200, 20);
            this.case_PositivityTextBox.TabIndex = 12;
            // 
            // new_People_VaccinatedLabel
            // 
            new_People_VaccinatedLabel.AutoSize = true;
            new_People_VaccinatedLabel.Location = new System.Drawing.Point(255, 337);
            new_People_VaccinatedLabel.Name = "new_People_VaccinatedLabel";
            new_People_VaccinatedLabel.Size = new System.Drawing.Size(125, 13);
            new_People_VaccinatedLabel.TabIndex = 13;
            new_People_VaccinatedLabel.Text = "New People Vaccinated:";
            // 
            // new_People_VaccinatedTextBox
            // 
            this.new_People_VaccinatedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "New_People_Vaccinated", true));
            this.new_People_VaccinatedTextBox.Location = new System.Drawing.Point(400, 334);
            this.new_People_VaccinatedTextBox.Name = "new_People_VaccinatedTextBox";
            this.new_People_VaccinatedTextBox.Size = new System.Drawing.Size(200, 20);
            this.new_People_VaccinatedTextBox.TabIndex = 14;
            // 
            // new_CasesLabel
            // 
            new_CasesLabel.AutoSize = true;
            new_CasesLabel.Location = new System.Drawing.Point(255, 363);
            new_CasesLabel.Name = "new_CasesLabel";
            new_CasesLabel.Size = new System.Drawing.Size(64, 13);
            new_CasesLabel.TabIndex = 15;
            new_CasesLabel.Text = "New Cases:";
            // 
            // new_CasesTextBox
            // 
            this.new_CasesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "New_Cases", true));
            this.new_CasesTextBox.Location = new System.Drawing.Point(400, 360);
            this.new_CasesTextBox.Name = "new_CasesTextBox";
            this.new_CasesTextBox.Size = new System.Drawing.Size(200, 20);
            this.new_CasesTextBox.TabIndex = 16;
            // 
            // new_Case_PositivityLabel
            // 
            new_Case_PositivityLabel.AutoSize = true;
            new_Case_PositivityLabel.Location = new System.Drawing.Point(255, 389);
            new_Case_PositivityLabel.Name = "new_Case_PositivityLabel";
            new_Case_PositivityLabel.Size = new System.Drawing.Size(103, 13);
            new_Case_PositivityLabel.TabIndex = 17;
            new_Case_PositivityLabel.Text = "New Case Positivity:";
            // 
            // new_Case_PositivityTextBox
            // 
            this.new_Case_PositivityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "New_Case_Positivity", true));
            this.new_Case_PositivityTextBox.Location = new System.Drawing.Point(400, 386);
            this.new_Case_PositivityTextBox.Name = "new_Case_PositivityTextBox";
            this.new_Case_PositivityTextBox.Size = new System.Drawing.Size(200, 20);
            this.new_Case_PositivityTextBox.TabIndex = 18;
            // 
            // cases_Per_100K_PopulationLabel
            // 
            cases_Per_100K_PopulationLabel.AutoSize = true;
            cases_Per_100K_PopulationLabel.Location = new System.Drawing.Point(255, 415);
            cases_Per_100K_PopulationLabel.Name = "cases_Per_100K_PopulationLabel";
            cases_Per_100K_PopulationLabel.Size = new System.Drawing.Size(139, 13);
            cases_Per_100K_PopulationLabel.TabIndex = 19;
            cases_Per_100K_PopulationLabel.Text = "Cases Per 100K Population:";
            // 
            // cases_Per_100K_PopulationTextBox
            // 
            this.cases_Per_100K_PopulationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOVID_DataBindingSource, "Cases_Per_100K_Population", true));
            this.cases_Per_100K_PopulationTextBox.Location = new System.Drawing.Point(400, 412);
            this.cases_Per_100K_PopulationTextBox.Name = "cases_Per_100K_PopulationTextBox";
            this.cases_Per_100K_PopulationTextBox.Size = new System.Drawing.Size(200, 20);
            this.cases_Per_100K_PopulationTextBox.TabIndex = 20;
            // 
            // report_DateLabel
            // 
            report_DateLabel.AutoSize = true;
            report_DateLabel.Location = new System.Drawing.Point(255, 442);
            report_DateLabel.Name = "report_DateLabel";
            report_DateLabel.Size = new System.Drawing.Size(68, 13);
            report_DateLabel.TabIndex = 21;
            report_DateLabel.Text = "Report Date:";
            // 
            // report_DateDateTimePicker
            // 
            this.report_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cOVID_DataBindingSource, "Report_Date", true));
            this.report_DateDateTimePicker.Location = new System.Drawing.Point(400, 438);
            this.report_DateDateTimePicker.Name = "report_DateDateTimePicker";
            this.report_DateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.report_DateDateTimePicker.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
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
            this.Controls.Add(this.cOVID_DataBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DataBindingNavigator)).EndInit();
            this.cOVID_DataBindingNavigator.ResumeLayout(false);
            this.cOVID_DataBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private COVID_DBDataSet cOVID_DBDataSet;
        private System.Windows.Forms.BindingSource cOVID_DataBindingSource;
        private COVID_DBDataSetTableAdapters.COVID_DataTableAdapter cOVID_DataTableAdapter;
        private COVID_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cOVID_DataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cOVID_DataBindingNavigatorSaveItem;
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
    }
}