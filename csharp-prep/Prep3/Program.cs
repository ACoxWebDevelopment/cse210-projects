using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator= new Random() ;
       int secretNumber= randomGenerator.Next (1,100);
       int numGuesses=0;
       int secretGuess=0;
       while (secretNumber!=secretGuess){
       Console.WriteLine("Enter your guess for the secret number 1-100 ");
       string guess=Console.ReadLine();
        secretGuess=int.Parse(guess);
       
        if (secretGuess<secretNumber)
        {
            Console.WriteLine("The secret number is higer");
            ++numGuesses;
        }
        if (secretGuess>secretNumber)
        {
            Console.WriteLine("The scecret number is lower");
            ++numGuesses;
        }
       }
       Console.WriteLine($"{secretNumber} is the correct answer.  It took you {numGuesses} guesses");

    }
}