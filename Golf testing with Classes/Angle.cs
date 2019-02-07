using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_Assignment_with_Classes
{
    class Angle
    {

        public static double AskUserForAngle()
        {
            int uselessNumber = 0;
            bool stayAlive = true;

            do
            {
                try
                {

                    Program.DisplayMessage("\nPlease write your wanted angle that's higher than 0 but lower than 90");
                    double angle = double.Parse(Console.ReadLine() ?? "");

                    if (angle > 0 && angle < 90)
                    {
                        return angle;
                    }
                    else if (angle <= 0)
                    {
                        Program.DisplayMessage("Please try again with a bigger value this time", ConsoleColor.Red);
                    }
                    else if (angle >= 90)
                    {
                        Program.DisplayMessage("Please try again with a smaller value this time", ConsoleColor.Red);
                    }
                    else
                    {
                        return uselessNumber;
                    }
                }
                catch (FormatException)
                {
                    Program.DisplayMessage("Please write a number.\nPress any key to continue...", ConsoleColor.Red);
                }
                catch (Exception)
                {
                    Program.DisplayMessage("Something went wrong, please try again", ConsoleColor.Red);
                }
                Console.ReadKey();
                Console.Clear();

            } while (stayAlive);
            return uselessNumber;
        }
    }
}

