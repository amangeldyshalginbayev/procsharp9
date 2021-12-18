using System;
using System.IO;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                myCar.Accelerate(500);
            }
            catch (CarIsDeadException e) when(e.ErrorTimeSTamp.DayOfWeek != DayOfWeek.Friday)
            {
                // try
                // {
                try
                {
                    FileStream fileStream = File.Open(@"C:\carErrors.txt", FileMode.Open);
                    // log info to file here
                }
                catch (Exception e2)
                {
                    // compile error: The property 'System.Exception.InnerException' has no setter
                    //e.InnerException = e2;
                    // instead use this
                    throw new CarIsDeadException(e.CauseOfError, e.ErrorTimeSTamp, e.Message, e2);
                }
                // }
                // catch (Exception exception)
                // {
                //     Console.WriteLine("Catching inner exception ->");
                //     Console.WriteLine(e.Message);
                //     Console.WriteLine($"Inner exception TargetSite: {e.InnerException?.TargetSite}");
                //     Console.WriteLine($"StackTrace: {e.InnerException?.StackTrace}");
                // }

                // This new line will only print if the when clause evaluates to true.
                Console.WriteLine("Catching car is dead!");
                
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // This will catch any other exception
            // beyond CarIsDeadException or
            // ArgumentOutOfRangeException.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Inner exception: {e.InnerException?.Message}");
            }
            finally
            {
                myCar.CrankTunes(false);
            }

            Console.ReadLine();
        }
    }
}