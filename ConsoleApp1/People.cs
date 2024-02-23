using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class People
    {
        private List<Person> _people = new List<Person>();

        public int Count => _people.Count;

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public void Clear()
        {
            _people.Clear();
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _people;
        }

        public IEnumerable<Person> GetApplePeople()
        {
            return _people.Where(person => person.MobileType == MobileType.Apple);
        }

        public IEnumerable<Person> GetAndroidPeople()
        {
            return _people.Where(person => person.MobileType == MobileType.Android);
        }
    }
}
