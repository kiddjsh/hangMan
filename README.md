# hangMan
An application, using a solution algorithm that employs loops, simple data structures, and arrays. The gaming  application displays the input and output for a Hangman program, using my last name as the word to guess. The  application prompts for a letter to be entered, when the letter is entered, it is checked against a list of  valid character data types; if not correct, an error with a letter encryption is displayed; if correct, a message with the letter displays within the letter encryption.

# IPO Model
![IPO Model_hangMan](https://raw.githubusercontent.com/kiddjsh/hangMan/main/images/IPO%20Model_hangMan.PNG)

# Pseudocode
![Pseudocode_hangMan_1](https://raw.githubusercontent.com/kiddjsh/hangMan/main/images/pseudocode_handMan_1.PNG)
![Pseudocode_hangMan_2](https://raw.githubusercontent.com/kiddjsh/hangMan/main/images/pseudocode_hangMan_2.PNG)


# My C# Solution
```C#
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

            //letterDisplay
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

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

```

# Complete Working Program
![CWP_hangMan_1](https://raw.githubusercontent.com/kiddjsh/hangMan/main/images/CWP_hangMan_1.PNG)
![CWP_hangMan_2](https://raw.githubusercontent.com/kiddjsh/hangMan/main/images/CWP_hangMan_2.PNG)
![CWP_hangMan_3](https://raw.githubusercontent.com/kiddjsh/hangMan/main/images/CWP_hangMan_3.PNG)
![CWP_hangMan_4](https://raw.githubusercontent.com/kiddjsh/hangMan/main/images/CWP_hangMan_4.PNG)
![CWP_hangMan_5](https://raw.githubusercontent.com/kiddjsh/hangMan/main/images/CWP_hangMan_5.PNG)
