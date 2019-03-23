using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Zhenchak04.Models;

namespace Zhenchak04.ViewModels
{
    class PersonListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> Persons
        {
            get => _persons;
            private set
            {
                _persons = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Person> _persons;


        internal PersonListViewModel()
        {
            _persons = PersonListGenerator.GeneratePersons();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}