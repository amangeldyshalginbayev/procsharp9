using System;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Rusty",30);
            carArray[1] = new Car("Clunker",55);
            carArray[2] = new Car("Zippy",30);
            carArray[3] = new Car("Fred",30);
        }
        
        public IEnumerator GetEnumerator()
        {
            // will not get called immediately
            // throw new Exception("This won't get called");
            // foreach (Car c in carArray)
            // {
            //     yield return c;
            // }

            //throw new Exception("This will get called.");

            return ActualImplementation();
            
            IEnumerator ActualImplementation()
            {
                foreach (var c in carArray)
                {
                    yield return c;
                }
            }
        }

        public IEnumerable GetTheCars(bool returnReversed)
        {
            // do some error checking here
            return ActualImplementation();
            
            IEnumerable ActualImplementation()
            {
                if (returnReversed)
                {
                    for (int i = carArray.Length; i != 0; i--)
                    {
                        yield return carArray[i - 1];
                    }
                }
                else
                {
                    foreach (var c in carArray)
                    {
                        yield return c;
                    }
                }
            }
        }
    }
}