using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // course class
    class Course
    {
        public string CourseName;
        public List<Student> enrolledStudents;  // students in this course

        public Course(string name)
        {
            CourseName = name;
            enrolledStudents = new List<Student>();
        }

        // show students in course
        public void showEnrolledStudents()
        {
            Console.WriteLine("Students in " + CourseName + ":");
            foreach (Student student in enrolledStudents)
            {
                Console.WriteLine("- " + student.Name);
            }
            Console.WriteLine();
        }
    }

    // student class
    class Student
    {
        public string Name;
        public int RollNumber;
        public List<Course> courses;  // courses student is enrolled in

        public Student(string name, int roll)
        {
            Name = name;
            RollNumber = roll;
            courses = new List<Course>();
        }

        // enroll in course (association)
        public void enrollInCourse(Course course)
        {
            courses.Add(course);
            course.enrolledStudents.Add(this);  // add student to course too
            Console.WriteLine(Name + " enrolled in " + course.CourseName);
        }

        // view enrolled courses
        public void viewCourses()
        {
            Console.WriteLine(Name + "'s courses:");
            foreach (Course course in courses)
            {
                Console.WriteLine("- " + course.CourseName);
            }
            Console.WriteLine();
        }
    }

    // school class
    class School
    {
        public string SchoolName;
        public List<Student> students;  // aggregation - students can exist without school

        public School(string name)
        {
            SchoolName = name;
            students = new List<Student>();
        }

        // add student to school (aggregation)
        public void addStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine(student.Name + " added to " + SchoolName);
        }

        public void showAllStudents()
        {
            Console.WriteLine("Students in " + SchoolName + ":");
            foreach (Student student in students)
            {
                Console.WriteLine("- " + student.Name + " (Roll: " + student.RollNumber + ")");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create school
            School school = new School("ABC School");

            // create students
            Student s1 = new Student("john", 101);
            Student s2 = new Student("alice", 102);

            // add students to school (aggregation)
            school.addStudent(s1);
            school.addStudent(s2);

            // create courses
            Course math = new Course("Mathematics");
            Course science = new Course("Science");

            // students enroll in courses (association - many to many)
            s1.enrollInCourse(math);
            s1.enrollInCourse(science);
            s2.enrollInCourse(math);

            // show relationships
            school.showAllStudents();
            s1.viewCourses();
            s2.viewCourses();
            math.showEnrolledStudents();

            Console.ReadLine();
        }
    }
}