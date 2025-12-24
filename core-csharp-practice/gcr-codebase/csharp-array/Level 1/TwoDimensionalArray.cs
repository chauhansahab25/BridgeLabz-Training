//using System;
//    public class TwoDimensionalArray
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter number of rows :");
//            int rows = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter number of columns :");
//            int columns = Convert.ToInt32(Console.ReadLine());

//            int[,] array_two_d = new int[rows,columns];
//            Console.WriteLine("Enter the elements of 2D array :");

//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < columns; j++) {
//                    array_two_d[i,j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }
//            int[] array_one_d = new int[rows * columns];
//            int index = 0;

//            for (int i = 0; i < rows; i++) {
//                for (int j = 0; j < columns; j++) {
//                    array_one_d[index]= array_two_d[i,j];
//                    index++;
//                }
//            }
//            for (int i = 0; i < array_one_d.Length; i++) { 
//                Console.WriteLine(array_one_d [i]+ " ");
//            }

            
//        }
//    }
//}
