using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3ThreadTasksPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Hello World!");
            Task t1 = new Task(Fun1);
            Task t2 = new Task(Fun2);
            t1.Start();
            t2.Start();
            Console.WriteLine("Hello");
            Console.Read(); //makes your program wait
        }
        static void Fun1()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Func1");

        }
        static void Fun2()
        {
            //Thread.Sleep(10000);// Task gives same output as Thread
            Console.WriteLine("Func2");

        }
    }
    }

