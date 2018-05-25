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
            Employee initialEmp = new Employee();

            DisplayHeader();
            InitialEmployeeName(initialEmp);

        }

        static void InitialEmployeeName(Employee emp)
        {
            string first_name = "";
            string last_name = "";
            string emp_number = "";

            #region Asking for user input section
            Console.WriteLine("\nWhat is your first name? ");
            first_name = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            last_name = Console.ReadLine();

            Console.WriteLine("what is your employee number? ");
            emp_number = Console.ReadLine();
            #endregion

            Employee myEmp = new Employee(first_name, last_name, emp_number);

            if (emp_number == string.Empty)
            {
                WelcomeEmpNumber();

            }
            else
            {
                WelcomeEmpNumber(emp_number);

            }

            myEmp.AnnounceEmployee();
            

        }

        static void SysDateTime()
        {
            #region Access notifications
            Console.WriteLine("Please note the time: " + DateTime.Now);
            Console.WriteLine("All access will be logged...\n");
            #endregion

        }

        static void DisplayHeader()
        {
            Console.WriteLine("*************************\n*** Employee Solution ***\n*************************\n");
            SysDateTime();

        }

        // Welcome the inputter
        static void WelcomeEmpNumber()
        {
            Console.WriteLine("You must have a name");

        }

        // Welcome overloaded
        static void WelcomeEmpNumber(string number)
        {
            Console.WriteLine($"Welcome employee #{number}");

        }
    }
}
