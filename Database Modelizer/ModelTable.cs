using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DatabaseModelizer
{
    public class ModelTable<TModel> where TModel : Model
    {
        private string _selectCommandText;
        private List<TModel> _models;

        public string Name { get; set; }
        public DataAccessor DataAccessor { get; set; }
        public int Count
        {
            get
            {
                return _models.Count;
            }
        }
        public int LastIndex
        {
            get
            {
                if (_models.Count < 1)
                {
                    return -1;
                }
                return _models.Count - 1;
            }
        }
        public bool IsEmpty
        {
            get
            {
                return (_models.Count == 0);
            }
        }
        public TModel this[int index]
        {
            get
            {
                return _models[index];
            }
        }
        TModel Current
        {
            get
            {
                return _models.GetEnumerator().Current;
            }
        }

        public ModelTable(string name, DataAccessor dataAccessor, string selectCommandText = null)
        {
            this.Name = name;
            this.DataAccessor = dataAccessor;
            _selectCommandText = string.IsNullOrEmpty(selectCommandText)
                ? string.Format("SELECT * FROM {0}", this.Name)
                : selectCommandText;
            PullFromDatabase();
        }

        #region Private
        private void PullFromDatabase()
        {
            _models = ConvertToList(this.DataAccessor.GetTable(_selectCommandText, Name));
        }

        private int PushToDatabase()
        {
            return this.DataAccessor.SetTable(_selectCommandText, ConvertToDataTable(_models));
        }

        private DataTable ConvertToDataTable(List<TModel> models)
        {
            if (models.Count == 0)
            {
                return null;
            }
            DataTable table = new DataTable(Name);
            foreach (string columnName in models[0].GetColumnsNames())
            {
                table.Columns.Add(columnName);
            }
            foreach (TModel model in models)
            {
                DataRow row = table.NewRow();
                foreach (Field field in model.GetFields())
                {
                    row[field.ColumnName] = field.Value;
                }
            }
            return table;
        }

        private List<TModel> ConvertToList(DataTable table)
        {
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<TModel> modelsList = new List<TModel>();
            foreach (DataRow row in table.Rows)
            {
                TModel model = default(TModel);
                foreach (Field field in model.GetFields())
                {
                    if (table.Columns.Contains(field.ColumnName))
                    {
                        model.SetProperty(field.PropertyName, row[field.ColumnName]);
                    }
                }
            }
            return modelsList;
        }
        #endregion

        public void Synchronize()
        {
            PushToDatabase();
            PullFromDatabase();
        }

        #region CRUD
        public void Create(TModel newModel)
        {
            _models.Add(newModel);
            Synchronize();
        }

        public List<TModel> Read(Func<TModel, bool> predicate = null)
        {
            return (predicate == null) ? _models : _models.Where(predicate).ToList();
        }

        public TModel Read(int index)
        {
            if (index < 0)
            {
                index = 0;
            }
            if (index > _models.Count - 1)
            {
                index = _models.Count - 1;
            }
            return _models[index];
        }

        public void Update(TModel newModel, Func<TModel, bool> predicate)
        {
            IEnumerable<TModel> models = this._models.Where<TModel>(predicate);
            foreach (TModel model in models)
            {
                foreach (Field field in newModel.GetFields())
                {
                    model.SetProperty(field.PropertyName, field.Value);
                }
            }
            Synchronize();
        }

        public int Delete(Predicate<TModel> predicate)
        {
            int count = _models.RemoveAll(predicate);
            Synchronize();
            return count;
        }
        #endregion
    }
}