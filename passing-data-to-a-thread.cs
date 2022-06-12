using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace passingdatatoathread
{
    class Program
    {
        static void Print(string mesg)
        {
            Console.WriteLine(mesg);
        }
        static void Main(string[] args)
        {
            /*Thread t = new Thread(
                ()=>Print("hello")
                );
            t.Start();*/
            /*
            for(int i = 0; i < 10; i++)
            {
                int temp = i;
                new Thread( ()=>Console.WriteLine(temp)).Start();
            }*/
            string text = "t1";
            Thread t1 = new Thread(()=>Console.WriteLine(text));

            text = "t2";
            Thread t2 = new Thread(()=>Console.WriteLine(text));

            t1.Start();
            t2.Start();

            Console.ReadLine();
        }
    }
}
