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
                                
                                   
                          
                                       
                                                                                              $$\     
                                                                                              $$ |    
                                 $$$$$$$\  $$$$$$\   $$$$$$\   $$$$$$\   $$$$$$\   $$$$$$$\ $$$$$$\   
                                $$  _____|$$  __$$\ $$  __$$\ $$  __$$\ $$  __$$\ $$  _____|\_$$  _|  
                                $$ /      $$ /  $$ |$$ |  \__|$$ |  \__|$$$$$$$$ |$$ /        $$ |    
                                $$ |      $$ |  $$ |$$ |      $$ |      $$   ____|$$ |        $$ |$$\ 
                                \$$$$$$$\ \$$$$$$  |$$ |      $$ |      \$$$$$$$\ \$$$$$$$\   \$$$$  |
                                 \_______| \______/ \__|      \__|       \_______| \_______|   \____/ 
                                                                      
                                                                      
                                                                      

                                                          


                                                                 

                ";

            Console.WriteLine(title);
            Console.WriteLine(); // breakline
            CenterText.centerText("Press enter");
            Console.ReadKey();
            Console.Clear();


        }
    }
}