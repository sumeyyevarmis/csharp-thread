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
        static bool done;
        static void Go()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done");
            }
        }
        static void Main()
        {
            new Thread(Go).Start();
            Go();
            Console.ReadLine();
        }
    }
}
