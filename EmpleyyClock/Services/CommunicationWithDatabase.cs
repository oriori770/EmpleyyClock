using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeClock.Services
{
    internal static class CommunicationWithDatabase
    {
        public static string CreateQueryString(string tz, string password, string mode, string EmId = "", string PaId = "")
        {
            string Query = mode switch
            {
                "Entrance" => $"select TOP(2) Employees.FirstName, Employees.EmployeeNat, Employees.ID, EmployeeAttendance.EntryTime, EmployeeAttendance.ExitTime from Employees  INNER JOIN Passwords on Passwords.EmployeeID = Employees.ID INNER JOIN EmployeeAttendance on EmployeeAttendance.EmployeeCode = Employees.ID where Passwords.IsActive = 1 and Employees.EmployeeNat = {tz} and Passwords.EmployeePassword = '{password}' order by EmployeeAttendance.EntryTime DESC",
                "PasswordChangeForm" => $"select Employees.ID, Passwords.ID from Employees  INNER JOIN Passwords on Passwords.EmployeeID = Employees.ID   where Passwords.IsActive = 1 and Employees.EmployeeNat = {tz}  and Passwords.EmployeePassword = '{password}';\r\n",
                "ChangePassword" => $"update Passwords set IsActive = 0 where ID = '{PaId}' ; insert into Passwords (EmployeeID, EmployeePassword, ExpiryDate, IsActive) values ({EmId}, '{password}', DATEADD(MONTH, 3, GETDATE()),1)",
                "EntryUpdate" => $"insert into EmployeeAttendance (EmployeeCode,EntryTime) values ({EmId} ,GETDATE()) \r\n",
                "ExitUpdate" => $"update EmployeeAttendance set ExitTime = GETDATE()  where EmployeeCode = {EmId} and ExitTime is null",
                "CheckingNull" => $"select * from EmployeeAttendance where ExitTime is null and EmployeeCode = {EmId}\r\n",
                _ => "",
            };
            return Query;
        }
        public static DataTable GetData(string QueryString, DbContext DbContext)
        {
            DataTable NamePassword = DbContext.MakeQuery(QueryString);

            return NamePassword;
        }
        public static string[] DataExtraction1(DataTable dt)
        {
            string? Name = dt.Rows[0][0].ToString();
            string? EmployeeNat = dt.Rows[0][1].ToString();
            string? ID = dt.Rows[0][2].ToString();
            string? EntryTime = dt.Rows[0][3].ToString();
            string? ExitTime;
            if (DBNull.Value.Equals(dt.Rows[0][4]))
            {
                ExitTime = dt.Rows[1][4].ToString();
            }
            else
            {
                ExitTime = dt.Rows[0][4].ToString();
            }
            string[] myData =
                {
                Name, EmployeeNat,ID, EntryTime, ExitTime
                };

            return myData;
        }
        public static string[] DataExtraction2(DataTable dt) 
        {
            string EmployeesID = dt.Rows[0][0].ToString();
            string PasswordID = dt.Rows[0][1].ToString();
            string[] myData = { EmployeesID, PasswordID };
            return myData;

        }


    }
}
