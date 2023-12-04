using System;
using System.Text.RegularExpressions;

namespace Eggman
{
    internal class Program
    {
        private static void Main(string[] args)
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
             
            }



            }
        }
    }