using System;

class Program
{
    static void Main(string[] args)
    {
        Random random=new Random();
        int magNumber= random.Next(1,100);
        int guess;
        int numGuesses=0;
        do
        {
            Console.WriteLine("Try to guess my number between 1 and 100");
            guess=Convert.ToInt32(Console.ReadLine());
            numGuesses ++;
            if (guess<magNumber)
            {
                Console.WriteLine("higher");
            }
            if (guess>magNumber)
            {
                Console.WriteLine("lower");
            }
        }
        while (guess!=magNumber);
        Console.WriteLine($"{guess} is the correct number! It took you {numGuesses} guesses.");
        
    }
}