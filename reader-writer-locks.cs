using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace readerwriterlocks
{
    class Program
    {
        static ReaderWriterLockSlim _rw = new ReaderWriterLockSlim();
        static List<int> _items = new List<int>();
        static Random _rand = new Random();
        static void Main(string[] args)
        {
            new Thread(Read).Start();
            new Thread(Read).Start();
            new Thread(Read).Start();

            new Thread(Write).Start("A");
            new Thread(Write).Start("B");
            Console.ReadLine();
        }
        static void Read()
        {
            while (true)
            {
                _rw.EnterReadLock();
                foreach (int i in _items) Thread.Sleep(10);
                _rw.ExitReadLock();
            }
        }
        static void Write(object threadID)
        {
            while (true)
            {
                int newNumber = GetRandNum(100);
                _rw.EnterWriteLock();
                _items.Add(newNumber);
                _rw.ExitWriteLock();
                Console.WriteLine("Thread " + threadID + " added " + newNumber);
                Thread.Sleep(100);
            }
        }
        static int GetRandNum(int max) { lock (_rand) return _rand.Next(max); }
    }
}
