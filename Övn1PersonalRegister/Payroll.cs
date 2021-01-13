using System;
using System.Collections.Generic;

namespace Övn1PersonalRegister
{
    public class Payroll
    {
        // Private List of Employee objects called payroll
        // Declaration of type List<> called payroll in the Employee class
        private List<Employee> payroll;
        public Payroll()
        {
            // instantiate payroll
            payroll = new List<Employee>();
        }

        internal Employee[] GetEmployees()
        {
            // Send back a copy of the payroll since the list is private!
            // Use Array to get the copy not the actual list!
            return payroll.ToArray();
        }

        public void AddEmployee(string name, int salary)
        {
            // add a new employee with name and salary to our list called payroll
            payroll.Add(new Employee(name, salary));
        }
    }
}