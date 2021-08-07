using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SampleClient
{
    public partial class Form_Main : Form
    {
        private int _currentIndex = -1;
        private Person _currentPerson = null;

        public Form_Main()
        {
            InitializeComponent();
            SetGendersList();
            SetPersonsList();
            SetCurrentPerson();
        }

        #region Common
        private void SetGendersList()
        {
            var male = new KeyValuePair<string, string>("Male", "m");
            var female = new KeyValuePair<string, string>("Female", "f");
            comboBox_gender.DataSource = new List<KeyValuePair<string, string>>() { male, female };
            comboBox_gender.DisplayMember = "Key";
            comboBox_gender.ValueMember = "Value";
            comboBox_gender.SelectedItem = male;
        }

        private void SetPersonsList(List<Person> persons = null)
        {
            dataGridView_list.DataSource = persons == null ? Database.Persons.Read() : persons;
        }

        private void SetCurrentPerson(int index = 0, bool setDataGridView = true)
        {
            if (Database.Persons.Count != 0)
            {
                if (index < 0)
                {
                    index = Database.Persons.LastIndex;
                }
                if (index > Database.Persons.LastIndex)
                {
                    index = 0;
                }
                _currentIndex = index;
                _currentPerson = Database.Persons.Read(_currentIndex);

                label_current.Text = string.Format("{0} / {1}",
                    _currentIndex + 1, Database.Persons.Count);
                textBox_name.Text = _currentPerson.Name.ToString();
                comboBox_gender.SelectedValue = _currentPerson.Gender;
                dateTimePicker_birthDate.Value = _currentPerson.BirthDate == null
                    ? DateTime.MinValue : DateTime.Parse(_currentPerson.BirthDate.ToString());
                if (setDataGridView)
                {
                    dataGridView_list.CurrentCell = dataGridView_list[0, _currentIndex];
                }
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        private void button_first_Click(object sender, EventArgs e)
        {
            SetCurrentPerson(index: 0);
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            SetCurrentPerson(index: Database.Persons.LastIndex);
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            SetCurrentPerson(index: --_currentIndex);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            SetCurrentPerson(index: ++_currentIndex);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                Id = Guid.NewGuid(),
                Name = textBox_name.Text,
                Gender = comboBox_gender.SelectedValue,
                BirthDate = dateTimePicker_birthDate.Value
            };
            Database.Persons.Create(person);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (_currentPerson != null)
            {
                Person person = new Person()
                {
                    Id = _currentPerson.Id,
                    Name = textBox_name.Text,
                    Gender = comboBox_gender.SelectedValue,
                    BirthDate = dateTimePicker_birthDate.Value
                };
                Database.Persons.Update(person, p => p.Id == person.Id);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (_currentPerson != null)
            {
                Database.Persons.Delete(p => p.Id == _currentPerson.Id);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            List<Person> foundPersons = Database.Persons
                    .Read(p => p.Name.ToString().Contains(textBox_name.Text));
            SetPersonsList(foundPersons);
        }

        private void button_clearSearch_Click(object sender, EventArgs e)
        {
            textBox_search.Clear();
            SetPersonsList();
        }

        private void dataGridView_list_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SetCurrentPerson(e.RowIndex, setDataGridView: false);
        }
    }
}
