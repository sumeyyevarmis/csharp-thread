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
        static void hello()
        {
            Console.WriteLine("Hello !");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(hello);
            t.Start();
            Console.ReadLine();
        }
    }
}
