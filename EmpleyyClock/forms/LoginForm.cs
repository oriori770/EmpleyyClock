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

namespace EmployeeClock.forms
{
    public partial class LoginForm : Form
    {

        private string FormTitle;
        public DbContext _DbContext;
        public LoginForm(string formTitle, DbContext DbContext)
        {
            InitializeComponent();
            FormTitle = formTitle;
            _DbContext = DbContext;
        }

        private void ButtonEntrance_Click(object sender, EventArgs e)
        {
            string Tz = textBoxID.Text;
            string password = textBoxPassword.Text;
            string Query = CommunicationWithDatabase.CreateQueryString(Tz, password, "Entrance");
            DataTable dt = CommunicationWithDatabase.GetData(Query, _DbContext);


            if (IdentityCheck.CheckIfContainsPassword(dt, true))
            {
                string[] array = CommunicationWithDatabase.DataExtraction1(dt);
                FormHandler.ChangeForm(FormTitle, "ClockForm", array);
            }

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            string Tz = textBoxID.Text;
            string password = textBoxPassword.Text;
            string Query = CommunicationWithDatabase.CreateQueryString(Tz, password, "PasswordChangeForm");
            //DataTable dt1 = _DbContext.MakeQuery("");
            DataTable dt = CommunicationWithDatabase.GetData(Query, _DbContext);

            if (IdentityCheck.CheckIfContainsPassword(dt, true))
            {
                FormHandler.ChangeForm(FormTitle, "PasswordChangeForm");
            }
        }
        public void InClose()
        {
            textBoxID.Text = "";
            textBoxPassword.Text = "";
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
