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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            _HealthyPeopleDB_TestDataSet.PatientRecordsRow patientRecords;
            patientRecords = this._HealthyPeopleDB_TestDataSet.PatientRecords.NewPatientRecordsRow();
            patientIDContent.Text = patientID.ToString();
            patientRecords.PatientID = Int32.Parse(patientIDContent.ToString());
            patientRecords.PatientEvent = patientEventTextBox.Text;
            patientRecords.PatientEventDate = patientEventDateDateTimePicker.Value.Date;
            try {
                this._HealthyPeopleDB_TestDataSet.PatientRecords.Rows.Add(patientRecords);
                this.patientRecordsTableAdapter.Update(this._HealthyPeopleDB_TestDataSet.PatientRecords);
                bool isItHere = this._HealthyPeopleDB_TestDataSet.PatientRecords.Contains(patientRecords);
                if (isItHere)
                    MessageBox.Show("It's Here!");
                else
                    MessageBox.Show("something's wrong");
                MessageBox.Show("Data Saved");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source, ex.Message);
            }
            // _HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter patient = new _HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter();

        }

        private void PatientRecordsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientRecordsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._HealthyPeopleDB_TestDataSet);

        }

        private void AddPatientEventForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_HealthyPeopleDB_TestDataSet.PatientRecords' table. You can move, or remove it, as needed.
            this.patientRecordsTableAdapter.Fill(this._HealthyPeopleDB_TestDataSet.PatientRecords);

        }

        private void PatientEventIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
