using System;

namespace CG_Practice.dsacsharp.binarysearch
{
    class Matrix2DSearch
    {
        static void Main()
        {
            int[,] matrix = {
                { 1,  4,  7,  11 },
                { 2,  5,  8,  12 },
                { 3,  6,  9,  16 },
                { 10, 13, 14, 17 }
            };
            
            int target = 5;
            
            Console.WriteLine("2D Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            Console.WriteLine("Searching for: " + target);
            
            bool found = SearchMatrix(matrix, target);
            
            if (found)
            {
                Console.WriteLine("Target found in matrix");
            }
            else
            {
                Console.WriteLine("Target not found in matrix");
            }
            
            Console.ReadKey();
        }
        
        static bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            
            int left = 0;
            int right = rows * cols - 1;
            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midValue = matrix[mid / cols, mid % cols];
                
                if (midValue == target)
                {
                    return true;
                }
                else if (midValue < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            
            return false;
        }
    }
}