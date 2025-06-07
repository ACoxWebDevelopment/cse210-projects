using System;

class Program
{
    static void Main(string[] args)
    {

        MathAssignment myMath = new MathAssignment("Herbert Hoover", "math", "fractions", "problems 1-25");
        string mathHomework = myMath.GetHomeworkList();
        Console.WriteLine(mathHomework);

        WritingAssignment myWritingAssignment = new WritingAssignment("Maria Jones", "Writing", "Middle Earth by Maria Jones");
        string writingHomework = myWritingAssignment.GetWritingInformation();
        Console.WriteLine();
        Console.WriteLine(writingHomework);
    }

} 