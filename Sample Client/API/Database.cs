using DatabaseModelizer;

namespace SampleClient
{
    static class Database
    {
        private static DataAccessor _dataAccessor;

        public static ModelTable<Person> Persons { get; private set; }

        static Database()
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database.mdb;User Id=admin;Password=;";
            _dataAccessor = new DataAccessor(connectionString, DataProvider.OleDb);
            Persons = new ModelTable<Person>("persons", _dataAccessor);
        }
    }
}
