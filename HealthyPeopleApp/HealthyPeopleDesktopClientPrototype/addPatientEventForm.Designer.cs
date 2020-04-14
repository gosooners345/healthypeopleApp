namespace HealthyPeopleDesktopClientPrototype
{
    partial class addPatientEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPatientEventForm));
            System.Windows.Forms.Label patientEventIDLabel;
            System.Windows.Forms.Label patientEventLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label patientEventDateLabel;
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this._HealthyPeopleDB_TestDataSet = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet();
            this.patientRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientRecordsTableAdapter = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter();
            this.tableAdapterManager = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.TableAdapterManager();
            this.patientRecordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientRecordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientEventIDTextBox = new System.Windows.Forms.TextBox();
            this.patientEventTextBox = new System.Windows.Forms.TextBox();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.patientEventDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            patientEventIDLabel = new System.Windows.Forms.Label();
            patientEventLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            patientEventDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._HealthyPeopleDB_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingNavigator)).BeginInit();
            this.patientRecordsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.submitButton.Location = new System.Drawing.Point(165, 360);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(336, 360);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // _HealthyPeopleDB_TestDataSet
            // 
            this._HealthyPeopleDB_TestDataSet.DataSetName = "_HealthyPeopleDB_TestDataSet";
            this._HealthyPeopleDB_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientRecordsBindingSource
            // 
            this.patientRecordsBindingSource.DataMember = "PatientRecords";
            this.patientRecordsBindingSource.DataSource = this._HealthyPeopleDB_TestDataSet;
            // 
            // patientRecordsTableAdapter
            // 
            this.patientRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeDetailsTableAdapter = null;
            this.tableAdapterManager.JobsTableAdapter = null;
            this.tableAdapterManager.PatientRecordsTableAdapter = this.patientRecordsTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PatientUserTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableTableAdapter = null;
            // 
            // patientRecordsBindingNavigator
            // 
            this.patientRecordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientRecordsBindingNavigator.BindingSource = this.patientRecordsBindingSource;
            this.patientRecordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientRecordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientRecordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientRecordsBindingNavigatorSaveItem});
            this.patientRecordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientRecordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientRecordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientRecordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientRecordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientRecordsBindingNavigator.Name = "patientRecordsBindingNavigator";
            this.patientRecordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientRecordsBindingNavigator.Size = new System.Drawing.Size(560, 25);
            this.patientRecordsBindingNavigator.TabIndex = 10;
            this.patientRecordsBindingNavigator.Text = "bindingNavigator1";
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
            // patientRecordsBindingNavigatorSaveItem
            // 
            this.patientRecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientRecordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientRecordsBindingNavigatorSaveItem.Image")));
            this.patientRecordsBindingNavigatorSaveItem.Name = "patientRecordsBindingNavigatorSaveItem";
            this.patientRecordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.patientRecordsBindingNavigatorSaveItem.Text = "Save Data";
            this.patientRecordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.PatientRecordsBindingNavigatorSaveItem_Click);
            // 
            // patientEventIDLabel
            // 
            patientEventIDLabel.AutoSize = true;
            patientEventIDLabel.Location = new System.Drawing.Point(126, 90);
            patientEventIDLabel.Name = "patientEventIDLabel";
            patientEventIDLabel.Size = new System.Drawing.Size(88, 13);
            patientEventIDLabel.TabIndex = 10;
            patientEventIDLabel.Text = "Patient Event ID:";
            // 
            // patientEventIDTextBox
            // 
            this.patientEventIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientEventID", true));
            this.patientEventIDTextBox.Location = new System.Drawing.Point(232, 87);
            this.patientEventIDTextBox.Name = "patientEventIDTextBox";
            this.patientEventIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientEventIDTextBox.TabIndex = 11;
            // 
            // patientEventLabel
            // 
            patientEventLabel.AutoSize = true;
            patientEventLabel.Location = new System.Drawing.Point(126, 116);
            patientEventLabel.Name = "patientEventLabel";
            patientEventLabel.Size = new System.Drawing.Size(74, 13);
            patientEventLabel.TabIndex = 12;
            patientEventLabel.Text = "Patient Event:";
            // 
            // patientEventTextBox
            // 
            this.patientEventTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientEvent", true));
            this.patientEventTextBox.Location = new System.Drawing.Point(232, 113);
            this.patientEventTextBox.Name = "patientEventTextBox";
            this.patientEventTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientEventTextBox.TabIndex = 13;
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(126, 142);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 14;
            patientIDLabel.Text = "Patient ID:";
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientID", true));
            this.patientIDTextBox.Location = new System.Drawing.Point(232, 139);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientIDTextBox.TabIndex = 15;
            // 
            // patientEventDateLabel
            // 
            patientEventDateLabel.AutoSize = true;
            patientEventDateLabel.Location = new System.Drawing.Point(126, 169);
            patientEventDateLabel.Name = "patientEventDateLabel";
            patientEventDateLabel.Size = new System.Drawing.Size(100, 13);
            patientEventDateLabel.TabIndex = 16;
            patientEventDateLabel.Text = "Patient Event Date:";
            // 
            // patientEventDateDateTimePicker
            // 
            this.patientEventDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientRecordsBindingSource, "PatientEventDate", true));
            this.patientEventDateDateTimePicker.Location = new System.Drawing.Point(232, 165);
            this.patientEventDateDateTimePicker.Name = "patientEventDateDateTimePicker";
            this.patientEventDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.patientEventDateDateTimePicker.TabIndex = 17;
            // 
            // addPatientEventForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(patientEventIDLabel);
            this.Controls.Add(this.patientEventIDTextBox);
            this.Controls.Add(patientEventLabel);
            this.Controls.Add(this.patientEventTextBox);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(patientEventDateLabel);
            this.Controls.Add(this.patientEventDateDateTimePicker);
            this.Controls.Add(this.patientRecordsBindingNavigator);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Name = "addPatientEventForm";
            this.Text = "addPatientEventForm";
            this.Load += new System.EventHandler(this.AddPatientEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._HealthyPeopleDB_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingNavigator)).EndInit();
            this.patientRecordsBindingNavigator.ResumeLayout(false);
            this.patientRecordsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private _HealthyPeopleDB_TestDataSet _HealthyPeopleDB_TestDataSet;
        private System.Windows.Forms.BindingSource patientRecordsBindingSource;
        private _HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter patientRecordsTableAdapter;
        private _HealthyPeopleDB_TestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientRecordsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientRecordsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox patientEventIDTextBox;
        private System.Windows.Forms.TextBox patientEventTextBox;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.DateTimePicker patientEventDateDateTimePicker;
    }
}