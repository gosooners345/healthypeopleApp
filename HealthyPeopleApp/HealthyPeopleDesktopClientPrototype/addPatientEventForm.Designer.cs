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
            System.Windows.Forms.Label patientEventIDLabel1;
            System.Windows.Forms.Label patientEventLabel1;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label patientEventDateLabel;
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this._HealthyPeopleDB_TestDataSet = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet();
            this.patientRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientRecordsTableAdapter = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter();
            this.tableAdapterManager = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.TableAdapterManager();
            this.patientIDlabelStrip = new System.Windows.Forms.Label();
            this.patientEventIDLabel2 = new System.Windows.Forms.Label();
            this.patientEventTextBox = new System.Windows.Forms.TextBox();
            this.patientIDLabel1 = new System.Windows.Forms.Label();
            this.patientEventDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientEventDesc = new System.Windows.Forms.Label();
            this.eventDescRTB = new System.Windows.Forms.RichTextBox();
            patientEventIDLabel1 = new System.Windows.Forms.Label();
            patientEventLabel1 = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            patientEventDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._HealthyPeopleDB_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patientEventIDLabel1
            // 
            patientEventIDLabel1.AutoSize = true;
            patientEventIDLabel1.Location = new System.Drawing.Point(35, 19);
            patientEventIDLabel1.Name = "patientEventIDLabel1";
            patientEventIDLabel1.Size = new System.Drawing.Size(88, 13);
            patientEventIDLabel1.TabIndex = 20;
            patientEventIDLabel1.Text = "Patient Event ID:";
            // 
            // patientEventLabel1
            // 
            patientEventLabel1.AutoSize = true;
            patientEventLabel1.Location = new System.Drawing.Point(49, 41);
            patientEventLabel1.Name = "patientEventLabel1";
            patientEventLabel1.Size = new System.Drawing.Size(74, 13);
            patientEventLabel1.TabIndex = 21;
            patientEventLabel1.Text = "Patient Event:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(66, 71);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 22;
            patientIDLabel.Text = "Patient ID:";
            // 
            // patientEventDateLabel
            // 
            patientEventDateLabel.AutoSize = true;
            patientEventDateLabel.Location = new System.Drawing.Point(23, 102);
            patientEventDateLabel.Name = "patientEventDateLabel";
            patientEventDateLabel.Size = new System.Drawing.Size(100, 13);
            patientEventDateLabel.TabIndex = 23;
            patientEventDateLabel.Text = "Patient Event Date:";
            // 
            // submitButton
            // 
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.submitButton.Location = new System.Drawing.Point(52, 272);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 28);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(254, 275);
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
            // patientIDlabelStrip
            // 
            this.patientIDlabelStrip.AutoSize = true;
            this.patientIDlabelStrip.Location = new System.Drawing.Point(132, 71);
            this.patientIDlabelStrip.Name = "patientIDlabelStrip";
            this.patientIDlabelStrip.Size = new System.Drawing.Size(0, 13);
            this.patientIDlabelStrip.TabIndex = 20;
            // 
            // patientEventIDLabel2
            // 
            this.patientEventIDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientEventID", true));
            this.patientEventIDLabel2.Location = new System.Drawing.Point(132, 19);
            this.patientEventIDLabel2.Name = "patientEventIDLabel2";
            this.patientEventIDLabel2.Size = new System.Drawing.Size(100, 23);
            this.patientEventIDLabel2.TabIndex = 21;
            this.patientEventIDLabel2.Text = "label1";
            // 
            // patientEventTextBox
            // 
            this.patientEventTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientEvent", true));
            this.patientEventTextBox.Location = new System.Drawing.Point(132, 38);
            this.patientEventTextBox.Name = "patientEventTextBox";
            this.patientEventTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientEventTextBox.TabIndex = 22;
            // 
            // patientIDLabel1
            // 
            this.patientIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientRecordsBindingSource, "PatientID", true));
            this.patientIDLabel1.Location = new System.Drawing.Point(129, 71);
            this.patientIDLabel1.Name = "patientIDLabel1";
            this.patientIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.patientIDLabel1.TabIndex = 23;
            this.patientIDLabel1.Text = "label1";
            // 
            // patientEventDateDateTimePicker
            // 
            this.patientEventDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientRecordsBindingSource, "PatientEventDate", true));
            this.patientEventDateDateTimePicker.Location = new System.Drawing.Point(129, 98);
            this.patientEventDateDateTimePicker.Name = "patientEventDateDateTimePicker";
            this.patientEventDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.patientEventDateDateTimePicker.TabIndex = 24;
            // 
            // patientEventDesc
            // 
            this.patientEventDesc.AutoSize = true;
            this.patientEventDesc.Location = new System.Drawing.Point(26, 137);
            this.patientEventDesc.Name = "patientEventDesc";
            this.patientEventDesc.Size = new System.Drawing.Size(91, 13);
            this.patientEventDesc.TabIndex = 26;
            this.patientEventDesc.Text = "Event Description";
            // 
            // eventDescRTB
            // 
            this.eventDescRTB.Location = new System.Drawing.Point(129, 137);
            this.eventDescRTB.Name = "eventDescRTB";
            this.eventDescRTB.Size = new System.Drawing.Size(200, 109);
            this.eventDescRTB.TabIndex = 27;
            this.eventDescRTB.Text = "";
            // 
            // addPatientEventForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(457, 331);
            this.Controls.Add(this.eventDescRTB);
            this.Controls.Add(this.patientEventDesc);
            this.Controls.Add(patientEventDateLabel);
            this.Controls.Add(this.patientEventDateDateTimePicker);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDLabel1);
            this.Controls.Add(patientEventLabel1);
            this.Controls.Add(this.patientEventTextBox);
            this.Controls.Add(patientEventIDLabel1);
            this.Controls.Add(this.patientEventIDLabel2);
            this.Controls.Add(this.patientIDlabelStrip);
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
        private System.Windows.Forms.Label patientIDlabelStrip;
        private System.Windows.Forms.Label patientEventIDLabel2;
        private System.Windows.Forms.TextBox patientEventTextBox;
        private System.Windows.Forms.Label patientIDLabel1;
        private System.Windows.Forms.DateTimePicker patientEventDateDateTimePicker;
        private System.Windows.Forms.Label patientEventDesc;
        private System.Windows.Forms.RichTextBox eventDescRTB;
    }
}