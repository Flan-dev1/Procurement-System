using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatabaseConnection
{

    public sealed class Database 
    {
        public string Query { get; set; }
        private readonly string _connectionString = "Server=localhost;Database=ProcurementSystem;Trusted_Connection=True;";
        private SqlCommand _command;
        private SqlConnection _conn;
        private SqlDataAdapter _adapter;

        public Database()
        {
            _conn = new SqlConnection(_connectionString);
            _conn.Open();
            _conn.Close();
        }

        public void Add()
        {
            
            // using is a type of keyword that automatically dispose any
            // IDisposable object in its argument after it reach out of scope
            using (_conn = new SqlConnection(_connectionString)) 
           {
                _conn.Open();
                _command = new SqlCommand(Query, _conn);
                _command.ExecuteNonQuery();
            }

        }

        public void Update()
        {
            using (_conn = new SqlConnection(_connectionString))
            {
                _conn.Open();
                _command = new SqlCommand(Query, _conn);
                _command.ExecuteNonQuery();
            }
        }

        public void Delete()
        {
            using (_conn = new SqlConnection(_connectionString))
            {
                _conn.Open();
                _command = new SqlCommand(Query, _conn);
                _command.ExecuteNonQuery();
            }
        }

        public DataTable Retrieved()
        {
            using (_conn = new SqlConnection(_connectionString))
            {
                _conn.Open();
                _command = new SqlCommand(Query, _conn);
                _adapter = new SqlDataAdapter(_command);
                DataTable dt = new DataTable();
                _adapter.Fill(dt);
                return dt;
            }
        }

        public DataSet RetrievedDataSet(string tableName)
        {
            
            using (_conn = new SqlConnection(_connectionString))
            {
                 _conn.Open();
                 _command = new SqlCommand(Query, _conn);
                 _adapter = new SqlDataAdapter(_command);
                 DataSet ds = new DataSet();
                 _adapter.Fill(ds, tableName);
                 return ds;
            }
            
        }

        

    }
}
