using System;
using System.Threading;
using System.Threading.Tasks;
namespace Lab3ThreadTask
{// DEBUGGING CLICK ON DEBUG then click on leftmost vertical margin and set breakpoint, Debugging pauses on the breakpoint set yellow arrow indicates where the debugger is
    //Types of Debugging - Step by Step(line by line excecution), step into(to go into the function to debug) , step out(to get out of the fucntion this is done when function goes into an infinite loop and when step into debugging is on ), Run into cursor(to get line by line output of the code)
    
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Hello World!");
            Thread t1 = new Thread(new ThreadStart(Fun1));
            Thread t2 = new Thread(new ThreadStart(Fun2));
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
            //Thread.Sleep(10000);// so if both have same sleep period then this function will execute parallely first
            Console.WriteLine("Func2");

        }
    }
}

