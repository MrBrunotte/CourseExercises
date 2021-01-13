namespace Övn1PersonalRegister
{
    internal class Employee
    {
        public string Name { get; }
        public int Salary { get; }

        // Ett härlett property
        public SalaryLevel SalaryLevel
        {
            get
            {
                if (Salary < 15000)
                {
                    return SalaryLevel.junior;
                }
                else
                {
                    return SalaryLevel.Senior;
                }
            }
        }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}