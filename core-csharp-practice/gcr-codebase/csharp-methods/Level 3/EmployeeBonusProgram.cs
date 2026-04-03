using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.NewFolder
{
    public class EmployeeBonusProgram
    {
        static void Main()
        {
            Console.WriteLine("=== Zara Company Employee Bonus Calculator ===");
            Console.WriteLine("Total Employees: 10");
            Console.WriteLine();

           
            double[,] employeeData = GenerateEmployeeData();

            
            double[,] salaryAndBonus = CalculateSalaryAndBonus(employeeData);// Calculate new salary and bonus

           
            DisplayResults(employeeData, salaryAndBonus);
        }

        
        static double[,] GenerateEmployeeData()
        {
            
            double[,] data = new double[10, 2];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                
                data[i, 0] = random.Next(10000, 100000);// Generate 5-digit salary

                
                data[i, 1] = random.Next(1, 16);// Generate years of service
            }

            return data;
        }

        
        static double[,] CalculateSalaryAndBonus(double[,] employeeData)
        {
            
            double[,] result = new double[10, 2];

            for (int i = 0; i < 10; i++)
            {
                double oldSalary = employeeData[i, 0];
                double yearsOfService = employeeData[i, 1];
                double bonusPercentage;
                double bonusAmount;

                
                if (yearsOfService > 5)
                {
                    bonusPercentage = 5.0; // 5% bonus
                }
                else
                {
                    bonusPercentage = 2.0; // 2% bonus
                }

                
                bonusAmount = oldSalary * (bonusPercentage / 100.0);//bonus amount

                
                double newSalary = oldSalary + bonusAmount;//new salary

                
                result[i, 0] = newSalary;
                result[i, 1] = bonusAmount;
            }

            return result;
        }

        static void DisplayResults(double[,] employeeData, double[,] salaryAndBonus)
        {
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-10} | {1,-12} | {2,-12} | {3,-12} | {4,-12} |",
                "Employee", "Years", "Old Salary", "Bonus", "New Salary"));
            Console.WriteLine("-------------------------------------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                int employeeNumber = i + 1;
                double yearsOfService = employeeData[i, 1];
                double oldSalary = employeeData[i, 0];
                double bonus = salaryAndBonus[i, 1];
                double newSalary = salaryAndBonus[i, 0];

                Console.WriteLine(String.Format("| {0,-10} | {1,-12} | {2,-12:F2} | {3,-12:F2} | {4,-12:F2} |",
                    "Emp " + employeeNumber, yearsOfService, oldSalary, bonus, newSalary));

                totalOldSalary += oldSalary;
                totalBonus += bonus;
                totalNewSalary += newSalary;
            }

            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine(String.Format("| {0,-10} | {1,-12} | {2,-12:F2} | {3,-12:F2} | {4,-12:F2} |",
                "TOTAL", "", totalOldSalary, totalBonus, totalNewSalary));
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("=== Summary ===");
            Console.WriteLine("Total Old Salary:  Rs. {0:F2}", totalOldSalary);
            Console.WriteLine("Total Bonus:       Rs. {0:F2}", totalBonus);
            Console.WriteLine("Total New Salary:  Rs. {0:F2}", totalNewSalary);
        }
    }

}
}
