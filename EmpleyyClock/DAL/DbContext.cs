using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;



namespace EmployeeClock.DAL
{
    public class DbContext
    {   private readonly string _ConnectionString;
        public DbContext(string ConnectionString)
        {
            // _ConnectionString = ConnectionString;
            _ConnectionString = GetConnString();
        }

        private static string connectionString;
        private static string GetConnString()
        {
            if (string.IsNullOrEmpty(connectionString) == false)
            {
                return connectionString;
            }
            IConfiguration builder = new ConfigurationBuilder()
             .AddJsonFile("secrets.json", optional: true) // Add secrets.json
             .Build();

            connectionString = builder["ConnectionString"];
            if (connectionString == null) throw new Exception("Cannot read conn striong from secrets");
            return connectionString;
        }



        public DataTable MakeQuery(string quereStr)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(quereStr, conn))
                {
                    try
                    {
                        conn.Open();

                        using (SqlDataAdapter Adapter = new SqlDataAdapter(cmd))
                        {
                            Adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
            }
            
            return output;

        }

        public int SendQuery(string quereStr)
        {
            int RowsCount = 0;
            //The number of rows affected
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(quereStr, conn))
                {
                    try
                    {
                        conn.Open();
                        RowsCount = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
            }

            return RowsCount;

        }
    }
}
