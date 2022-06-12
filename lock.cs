using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace @lock
{
    class Program
    {
        static readonly object _locker = new object();
        static int _val1 =1, _val2=1;
        static void Go()
        {
            lock (_locker)
            {
                if (_val2 != 0) Console.WriteLine(_val1 / _val2);
                _val2 = 0;
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(Go);
                t.Start();
            }
            Console.ReadLine();
        }
    }
}
