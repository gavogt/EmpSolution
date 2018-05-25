using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Manager : Employee
    {
        private string manNumber;

        public Manager(string managersNumber)
        {
            this.ManNumber = managersNumber;
        }

        public string ManNumber { get => manNumber; set => manNumber = value; }

        public override void AnnounceEmployee()
        {
            // Access Employee Properties
            Console.WriteLine("Manager name is " + Fname + " " + Lname);

        }
    }
}
