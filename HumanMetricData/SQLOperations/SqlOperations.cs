using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HumanMetricData.SQLOperations
{
    public class SqlOperations : IDisposable
    {
        public SqlDataAdapter adapter;
        private readonly string _connectionString;
        public SqlConnection _sqlConnection = null;
        bool _disposed = false;

        public SqlOperations() :this(@"" + Properties.Settings.Default.ConnectionString + Properties.Settings.Default.Connection + "")
        { }

        public SqlOperations(string connectionString) => _connectionString = connectionString;

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

    }
}
