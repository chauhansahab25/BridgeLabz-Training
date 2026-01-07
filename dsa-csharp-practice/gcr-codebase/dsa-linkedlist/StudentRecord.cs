using System;

class Student
{
    public int roll;
    public string name;
    public int age;
    public string grade;
    public Student next;
}

class StudentList
{
    Student head;
    
    public void AddFirst(int r, string n, int a, string g)
    {
        Student s = new Student();
        s.roll = r; s.name = n; s.age = a; s.grade = g;
        s.next = head;
        head = s;
    }
    
    public void AddLast(int r, string n, int a, string g)
    {
        Student s = new Student();
        s.roll = r; s.name = n; s.age = a; s.grade = g;
        if (head == null) { head = s; return; }
        Student temp = head;
        while (temp.next != null) temp = temp.next;
        temp.next = s;
    }
    
    public void AddAt(int pos, int r, string n, int a, string g)
    {
        if (pos == 0) { AddFirst(r, n, a, g); return; }
        Student s = new Student();
        s.roll = r; s.name = n; s.age = a; s.grade = g;
        Student temp = head;
        for (int i = 0; i < pos - 1 && temp != null; i++) temp = temp.next;
        if (temp != null) { s.next = temp.next; temp.next = s; }
    }
    
    public void Delete(int r)
    {
        if (head == null) return;
        if (head.roll == r) { head = head.next; return; }
        Student temp = head;
        while (temp.next != null && temp.next.roll != r) temp = temp.next;
        if (temp.next != null) temp.next = temp.next.next;
    }
    
    public Student Search(int r)
    {
        Student temp = head;
        while (temp != null)
        {
            if (temp.roll == r) return temp;
            temp = temp.next;
        }
        return null;
    }
    
    public void Display()
    {
        Student temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.roll} {temp.name} {temp.age} {temp.grade}");
            temp = temp.next;
        }
    }
    
    public void UpdateGrade(int r, string g)
    {
        Student s = Search(r);
        if (s != null) s.grade = g;
    }
}