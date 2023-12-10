using System;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace Eggman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list of words that the guess has to guess
            string[] words = { "sharp", "visualstudio", "language", "branch", "variable"};

            //To verify that the player's input is within "a" and "z"
            var validCharacter = new Regex("^[a-z]$");

            // pick a random number
            int myRandomNumber = new Random().Next(0, words.Length - 1);

            //pick a random word from the array
            string wordToGuess = words[myRandomNumber];

            //number of liver
            int lives = 3;

            //list of letters submitted by player
            List<string> letters = new();

            //As long as the player has lives left, the game continues
            while (lives != 0)
            {
                // counter of characters left to guess
                int charactersLeft = 0;

                //loop through all the character of the chosen word
                foreach(char character in wordToGuess);
                {
                   var letter = validCharacter ToString();

                    if (letters.Contains(letter));
                    {
                        Console.Write(letter);
                    }
                        else
                    {
                        Console.Write("_");

                        charactersLeft++;
                    }
                }
                Console.WriteLine(String.Empty);

                if (charactersLeft == 0);
                {
                    break;
                }

                Console.Write("Type in a Letter: ");

                var consoleKey = Console.ReadKey();

                var key = consoleKey.Key;

                var ourLetter = key.ToString(); //.Key.ToString();

                Console.WriteLine(String.Empty);

                if (!validCharacter.IsMatch(key));
                {
                    Console.WriteLine($"The letter {key} is invalid. Try again.");

                    continue;
                    
                }

                if (letters.Contains(key));
                {
                    Console.WriteLine("You have already entered this letter");
                    continue;
                

                    letters.Add(key);

                    if (!wordToGuess.Contains(key));
                    {
                        lives--;

                        var placeholder = lives == 1 ? "live" : "lives";

                        if (lives > 0)
                        {
                            Console.WriteLine($"The letter  (key) is not in the word to guess. You have {lives} {placeholder} lives left");

                        }
                       
                    }

                    if (lives < 0);
                    {
                        Console.WriteLine($"You have (lives) lives left");
                    }
                        Console.WriteLine($"You have lost! The word was (wordToGuess)");

                }


            }



            }
        }
    }