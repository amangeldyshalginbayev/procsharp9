using System.Collections;
using System.Collections.Generic;

namespace SimpleIndexer
{
    public class PersonCollectionStringIndexer : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        public Person this[string name]
        {
            get => listPeople[name];
            set => listPeople[name] = value;
        }

        public void ClearPeople()
        {
            listPeople.Clear();
        }

        public int Count => listPeople.Count;
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listPeople.GetEnumerator();
        }
    }
}