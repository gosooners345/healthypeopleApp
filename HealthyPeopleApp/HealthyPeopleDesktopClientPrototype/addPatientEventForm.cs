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
        
        public addPatientEventForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

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
    }
}
