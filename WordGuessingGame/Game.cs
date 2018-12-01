using System;

namespace WordGuessingGame
{
    class Game
    {
        int guess = 0;
        int targetNumber = 5;
        string userInput = "";
        string[] wordsArray = { "cat", "rat", "bat"};
        Random RandomNumber = new Random();

        public void Play()
        {
            targetNumber = RandomNumber.Next(wordsArray.Length);

            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText.centerText(" Guess which word I am thinking of is it: cat, rat, or bat ");
           
            //for (int i = 0; i < wordsArray.Length; i++)
            //{
            //    if (i == (wordsArray.Length - 1))
            //        CenterText.centerText("or " + wordsArray[i] + "? ");
            //    else
            //        Console.Write(wordsArray[i] + ", ");
            //}

            userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == wordsArray[targetNumber])
            {
                Correct.CorrectTitle();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                CenterText.centerText("Not a match. Try again! Press enter continue");
                //CenterText.centerText("Press enter to continue...");
                Console.ReadLine();
                Console.Clear();
                Play();
            }

            
            //Console.Read();
        }
    }
}