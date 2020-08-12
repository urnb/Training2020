using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Lab5DataTypes
{//ctrl - to go back to prev tab
    //ctrl + to go to next tab
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
           //Text binary
            byte b = 65;// loading huge files
            char c = (char)b;//text files.. hindi,marathi etc.//type casting byte to char // char only one character so string is used
            string d = "Test";//unicode 1 char = 2 bytes

            //Numeric Data types without decimals
            // Signed and unsigned
            short e = 10; //signed integer //short or ushort or Int16 same thing
            long f = 10;//very big interger

            //Numeric Data types with decimals
            float g = 0.1234f;//7 decimal places //temperature
            decimal h = 1.8M;//money //14 precison
            double i = 0.89898;//high precision //29 precision
            bool J = false ; //true or false
           
            Console.WriteLine("" + b + "" + c+""+d+ ""+e+""+f+""+J);
        }
    }
}
