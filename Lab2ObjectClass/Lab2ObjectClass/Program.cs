using System;
using System.Net.Sockets;

namespace Lab2ObjectClass
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
                    Person p = new Person();
                    Console.WriteLine("Name");
                    p.Name = Console.ReadLine();
                    Console.WriteLine("Age");
                    p.Age = Convert.ToInt32(Console.ReadLine());
             //       Console.WriteLine("Address");
               //     p.Address = Console.ReadLine();
                    //Console.WriteLine("Salary");
                    //p.Salary = Console.ReadLine();
                    if (p.Valid()) { 
                    Console.WriteLine("Name" + Name + "Age" + age );
                    }
                }
                catch (Exception e)
                { Console.WriteLine("Please try again"); }
            }
        }
    }
    class Person
    {
public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public bool Valid() { 
        if(Name.Length==0)
            {return false;}//then below code wont execute
            if (Age>100)
            { return false; }

            return true;
        }
    }
}
