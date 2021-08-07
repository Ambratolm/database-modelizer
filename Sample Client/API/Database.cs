using DatabaseModelizer;
using SampleClient.Properties;

namespace SampleClient
{
    static class Database
    {
        private static readonly DataAccessor _dataAccessor;

        public static ModelTable<Person> Persons { get; private set; }

        static Database()
        {
            _dataAccessor = new DataAccessor(Settings.Default.ConnectionString, DataProvider.OleDb);
            Persons = new ModelTable<Person>("persons", _dataAccessor);
        }
    }
}
