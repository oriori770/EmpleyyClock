using EmployeeClock.DAL;
using EmployeeClock.forms;
using EmployeeClock.Services;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Diagnostics.Metrics;



namespace EmployeeClock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()

        {

            // SET SECRETS.JSON TO COPY ALWAYS AFTER ADDING!!
            IConfiguration builder = new ConfigurationBuilder()
              .AddJsonFile("secrets.json", optional: true) // Add secrets.json
              .Build();
            // Read a value from the configuration
            string connString = builder["ConnectionString"];
            Console.WriteLine($"The secret value is: {connString}");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FormHandler.Start();
            Application.Run();

            
        }
    }
}