using EmployeeClock.DAL;
using EmployeeClock.forms;
using EmployeeClock.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleyyClock.forms
{

    public partial class PasswordChangeForm : Form
    {
        private string FormTitle;
        private DbContext MyDbContext;

        public PasswordChangeForm(string formTitle, DbContext dbContext)
        {
            InitializeComponent();
            FormTitle = formTitle;
            MyDbContext = dbContext;
        }



        private void linkLabelCancelation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.ChangeForm(FormTitle, "LoginForm");
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string tz = textBoxID.Text;
            string OldPassword = textBoxOldPassword.Text;
            string NewPassword = textBoxNewPassword.Text;
            string NewPasswordAgain = textBoxNewPasswordAgain.Text;
            string EmployeesID;
            string PasswordID;
            string Query = CommunicationWithDatabase.CreateQueryString(tz, OldPassword, "PasswordChangeForm");
            DataTable dt = CommunicationWithDatabase.GetData(Query, MyDbContext);



            if (NewPassword != NewPasswordAgain)
            {
                MessageBox.Show("Note, the passwords are not equal");
            }
            else if (IdentityCheck.CheckIfContainsPassword(dt, false))
            {
                string[] Ids = CommunicationWithDatabase.DataExtraction2(dt);
                EmployeesID = Ids[0];
                PasswordID = Ids[1];
                ChangePassword(NewPasswordAgain, EmployeesID, PasswordID);
            }
            else
            {
                MessageBox.Show("The username or password is incorrect. Please try again");
            }
        }
        private void ChangePassword(string NewPasswordAgain, string EmployeesID, string PasswordID)
        {
            string QueryUpate = CommunicationWithDatabase.CreateQueryString("", NewPasswordAgain, "ChangePassword", EmployeesID, PasswordID);
            object res = CommunicationWithDatabase.GetData(QueryUpate, MyDbContext);
            if (true)
            {
                MessageBox.Show("Password changed successfully");
            }
        }
        public void InClose()
        {
            textBoxID.Text = "";
            textBoxOldPassword.Text = "";
            textBoxNewPassword.Text = "";
            textBoxNewPasswordAgain.Text = string.Empty;
        }

        private void PasswordChangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
