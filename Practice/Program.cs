using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string employerNameInputing = "";

            Console.WriteLine("*** Employee Solution ***");

            Console.WriteLine("What is your name?");
            employerNameInputing = Console.ReadLine();

            if (employerNameInputing == string.Empty)
            {
                WelcomeName();
            }
            else
            {
                WelcomeName(employerNameInputing);
            }
        }

        // Welcome the inputter
        static void WelcomeName()
        {
            Console.WriteLine("You must have a name");
        }

        // Welcome overloaded
        static void WelcomeName(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
    }
}
