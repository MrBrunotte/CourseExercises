using System;

namespace Övn1PersonalRegister
{
    internal class Program
    {
        private static Payroll payroll = new Payroll();

        private static void Main(string[] args)
        {
            SeedData();
            do
            {
                PrintMenu();
            } while (true);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("1. Add new Employee");
            Console.WriteLine("2. Print");
            Console.WriteLine("Q. Quit");

            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    break;

                case "2":
                    Print();
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }

        private static void Print()
        {
            //Get an Array of Employee objects by creating a GetEmployess( ) method
            Employee[] employees = payroll.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);

                //if (employee.SalaryLevel.Equals(SalaryLevel.junior))
                //    Console.WriteLine(DoJuniorWork());
                //if (employee.SalaryLevel.Equals(SalaryLevel.Senior))
                //    Console.WriteLine(DoSeniorWork());

                // Ternary operation
                Console.WriteLine(employee.SalaryLevel.Equals(SalaryLevel.junior) ?
                    DoJuniorWork() :
                    DoSeniorWork());
            }
        }

        private static string DoSeniorWork()
        {
            return "Do senior work";
        }

        private static string DoJuniorWork()
        {
            return "Do junior work";
        }

        private static void Add()
        {
            Console.WriteLine("Add new Employee, Quit with Q");
            // Do loop because we want to do the validation at the end, not at the beginning!
            // We do something until "something" is true!
            do
            {
                // Create a method in the Util Class called AskForString that will return Name:
                string name = Util.AskForString("Name: ");
                if (name == "Q")
                {
                    break;
                }
                int salary = Util.AskForInt("Salary: ");
                // Save and add to payroll
                payroll.AddEmployee(name, salary);
            } while (true);
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 10000);
            payroll.AddEmployee("Nisse", 30000);
            payroll.AddEmployee("Lisa", 230000);
            payroll.AddEmployee("Anne", 50000);
        }
    }
}