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
    public partial class LoginWindow : Form
    {
        List<String> userIDList = new List<string>(), passwordList = new List<string>();
        public LoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Submits Login information to authenticate user to access system
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
        
            string userName = userIDTxtBox.Text;
            string password = employeePasswordTxtBox.Text;
            // Check credentials to see if user is a valid entry
           
            bool matchUserID = false, matchUserPassword = false;
           
           

            if (passwordList.Contains(password)&&userIDList.Contains(userName))
                {
                  for(int i =0; i<userIDList.Count; i++)
            {
                    if (userName == userIDList[i] && password == passwordList[i])
                    { matchUserID = true; matchUserPassword = true; }
                    else if (userName == userIDList[i] && password != passwordList[i])
                        continue;
                    else
                        continue;
                        
            }
                  //If userID and password are correct
                   if(matchUserID && matchUserPassword)
                  
                    {
                        // User is authenticated
                        this.DialogResult = DialogResult.OK;  }
                    else
                    {
                        //UserID or password mismatch
                        MessageBox.Show("Password or User ID don't match known records");
                    }
                }
                else
                    MessageBox.Show("Password or User ID doesn't exist in our records");
            }
                
           
        

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_HealthyPeopleDB_TestDataSet.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this._HealthyPeopleDB_TestDataSet.UserTable);
            for (int i = 0; i < this._HealthyPeopleDB_TestDataSet.UserTable.Rows.Count; i++)
            { userIDList.Add(this._HealthyPeopleDB_TestDataSet.UserTable.Rows[i][0].ToString());
                passwordList.Add(this._HealthyPeopleDB_TestDataSet.UserTable.Rows[i][1].ToString());
            }
           // MessageBox.Show(userIDList[0].ToString() + passwordList[0].ToString());
        }
    }
}
