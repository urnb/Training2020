using System;
using System.Threading;
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            int age = 0;
            //To add multiple records
            Console.WriteLine("How many records");
            int records = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < records; i++)
            {
                try
                {
                    //Console.WriteLine("Hello World!"+Name+""+age);
                    Console.WriteLine("Enter your name" + Name);
                    Name = Console.ReadLine();//Takes data just like scanf 
                    if (Name.Length == 0)
                    {
                        Console.WriteLine("Name is required");
                        Console.Read();//so that error message can be seen and return so as to exit the program 
                        return;
                    }
                    Console.WriteLine("Enter your age" + age);
                    age = Convert.ToInt16(Console.ReadLine());//as string is accepted so conversion to int is to be explicit
                    Console.WriteLine("Name  " + Name + "   Age  " + age);
                    //Console.ReadLine();
                }
                catch (Exception e)
                { Console.WriteLine("Please try again"); }
            }
        }
    }
}