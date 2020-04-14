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
            this.patientEventIDTextBox = new System.Windows.Forms.TextBox();
            this.patientEventTextBox = new System.Windows.Forms.TextBox();
            this.patientEventDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientIDContent = new System.Windows.Forms.Label();
            patientEventIDLabel = new System.Windows.Forms.Label();
            patientEventLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            patientEventDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._HealthyPeopleDB_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patientEventIDLabel
            // 
            patientEventIDLabel.AutoSize = true;
            patientEventIDLabel.Location = new System.Drawing.Point(26, 19);
            patientEventIDLabel.Name = "patientEventIDLabel";
            patientEventIDLabel.Size = new System.Drawing.Size(88, 13);
            patientEventIDLabel.TabIndex = 10;
            patientEventIDLabel.Text = "Patient Event ID:";
            // 
            // patientEventLabel
            // 
            patientEventLabel.AutoSize = true;
            patientEventLabel.Location = new System.Drawing.Point(26, 45);
            patientEventLabel.Name = "patientEventLabel";
            patientEventLabel.Size = new System.Drawing.Size(74, 13);
            patientEventLabel.TabIndex = 12;
            patientEventLabel.Text = "Patient Event:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(26, 71);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 14;
            patientIDLabel.Text = "Patient ID:";
            // 
            // patientEventDateLabel
            // 
            patientEventDateLabel.AutoSize = true;
            patientEventDateLabel.Location = new System.Drawing.Point(26, 98);
            patientEventDateLabel.Name = "patientEventDateLabel";
            patientEventDateLabel.Size = new System.Drawing.Size(100, 13);
            patientEventDateLabel.TabIndex = 16;
            patientEventDateLabel.Text = "Patient Event Date:";
            // 
            // submitButton
            // 
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.submitButton.Location = new System.Drawing.Point(64, 159);
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
            this.cancelButton.Location = new System.Drawing.Point(235, 159);
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
            // patientEventIDTextBox
            // 
            this.patientEventIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientEventID", true));
            this.patientEventIDTextBox.Location = new System.Drawing.Point(132, 16);
            this.patientEventIDTextBox.Name = "patientEventIDTextBox";
            this.patientEventIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientEventIDTextBox.TabIndex = 11;
            this.patientEventIDTextBox.TextChanged += new System.EventHandler(this.PatientEventIDTextBox_TextChanged);
            // 
            // patientEventTextBox
            // 
            this.patientEventTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientEvent", true));
            this.patientEventTextBox.Location = new System.Drawing.Point(132, 42);
            this.patientEventTextBox.Name = "patientEventTextBox";
            this.patientEventTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientEventTextBox.TabIndex = 13;
            // 
            // patientEventDateDateTimePicker
            // 
            this.patientEventDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientRecordsBindingSource, "PatientEventDate", true));
            this.patientEventDateDateTimePicker.Location = new System.Drawing.Point(132, 94);
            this.patientEventDateDateTimePicker.Name = "patientEventDateDateTimePicker";
            this.patientEventDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.patientEventDateDateTimePicker.TabIndex = 17;
            // 
            // patientIDContent
            // 
            this.patientIDContent.AutoSize = true;
            this.patientIDContent.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.patientRecordsBindingSource, "PatientID", true));
            this.patientIDContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientID", true));
            this.patientIDContent.Location = new System.Drawing.Point(132, 70);
            this.patientIDContent.Name = "patientIDContent";
            this.patientIDContent.Size = new System.Drawing.Size(35, 13);
            this.patientIDContent.TabIndex = 18;
            this.patientIDContent.Text = "label1";
            // 
            // addPatientEventForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(390, 222);
            this.Controls.Add(this.patientIDContent);
            this.Controls.Add(patientEventIDLabel);
            this.Controls.Add(this.patientEventIDTextBox);
            this.Controls.Add(patientEventLabel);
            this.Controls.Add(this.patientEventTextBox);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(patientEventDateLabel);
            this.Controls.Add(this.patientEventDateDateTimePicker);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Name = "addPatientEventForm";
            this.Text = "addPatientEventForm";
            this.Load += new System.EventHandler(this.AddPatientEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._HealthyPeopleDB_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox patientEventIDTextBox;
        private System.Windows.Forms.TextBox patientEventTextBox;
        private System.Windows.Forms.DateTimePicker patientEventDateDateTimePicker;
        private System.Windows.Forms.Label patientIDContent;
    }
}