using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int entry;
        do
        {
            Console.WriteLine("Enter a number or 0 to quit");
            entry=(Convert.ToInt32(Console.ReadLine()));
            if (entry!=0)
            {
            numbers.Add(entry);
            }

        }
        while (entry!=0);      
        Console.WriteLine($"The Sum is: {numbers.Sum()}");
        Console.WriteLine($"The Average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}