namespace HealthyPeopleDesktopClientPrototype
{
    partial class addPatientUserForm
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
            System.Windows.Forms.Label patientPasswordLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label patientNameLabel;
            System.Windows.Forms.Label emailAddressLabel;
            System.Windows.Forms.Label patientUserIDLabel1;
            System.Windows.Forms.Label patientAddressLabel;
            System.Windows.Forms.Label patientCityLabel;
            System.Windows.Forms.Label patientStateLabel;
            System.Windows.Forms.Label patientZipLabel;
            System.Windows.Forms.Label doctorsLabel;
            System.Windows.Forms.Label patientPhoneNumberLabel;
            System.Windows.Forms.Label patientBirthDateLabel;
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.patientTableAdapter1 = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.PatientTableAdapter();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.TableAdapterManager();
            this.patientUserTableTableAdapter1 = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.PatientUserTableTableAdapter();
            this._HealthyPeopleDB_TestDataSet = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet();
            this.patientUserTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientPasswordTextBox = new System.Windows.Forms.TextBox();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.patientUserIDTextBox1 = new System.Windows.Forms.TextBox();
            this.patientAddressTextBox = new System.Windows.Forms.TextBox();
            this.patientCityTextBox = new System.Windows.Forms.TextBox();
            this.patientStateTextBox = new System.Windows.Forms.TextBox();
            this.patientZipTextBox = new System.Windows.Forms.TextBox();
            this.doctorsTextBox = new System.Windows.Forms.TextBox();
            this.patientPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.patientBirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newUserRadio = new System.Windows.Forms.RadioButton();
            this.existingPatientRadio = new System.Windows.Forms.RadioButton();
            patientPasswordLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            patientNameLabel = new System.Windows.Forms.Label();
            emailAddressLabel = new System.Windows.Forms.Label();
            patientUserIDLabel1 = new System.Windows.Forms.Label();
            patientAddressLabel = new System.Windows.Forms.Label();
            patientCityLabel = new System.Windows.Forms.Label();
            patientStateLabel = new System.Windows.Forms.Label();
            patientZipLabel = new System.Windows.Forms.Label();
            doctorsLabel = new System.Windows.Forms.Label();
            patientPhoneNumberLabel = new System.Windows.Forms.Label();
            patientBirthDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._HealthyPeopleDB_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientUserTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientPasswordLabel
            // 
            patientPasswordLabel.AutoSize = true;
            patientPasswordLabel.Location = new System.Drawing.Point(42, 121);
            patientPasswordLabel.Name = "patientPasswordLabel";
            patientPasswordLabel.Size = new System.Drawing.Size(92, 13);
            patientPasswordLabel.TabIndex = 24;
            patientPasswordLabel.Text = "Patient Password:";
            patientPasswordLabel.Click += new System.EventHandler(this.PatientPasswordLabel_Click);
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(41, 151);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 25;
            patientIDLabel.Text = "Patient ID:";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Location = new System.Drawing.Point(41, 177);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new System.Drawing.Size(74, 13);
            patientNameLabel.TabIndex = 27;
            patientNameLabel.Text = "Patient Name:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new System.Drawing.Point(41, 203);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(76, 13);
            emailAddressLabel.TabIndex = 29;
            emailAddressLabel.Text = "Email Address:";
            // 
            // patientUserIDLabel1
            // 
            patientUserIDLabel1.AutoSize = true;
            patientUserIDLabel1.Location = new System.Drawing.Point(41, 88);
            patientUserIDLabel1.Name = "patientUserIDLabel1";
            patientUserIDLabel1.Size = new System.Drawing.Size(82, 13);
            patientUserIDLabel1.TabIndex = 31;
            patientUserIDLabel1.Text = "Patient User ID:";
            // 
            // patientAddressLabel
            // 
            patientAddressLabel.AutoSize = true;
            patientAddressLabel.Location = new System.Drawing.Point(41, 255);
            patientAddressLabel.Name = "patientAddressLabel";
            patientAddressLabel.Size = new System.Drawing.Size(84, 13);
            patientAddressLabel.TabIndex = 33;
            patientAddressLabel.Text = "Patient Address:";
            // 
            // patientCityLabel
            // 
            patientCityLabel.AutoSize = true;
            patientCityLabel.Location = new System.Drawing.Point(41, 281);
            patientCityLabel.Name = "patientCityLabel";
            patientCityLabel.Size = new System.Drawing.Size(63, 13);
            patientCityLabel.TabIndex = 35;
            patientCityLabel.Text = "Patient City:";
            // 
            // patientStateLabel
            // 
            patientStateLabel.AutoSize = true;
            patientStateLabel.Location = new System.Drawing.Point(41, 307);
            patientStateLabel.Name = "patientStateLabel";
            patientStateLabel.Size = new System.Drawing.Size(71, 13);
            patientStateLabel.TabIndex = 37;
            patientStateLabel.Text = "Patient State:";
            // 
            // patientZipLabel
            // 
            patientZipLabel.AutoSize = true;
            patientZipLabel.Location = new System.Drawing.Point(41, 333);
            patientZipLabel.Name = "patientZipLabel";
            patientZipLabel.Size = new System.Drawing.Size(61, 13);
            patientZipLabel.TabIndex = 39;
            patientZipLabel.Text = "Patient Zip:";
            // 
            // doctorsLabel
            // 
            doctorsLabel.AutoSize = true;
            doctorsLabel.Location = new System.Drawing.Point(41, 359);
            doctorsLabel.Name = "doctorsLabel";
            doctorsLabel.Size = new System.Drawing.Size(47, 13);
            doctorsLabel.TabIndex = 41;
            doctorsLabel.Text = "Doctors:";
            // 
            // patientPhoneNumberLabel
            // 
            patientPhoneNumberLabel.AutoSize = true;
            patientPhoneNumberLabel.Location = new System.Drawing.Point(41, 385);
            patientPhoneNumberLabel.Name = "patientPhoneNumberLabel";
            patientPhoneNumberLabel.Size = new System.Drawing.Size(117, 13);
            patientPhoneNumberLabel.TabIndex = 43;
            patientPhoneNumberLabel.Text = "Patient Phone Number:";
            // 
            // patientBirthDateLabel
            // 
            patientBirthDateLabel.AutoSize = true;
            patientBirthDateLabel.Location = new System.Drawing.Point(41, 412);
            patientBirthDateLabel.Name = "patientBirthDateLabel";
            patientBirthDateLabel.Size = new System.Drawing.Size(93, 13);
            patientBirthDateLabel.TabIndex = 45;
            patientBirthDateLabel.Text = "Patient Birth Date:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(59, 469);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(289, 469);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EmployeeDetailsTableAdapter = null;
            this.tableAdapterManager1.JobsTableAdapter = null;
            this.tableAdapterManager1.PatientRecordsTableAdapter = null;
            this.tableAdapterManager1.PatientTableAdapter = this.patientTableAdapter1;
            this.tableAdapterManager1.PatientUserTableTableAdapter = this.patientUserTableTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserTableTableAdapter = null;
            // 
            // patientUserTableTableAdapter1
            // 
            this.patientUserTableTableAdapter1.ClearBeforeFill = true;
            // 
            // _HealthyPeopleDB_TestDataSet
            // 
            this._HealthyPeopleDB_TestDataSet.DataSetName = "_HealthyPeopleDB_TestDataSet";
            this._HealthyPeopleDB_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientUserTableBindingSource
            // 
            this.patientUserTableBindingSource.DataMember = "PatientUserTable";
            this.patientUserTableBindingSource.DataSource = this._HealthyPeopleDB_TestDataSet;
            // 
            // patientPasswordTextBox
            // 
            this.patientPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientUserTableBindingSource, "PatientPassword", true));
            this.patientPasswordTextBox.Location = new System.Drawing.Point(163, 118);
            this.patientPasswordTextBox.Name = "patientPasswordTextBox";
            this.patientPasswordTextBox.PasswordChar = '*';
            this.patientPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.patientPasswordTextBox.TabIndex = 25;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "PatientUserTablePatient";
            this.patientBindingSource1.DataSource = this.patientUserTableBindingSource;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientID", true));
            this.patientIDTextBox.Location = new System.Drawing.Point(164, 148);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientIDTextBox.TabIndex = 26;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientName", true));
            this.patientNameTextBox.Location = new System.Drawing.Point(164, 174);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientNameTextBox.TabIndex = 28;
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "EmailAddress", true));
            this.emailAddressTextBox.Location = new System.Drawing.Point(164, 200);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailAddressTextBox.TabIndex = 30;
            // 
            // patientUserIDTextBox1
            // 
            this.patientUserIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientUserID", true));
            this.patientUserIDTextBox1.Location = new System.Drawing.Point(163, 88);
            this.patientUserIDTextBox1.Name = "patientUserIDTextBox1";
            this.patientUserIDTextBox1.Size = new System.Drawing.Size(200, 20);
            this.patientUserIDTextBox1.TabIndex = 32;
            // 
            // patientAddressTextBox
            // 
            this.patientAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientAddress", true));
            this.patientAddressTextBox.Location = new System.Drawing.Point(164, 252);
            this.patientAddressTextBox.Name = "patientAddressTextBox";
            this.patientAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientAddressTextBox.TabIndex = 34;
            // 
            // patientCityTextBox
            // 
            this.patientCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientCity", true));
            this.patientCityTextBox.Location = new System.Drawing.Point(164, 278);
            this.patientCityTextBox.Name = "patientCityTextBox";
            this.patientCityTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientCityTextBox.TabIndex = 36;
            // 
            // patientStateTextBox
            // 
            this.patientStateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientState", true));
            this.patientStateTextBox.Location = new System.Drawing.Point(164, 304);
            this.patientStateTextBox.Name = "patientStateTextBox";
            this.patientStateTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientStateTextBox.TabIndex = 38;
            // 
            // patientZipTextBox
            // 
            this.patientZipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientZip", true));
            this.patientZipTextBox.Location = new System.Drawing.Point(164, 330);
            this.patientZipTextBox.Name = "patientZipTextBox";
            this.patientZipTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientZipTextBox.TabIndex = 40;
            // 
            // doctorsTextBox
            // 
            this.doctorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "Doctors", true));
            this.doctorsTextBox.Location = new System.Drawing.Point(164, 356);
            this.doctorsTextBox.Name = "doctorsTextBox";
            this.doctorsTextBox.Size = new System.Drawing.Size(200, 20);
            this.doctorsTextBox.TabIndex = 42;
            // 
            // patientPhoneNumberTextBox
            // 
            this.patientPhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource1, "PatientPhoneNumber", true));
            this.patientPhoneNumberTextBox.Location = new System.Drawing.Point(164, 382);
            this.patientPhoneNumberTextBox.Name = "patientPhoneNumberTextBox";
            this.patientPhoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientPhoneNumberTextBox.TabIndex = 44;
            // 
            // patientBirthDateDateTimePicker
            // 
            this.patientBirthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource1, "PatientBirthDate", true));
            this.patientBirthDateDateTimePicker.Location = new System.Drawing.Point(164, 408);
            this.patientBirthDateDateTimePicker.Name = "patientBirthDateDateTimePicker";
            this.patientBirthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.patientBirthDateDateTimePicker.TabIndex = 46;
            // 
            // newUserRadio
            // 
            this.newUserRadio.AutoSize = true;
            this.newUserRadio.Location = new System.Drawing.Point(73, 37);
            this.newUserRadio.Name = "newUserRadio";
            this.newUserRadio.Size = new System.Drawing.Size(83, 17);
            this.newUserRadio.TabIndex = 47;
            this.newUserRadio.TabStop = true;
            this.newUserRadio.Text = "New Patient";
            this.newUserRadio.UseVisualStyleBackColor = true;
            // 
            // existingPatientRadio
            // 
            this.existingPatientRadio.AutoSize = true;
            this.existingPatientRadio.Location = new System.Drawing.Point(268, 37);
            this.existingPatientRadio.Name = "existingPatientRadio";
            this.existingPatientRadio.Size = new System.Drawing.Size(97, 17);
            this.existingPatientRadio.TabIndex = 48;
            this.existingPatientRadio.TabStop = true;
            this.existingPatientRadio.Text = "Existing Patient";
            this.existingPatientRadio.UseVisualStyleBackColor = true;
            // 
            // addPatientUserForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(457, 534);
            this.Controls.Add(this.existingPatientRadio);
            this.Controls.Add(this.newUserRadio);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(patientNameLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(emailAddressLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(patientUserIDLabel1);
            this.Controls.Add(this.patientUserIDTextBox1);
            this.Controls.Add(patientAddressLabel);
            this.Controls.Add(this.patientAddressTextBox);
            this.Controls.Add(patientCityLabel);
            this.Controls.Add(this.patientCityTextBox);
            this.Controls.Add(patientStateLabel);
            this.Controls.Add(this.patientStateTextBox);
            this.Controls.Add(patientZipLabel);
            this.Controls.Add(this.patientZipTextBox);
            this.Controls.Add(doctorsLabel);
            this.Controls.Add(this.doctorsTextBox);
            this.Controls.Add(patientPhoneNumberLabel);
            this.Controls.Add(this.patientPhoneNumberTextBox);
            this.Controls.Add(patientBirthDateLabel);
            this.Controls.Add(this.patientBirthDateDateTimePicker);
            this.Controls.Add(patientPasswordLabel);
            this.Controls.Add(this.patientPasswordTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Name = "addPatientUserForm";
            this.Text = "addPatientUserForm";
            this.Load += new System.EventHandler(this.AddPatientUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._HealthyPeopleDB_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientUserTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _HealthyPeopleDB_TestDataSetTableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private _HealthyPeopleDB_TestDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private _HealthyPeopleDB_TestDataSetTableAdapters.PatientUserTableTableAdapter patientUserTableTableAdapter1;
        private _HealthyPeopleDB_TestDataSet _HealthyPeopleDB_TestDataSet;
        private System.Windows.Forms.BindingSource patientUserTableBindingSource;
        private System.Windows.Forms.TextBox patientPasswordTextBox;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.TextBox patientUserIDTextBox1;
        private System.Windows.Forms.TextBox patientAddressTextBox;
        private System.Windows.Forms.TextBox patientCityTextBox;
        private System.Windows.Forms.TextBox patientStateTextBox;
        private System.Windows.Forms.TextBox patientZipTextBox;
        private System.Windows.Forms.TextBox doctorsTextBox;
        private System.Windows.Forms.TextBox patientPhoneNumberTextBox;
        private System.Windows.Forms.DateTimePicker patientBirthDateDateTimePicker;
        private System.Windows.Forms.RadioButton newUserRadio;
        private System.Windows.Forms.RadioButton existingPatientRadio;
    }
}