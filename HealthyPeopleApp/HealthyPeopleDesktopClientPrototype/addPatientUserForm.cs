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

        private List<String> patient;
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

            _HealthyPeopleDB_TestDataSet.PatientRow patientRow;
            _HealthyPeopleDB_TestDataSet.PatientUserTableRow userTableRow;
            userTableRow = this._HealthyPeopleDB_TestDataSet.PatientUserTable.NewPatientUserTableRow();
            patientRow = this._HealthyPeopleDB_TestDataSet.Patient.NewPatientRow();

            patientRow.PatientName = patientNameTextBox.Text;//  patientRow.PatientName name
            patientRow.PatientPhoneNumber = patientPhoneNumberTextBox.Text;//patientRow.PatientPhoneNumber phoneNum 
            patientRow.PatientBirthDate = patientBirthDateDateTimePicker.Value;//patientRow.PatientBirthDate birthDate 
            patientRow.PatientZip = patientZipTextBox.Text;//patientRow.PatientZip  zip 
            patientRow.PatientCity  = patientCityTextBox.Text;//city
            patientRow.EmailAddress = emailAddressTextBox.Text;//emailAddress 
            patientRow.PatientState = patientStateTextBox.Text; //state
            patientRow.PatientAddress = patientAddressTextBox.Text;//address 
            patientRow.PatientUserID = patientUserIDTextBox1.Text;//userID 
             userTableRow.PatientUserID = patientUserIDTextBox1.Text;
            userTableRow.PatientPassword = patientPasswordTextBox.Text;
            

            try
            {
                this._HealthyPeopleDB_TestDataSet.PatientUserTable.Rows.Add(userTableRow);
                this.patientUserTableTableAdapter1.Update(this._HealthyPeopleDB_TestDataSet.PatientUserTable);

                bool isItHere = this._HealthyPeopleDB_TestDataSet.PatientUserTable.Contains(userTableRow);
                if (isItHere)
                    MessageBox.Show("It's Here!");
                else
                    MessageBox.Show("something's wrong");
                this._HealthyPeopleDB_TestDataSet.Patient.Rows.Add(patientRow);
                this.patientTableAdapter1.Update(this._HealthyPeopleDB_TestDataSet.Patient);
                isItHere = this._HealthyPeopleDB_TestDataSet.Patient.Contains(patientRow);
                if (isItHere)
                    MessageBox.Show("It's Here!");
                else
                    MessageBox.Show("something's wrong");



                MessageBox.Show("Data Saved");
               // con.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show("{0}", ex.Source);
                MessageBox.Show("{0}", ex.StackTrace);
                this.DialogResult = DialogResult.Cancel;// this.DialogResult = DialogResult.OK;
            }

        }
    }
}
