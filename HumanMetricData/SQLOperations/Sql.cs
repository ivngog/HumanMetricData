using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace HumanMetricData.SQLOperations
{
    public class Sql : IDisposable
    {
        public SqlDataAdapter adapter;
        private readonly string _connectionString;
        public SqlConnection _sqlConnection = null;
        bool _disposed = false;


        public Sql() :this(@"" + Properties.Settings.Default.ConnectionString + Properties.Settings.Default.Connection + "")
        { }

        public Sql(string connectionString) => _connectionString = connectionString;

        

        public void OpenConnection()
        {
            _sqlConnection = new SqlConnection
            {
                ConnectionString = _connectionString
            };
            _sqlConnection.Open();
        }
        public void CloseConnection() 
        {
            if (_sqlConnection?.State != ConnectionState.Closed)
            {
                _sqlConnection.Close();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            if (disposing)
            {
                _sqlConnection.Dispose();
            }
            _disposed = true;

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public void Insert() { }
        public void Update() { }
        public void Delete() { }

        public void LoadMainData()
        {
            
            
        }

    }
}
