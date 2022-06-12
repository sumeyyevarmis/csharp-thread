using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace countdownEvent
{
    class Program
    {
        static CountdownEvent _countdown = new CountdownEvent(3);
        static void SaySomething(object thing)
        {
            Thread.Sleep(1000);
            Console.WriteLine(thing);
            _countdown.Signal();
        }
        static void Main(string[] args)
        {
            new Thread(SaySomething).Start("I am thread 1");
            new Thread(SaySomething).Start("I am thread 2");
            new Thread(SaySomething).Start("I am thread 3");

            _countdown.Wait(); // blocks until Signtal has been called 3 times
            Console.WriteLine("All thread have finished speaking");
            Console.ReadLine();
        }
    }
}
