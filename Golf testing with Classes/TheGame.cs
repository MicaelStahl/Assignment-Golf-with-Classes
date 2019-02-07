using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_Assignment_with_Classes
{
    class TheGame
    {
        public static int GolfFun()
        {
            Program.DisplayMessage(
                "\t\t\nHello and welcome to Assignment 2 - GolfCourse V2!\n" +
                "In this version I'll be trying to do the golf-assignment again, but with Classes.\n\n" +
                "Press any key to continue to the golf-course!\n"
                );

            Console.ReadKey();


            int usefulNumber = 0;
            int swings = 0;
            bool stayAlive = true;

            List<double> DistancePerSwing = new List<double>();
            List<double> RemainingAfterSwing = new List<double>();
            List<int> Swings = new List<int>();

            double distanceToHole = DistanceToHole.UserInputXNumber();
            double distanceRemaining = distanceToHole;

            do
            {

                double angle = Angle.AskUserForAngle();
                double velocity = Velocity.AskUserForVelocity();
                double distance = Calculations.CalculateDistance(angle, velocity);

                double distanceRemainingNegative = 0;


                DistancePerSwing.Add(distance);

                distanceRemaining -= distance;

                distanceRemainingNegative = distanceRemaining;

                distanceRemaining = Math.Abs(distanceRemaining);
                RemainingAfterSwing.Add(distanceRemaining);


                if (Math.Abs(distanceRemaining) < 0.1)
                {
                    ++swings;
                    Swings.Add(swings);

                    stayAlive = false;

                    VictoryScreen.Victory(DistancePerSwing, RemainingAfterSwing, Swings, distanceToHole);
                }
                else if (distanceRemainingNegative < -1 && distanceRemainingNegative > -200)
                {
                    ++swings;
                    Swings.Add(swings);
                    Console.Clear();
                    Program.DisplayMessage("\nYou shot " + Math.Round(distanceRemaining, 1) + " meters too far with your " + swings + " swing!", ConsoleColor.Yellow);
                }
                else if (distanceRemaining > distanceToHole)
                {
                    ++swings;
                    Swings.Add(swings);
                    Console.Clear();
                    Program.DisplayMessage("\nYou shot too far with your " + swings + " swing. You lost!", ConsoleColor.Red);
                }
                else
                {
                    ++swings;
                    Swings.Add(swings);

                    if(swings >= 10)
                    {
                        Program.DisplayMessage("\nYou should get a different profession. You've shot too many times.", ConsoleColor.Red);
                        stayAlive = false;
                    }
                    Console.Clear();
                    Program.DisplayMessage("\nYou have " + Math.Round(distanceRemaining, 1) + " meters remaining to the hole and you are on " + swings + " swings!");

                }
                //Console.ReadKey();

            } while (stayAlive);
            return usefulNumber;
        }
    }
}
