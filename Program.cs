// Geovanni Medina Herrera, NET25

using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 20);
            int rounds = 0;

            Console.WriteLine("Välkommen! \nJag tänker på ett ett nummer. Kan du gissa vilket? Du får fem försök.");

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Vänligen gissa på ett tal: ");
                int userGuess = int.Parse(Console.ReadLine());
                if (CheckGuess(userGuess, randomNumber) == "Wohoo! Du klarade det!")
                {
                    Console.WriteLine((CheckGuess(userGuess, randomNumber)));
                    break;
                }

                else
                {
                    Console.WriteLine((CheckGuess(userGuess, randomNumber)));
                }

                rounds++;

                if (rounds == 5)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }

            }
        }
        public static string CheckGuess(int guess, int correctNumber)
        {
            if (guess < correctNumber)
            {
                return "Tyvärr, du gissade för lågt!";
            }

            else if (guess > correctNumber)
            {
                return "Tyvärr, du gissade för högt!";
            }

            else
            {
                return "Wohoo! Du klarade det!";
            }
        }


    }


}
