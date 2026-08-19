using System;

class Student
{
    public string Name { get; set; }
    public int RollNumber { get; set; }
    public double Marks { get; set; }
    public Student(string name, int rollNumber, double marks)
    {
        Name = name;
        RollNumber = rollNumber;
        Marks = marks;
    }
    public string CalculateGrade()
    {
        if (Marks >= 80)
            return "A";
        else if (Marks >= 60)
            return "B";
        else if (Marks >= 40)
            return "C";
        else
            return "F";
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Marks: " + Marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Student[] students = new Student[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEnter details of student " + (i + 1));
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Roll Number: ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());
            students[i] = new Student(name, rollNumber, marks);
        }
        Console.WriteLine("\nStudent Details:");
        for (int i = 0; i < n; i++)
        {
            students[i].DisplayDetails();
            Console.WriteLine();
        }
    }
}