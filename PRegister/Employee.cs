namespace PRegisterÖvning1
{
    internal class Employee
    {
        public string Name { get; }

        public int Salary { get; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Name:\t{Name}\nSalary:\t{Salary}\n";
        }
    }
}