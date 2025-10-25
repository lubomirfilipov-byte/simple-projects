using System;

namespace MyProgram
{
    class Zadacha1
    {
        static void Main(string[] args)
        {
            int guessedNumber = 0;
            Random number = new Random();
            int randomNumber = number.Next(1, 10);
                while (guessedNumber >= 1 || guessedNumber <= 10)
            {
                System.Console.WriteLine("Please enter a number between 1 and 10:");
                guessedNumber = Convert.ToInt32(Console.ReadLine());

                if (guessedNumber > randomNumber)
                {
                    System.Console.WriteLine("Too high!");
                }
                else if (guessedNumber < randomNumber)
                {
                    System.Console.WriteLine("Too low!");
                }
                else
                {
                    System.Console.WriteLine("Congratulations! You guessed the number!");
                    break;
                }
            }
               
            
        }
    }
}