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
        

        private void PatientPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        
        private void AddPatientUserForm_Load(object sender, EventArgs e)
        {
           
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
        
          
            // Adds new patient and user data to database
            //User Data
            _HealthyPeopleDB_TestDataSet.PatientRow patientRow;
            _HealthyPeopleDB_TestDataSet.PatientUserTableRow userTableRow;
            userTableRow = this._HealthyPeopleDB_TestDataSet.PatientUserTable.NewPatientUserTableRow();
            patientRow = this._HealthyPeopleDB_TestDataSet.Patient.NewPatientRow();
            patientRow.PatientName = patientNameTextBox.Text;
            patientRow.PatientPhoneNumber = patientPhoneNumberTextBox.Text;
            patientRow.PatientBirthDate = patientBirthDateDateTimePicker.Value;
            patientRow.PatientZip = patientZipTextBox.Text;
            patientRow.PatientCity  = patientCityTextBox.Text;
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
                this.DialogResult = DialogResult.Cancel;// this.DialogResult = DialogResult.OK;
            }

        }
    }
}
