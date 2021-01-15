using System;

namespace PRegisterÖvning1
{
    class Program
    {
        static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {
            SeedData();
            do
            {
                PrintMenu();
            } while (true);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("\n---- Employee List ----\n");
            Console.WriteLine("1. Add new employee.");
            Console.WriteLine("2. Print employees.");
            Console.WriteLine("Q. Type Q to quit.");

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
                case "q":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        private static void Add()
        {
            Console.WriteLine("---- Add new Employee & Salary, type Q to quit! ----\n");
            do
            {
                string name = Util.AskForString("Name: ");
                if (name == "Q" || name == "q")
                {
                    break;
                }
                int salary = Util.AskForInt("Salary: ");
                payroll.AddEmployee(name, salary);

            } while (true);
        }

        private static void Print()
        {
            Employee[] employees = payroll.GetEmployees();

            Console.WriteLine("---- Print all employees ----\n");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Stefan", 50000);
            payroll.AddEmployee("Viggo", 60000);
            payroll.AddEmployee("Peter", 35000);
            payroll.AddEmployee("Lisa", 34500);
            payroll.AddEmployee("Calle", 70000);
        }
    }
}
