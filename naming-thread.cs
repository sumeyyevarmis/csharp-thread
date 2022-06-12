using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace namingthread
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Thread.CurrentThread.Name = "main";
            Thread worker = new Thread(Go);
            worker.Name = "worker";
            worker.Start();
            Go();
            Console.ReadLine();
        }
        static void Go()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
        }
        
    }
}
