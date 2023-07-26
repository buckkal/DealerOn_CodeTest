using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.rover.properties;
using app.rover.methods;

namespace app.rover
{
    public class RunRover
    {
        public static void runRover()
        {
            //first perform the program with the terminal
            runTerminal();

            //TO-DO: second perform the program with GUI
        }

        private static void runTerminal()
        {
            while (RoverInterface.loop == 0)
            {
                int decision = GetDecisionTerminal();

                //get the inputs from the chosen way
                if (decision == 0)
                {
                    GetInputs.getGridSize();
                    GetInputs.getRoverData();
                }
                else if (decision == 1)
                    ReadFile.getFileContents();

                if (RoverInterface.loop != 1)
                {
                    //call method to get the correct output
                    PerformMoveRover();
                    //give user opportunity to exit program
                    Console.WriteLine("If you want to exit, type 'exit', otherwise, hit enter");
                    string? ans = Console.ReadLine();

                    if (ans == "exit")
                        RoverInterface.loop = 1;
                }

                RoverInterface.gridSize = "";
                RoverInterface.roverData = new List<RoverData>();
            }
        }

        private static int GetDecisionTerminal()
        {
            //Ask whether or not there is a file to upload, allow user to exit program
            Console.WriteLine("Do you have a file to upload? yes or no");
            string? ans = Console.ReadLine();

            if (ans == "no")
                return 0;
            else if (ans == "yes")
                return 1;
            else if (ans == "exit")
            {
                RoverInterface.loop = 1;
                return -1;
            }
            else
            {
                Console.WriteLine("\nPlease input either 'yes' or 'no'.\n");
                return -1;
            }
        }

        private static void PerformMoveRover()
        {
            Console.WriteLine("\nResults:");

            //loop through inputs
            for (int i = 0; i < RoverInterface.roverData.Count; i++)
            {
                string? position = RoverInterface.roverData[i].Location,
                inst = RoverInterface.roverData[i].Instructions;

                if (position != null)
                {
                    //call method to check where the rover is
                    bool isInGrid = MoveRover.checkRover(position);

                    //call method to turn left, turn right, and move forward
                    int skip = 1;
                    if (isInGrid && inst != null)
                    {
                        position = MoveRover.moveRoverFromInstructions(position, inst);
                        skip = 0;
                    }

                    //call method to check, skip this if it was not in the grid
                    if (skip == 1)
                        isInGrid = MoveRover.checkRover(position);

                    //print out answer
                    if (isInGrid)
                        Console.WriteLine(position);
                    else
                        Console.WriteLine("position is out of grid: " + position);
                }
                else
                    Console.WriteLine("position was shown as empty");
            }
            Console.WriteLine("\n");
        }
    }
}