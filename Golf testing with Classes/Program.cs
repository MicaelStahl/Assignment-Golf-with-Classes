using System;
using System.Collections.Generic;

namespace Golf_Assignment_with_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            TheGame.GolfFun();
        }

        public static void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
