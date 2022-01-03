using System.Collections.Generic;

namespace SimpleIndexer
{
    public class SomeClass : IStringContainer
    {
        private List<string> myStrings = new List<string>();

        public string this[int index]
        {
            get => myStrings[index];
            set => myStrings[index] = value;
        }
    }
}