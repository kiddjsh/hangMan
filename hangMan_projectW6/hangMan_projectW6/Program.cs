using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangMan_projectW6
{
    class Program
    {
        static void Main(string[] args)
        {
            char guess;
            char letter0 = 'k', letter1 = 'i', letter2 = 'd';
            char letter3 = 'd', letter4 = 'e', letter5 = 'r';
            char[] guessed = new char[26];
            char[] word = new char[] { letter0, letter1, letter2, letter3, letter4, letter5 };
            int score = 0;
            int noGuess = 0;
            int noCorrectGuess = 0;
            int wLength = word.Length;
            bool found;
            string user = "";

            //output greeting
            Console.ForegroundColor = ConsoleColor.Green;
            user = Console.ReadLine();
            Console.WriteLine("Hi! Welcome to Hangman.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter a letter when prompted.");
            Console.WriteLine("Press 'Enter' to begin...");
            Console.Write("_________________________________________________________________");
            user = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            //mysteryWord
            for (int i = 0; i < wLength; i++)
                guessed[i] = '*';

            //input
            while (noGuess <= 9)
            {
                found = false;
                Console.WriteLine();
                Console.WriteLine("Please enter a letter: ");
                guess = Convert.ToChar(Console.ReadLine());
                noGuess++;

                //loop
                for (int i = 0; i < wLength; i++)
                    if (word[i] == guess)
                    {
                        found = true;
                        guessed[i] = guess;
                        noCorrectGuess++;
                    }

                if (found)
                {
                    Console.WriteLine();
                    Console.WriteLine("You guessed correctly!");
                    found = true;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Incorrect. Try Again.");
                    score++;
                }    

                Console.WriteLine();
                Console.WriteLine(guessed);
                if (noCorrectGuess == wLength)
                    break;
            }

            if (noCorrectGuess == wLength)
            {
                Console.WriteLine();
                Console.WriteLine("You guessed the word: kidder!");
            }

            else
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("You guessed " + score + " letters incorrectly.");

        Console.ReadLine();

        }
    }
}

    


 





