using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.oopscsharp
{
    // course class
    class Course
    {
        public string CourseName;
        public string CourseCode;
        public Professor assignedProfessor;  // professor teaching this course
        public List<Student> enrolledStudents;

        public Course(string name, string code)
        {
            CourseName = name;
            CourseCode = code;
            enrolledStudents = new List<Student>();
        }

        // assign professor to course
        public void AssignProfessor(Professor prof)
        {
            assignedProfessor = prof;
            prof.courses.Add(this);  // add course to professor's list
            Console.WriteLine("Prof. " + prof.Name + " assigned to " + CourseName);
        }

        public void showCourseInfo()
        {
            Console.WriteLine("Course: " + CourseName + " (" + CourseCode + ")");
            if (assignedProfessor != null)
                Console.WriteLine("Professor: " + assignedProfessor.Name);
            Console.WriteLine("Students enrolled: " + enrolledStudents.Count);
            Console.WriteLine();
        }
    }

    // student class
    class Student
    {
        public string Name;
        public int StudentId;
        public List<Course> enrolledCourses;

        public Student(string name, int id)
        {
            Name = name;
            StudentId = id;
            enrolledCourses = new List<Course>();
        }

        // enroll in course (communication)
        public void EnrollCourse(Course course)
        {
            enrolledCourses.Add(course);
            course.enrolledStudents.Add(this);
            Console.WriteLine(Name + " enrolled in " + course.CourseName);
        }

        public void showStudentInfo()
        {
            Console.WriteLine("Student: " + Name + " (ID: " + StudentId + ")");
            Console.WriteLine("Enrolled courses:");
            foreach (Course course in enrolledCourses)
            {
                Console.WriteLine("- " + course.CourseName);
            }
            Console.WriteLine();
        }
    }

    // professor class
    class Professor
    {
        public string Name;
        public string Department;
        public List<Course> courses;  // courses professor teaches

        public Professor(string name, string dept)
        {
            Name = name;
            Department = dept;
            courses = new List<Course>();
        }

        public void showProfessorInfo()
        {
            Console.WriteLine("Professor: " + Name + " (" + Department + ")");
            Console.WriteLine("Teaching courses:");
            foreach (Course course in courses)
            {
                Console.WriteLine("- " + course.CourseName);
            }
            Console.WriteLine();
        }
    }

    // university management system
    class UniversitySystem
    {
        public string UniversityName;
        public List<Student> students;
        public List<Professor> professors;
        public List<Course> courses;

        public UniversitySystem(string name)
        {
            UniversityName = name;
            students = new List<Student>();
            professors = new List<Professor>();
            courses = new List<Course>();
        }

        public void addStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine(student.Name + " added to " + UniversityName);
        }

        public void addProfessor(Professor professor)
        {
            professors.Add(professor);
            Console.WriteLine("Prof. " + professor.Name + " joined " + UniversityName);
        }

        public void addCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine(course.CourseName + " added to curriculum");
        }

        public void showUniversityInfo()
        {
            Console.WriteLine("University: " + UniversityName);
            Console.WriteLine("Students: " + students.Count);
            Console.WriteLine("Professors: " + professors.Count);
            Console.WriteLine("Courses: " + courses.Count);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // create university system
            UniversitySystem uni = new UniversitySystem("Tech University");

            // create professors
            Professor prof1 = new Professor("Dr. Smith", "Computer Science");
            Professor prof2 = new Professor("Dr. Jones", "Mathematics");

            // create courses
            Course course1 = new Course("Programming", "CS101");
            Course course2 = new Course("Data Structures", "CS201");
            Course course3 = new Course("Calculus", "MATH101");

            // create students
            Student s1 = new Student("john", 1001);
            Student s2 = new Student("alice", 1002);

            // add to university
            uni.addProfessor(prof1);
            uni.addProfessor(prof2);
            uni.addCourse(course1);
            uni.addCourse(course2);
            uni.addCourse(course3);
            uni.addStudent(s1);
            uni.addStudent(s2);

            // assign professors to courses
            course1.AssignProfessor(prof1);
            course2.AssignProfessor(prof1);
            course3.AssignProfessor(prof2);

            // students enroll in courses
            s1.EnrollCourse(course1);
            s1.EnrollCourse(course3);
            s2.EnrollCourse(course1);
            s2.EnrollCourse(course2);

            // show information
            uni.showUniversityInfo();
            prof1.showProfessorInfo();
            s1.showStudentInfo();
            course1.showCourseInfo();

            Console.ReadLine();
        }
    }
}