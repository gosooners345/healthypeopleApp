using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyPeopleDesktopClientPrototype
{
    public partial class addPatientEventForm : Form
    {
        public  int patientID;
        public addPatientEventForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Save health event record to patient's records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            _HealthyPeopleDB_TestDataSet.PatientRecordsRow patientRecords;
            patientRecords = this._HealthyPeopleDB_TestDataSet.PatientRecords.NewPatientRecordsRow();
            
            patientRecords.PatientID = Int32.Parse(patientIDLabel1.Text);
            patientRecords.PatientEvent = patientEventTextBox.Text;
            patientRecords.PatientEventDate = patientEventDateDateTimePicker.Value.Date;
            //Save an event to a patient's health record
            try {

                this._HealthyPeopleDB_TestDataSet.PatientRecords.Rows.Add(patientRecords);
                this.patientRecordsTableAdapter.Update(this._HealthyPeopleDB_TestDataSet.PatientRecords);
                
                MessageBox.Show("Data Saved");
                this.DialogResult = DialogResult.OK;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, ex.Message);
            }

        }

       
        private void AddPatientEventForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_HealthyPeopleDB_TestDataSet.PatientRecords' table. You can move, or remove it, as needed.
          
            patientIDLabel1.Text = patientID.ToString();
        }

        private void PatientEventIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
