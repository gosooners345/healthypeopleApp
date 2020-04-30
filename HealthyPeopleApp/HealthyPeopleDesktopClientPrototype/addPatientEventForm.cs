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
        public string typeTag;
        //_HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter patientRecordsTableAdapter;
        public int eventID;
           _HealthyPeopleDB_TestDataSet.PatientRecordsRow patientRecords;


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
            //Add Patient Health events to record
            if (typeTag == "New")
            {
                patientRecords = this._HealthyPeopleDB_TestDataSet.PatientRecords.NewPatientRecordsRow();

                patientRecords.PatientID = Int32.Parse(patientIDLabel1.Text);
                patientRecords.PatientEvent = patientEventTextBox.Text;
                patientRecords.PatientEventDate = patientEventDateDateTimePicker.Value.Date;
                patientRecords.PatientEventDescription = eventDescRTB.Text;
                //Save an event to a patient's health record
                try
                {

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
            else if(typeTag == "Update")
            {
                //Update Patient Records
               
                    patientRecords = this._HealthyPeopleDB_TestDataSet.PatientRecords.FindByPatientEventID(eventID);
                    patientRecords.PatientID = Int32.Parse(patientIDLabel1.Text);
                    patientRecords.PatientEvent = patientEventTextBox.Text;
                    patientRecords.PatientEventDate = patientEventDateDateTimePicker.Value.Date;
                    patientRecords.PatientEventDescription = eventDescRTB.Text;
                    //Update Patient Record
                 try
                {
                    
                    this.patientRecordsTableAdapter.Update(patientRecords);
                    
                    this.DialogResult = DialogResult.OK;
                }
catch(Exception ex)
                {
                    MessageBox.Show(ex.Source, ex.Source);
                    this.DialogResult = DialogResult.Cancel;
                }

            }
        }

       
        private void AddPatientEventForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_HealthyPeopleDB_TestDataSet.PatientRecords' table. You can move, or remove it, as needed.
          
           
            switch (typeTag)
            {
                case "Update": Text = "Update";
                    this.patientRecordsTableAdapter.Fill(_HealthyPeopleDB_TestDataSet.PatientRecords);// ByPatientID(_HealthyPeopleDB_TestDataSet.PatientRecords, patientID);
                    patientRecords = _HealthyPeopleDB_TestDataSet.PatientRecords.FindByPatientEventID(eventID);
                    patientIDLabel1.Text = patientID.ToString();
                    patientEventIDLabel2.Text = eventID.ToString();
                    patientEventTextBox.Text = patientRecords.PatientEvent;
                    eventDescRTB.Text = patientRecords.PatientEventDescription;
                    patientEventDateDateTimePicker.Value = patientRecords.PatientEventDate;

                    break;
                case "New": Text = "Add New Event"; break;
            }
        }

    }
}
