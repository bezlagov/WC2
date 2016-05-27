using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoggerForWorkCatalog.Model
{
    class DatabaseProvider
    {
        private static DatabaseProvider instance;

        public static DatabaseProvider Instance
        {
            get
            {
                if (instance == null) instance = new DatabaseProvider();
                return instance;
            }
        }
        private DatabaseProvider() { }

        private SqlConnectionStringBuilder connectionString;
        public void Initialize(string database)
        {
            connectionString = new SqlConnectionStringBuilder();     //using System.Data.Common; 
            connectionString.DataSource = "IVAN\\SQLEXPRESS";
            connectionString.InitialCatalog = database;
            connectionString.IntegratedSecurity = true;
        }

        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString.ConnectionString;
            connection.Open();
            return connection;
        }


        public void LoggingData(LogMessage message)
        {
            using (var connection = OpenConnection())
            {
                var com = new SqlCommand();
                com.Connection = connection;
                //com.CommandType = CommandType.StoredProcedure;
                //com.CommandText = "AddNewWorker";

                //SqlParameter nameParam = new SqlParameter();
                //nameParam.ParameterName = "@id";
                //nameParam.SqlDbType = SqlDbType.NVarChar;
                //nameParam.Direction = ParameterDirection.Input;
                //nameParam.Value = name;
                //com.Parameters.Add(nameParam);

                com.ExecuteNonQuery();
            }
        }
    }
}
