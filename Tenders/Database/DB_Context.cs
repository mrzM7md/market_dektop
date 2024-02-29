using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.Database
{
    internal class DB_Context
    {
        internal SqlConnection sqlConnection;

        public DB_Context()
        {
            //SqlConnectionStringBuilder sqlConnectionStringBuilder;
            //sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            //sqlConnectionStringBuilder.DataSource = ".";
            //sqlConnectionStringBuilder.InitialCatalog = "SimpleMarket";
            //sqlConnectionStringBuilder.PersistSecurityInfo = false;
            //sqlConnectionStringBuilder.UserID = "";
            //sqlConnectionStringBuilder.Password = "";

            string connectionString = @"Data Source=.;Initial Catalog=SimpleMarket;Integrated Security=True";

            //string connectionString = sqlConnectionStringBuilder.ConnectionString;

            sqlConnection = new SqlConnection(connectionString);
        }

        internal void open()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        internal void close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
