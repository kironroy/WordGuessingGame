using System;


namespace WordGuessingGame

{
    class CenterText
    {
        public static void centerText(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2 );

            //Console.WriteLine("Centering text:");
            //Console.WriteLine("Console window width is " + screenWidth + " and the text length is " + stringWidth + ".");
            //Console.WriteLine("Divide the screen width by 2 (" + screenWidth / 2 + ").");
            //Console.WriteLine("Divide string length by 2 (" + stringWidth / 2 + ") and add those together.");
            //Console.WriteLine("The result is the number of spaces needed (" + spaces + ").");

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine(message.PadLeft(spaces));
        }

    }
}