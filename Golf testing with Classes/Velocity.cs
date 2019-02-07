using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_Assignment_with_Classes
{
    class Velocity
    {
        public static double AskUserForVelocity()
        {
            int uselessNumber = 0;

            bool stayAlive = true;

            do
            {
                try
                {
                    Program.DisplayMessage("\nPlease write your wanted velocity that's higher than 0 but lower than 102");
                    double velocity = double.Parse(Console.ReadLine() ?? "");

                    if (velocity > 0 && velocity < 102)
                    {
                        return velocity;
                    }
                    else if (velocity <= 0)
                    {
                        Program.DisplayMessage("Please try again with a bigger value this time", ConsoleColor.Red);
                    }
                    else if (velocity >= 102)
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
                    Program.DisplayMessage("Please write a number. \nPress any key to continue...", ConsoleColor.Red);
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
