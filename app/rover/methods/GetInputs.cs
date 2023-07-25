using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.properties;

namespace app.rover.methods
{
    internal static class GetInputs
    {
        public static void getGridSize()
        {
            //get the size of the grid (X and Y)
            Console.WriteLine("\nWhat is the X length? ");
            string? x = Console.ReadLine();

            Console.WriteLine("\nWhat is the Y length? ");
            string? y = Console.ReadLine();

            RoverInterface.gridSize = x + " " + y;
        }

        public static string getGridSizeFromFile()
        {
            Console.WriteLine("\ngetGridSizeFromFile\n");
            return "";
        }

        public static void getRoverData() 
        {
            //use the gridSize to give the user information on what they can pick
            string[] size = RoverInterface.gridSize.Split(' ');

            //get the necessary inputs for the position and the instructions
            Console.WriteLine("\nWhat is the X position of the rover?");
            Console.WriteLine("Max Length: " + size[0]);
            string? pointX = Console.ReadLine();

            Console.WriteLine("\nWhat is the Y position of the rover? ");
            Console.WriteLine("Max Length: " + size[1]);
            string? pointY = Console.ReadLine();

            Console.WriteLine("\nWhich way is the rover facing? (N, E, S, W)");
            string? direction = Console.ReadLine();

            Console.WriteLine("\nWhat are the instructions? (Ex: MLMRMML)");
            string? instructions = Console.ReadLine();

            RoverData roverData = new RoverData() 
            {
                Location = pointX + " " + pointY + " " + direction,
                Instructions = instructions,
            };

            RoverInterface.roverData.Add(roverData);
        }

        public static List<RoverData> getRoverDataFromFile() 
        {
            Console.WriteLine("\ngetRoverDataFromFile\n");
            return new List<RoverData>();
        }
    }
}