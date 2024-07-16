using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeClock.Services
{
    internal static class IdentityCheck
    {
        public static bool CheckIfContainsPassword(DataTable NamePassword, bool ShowMessages) 
        {
            if (NamePassword.Rows.Count != 0)
            {
                string? name = NamePassword.Rows[0][0].ToString();
                if (ShowMessages) 
                {
                    MessageBox.Show("hi " + name + " Welcome!!!");
                }
                    return true;
            }
            else
            {
                if (ShowMessages)
                {
                    MessageBox.Show("The username or password is incorrect. Please try again");
                }
                return false;   
            }
            
        }


    }
}
