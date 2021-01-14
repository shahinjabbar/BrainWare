﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Infrastructure
{
    using System.Configuration;
    using System.Data.Common;
    using System.Data.SqlClient;

    public class Database
    {
        private readonly SqlConnection _connection;
        private readonly string _connectionString;
        public Database()
        {
            // var connectionString = "Data Source=LOCALHOST;Initial Catalog=BrainWare;Integrated Security=SSPI";
            var connectionString = ConfigurationManager.AppSettings["connectionString"].ToString();

            _connection = new SqlConnection(connectionString);

            _connection.Open();
        }

        public DbDataReader ExecuteReader(string query)
        {
            var sqlQuery = new SqlCommand(query, _connection);

            return sqlQuery.ExecuteReader();
        }

        public int ExecuteNonQuery(string query)
        {
            var sqlQuery = new SqlCommand(query, _connection);

            return sqlQuery.ExecuteNonQuery();
        }

    }
}