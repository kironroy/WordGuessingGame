using System;

namespace WordGuessingGame
{
    public class Game
    {
        
        int targetNumber = 5;
        string userInput = "";
        string[] wordsArray = { "cat", "rat", "bat"};
        Random RandomNumber = new Random();

        public void Play()
        {
            targetNumber = RandomNumber.Next(wordsArray.Length);

            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText.centerText("Guess which word I am thinking:");


            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (i == (wordsArray.Length - 1))
                    CenterText.centerText("or " + wordsArray[i] + "? ");
                else
                    CenterText.centerText(wordsArray[i] + ", ");
            }

            userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == wordsArray[targetNumber])
            {
                Correct.CorrectTitle();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText.centerText("Not a match. Try again!");
                CenterText.centerText("Please press enter . . .");
                Console.ReadLine();
                Console.Clear();
                Play();
            }

            
            
        }
    }
}