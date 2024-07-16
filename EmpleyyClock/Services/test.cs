using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.Services
{
    internal class test
    {
        public static void printDT(DataTable dt)
        {
            [DllImport("kernel32.dll")]
            static extern bool AllocConsole();
            [DllImport("kernel32.dll")]
            static extern bool FreeConsole();
            // Call AllocConsole() to create a console window
            AllocConsole();
            // Now Console.WriteLine() will output to this console window
            foreach (DataColumn column in dt.Columns)
            {
                Console.Write($"{column.ColumnName,-20}"); // Adjust the width as needed
            }
            Console.WriteLine();
            // Print data rows
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write($"{item,-20}"); // Adjust the width as needed
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            // Don't forget to free the console when done
            FreeConsole();
        }

        



    }
}
