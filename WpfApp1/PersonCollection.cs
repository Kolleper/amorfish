using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;

namespace WpfApp1
{
    public class PersonCollection : INotifyPropertyChanged
    {
        private PersonInformation newPerson;
        private readonly ObservableCollection<PersonInformation> persons;
        public PersonCollection()
        {
            persons = new ObservableCollection<PersonInformation>();
            newPerson = new PersonInformation();
        }

        public ReadOnlyObservableCollection<PersonInformation> Persons
        {
            get
            {
                return new ReadOnlyObservableCollection<PersonInformation>(persons);
            }
        }

        public PersonInformation NewPerson
        {
            get
            {
                return newPerson;
            }
            private set
            {
                if (newPerson != value)
                {
                    newPerson = value;
                    OnPropertyChanged("NewPerson");
                }
            }
        }
        public void AddNewPerson()
        {
            persons.Add(newPerson);
            NewPerson = new PersonInformation();
            
        }

        public void RemovePerson(PersonInformation person)
        {
            persons.Remove(person);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
