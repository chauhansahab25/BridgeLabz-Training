using System;
class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
    public virtual double CalculateSalary()
    {
        return Salary;
    }
}
class Developer : Employee
{
    public Developer(string name, double salary) : base(name, salary)
    {
    }
    public override double CalculateSalary()
    {
        return Salary + (Salary * 20 / 100);
    }
}
class Manager : Employee
{
    public Manager(string name, double salary) : base(name, salary)
    {
    }
    public override double CalculateSalary()
    {
        return Salary + (Salary * 30 / 100);
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Enter number of employees: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Employee[] employees = new Employee[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEnter employee " + (i + 1));
            Console.Write("Enter Type (Developer/Manager): ");
            string type = Console.ReadLine();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (type.ToLower() == "developer")
            {
                employees[i] = new Developer(name, salary);
            }
            else if (type.ToLower() == "manager")
            {
                employees[i] = new Manager(name, salary);
            }
            else
            {
                Console.WriteLine("Invalid employee type");
            }
        }

        Console.WriteLine("\nEmployee Salaries:");
        for (int i = 0; i < n; i++)
        {
            if (employees[i] != null)
            {
                Console.WriteLine(
                    employees[i].Name + ": " + employees[i].CalculateSalary()
                );
            }
        }
    }
}