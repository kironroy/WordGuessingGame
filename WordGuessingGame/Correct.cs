using System;
using System.Globalization;
using System.Collections.Generic;

namespace WordGuessingGame
{
    public class Correct
    {
        public static void CorrectTitle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            string title =
                @"
                                
                                   
                          
                                         ██████╗ ██████╗ ██████╗ ██████╗ ███████╗ ██████╗████████╗
                                        ██╔════╝██╔═══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝╚══██╔══╝
                                        ██║     ██║   ██║██████╔╝██████╔╝█████╗  ██║        ██║   
                                        ██║     ██║   ██║██╔══██╗██╔══██╗██╔══╝  ██║        ██║   
                                        ╚██████╗╚██████╔╝██║  ██║██║  ██║███████╗╚██████╗   ██║   
                                         ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝ ╚═════╝   ╚═╝   
                                                          


                                                                 

                ";

            Console.WriteLine(title);
            Console.WriteLine(); // breakline
            CenterText.centerText("Press enter");
            Console.ReadKey();
            Console.Clear();


        }
    }
}