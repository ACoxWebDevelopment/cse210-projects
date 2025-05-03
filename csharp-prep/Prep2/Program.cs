using System;

class Program
{
    static void Main(string[] args)
    {
        string grade=null;
        string sign="";
        Console.WriteLine("Welcome to the letter grade converter");
        Console.WriteLine("Please enter your score as a whole number");
        int score=Convert.ToInt32(Console.ReadLine());
        if (score<60)
        {
             grade="F";
        }
        if (score>=60)
        {
            grade="D";
            if (score<63)
            {
                sign="-";
            }
            else if (score>=67)
            {
                sign="+";
            }
        }
        if (score>=70)
        {
            grade="C";
            if (score<73)
            {
                sign="-";
            }
            else if (score>=77)
            {
                sign="+";
            }
        }
        if (score>=80)
        {
            grade="B";
            if (score<83)
            {
                sign="-";
            }
            else if (score>=87)
            {
                sign="+";
            }
        }
        if (score>=90)
        {
            grade="A";
            if(score<93)
            {
                sign="-";
            }
        }
        Console.WriteLine($"Your letter grade is a/an {grade}{sign}");

        if(score>=70)
        {
            Console.WriteLine("Congratulations, You passed!");

        }
        else 
        {
            Console.WriteLine("You did not pass this time.  Keep trying");
        }
    }   

}