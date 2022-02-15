using System;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithCSharpAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(" Fun With Async ===>");
            //Console.WriteLine(DoWork());
            // string message = await DoWorkAsync();
            // Console.WriteLine(message);

            // string message1 = await DoWorkAsync().ConfigureAwait(false);
            // Console.WriteLine("Completed");

            //await MethodReturningTaskOfVoidAsync();
            //Console.WriteLine("Void method complete. This inside Main().");
            
            //MethodReturningVoidAsync();
            //Console.WriteLine("Void async is complete");

            //await MultipleAwaits();
            //await MultipleAwaitsUpdated();

            //Console.WriteLine(DoWorkAsync().Result);

            await MethodWithProblemsFixed(3, 3);
            
            Console.WriteLine("Completed");
            Console.ReadLine();

        }


        static string DoWork()
        {
            Thread.Sleep(10_000);
            return "Done with work";
        }

        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Done with work!";
            });
        }

        static async Task MethodReturningTaskOfVoidAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(4_000);
            });
            Console.WriteLine("Void method completed.");
        }

        static async void MethodReturningVoidAsync()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(14_000);
            });

            Console.WriteLine("Fire and forget void method completed.");
        }

        static async Task MultipleAwaits()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2_000);
            });
            Console.WriteLine("Done with first task!");

            await Task.Run(() =>
            {
                Thread.Sleep(2_000);
            });
            Console.WriteLine("Done with second task!");

            await Task.Run(() =>
            {
                Thread.Sleep(10_000);
            });
            Console.WriteLine("Done with third task!");
        }

        static async Task MultipleAwaitsUpdated()
        {
            var task1 = Task.Run(() =>
            {
                Thread.Sleep(15_000);
                Console.WriteLine("Done with first task!");
            });
            
            var task2 = Task.Run(() =>
            {
                Thread.Sleep(3_000);
                Console.WriteLine("Done with second task!");
            });
            
            var task3 = Task.Run(() =>
            {
                Thread.Sleep(1_000);
                Console.WriteLine("Done with third task!");
            });

            //await Task.WhenAll(task1, task2, task3);
            await Task.WhenAny(task1, task2, task3);
        }

        static async Task<string> MethodWithTryCatch()
        {
            try
            {
                // Do some work
                return "Hello";
            }
            catch (Exception e)
            {
                //await LogTheErrors();
                throw;
            }
            finally
            {
                //await DoMagicCleanUp();
            }
        }

        static async ValueTask<int> ReturnAnInt()
        {
            await Task.Delay(3_000);
            return 5; // ValueTask<T> is just a Task for value types
        }

        static async Task MethodWithProblems(int firstParam, int secondParam)
        {
            Console.WriteLine("Enter");
            await Task.Run(() =>
            {
                // Call long running method
                Thread.Sleep(7_000);
                Console.WriteLine("First Complete");
                // Call another long running method that fails because the second parameter is out of range
                Console.WriteLine("Something bad happened");
            });
        }

        static async Task MethodWithProblemsFixed(int firstParam, int secondParam)
        {
            Console.WriteLine("Enter");
            if (secondParam < 0)
            {
                Console.WriteLine($"Bad data for parameter: {nameof(secondParam)}");
                return;
            }

            await actualImplementation();

            async Task actualImplementation()
            {
                await Task.Run(() =>
                {
                    // Call long running method
                    Thread.Sleep(7_000);
                    Console.WriteLine("First Complete");
                    // Call another long running method that fails because the second parameter is out of range
                    Console.WriteLine("Something bad happened");
                });
            }
        }




























    }
}