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
using MessageBox = System.Windows.MessageBox;
using System.Windows.Shapes;
using System.Globalization;

namespace HealthyPeopleDesktopClientPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Data.CollectionViewSource patientRecordsViewSource;
        HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet _HealthyPeopleDB_TestDataSet;// = ((HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet)(FindResource("_HealthyPeopleDB_TestDataSet")));
        // HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet.PatientRecordsDataTable patientRecords;
        HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter patientRec;// = new _HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter();
        private string conString = "HealthyPeopleDesktopClientPrototype.Properties.Settings.HealthyPeopleDB_TestConnectionString";
        protected int patientIDRec;
        protected static List<String> patientInfo;
       // List<_HealthyPeopleDB_TestDataSet.PatientRecordsRow> patientRecords = new List<_HealthyPeopleDB_TestDataSet.PatientRecordsRow>();
        // = new List<string>();
        public MainWindow()
        {
            #region Log In Code
            //LoginWindow loginWindow = new LoginWindow();
            //loginWindow.ShowDialog();
            //if (loginWindow.DialogResult == System.Windows.Forms.DialogResult.OK)
            //{
            //    InitializeComponent();
            //    LoadGrid();
            //    patientInfo = new List<string>();
            //}
            //else
            //    System.Windows.Application.Current.Shutdown();
            #endregion
            InitializeComponent();
           // LoadGrid();


        }

        private void SignOffButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            if (loginWindow.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                InitializeComponent();

            }
            else
                System.Windows.Application.Current.Shutdown();
        }
        /// <summary>
        /// Load the Patient Records into the program
        /// </summary>
        private void LoadGrid()
        {

            try
            {
                #region Old Code
                // OleDbConnection con = new OleDbConnection();
                // con.ConnectionString = ConfigurationManager.ConnectionStrings[conString].ToString();
                // con.Open();
                // OleDbCommand command = new OleDbCommand();
                // command.CommandText = "select * from [PatientRecords]";
                // command.Connection = con;
                // OleDbDataReader reader = command.ExecuteReader();
                // //patientRecordsViewSource.Source = reader;
                //healthRecGrid.ItemsSource = reader;
                #endregion
                patientRec.Fill(_HealthyPeopleDB_TestDataSet.PatientRecords);

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(String.Format("{0} {1} {2}", ex.Source, ex.StackTrace, ex.Message), ex.Data.ToString());
            }

        }
        /// <summary>
        /// Searches the DB for patient name
        /// </summary>
        /// <param name="search">Search Entry</param>
        private void LoadGrid(int search)
        {

            //Searches the DB for matching health Records by patient ID  
            try
            {
                #region Old Code
               // OleDbConnection con = new OleDbConnection();
               // con.ConnectionString = ConfigurationManager.ConnectionStrings[conString].ToString();
               // con.Open();
               // OleDbCommand command = new OleDbCommand();
               // command.CommandText = String.Format("select * from [PatientRecords] WHERE PatientID = {0}", search);
               // command.Connection = con;
               // OleDbDataReader reader = command.ExecuteReader();
               //// patientRecordsViewSource.Source = reader;
               // healthRecGrid.ItemsSource = reader;
                #endregion

                //Searches the Patient Records Table for matching patient ID #'s and adds matching numbers to the list
                #region New Code
                //Fills the Table Limited by Patient ID searched
                patientRec.FillByPatientID(_HealthyPeopleDB_TestDataSet.PatientRecords, search);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
            }

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
            if (searchBy != "")
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings[conString].ToString();
                con.Open();
                OleDbCommand command = new OleDbCommand();
                  bool success = false;

                command.CommandText = String.Format("select * from [Patient] WHERE [Patient.PatientName] = '{0}'", searchBy);
                command.Connection = con;
                OleDbDataReader reader = command.ExecuteReader();
                
                // Searches the DB for the patient and returns the data to the form
                #region Search DB Code
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
                #endregion
                reader.Close();
                con.Close();
            }
            //else
              //  patientRecordsViewSource.Filter += null;// new FilterEventHandler(ResetFilters);
           // LoadGrid();
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

            _HealthyPeopleDB_TestDataSet = ((HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet)(this.FindResource("_HealthyPeopleDB_TestDataSet")));
            // Load data into the table EmployeeDetails. You can modify this code as needed.
            patientRec = new _HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter();

            HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.EmployeeDetailsTableAdapter _HealthyPeopleDB_TestDataSetEmployeeDetailsTableAdapter = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.EmployeeDetailsTableAdapter();
            _HealthyPeopleDB_TestDataSetEmployeeDetailsTableAdapter.Fill(_HealthyPeopleDB_TestDataSet.EmployeeDetails);
            System.Windows.Data.CollectionViewSource employeeDetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeeDetailsViewSource")));
            employeeDetailsViewSource.View.MoveCurrentToFirst();
            patientRec.Fill(_HealthyPeopleDB_TestDataSet.PatientRecords);



            //  Load data into the table PatientRecords. You can modify this code as needed.
            HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter _HealthyPeopleDB_TestDataSetPatientRecordsTableAdapter = patientRec;//new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.PatientRecordsTableAdapter();
           // _HealthyPeopleDB_TestDataSetPatientRecordsTableAdapter.Fill(_HealthyPeopleDB_TestDataSet.PatientRecords);
            patientRecordsViewSource = ((CollectionViewSource)(this.FindResource("patientRecordsViewSource")));
           // LoadGrid();
            patientRecordsViewSource.View.MoveCurrentToFirst();
            
        }

        //Add new health event to patient records
        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                addPatientEventForm addEvent = new addPatientEventForm();
                addEvent.patientID = patientIDRec;
                addEvent.typeTag = "New";
                addEvent.ShowDialog();

                if (addEvent.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    LoadGrid(patientIDRec);
                    addEvent.Dispose();

                }
                else { addEvent.Dispose(); }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Source, ex.Message);
            }
        }
        //Update Health Records 
        private void UpdateEvent_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                addPatientEventForm updateEvent = new addPatientEventForm();
                int index = patientRecordsViewSource.View.CurrentPosition;
                updateEvent.eventID = _HealthyPeopleDB_TestDataSet.PatientRecords[index].PatientEventID;
                updateEvent.patientID = _HealthyPeopleDB_TestDataSet.PatientRecords[index].PatientID;
                updateEvent.typeTag = "Update";
                updateEvent.ShowDialog();
                if (updateEvent.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    LoadGrid(updateEvent.patientID);
                    updateEvent.Dispose(); }
                else
                    updateEvent.Dispose();
               
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Source,ex.StackTrace); }
        }

        //Delete Records 
        /// <summary>
        /// DO NOT IMPLEMENT IN FINAL VERSION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteEvent_Click(object sender, RoutedEventArgs e)
        {
            int index = patientRecordsViewSource.View.CurrentPosition;
            //  patientRec.Delete(_HealthyPeopleDB_TestDataSet.PatientRecords[index].)
            _HealthyPeopleDB_TestDataSet.PatientRecords[index].Delete();
            patientRec.Update(_HealthyPeopleDB_TestDataSet.PatientRecords);
            MessageBox.Show(_HealthyPeopleDB_TestDataSet.PatientRecords.Count.ToString());

        }

        #region Navigation Controls
        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            patientRecordsViewSource.View.MoveCurrentToPrevious();

           // healthRecGrid.Select
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            patientRecordsViewSource.View.MoveCurrentToNext();
        }
        #endregion
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    
}
