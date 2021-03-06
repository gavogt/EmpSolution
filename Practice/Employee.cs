﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Employee
    {
        #region Employee Variables
        private string fname;
        private string lname;
        private string empNumber;
        #endregion

        // Accessing the properties
        protected string Fname { get => fname; set => fname = value; }
        protected string Lname { get => lname; set => lname = value; }
        protected string EmpNumber { get => empNumber; set => empNumber = value; }

        public Employee(string first, string last, string enumber)
        {
            this.fname = first;
            this.lname = last;
            this.empNumber = enumber;
        }

        public Employee()
        {
            fname = " Error! Employee has no name";
        }

        #region Employee Methods
        public virtual void AnnounceEmployee()
        {
            Console.WriteLine("Employee name is " + fname + " " + lname);

        }
        #endregion
    }
}
