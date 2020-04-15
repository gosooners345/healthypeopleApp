using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyPeopleDesktopClientPrototype
{
    public partial class addPatientUserForm : Form

    {
        //Class wide variables
        public int patientID;
        _HealthyPeopleDB_TestDataSet.PatientRow patientRow;
        _HealthyPeopleDB_TestDataSet.PatientUserTableRow userTableRow;
        public string typeTag;

        private void PatientPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        //Load form
        private void AddPatientUserForm_Load(object sender, EventArgs e)
        {

            switch(typeTag)
            {
                //Create new patient form
                case "Add":
                    Text = "Add New Patient";
                   
                    newUserRadio.Checked = true;
                    existingPatientRadio.Checked = false; break;
                case "Update":
                    this.Text = "Update Patient Info"; 
                //Fill form with existing patient data
                    existingPatientRadio.Checked = true; newUserRadio.Checked = false;
                    this.patientTableAdapter1.Fill(this._HealthyPeopleDB_TestDataSet.Patient);
                    this.patientUserTableTableAdapter1.Fill(_HealthyPeopleDB_TestDataSet.PatientUserTable);
                    patientRow = this._HealthyPeopleDB_TestDataSet.Patient.FindByPatientID(patientID);
                    userTableRow = this._HealthyPeopleDB_TestDataSet.PatientUserTable.FindByPatientUserID(patientRow.PatientUserID);
                    patientIDTextBox.Text = patientRow.PatientID.ToString();
                    patientUserIDTextBox1.Text = patientRow.PatientUserID;
                    patientPasswordTextBox.Text = userTableRow.PatientPassword;
                    patientNameTextBox.Text = patientRow.PatientName;
                    patientStateTextBox.Text = patientRow.PatientState;
                    patientCityTextBox.Text = patientRow.PatientCity;
                    emailAddressTextBox.Text = patientRow.EmailAddress;
                    patientAddressTextBox.Text = patientRow.PatientAddress;
                   
                    doctorsTextBox.Text = "";

                    patientPhoneNumberTextBox.Text = patientRow.PatientPhoneNumber;
                    patientBirthDateDateTimePicker.Value = patientRow.PatientBirthDate;
                    patientZipTextBox.Text = patientRow.PatientZip;

                    break;
            }
        }

       
        
        public addPatientUserForm()
        {
            InitializeComponent();
        
        }
       
      
        private void LoadData(object sender, EventArgs e)
        {

            this.patientTableAdapter1.Fill(_HealthyPeopleDB_TestDataSet.Patient);
            this.patientUserTableTableAdapter1.Fill(_HealthyPeopleDB_TestDataSet.PatientUserTable);


        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (newUserRadio.Checked)
            // Adds new patient and user data to database
            //User Data
            {
               
                userTableRow = this._HealthyPeopleDB_TestDataSet.PatientUserTable.NewPatientUserTableRow();
                patientRow = this._HealthyPeopleDB_TestDataSet.Patient.NewPatientRow();
                patientRow.PatientName = patientNameTextBox.Text;
                patientRow.PatientPhoneNumber = patientPhoneNumberTextBox.Text;
                patientRow.PatientBirthDate = patientBirthDateDateTimePicker.Value;
                patientRow.PatientZip = patientZipTextBox.Text;
                patientRow.Doctors = doctorsTextBox.Text;
                patientRow.PatientCity = patientCityTextBox.Text;
                patientRow.EmailAddress = emailAddressTextBox.Text;
                patientRow.PatientState = patientStateTextBox.Text; //state
                patientRow.PatientAddress = patientAddressTextBox.Text;//address 
                patientRow.PatientUserID = patientUserIDTextBox1.Text;//userID 
                userTableRow.PatientUserID = patientUserIDTextBox1.Text;
                userTableRow.PatientPassword = patientPasswordTextBox.Text;

                //Update Tables with new patient records
                try
                {
                    //Add and Update Records
                    this._HealthyPeopleDB_TestDataSet.PatientUserTable.Rows.Add(userTableRow);
                    this.patientUserTableTableAdapter1.Update(this._HealthyPeopleDB_TestDataSet.PatientUserTable);
                    this._HealthyPeopleDB_TestDataSet.Patient.Rows.Add(patientRow);
                    this.patientTableAdapter1.Update(this._HealthyPeopleDB_TestDataSet.Patient);
                    MessageBox.Show("Data Saved");
                    this.DialogResult = DialogResult.OK;
                }
                //Catches an exception
                catch (Exception ex)
                {

                    MessageBox.Show("{0}", ex.Source);
                    MessageBox.Show("{0}", ex.StackTrace);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            //Update Patient User Data In System
            else if (existingPatientRadio.Checked)
            {
                //Update data in variable
                try
                {
                    patientRow.PatientName = patientNameTextBox.Text;
                patientRow.PatientPhoneNumber = patientPhoneNumberTextBox.Text;
                patientRow.PatientBirthDate = patientBirthDateDateTimePicker.Value;
                patientRow.PatientZip = patientZipTextBox.Text;
                patientRow.PatientCity = patientCityTextBox.Text;
                patientRow.EmailAddress = emailAddressTextBox.Text;
                patientRow.PatientState = patientStateTextBox.Text;
                patientRow.PatientAddress = patientAddressTextBox.Text;
                patientRow.PatientUserID = patientUserIDTextBox1.Text;
                userTableRow.PatientUserID = patientUserIDTextBox1.Text;
                patientRow.Doctors = doctorsTextBox.Text;
                userTableRow.PatientPassword = patientPasswordTextBox.Text;

                //Update tables with new data
                    this.patientUserTableTableAdapter1.Update(userTableRow);
                    this.patientTableAdapter1.Update(patientRow);
                    this.DialogResult = DialogResult.OK;

                }
                // In case of any errors
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Source, ex.Message);
                    this.DialogResult = DialogResult.Cancel;
                }

            }
        }
    }
}
