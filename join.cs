using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Threading;

namespace thread
{
    class Program
    {
        static int j = 0;
        static void Main()
        {
            Thread t = new Thread(Go);
            t.Start();
            // t.Join();
            while (j < 1) ;
            Console.WriteLine("Thread t has ended!");
            Console.ReadLine();
        }
        static void Go()
        {
            for( int i = 0; i < 10; i++)
            {
                j++;
                Console.WriteLine(j);
            }
        }
    }
}
