using System.Linq;
using System.Reflection;

namespace DatabaseModelizer
{
    public abstract class Model
    {
        #region Private
        private ColumnAttribute GetColumnAttribute(PropertyInfo property)
        {
            return property.GetCustomAttributes(true)
                .First(attribute => attribute.GetType() == typeof(ColumnAttribute))
                as ColumnAttribute;
        }
        #endregion

        public void GetProperty(string propertyName)
        {
            this.GetType().GetProperty(propertyName).GetValue(this, null);
        }

        public void SetProperty(string propertyName, object value)
        {
            this.GetType().GetProperty(propertyName).SetValue(this, value, null);
        }

        public string[] GetPropertiesNames()
        {
            return this.GetType().GetProperties()
                .Select(property => property.Name).ToArray();
        }

        public Field[] GetFields()
        {
            return this.GetType().GetProperties()
                .Select(property => new Field()
                {
                    ColumnName = GetColumnAttribute(property).Name,
                    PropertyName = property.Name,
                    Value = property.GetValue(this, null)
                }).ToArray();
        }

        public string[] GetColumnsNames()
        {
            return this.GetType().GetProperties()
                .Select(property => GetColumnAttribute(property).Name).ToArray();
        }
    }
}
