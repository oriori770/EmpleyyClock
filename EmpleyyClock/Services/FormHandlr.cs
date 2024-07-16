using EmpleyyClock.forms;
using EmployeeClock.DAL;
using EmployeeClock.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace EmployeeClock.Services
{
    internal static class FormHandler
    {
        public static string MyConnectionString = "Server=DESKTOP-8UL1N63;Database=company1;User Id=sa;Password=1234;";
        public static DbContext dbContext = new DbContext(MyConnectionString);
        public static LoginForm loginForm = new LoginForm("LoginForm", dbContext);
        public static PasswordChangeForm passwordChangeForm = new PasswordChangeForm("PasswordChangeForm", dbContext);
        public static ClockForm clockForm = new ClockForm("ClockForm", dbContext);



        public static void Start()
        {
            loginForm.Show();
            //test.printDT(dbContext.MakeQuery("select * from Employees"));

        }
        public static void ChangeForm(string current, string next, string[] meta)
        {
            ShowForm(next, meta);
            CloseForm(current);
        }
        public static void ChangeForm(string current, string next)
        {
            ShowForm(next);
            CloseForm(current);
        }

        public static void ShowForm(string FormName, string[] meta= null)
        {
            switch (FormName)
            {
                case "LoginForm":
                    loginForm.Show();
                    break;
                case "PasswordChangeForm":
                    passwordChangeForm.Show();
                    break;
                case "ClockForm":
                    clockForm.InOpen(meta);
                    clockForm.Show();
                    break;
            }
        }
        public static void CloseForm(string FormName)
        {
            switch (FormName)
            {
                case "LoginForm":                    
                    loginForm.InClose();
                    loginForm.Hide();
                    break;
                case "PasswordChangeForm":
                    passwordChangeForm.InClose();
                    passwordChangeForm.Hide();
                    break;
                case "ClockForm":
                    clockForm.InClose();
                    clockForm.Hide();
                    break;
            }
        }
    }

}
