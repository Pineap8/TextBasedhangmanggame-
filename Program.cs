using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hanghangmanman
{

class Hangman

        
    {
        static void Main(string[] args)
          
        {
            Console.WriteLine("Enter a Letter to start hangman");
            Console.ReadLine();

            string[] wordList = { "programming", "computer", "hangman",
        "challenge", "console", "session","abruptly"
 };         Console.WriteLine("Enter a Letter to start hangman");
            Random rand = new Random(); string wordToGuess = wordList[rand.Next(wordList.Length)];
            char[] guessedLetters = new char[wordToGuess.Length]; for
                (int i = 0; i < guessedLetters.Length; i++) guessedLetters[i] = '_';

            int maxAttempts = 6;
            int wrongGuesses = 0;
            bool wordGuessed = false;

            while (wrongGuesses < maxAttempts && wordGuessed)
                Console.Write("Guess a letter");
                string input = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(input) || (input.Length != 1) || !char.IsLetter(input[0]))
            { Console.WriteLine("Please enter one letter only");}

            char guess = input [0];
            bool correctGuess = false;


            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == guess && guessedLetters[i] == '_')
                { guessedLetters[i] = guess; correctGuess = true; }
            }
                if (!correctGuess)
                { wrongGuesses++; Console.WriteLine($"Wrong Guess. Attempts Left:{maxAttempts - wrongGuesses}"); }
                else { Console.WriteLine("Good Guess"); }
                if (new string(guessedLetters)== wordToGuess)
                { wordGuessed = true; }

                if (wordGuessed)
                { Console.WriteLine($"\nCongrats! You guessed the word{wordToGuess}"); }
                else { Console.WriteLine($"\n Game Over, you failed. The word was: {wordToGuess}"); }






        }
    }
}
