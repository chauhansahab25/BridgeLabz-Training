using System;

class Arithmeticoperators
{
    static void Main() 
    {
        int x = 10;
        int y = 5;
        
        int sum = x + y;
        int diff = x - y;
        int product = x * y;
        int division = x / y;
        int rem = x % y;
        
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + diff);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Division: " + division);
        Console.WriteLine("Modulus: " + rem);
    }
}





using System;

class Relationaloperators 
{
    static void Main() 
    {
        int x = 25;
        int y = 30;
        
        Console.WriteLine("num1 equal to num2 " + (x == y));
        Console.WriteLine("num1 not equal to num2 " + (x != y));
        Console.WriteLine("num1 greater than num2 " + (x > y));
        Console.WriteLine("num1 less than num2 " + (x < y));
        Console.WriteLine("num1 >= num2 " + (x >= y));
        Console.WriteLine("num1 <= num2 " + (x <= y));
    }
}



using System;

class Assignmentoperator 
{
    static void Main() 
    {
        int x = 100;
        Console.WriteLine("Initial value: " + x);
        
        x += 30;
        Console.WriteLine("After += 30: " + x);
        
        x -= 50;
        Console.WriteLine("After -= 50: " + x);
        
        x *= 3;
        Console.WriteLine("After *= 3: " + x);
        
        x /= 2;
        Console.WriteLine("After /= 2: " + x);
        
        x %= 10;
        Console.WriteLine("After %= 10: " + x);
    }
}


using System;

class Ternaryoperator 
{
    static void Main() 
    {
        int marks = 75;
        string result = (marks >= 50) ? "Pass" : "Fail";
        Console.WriteLine("Result: " + result);
    }
}


using System;

class Vehicle {}
class Car : Vehicle {}
class Bike : Vehicle {}

class IsOperator 
{
    static void Main() 
    {
        Vehicle myVehicle = new Car();
        Car myCar = new Car();
        
        Console.WriteLine("myVehicle is Vehicle: " + (myVehicle is Vehicle));
        Console.WriteLine("myVehicle is Car: " + (myVehicle is Car));
        Console.WriteLine("myVehicle is Bike: " + (myVehicle is Bike));
        Console.WriteLine("myCar is Vehicle: " + (myCar is Vehicle));
        
    }
}



using System;

class Unaryoperators 
{
    static void Main() 
    {
        int value = 30;
        bool flag = false;
        
        Console.WriteLine("Original value: " + value);
        Console.WriteLine("Pre-increment: " + (++value));
        Console.WriteLine("New value: " + value);
        Console.WriteLine("Post-increment: " + (value++));
        Console.WriteLine("New value: " + value);
        
        Console.WriteLine("Pre-decrement: " + (--value));
        Console.WriteLine("Post-decrement: " + (value--));
        Console.WriteLine("Final value: " + value);
        
        Console.WriteLine("Original flag: " + flag);
        Console.WriteLine("NOT flag: " + (!flag));
    }
}









