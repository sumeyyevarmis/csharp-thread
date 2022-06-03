using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread
{
    class Program
    {
        bool done;
        static void Main()
        {
            Program tt = new Program(); // create a common instance
            new Thread(tt.Go).Start();
            tt.Go();
            Console.ReadLine();
        }
        void Go()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done");
            }
        }

    }
}
