using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers= new List<int>();
        int numInput=999;
        string entry;
        do 
        {
        Console.Write("Enter a number to add to the list or 0 to end ");
        entry=Console.ReadLine();
        numInput=int.Parse(entry);
        userNumbers.Add(numInput);
        }
         while (numInput!=0);
         userNumbers.Remove(0);
         Console.WriteLine($"The Sum of these numbers is {userNumbers.Sum()}");
         float average = userNumbers.Sum()/(float) userNumbers.Count;
         Console.WriteLine($"The Average of these numbers is {average}");
         Console.WriteLine($"The largest number is {userNumbers.Max()}");
    }
}