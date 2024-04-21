using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace resourceconfliceinthreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math(2, 3);
            Thread t1 = new Thread(new ThreadStart(m.Add));
            Thread t2 = new Thread(new ThreadStart(m.Subtract));
            Thread t3 = new Thread(new ThreadStart(m.Multiply));
            t1.Start();
            t2.Start();
            t3.Start();

            // Wait for the user to press a key
            Console.ReadKey();
        }
    }
    class Math
    {
        public int value1;
        public int value2;
        private int result;
        public Math(int _value1, int _value2)
        {
            value1 = _value1;
            value2 = _value2;
        }
        public void Add()
        {
            result = value1 + value2;
            Thread.Sleep(1000);
            Console.WriteLine("Add: " + result);
        }
        public void Subtract()
        {
            result = value1 - value2;
            Thread.Sleep(1000);
            Console.WriteLine("Subtract: " + result);
        }
        public void Multiply()
        {
            result = value1 * value2;
            Thread.Sleep(1000);
            Console.WriteLine("Multiply: " + result);
        }
    }
}
