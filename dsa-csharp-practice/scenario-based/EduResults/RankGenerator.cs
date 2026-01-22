// using System;

// public class RankGenerator
//     {
//         public List<Student> Sort(List<Student> students)
//         {
//             if (students.Count <= 1)
//                 return students;

//             List<Student> left = new List<Student>();
//             List<Student> right = new List<Student>();

//             int mid = students.Count / 2;

//             for (int i = 0; i < mid; i++)
//                 left.Add(students[i]);
//             for (int i = mid; i < students.Count; i++)
//                 right.Add(students[i]);

//             left = Sort(left);
//             right = Sort(right);

//             return Merge(left, right);
//         }

//         private List<Student> Merge(List<Student> left, List<Student> right)
//         {
//             List<Student> result = new List<Student>();
//             int i = 0, j = 0;

//             while (i < left.Count && j < right.Count)
//             {
//                 if (left[i].Score >= right[j].Score) 
//                 {
//                     result.Add(left[i]);
//                     i++;
//                 }
//                 else
//                 {
//                     result.Add(right[j]);
//                     j++;
//                 }
//             }

//             while (i < left.Count)
//             {
//                 result.Add(left[i]);
//                 i++;
//             }

//             while (j < right.Count)
//             {
//                 result.Add(right[j]);
//                 j++;
//             }

//             return result;
//         }
//     }

    
    