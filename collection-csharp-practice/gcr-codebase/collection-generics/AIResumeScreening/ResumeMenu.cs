// using System;

// namespace CG_Practice.dsascenario.AIResumeScreening
// {
//     public class ResumeMenu
//     {
//         public static void Start()
//         {
//             Resume<SoftwareEngineer> se = new Resume<SoftwareEngineer>();
//             Resume<DataScientist> ds = new Resume<DataScientist>();

//             ResumeUtility.AddRole(se, new SoftwareEngineer("Amit", 3));
//             ResumeUtility.AddRole(se, new SoftwareEngineer("Ravi", 5));

//             ResumeUtility.AddRole(ds, new DataScientist("Neha", 4));

//             Console.WriteLine("\n--- Software Engineer Screening ---");
//             se.Process();

//             Console.WriteLine("\n--- Data Scientist Screening ---");
//             ds.Process();
//         }
//     }
// }
