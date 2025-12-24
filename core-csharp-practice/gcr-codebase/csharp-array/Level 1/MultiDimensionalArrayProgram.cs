//using System;

//class MultiDimensionalArrayProgram
//{
//    static void Main()
//    {

//        Console.Write("Enter number of rows: ");//Get input from user
//        int rows = int.Parse(Console.ReadLine());

//        Console.Write("Enter number of columns: ");
//        int columns = int.Parse(Console.ReadLine());


//        int[,] matrix = new int[rows, columns];

//        Console.WriteLine("\nEnter elements for the matrix:");        //Take user input

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                Console.Write("Enter element at position [{0},{1}]: ", i, j);
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }


//        Console.WriteLine("\n2D Array (Matrix):");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }


//        int[] array = new int[rows * columns];


//        int index = 0;


//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                array[index] = matrix[i, j]; // Copy element
//                index++; // Increment index
//            }
//        }
//        Console.WriteLine("\n1D Array:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.Write(array[i] + " ");
//        }
//        Console.WriteLine();
//    }
//}
