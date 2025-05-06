using System;
using System.Reflection;

class Program
{
    static void Welcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string GetName()
    {
        Console.Write("Please enter your name: ");
        string name=Console.ReadLine();
        return name;
    }
    static int GetNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favnum= Convert.ToInt32(Console.ReadLine());
        return favnum;
    }

    static int SqrNumber(int p1)
    {
        int numsqrd=p1*p1;
        return numsqrd;
    }

    static void DisplayMessage(string username, int squared)
    {
        Console.WriteLine($"{username}, the square of your number is {squared}");
    }

    static void Main(string[] args)
    {
        Welcome();
        string username=GetName();
        int usernumber=GetNumber();
        int squared=SqrNumber(usernumber);
        DisplayMessage(username, squared);

    }
    
    
}