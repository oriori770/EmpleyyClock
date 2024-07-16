using EmployeeClock.DAL;
using EmployeeClock.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmpleyyClock.forms
{
    public partial class ClockForm : Form
    {
        private DbContext dbContext;
        private string FormTitle;
        private string IdCurrentEmployee;
        public ClockForm(string formTitle, DbContext db)
        {
            InitializeComponent();
            FormTitle = formTitle;
            dbContext = db;

        }


        private void linkLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.ChangeForm(FormTitle, "LoginForm");
        }

        public void InOpen(string[] empoloyeeDetails)
        {
            EmployeeNat.Text = empoloyeeDetails[1];
            IdCurrentEmployee = empoloyeeDetails[2];
            labelLastEntryDate.Text = empoloyeeDetails[3];
            labelLastExitDate.Text = empoloyeeDetails[4];
        }
        public void InClose()
        {
            EmployeeNat.Text = "";
            labelLastEntryDate.Text = "";
            labelLastExitDate.Text = "";
        }
        private bool CheckingIfNull(string id, DbContext db)
        {
            string Query = CommunicationWithDatabase.CreateQueryString("", "", "CheckingNull", IdCurrentEmployee);
            DataTable dt = CommunicationWithDatabase.GetData(Query, db);
            bool res = IdentityCheck.CheckIfContainsPassword(dt, false);
            return res;
        }
        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            string Query = CommunicationWithDatabase.CreateQueryString("", "", "EntryUpdate", IdCurrentEmployee);
            if (!CheckingIfNull(IdCurrentEmployee, dbContext))
            //if(true)
            {
                DataTable dt = CommunicationWithDatabase.GetData(Query, dbContext);
                MessageBox.Show("Your entire request has been successfully received");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            string Query = CommunicationWithDatabase.CreateQueryString("", "", "ExitUpdate", IdCurrentEmployee);
            if (CheckingIfNull(IdCurrentEmployee, dbContext))
            {
                DataTable dt = CommunicationWithDatabase.GetData(Query, dbContext);
                MessageBox.Show("Your Exit request has been successfully received");
            }
        }

        private void ClockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
