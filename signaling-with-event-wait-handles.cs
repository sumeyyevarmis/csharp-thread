using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace signalingwitheventwaithandles
{
    class Program
    {
        static EventWaitHandle _waitHandle = new AutoResetEvent(false);
        static void Waiter()
        {
            Console.WriteLine("Waiting...");
            _waitHandle.WaitOne(); // wait for notification
            Console.WriteLine("Notified");
        }
        static void Main(string[] args)
        {
            new Thread(Waiter).Start();
            Thread.Sleep(1000); // pause for a second
            _waitHandle.Set(); // wake up the waiter
            Console.ReadLine();
        }
    }
}
