using System;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DatabaseModelizer
{
    public class DataProvider
    {
        public Type TConnection { get; set; }
        public Type TDataAdapter { get; set; }
        public Type TCommandBuilder { get; set; }

        public static DataProvider Sql
        {
            get
            {
                return new DataProvider()
                {
                    TConnection = typeof(SqlConnection),
                    TDataAdapter = typeof(SqlDataAdapter),
                    TCommandBuilder = typeof(SqlCommandBuilder)
                };
            }
        }
        public static DataProvider OleDb
        {
            get
            {
                return new DataProvider()
                {
                    TConnection = typeof(OleDbConnection),
                    TDataAdapter = typeof(OleDbDataAdapter),
                    TCommandBuilder = typeof(OleDbCommandBuilder)
                };
            }
        }
        public static DataProvider Odbc
        {
            get
            {
                return new DataProvider()
                {
                    TConnection = typeof(OdbcConnection),
                    TDataAdapter = typeof(OdbcDataAdapter),
                    TCommandBuilder = typeof(OdbcCommandBuilder)
                };
            }
        }

        public DbConnection CreateConnection(string connectionString)
        {
            return Activator.CreateInstance(this.TConnection, connectionString) as DbConnection;
        }

        public DbDataAdapter CreateDataAdapter(string commandText, DbConnection connection)
        {
            return Activator.CreateInstance(this.TDataAdapter, commandText, connection) as DbDataAdapter;
        }

        public DbCommandBuilder CreateCommandBuilder(DbDataAdapter adapter)
        {
            return Activator.CreateInstance(this.TCommandBuilder, adapter) as DbCommandBuilder;
        }
    }
}
