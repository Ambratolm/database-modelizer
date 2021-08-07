
namespace DatabaseModelizer
{
    public class Field
    {
        public string ColumnName { get; set; }
        public string PropertyName { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1}: {2}", ColumnName, PropertyName, Value);
        }
    }
}
