using System.Collections;

namespace IssuesWithNonGenericCollections
{
    public class PersonCollection : IEnumerable
    {
        private ArrayList _arPeople = new ArrayList();

        public Person GetPerson(int pos) => (Person)_arPeople[pos];

        public void AddPerson(Person p)
        {
            _arPeople.Add(p);
        }

        public void ClearPeople()
        {
            _arPeople.Clear();
        }

        public int Count => _arPeople.Count;

        IEnumerator IEnumerable.GetEnumerator() => _arPeople.GetEnumerator();
    }
}