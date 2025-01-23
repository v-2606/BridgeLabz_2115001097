using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter marks for the following subjects (out of 100):");
        Console.Write("Physics: ");
        double physics = Convert.ToDouble(Console.ReadLine());
        Console.Write("Chemistry: ");
        double chemistry = Convert.ToDouble(Console.ReadLine());
        Console.Write("Maths: ");
        double maths = Convert.ToDouble(Console.ReadLine());

        if (physics < 0 || physics > 100 || chemistry < 0 || chemistry > 100 || maths < 0 || maths > 100)
        {
            Console.WriteLine("Error: Marks should be between 0 and 100 for all subjects.");
            return;
        }

        double totalMarks = physics + chemistry + maths;
        double percentage = (totalMarks / 300) * 100;

        string grade;
        string remarks;

        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Excellent performance!";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Good job!";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Satisfactory performance.";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Needs improvement.";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Poor performance.";
        }
        else
        {
            grade = "R";
            remarks = "Requires remedial actions.";
        }
        Console.WriteLine(totalMarks + " is your total marks out of 300.");
        Console.WriteLine(percentage.ToString("F2") + "% is your overall percentage.");
        Console.WriteLine(grade + " is your assigned grade.");
        Console.WriteLine(remarks + " is your performance remarks.");
    }
}
