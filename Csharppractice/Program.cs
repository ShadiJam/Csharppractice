using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharppractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string greeting = "Hello World";
            int year = 1492;
            bool havedog = false;
            string todaysdate = "10/3/2016";
            float money = 5.45f;
            char x = 'X';

            //string interpolation
            Console.WriteLine(greeting);
            Console.WriteLine("Columbus Sailed the world in " + year);
            Console.WriteLine("It is " + havedog + " that I have a dog at home.");
            Console.WriteLine("Today is " + todaysdate);
            Console.WriteLine("I spent $" + money + " on a cheeseburger.");
            Console.WriteLine(x + " marks the spot");

            Console.ReadLine();



        }
    }
}
