using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_Assignment_with_Classes
{
    class VictoryScreen
    {
        public static void Victory(List<double> DistancePerSwing, List<double> RemainingAfterSwing, List<int> Swings, double distanceToHole)
        {
            int swings = 0;
            foreach (int points in Swings)
            {
                swings = swings + points;
            }
            for (int i = 0; i < DistancePerSwing.Count; i++)
            {
                Program.DisplayMessage($"Swing {i + 1} = {Math.Round(DistancePerSwing[i], 1)} meter swing.\t {Math.Round(RemainingAfterSwing[i], 1)} meters remains", ConsoleColor.Yellow);
            }
            if (swings == 1)
            {
                Program.DisplayMessage("\nYou hit a hole-in-one with your magnificent " + distanceToHole + " meters shot you lucky bastard! Well done!", ConsoleColor.Green);
            }
            Program.DisplayMessage("\nCongratulations, you won the game!", ConsoleColor.Green);
            Console.ReadKey();
        }
    }
}
