using System;
using System.Collections.ObjectModel;
using Zhenchak04.Models;

namespace Zhenchak04
{
    static class PersonListGenerator
    {
        public static ObservableCollection<Person> GeneratePersons()
        {
            var persons = new ObservableCollection<Person>();

            for (int i = 0; i < 10; i++)
            {
                persons.Add(new Person("Mark", "Adams", "minecraft333@gmail.com", new DateTime(2003, 12, 10)));
                persons.Add(new Person("Hayly", "Brown", "sugar34@gmail.com", new DateTime(1995, 06, 05)));
                persons.Add(new Person("Billy", "Ash", "b.ash@gmail.com", new DateTime(1997, 01, 07)));
                persons.Add(new Person("Kris", "Walker", "walker77@gmail.com", new DateTime(2000, 02, 04)));
                persons.Add(new Person("Jamie", "Philips", "j88phil@gmail.com", new DateTime(1993, 09, 03)));
            }
            return persons;
        }
    }
}
