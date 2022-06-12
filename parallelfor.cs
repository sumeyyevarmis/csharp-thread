using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace parallelfor
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Parallel.For(0, 100, (ctr) => {
                Console.WriteLine(ctr + " sayi");
                // 0 dahil 100 dahil deðil ve bir bir artar,
                // üçüncü parametre body ve bunu lamda ile iþlemlerini yaparýz
            });
            Console.ReadLine();
        }*/


        /*
        // the number of parallel iterations to perform
        const int N = 1000000;
        static void Main()
        {
            // the result of all thread-local computations
            int result = 0;
            // this example e limits the degree of parallelism to four
            // You might limit the degree of parallelism when your algorithm
            // does not scale beyond a certain number of cores or when you
            // enforce a particular quality of service in your application.
            Parallel.For(0, N, new ParallelOptions { MaxDegreeOfParallelism = 4 },
                // Initialize the local states
                ()=>0, //her 4 thread için bir kere çalýþýyor
                // Accumulate the thread-local computations in the loop body
                (i,loop, localState) => { return localState + Compute(i); },
                // Combine all local states
                localState => Interlocked.Add(ref result, localState)
                );
            // Print the actual and expected results.
            Console.WriteLine("Actual result: {0}. Expected 1000000.", result);
            Console.ReadLine();
        }
        private static int Compute(int n)
        {
            for (int i = 0; i < 10000; i++) ;
            
            return 1;
            
        }*/
        const int N = 100000;
        static void Main()
        {
            double pi = 1;
            int t = -1;
            for(int i = 3;i<100000; i += 2)
            {
                pi = pi + (double)1 / i * t;
                t = t * -1;
            }
            Console.WriteLine(4 * pi);
            pi = 1;

            Parallel.For<double>(1, N, new ParallelOptions { MaxDegreeOfParallelism = 4 },
            // Initialize the local states
            () => 0,
            // Accumulate the thread-local computations in the loop body
            (i, loop, localState) => {
                int ctr = i;
                i = i * 2 + 1;
                if (ctr % 2 == 0)
                    return localState + (double)1 / i;
                else 
                    return localState - (double)1 / i;
            },
                // Combine all local states
                localState => { pi = pi + localState; });
            Console.WriteLine(pi * 4);

            Console.ReadLine();
        }


    }
}
