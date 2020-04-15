using System;
using System.Configuration;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Forms;

using System.Windows.Shapes;

namespace HealthyPeopleDesktopClientPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string conString = "HealthyPeopleDesktopClientPrototype.Properties.Settings.HealthyPeopleDB_TestConnectionString";
        protected int patientIDRec;
            protected static List<String> patientInfo;// = new List<string>();
        public MainWindow()
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            if (loginWindow.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                InitializeComponent();
                LoadGrid();
                patientInfo = new List<string>();
            }
            else
                System.Windows.Application.Current.Shutdown();
            // InitializeComponent();
            // LoadGrid();


        }

        private void SignOffButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            if (loginWindow.DialogResult == System.Windows.Forms.DialogResult.OK)
            { InitializeComponent();
          
            }
            else
                System.Windows.Application.Current.Shutdown();
        }
        /// <summary>
        /// Load the Patient Records into the program
        /// </summary>
        private void LoadGrid()
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings[conString].ToString();
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.CommandText = "select * from [PatientRecords]";
            command.Connection = con;
            OleDbDataReader reader = command.ExecuteReader();

            healthRecGrid.ItemsSource = reader;
           

        }
        /// <summary>
        /// Searches the DB for patient name
        /// </summary>
        /// <param name="search">Search Entry</param>
        private void LoadGrid(int search)
        {
            
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings[conString].ToString();
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.CommandText = String.Format("select * from [PatientRecords] WHERE PatientID = {0}",search);
            command.Connection = con;
            OleDbDataReader reader = command.ExecuteReader();

            healthRecGrid.ItemsSource = reader;
           
          
        }
        /// <summary>
        /// Searches for Patient Records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string searchBy = searchPatientTextBox.Text;
            int searchID;
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings[conString].ToString();
            con.Open();
            OleDbCommand command = new OleDbCommand();
            bool success = false;

            command.CommandText = String.Format("select * from [Patient] WHERE [Patient.PatientName] = '{0}'", searchBy);
            command.Connection = con;
            OleDbDataReader reader = command.ExecuteReader();

            List<String> patientNames = new List<string>();
            List<int> patientIDs = new List<int>();

           // Searches the DB for the patient and returns the data to the form
            try
            {
                while (reader.Read())
                {
               
                    success = true;
                    searchID = Int32.Parse(reader["PatientID"].ToString());
                    LoadGrid(searchID);
                    this.patientIDTextBox.Content = searchID.ToString();
                    this.patientNameTextBox1.Content = reader["PatientName"].ToString();
                    patientAddressTextBox.Content = reader["PatientAddress"].ToString();
                    patientCityTextBox.Content = reader["PatientCity"].ToString();
                    patientUserIDTextBox.Content = reader["PatientUserID"].ToString();
                    patientBirthDateDatePicker.SelectedDate = DateTime.Parse(reader["PatientBirthDate"].ToString());
                    patientPhoneNumberTextBox.Content = reader["PatientPhoneNumber"].ToString();
                    emailAddressTextBox.Content = reader["EmailAddress"].ToString();
                    patientStateTextBox.Content = reader["PatientState"].ToString();
                    patientZipTextBox.Content = reader["PatientZip"].ToString();
                    patientIDRec = Int32.Parse(patientIDTextBox.Content.ToString());
                }
            }
            catch
            {
                success = false;
                System.Windows.MessageBox.Show(String.Format("{0}: Names didn't Load Properly", success));

            }
            reader.Close();
            con.Close();

        }
        //Adds new patient to system
        private void AddPatientButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                addPatientUserForm add = new addPatientUserForm();
                add.typeTag = "Add";
                add.ShowDialog();
                if (add.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    LoadGrid();
                }
                else
                {
                    add.Dispose();
                }

              
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// Allows Patient information to be updated in system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePatientButton_Click(object sender, RoutedEventArgs e)
        {
            addPatientUserForm updatePatient = new addPatientUserForm();
            int patientID = patientIDRec;
          
            updatePatient.patientID = patientID;
            updatePatient.typeTag = "Update"; updatePatient.ShowDialog();
            if (updatePatient.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                LoadGrid(patientID);
            }
            else
            {
                updatePatient.Dispose();
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet _HealthyPeopleDB_TestDataSet = ((HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet)(this.FindResource("_HealthyPeopleDB_TestDataSet")));
            // Load data into the table EmployeeDetails. You can modify this code as needed.
            HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.EmployeeDetailsTableAdapter _HealthyPeopleDB_TestDataSetEmployeeDetailsTableAdapter = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.EmployeeDetailsTableAdapter();
            _HealthyPeopleDB_TestDataSetEmployeeDetailsTableAdapter.Fill(_HealthyPeopleDB_TestDataSet.EmployeeDetails);
            System.Windows.Data.CollectionViewSource employeeDetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeeDetailsViewSource")));
            employeeDetailsViewSource.View.MoveCurrentToFirst();
           
           
        }

        //Add new health event to patient records
        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                addPatientEventForm addEvent = new addPatientEventForm();
                addEvent.patientID = patientIDRec;
                addEvent.ShowDialog();
                if(addEvent.DialogResult==System.Windows.Forms.DialogResult.OK)
                {
                    LoadGrid(patientIDRec);

                }
                else { addEvent.Dispose(); }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Source,ex.Message);
            }
        }

        private void UpdatePatientButton_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }

}
