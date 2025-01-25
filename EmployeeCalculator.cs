using System;

class EmployeeCalculator
{
    static void Main()
    {
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        InputAndCalculate(salaries, yearsOfService, bonuses, newSalaries, ref totalBonus, ref totalOldSalary, ref totalNewSalary);

        Console.WriteLine("Total Bonus Payout: " + totalBonus);
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }

    static void InputAndCalculate(
        double[] salaries,
        double[] yearsOfService,
        double[] bonuses,
        double[] newSalaries,
        ref double totalBonus,
        ref double totalOldSalary,
        ref double totalNewSalary)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter salary for employee " + (i + 1) + ":");
            salaries[i] = Convert.ToDouble(Console.ReadLine());
            while (salaries[i] <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number:");
                salaries[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter years of service for employee " + (i + 1) + ":");
            yearsOfService[i] = Convert.ToDouble(Console.ReadLine());
            while (yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Enter a non-negative number:");
                yearsOfService[i] = Convert.ToDouble(Console.ReadLine());
            }

            if (yearsOfService[i] > 5)
            {
                bonuses[i] = salaries[i] * 0.05;
            }
            else
            {
                bonuses[i] = salaries[i] * 0.02;
            }

            newSalaries[i] = salaries[i] + bonuses[i];
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }
    }
}
