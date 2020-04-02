﻿namespace HealthyPeopleDesktopClientPrototype
{
    partial class LoginWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIDTxtBox = new System.Windows.Forms.TextBox();
            this.employeePasswordTxtBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this._HealthyPeopleDB_TestDataSet = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSet();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new HealthyPeopleDesktopClientPrototype._HealthyPeopleDB_TestDataSetTableAdapters.UserTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._HealthyPeopleDB_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(155, 191);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(295, 191);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // userIDTxtBox
            // 
            this.userIDTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.userTableBindingSource, "UserID", true));
            this.userIDTxtBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userIDTxtBox.Location = new System.Drawing.Point(285, 56);
            this.userIDTxtBox.Name = "userIDTxtBox";
            this.userIDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTxtBox.TabIndex = 4;
            // 
            // employeePasswordTxtBox
            // 
            this.employeePasswordTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.userTableBindingSource, "Password", true));
            this.employeePasswordTxtBox.Location = new System.Drawing.Point(285, 128);
            this.employeePasswordTxtBox.Name = "employeePasswordTxtBox";
            this.employeePasswordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.employeePasswordTxtBox.TabIndex = 5;
            this.employeePasswordTxtBox.UseSystemPasswordChar = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(189, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(112, 13);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Employee Portal Login";
            // 
            // _HealthyPeopleDB_TestDataSet
            // 
            this._HealthyPeopleDB_TestDataSet.DataSetName = "_HealthyPeopleDB_TestDataSet";
            this._HealthyPeopleDB_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this._HealthyPeopleDB_TestDataSet;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // LoginWindow
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(530, 266);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.employeePasswordTxtBox);
            this.Controls.Add(this.userIDTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginWindow";
            this.Text = "Employee Portal Login";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this._HealthyPeopleDB_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userIDTxtBox;
        private System.Windows.Forms.TextBox employeePasswordTxtBox;
        private System.Windows.Forms.Label titleLabel;
        private _HealthyPeopleDB_TestDataSet _HealthyPeopleDB_TestDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private _HealthyPeopleDB_TestDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
    }
}