using System;
using System.Security.Authentication;

class Program
{
    static void Main(string[] args)
    {

        Fraction myFractionZero = new Fraction();
        myFractionZero.DisplayFraction();
        myFractionZero.DisplayDecimal();

        Console.WriteLine("Enter the numerator");
        int userTop = Convert.ToInt32(Console.ReadLine());

        Fraction myFractionOne = new Fraction(userTop);
        myFractionOne.DisplayFraction();
        myFractionOne.DisplayDecimal();

        Console.WriteLine("Enter the Denominator");
        int userBottom = Convert.ToInt32(Console.ReadLine());

        Fraction myFractionTwo = new Fraction(userTop, userBottom);
        myFractionTwo.DisplayFraction();
        myFractionTwo.DisplayDecimal();

    }
}