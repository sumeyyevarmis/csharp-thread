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
        static int[,] x = new int[10, 20];
        static int lck=0;
        static void sum()
        {
            int total = 0;
            for(int j = 0; j < 10; j++)
            {
                for(int i = 0; i < 20; i++)
                {
                    total = total + x[j, i];
                }
            }
            Console.WriteLine(total);
            lck++;
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < 4; i++)
            {
                Thread t = new Thread(sum);
                t.Start();
            }
            while (lck < 4) ;
            Console.ReadLine();
        }

    }
}
