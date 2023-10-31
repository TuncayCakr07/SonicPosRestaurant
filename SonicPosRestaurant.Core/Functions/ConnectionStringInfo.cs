﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicPosRestaurant.Core.Functions
{
    public class ConnectionStringInfo
    {
        private static string FilePath =$"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Connection.dat";

        public static string Get()
        {
            if (File.Exists(FilePath))
            {
               return File.ReadAllText(FilePath);
            }
            return null;    
        }
        public static void Set(string connectionString)
        {
            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}"))
            {
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{Application.CompanyName}");
            }
            File.WriteAllText(FilePath, connectionString);
        }
        public static bool Check(string connectionString=null)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(connectionString?? Get());
            connectionStringBuilder.InitialCatalog = "master";
            using (SqlConnection connection=new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                  return false;
                }
            }
        }
    }
}
