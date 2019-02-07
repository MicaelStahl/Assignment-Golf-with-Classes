using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_Assignment_with_Classes
{
    class DistanceToHole
    {

        public DistanceToHole() { }

        public static double UserInputXNumber()
        {
            int uselessNumber = 0;
            bool stayAlive = true;

            Console.Clear();

            do
            {
                try
                {

                    Program.DisplayMessage(
                        "\nWould you like to declare your own distance to the hole?\n" +
                        "Y - Yes, you will settle the distance yourself!\n" +
                        "N - No, the computer will get you a distance between 100-3000 meters!\n"
                        );

                    char choice = char.ToUpper(Console.ReadKey(true).KeyChar);
                    Console.Clear();

                    if (choice == 'Y')
                    {
                        Program.DisplayMessage("Please pick your distance to the hole (1-3000 meters): ");
                        double distance = double.Parse(Console.ReadLine());

                        if (distance > 3000)
                        {
                            Program.DisplayMessage("It's over 3000!!", ConsoleColor.Red);
                            Console.ReadKey();

                        }
                        else if (distance < 0)
                        {
                            Program.DisplayMessage("I specifically told you to pick a value between 100-3000. Please try again", ConsoleColor.Red);
                            Console.ReadKey();
                        }
                        else
                        {
                            return distance;
                        }
                    }
                    else if (choice == 'N')
                    {
                        Random random = new Random();
                        int randomNumber = random.Next(100, 3000);

                        Program.DisplayMessage("\nThe distance became: " + randomNumber + " meters, good luck!\n", ConsoleColor.Yellow);
                        Console.ReadKey();

                        double distance = Convert.ToDouble(randomNumber);

                        return distance;
                    }
                    else
                    {
                        Program.DisplayMessage("Please try again!", ConsoleColor.Red);
                    }

                }
                catch (FormatException)
                {
                    Program.DisplayMessage("Please write a number.", ConsoleColor.Red);
                }
                catch (Exception)
                {
                    Program.DisplayMessage("Something went wrong, please try again", ConsoleColor.Red);
                }
            } while (stayAlive);
            return uselessNumber;
        }
    }
}
