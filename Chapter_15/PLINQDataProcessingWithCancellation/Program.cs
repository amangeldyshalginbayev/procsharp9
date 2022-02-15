using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PLINQDataProcessingWithCancellation
{
    class Program
    {
        private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Start any key to start processing");
            //Console.ReadKey();
            //Console.WriteLine("Processing");
            //Task.Factory.StartNew(ProcessIntDataNonParallel);
            //Task.Factory.StartNew(ProcessIntDataParallel);

            do
            {
                Console.WriteLine("Start any key to start processing");
                Console.ReadKey();
                Console.WriteLine("Processing");
                Task.Factory.StartNew(ProcessIntDataParallelWithCancellationToken);
                Console.Write("Enter Q to quit: ");
                string answer = Console.ReadLine();

                if (answer.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    _cancellationTokenSource.Cancel();
                    break;
                }
            } while (true);

            Console.ReadLine();
        }

        static void ProcessIntDataNonParallel()
        {
            int[] source = Enumerable.Range(1, 100_000_000).ToArray();
            int[] modThreeIsZero = (
                from num in source
                where num % 3 == 0
                orderby num descending
                select num).ToArray();
            Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");
        }

        static void ProcessIntDataParallel()
        {
            int[] source = Enumerable.Range(1, 100_000_000).ToArray();
            int[] modThreeIsZero = (
                from num in source.AsParallel()
                where num % 3 == 0
                orderby num descending
                select num).ToArray();
            Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");
        }
        
        static void ProcessIntDataParallelWithCancellationToken()
        {
            int[] source = Enumerable.Range(1, 100_000_000).ToArray();
            int[] modThreeIsZero = null;
            try
            {
                modThreeIsZero = (
                    from num in source.AsParallel().WithCancellation(_cancellationTokenSource.Token)
                    where num % 3 == 0
                    orderby num descending
                    select num).ToArray();
                Console.WriteLine();
                Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception happened!!!");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}