﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;

namespace ProjectCinema
{
    class DbProvider
    {
        string connectionString;
        protected SqlConnection connection;

        public DbProvider()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["MyConnection1"].ConnectionString;
            connection =
                new SqlConnection(connectionString);

        }
        
    }
}
