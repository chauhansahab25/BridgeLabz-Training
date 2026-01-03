using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // faculty class - can exist independently
    class Faculty
    {
        public string Name;
        public string Subject;

        public Faculty(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }

        public void showFaculty()
        {
            Console.WriteLine("Faculty: " + Name + " - " + Subject);
        }
    }

    // department class - part of university (composition)
    class Department
    {
        public string DeptName;
        public List<Faculty> faculties;  // aggregation with faculty

        public Department(string name)
        {
            DeptName = name;
            faculties = new List<Faculty>();
        }

        // assign faculty to department (aggregation)
        public void assignFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
            Console.WriteLine(faculty.Name + " assigned to " + DeptName);
        }

        public void showDepartment()
        {
            Console.WriteLine("Department: " + DeptName);
            foreach (Faculty faculty in faculties)
            {
                faculty.showFaculty();
            }
            Console.WriteLine();
        }
    }

    // university class - owns departments (composition)
    class University
    {
        public string UniversityName;
        public List<Department> departments;  // composition - university owns departments

        public University(string name)
        {
            UniversityName = name;
            departments = new List<Department>();
        }

        // create department (composition)
        public Department createDepartment(string deptName)
        {
            Department dept = new Department(deptName);
            departments.Add(dept);
            Console.WriteLine("Created " + deptName + " in " + UniversityName);
            return dept;
        }

        public void showUniversity()
        {
            Console.WriteLine("University: " + UniversityName);
            foreach (Department dept in departments)
            {
                dept.showDepartment();
            }
        }

        // close university (composition - departments deleted, faculty remains)
        public void closeUniversity()
        {
            Console.WriteLine("Closing " + UniversityName + " - departments will be removed");
            Console.WriteLine("Faculty members can work elsewhere");
            departments.Clear();  // departments deleted but faculty exists
        }
    }

    class Program
    {
        static void Main()
        {
            // create university
            University uni = new University("State University");

            // create departments (composition)
            Department csDept = uni.createDepartment("Computer Science");
            Department mathDept = uni.createDepartment("Mathematics");

            // create faculty (independent)
            Faculty f1 = new Faculty("Dr. Smith", "Programming");
            Faculty f2 = new Faculty("Dr. Jones", "Algorithms");
            Faculty f3 = new Faculty("Dr. Brown", "Calculus");

            // assign faculty to departments (aggregation)
            csDept.assignFaculty(f1);
            csDept.assignFaculty(f2);
            mathDept.assignFaculty(f3);

            // show university structure
            uni.showUniversity();

            // close university
            uni.closeUniversity();

            // faculty still exists
            Console.WriteLine("Faculty still exists:");
            f1.showFaculty();

            Console.ReadLine();
        }
    }
}