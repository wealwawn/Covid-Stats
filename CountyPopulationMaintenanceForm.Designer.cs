
namespace Project1b
{
    partial class CountyPopulationMaintenanceForm
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
            System.Windows.Forms.Label countyIDLabel;
            System.Windows.Forms.Label populationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountyPopulationMaintenanceForm));
            this.cOVID_DBDataSet = new Project1b.COVID_DBDataSet();
            this.populationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populationsTableAdapter = new Project1b.COVID_DBDataSetTableAdapters.PopulationsTableAdapter();
            this.tableAdapterManager = new Project1b.COVID_DBDataSetTableAdapters.TableAdapterManager();
            this.countiesTableAdapter = new Project1b.COVID_DBDataSetTableAdapters.CountiesTableAdapter();
            this.populationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.populationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.countyIDTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.countiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            countyIDLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationsBindingNavigator)).BeginInit();
            this.populationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 44);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // countyIDLabel
            // 
            countyIDLabel.AutoSize = true;
            countyIDLabel.Location = new System.Drawing.Point(12, 70);
            countyIDLabel.Name = "countyIDLabel";
            countyIDLabel.Size = new System.Drawing.Size(57, 13);
            countyIDLabel.TabIndex = 3;
            countyIDLabel.Text = "County ID:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(12, 96);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(60, 13);
            populationLabel.TabIndex = 5;
            populationLabel.Text = "Population:";
            // 
            // cOVID_DBDataSet
            // 
            this.cOVID_DBDataSet.DataSetName = "COVID_DBDataSet";
            this.cOVID_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // populationsBindingSource
            // 
            this.populationsBindingSource.DataMember = "Populations";
            this.populationsBindingSource.DataSource = this.cOVID_DBDataSet;
            // 
            // populationsTableAdapter
            // 
            this.populationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountiesTableAdapter = this.countiesTableAdapter;
            this.tableAdapterManager.COVID_DataTableAdapter = null;
            this.tableAdapterManager.PopulationsTableAdapter = this.populationsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project1b.COVID_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // countiesTableAdapter
            // 
            this.countiesTableAdapter.ClearBeforeFill = true;
            // 
            // populationsBindingNavigator
            // 
            this.populationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.populationsBindingNavigator.BindingSource = this.populationsBindingSource;
            this.populationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.populationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.populationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.populationsBindingNavigatorSaveItem});
            this.populationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.populationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.populationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.populationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.populationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.populationsBindingNavigator.Name = "populationsBindingNavigator";
            this.populationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.populationsBindingNavigator.Size = new System.Drawing.Size(364, 25);
            this.populationsBindingNavigator.TabIndex = 0;
            this.populationsBindingNavigator.Text = "bindingNavigator1";
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
            // populationsBindingNavigatorSaveItem
            // 
            this.populationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.populationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("populationsBindingNavigatorSaveItem.Image")));
            this.populationsBindingNavigatorSaveItem.Name = "populationsBindingNavigatorSaveItem";
            this.populationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.populationsBindingNavigatorSaveItem.Text = "Save Data";
            this.populationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.populationsBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.populationsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(78, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // countyIDTextBox
            // 
            this.countyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.populationsBindingSource, "CountyID", true));
            this.countyIDTextBox.Location = new System.Drawing.Point(78, 67);
            this.countyIDTextBox.Name = "countyIDTextBox";
            this.countyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.countyIDTextBox.TabIndex = 4;
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.populationsBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(78, 93);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(100, 20);
            this.populationTextBox.TabIndex = 6;
            // 
            // countiesBindingSource
            // 
            this.countiesBindingSource.DataMember = "Counties";
            this.countiesBindingSource.DataSource = this.cOVID_DBDataSet;
            // 
            // countiesBindingSource1
            // 
            this.countiesBindingSource1.DataMember = "Counties";
            this.countiesBindingSource1.DataSource = this.cOVID_DBDataSet;
            // 
            // CountyPopulationMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 180);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(countyIDLabel);
            this.Controls.Add(this.countyIDTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.populationsBindingNavigator);
            this.Name = "CountyPopulationMaintenanceForm";
            this.Text = "CountyPopulationMaintenanceForm";
            this.Load += new System.EventHandler(this.CountyPopulationMaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOVID_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationsBindingNavigator)).EndInit();
            this.populationsBindingNavigator.ResumeLayout(false);
            this.populationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countiesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private COVID_DBDataSet cOVID_DBDataSet;
        private System.Windows.Forms.BindingSource populationsBindingSource;
        private COVID_DBDataSetTableAdapters.PopulationsTableAdapter populationsTableAdapter;
        private COVID_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator populationsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton populationsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox countyIDTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private COVID_DBDataSetTableAdapters.CountiesTableAdapter countiesTableAdapter;
        private System.Windows.Forms.BindingSource countiesBindingSource;
        private System.Windows.Forms.BindingSource countiesBindingSource1;
    }
}