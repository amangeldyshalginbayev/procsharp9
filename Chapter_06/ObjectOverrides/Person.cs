namespace ObjectOverrides
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string SSN { get; } = "";

        public Person()
        {
        }

        public Person(string firstName, string lastName, int age, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SSN = ssn;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString() => $"[First Name: {FirstName}; LastName: {LastName}; Age: {Age}]";

        public override bool Equals(object obj)
        {
            if (!(obj is Person person))
            {
                return false;
            }

            if (person.FirstName == this.FirstName && person.LastName == this.LastName && person.Age == this.Age)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode() => SSN.GetHashCode();
    }
}