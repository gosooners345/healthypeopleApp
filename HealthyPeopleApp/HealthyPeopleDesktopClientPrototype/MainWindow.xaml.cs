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
        private string conString ="HealthyPeopleDesktopClientPrototype.Properties.Settings.HealthyPeopleDB_TestConnectionString";
        public MainWindow()
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            if (loginWindow.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                InitializeComponent();

            }
            else
                System.Windows.Application.Current.Shutdown();

           // InitializeComponent();
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
            string searchBy = patientNameTextBox.Text;
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
                    this.patientIDLabel.Content = searchID.ToString();
                    this.patientNameLabel.Content = reader["PatientName"].ToString();
                    patientAddressLabel.Content = reader["PatientAddress"].ToString();
                    patientCityLabel.Content = reader["PatientCity"].ToString();
                  
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
    }
}
