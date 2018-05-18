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
            DisplayHeader();
            // Employer inputing
            InitialEmployeeName();

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

        // Logic of the initially adding an employee name
        static string InitialEmployeeName()
        {
            string employerNameInputing = "";

            Console.WriteLine("\nWhat is your name?");
            employerNameInputing = Console.ReadLine();

            if (employerNameInputing == string.Empty)
            {
                WelcomeName();
            }
            else
            {
                WelcomeName(employerNameInputing);
            }
 
            return employerNameInputing;

        }

        static void SysDateTime()
        {
            Console.WriteLine("Please note the time: "+DateTime.Now);
            Console.WriteLine("All access will be logged...\n");

        }

        static void DisplayHeader()
        {
            Console.WriteLine("*************************\n*** Employee Solution ***\n*************************\n");
            SysDateTime();

        }
    }
}
