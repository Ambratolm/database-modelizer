using System.Data;
using System.Data.Common;

namespace DatabaseModelizer
{
    /// <summary>
    /// Allows access to a database.
    /// </summary>
    public class DataAccessor
    {
        public string ConnectionString { get; set; }
        public DataProvider Provider { get; set; }

        public DataAccessor(string connectionString, DataProvider provider)
        {
            this.ConnectionString = connectionString;
            this.Provider = provider == null ? DataProvider.Sql : provider;
        }

        public DataTable GetTable(string commandText, string tableName)
        {
            using (DbConnection connection = this.Provider.CreateConnection(this.ConnectionString))
            {
                using (DbDataAdapter adapter = this.Provider.CreateDataAdapter(commandText, connection))
                {
                    using (DataTable table = new DataTable(tableName))
                    {
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public int SetTable(string commandText, DataTable table)
        {
            using (DbConnection connection = this.Provider.CreateConnection(this.ConnectionString))
            {
                using (DbDataAdapter adapter = this.Provider.CreateDataAdapter(commandText, connection))
                {
                    using (DbCommandBuilder commandBuilder = this.Provider.CreateCommandBuilder(adapter))
                    {
                        return adapter.Update(table);
                    }
                }
            }
        }
    }
}
