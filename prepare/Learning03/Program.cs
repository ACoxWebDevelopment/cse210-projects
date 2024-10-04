using System;
using System.Security.Authentication;

class Program
{
    static void Main(string[] args)
    {
        Fraction noarg = new Fraction();
        Fraction onearg= new Fraction(5);
        Fraction twoarg= new Fraction(6,7);

        Console.WriteLine(noarg.GetFractionString());
        Console.WriteLine(noarg.GetTop());

        Console.WriteLine(onearg.GetFractionString());
        Console.WriteLine(onearg.GetTop());

        Console.WriteLine(twoarg.GetFractionString());
        Console.WriteLine(twoarg.GetTop());

        Console.WriteLine($"Now changing the numerator");
        twoarg.SetTop(3);
        Console.WriteLine(twoarg.GetFractionString());
        Console.WriteLine($"Now changing the denominator");
        twoarg.SetBottom(4);
        Console.WriteLine(twoarg.GetFractionString());
        Console.WriteLine("Now printing the decimal value");
        Console.WriteLine(twoarg.GetDecimalValue());


        
    }
}