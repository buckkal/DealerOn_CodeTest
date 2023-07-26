using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.rover.methods
{
    public class MoveRover
    {
        public static bool checkRover(string position) {
            //get the x and y of the position of the rover
            string[] points = position.Split(" ");
            int x = int.Parse(points[0]),
                y = int.Parse(points[1]);

            //get the max length of the grid
            string[] lengths = RoverInterface.gridSize.Split(" ");
            int lenX = int.Parse(lengths[0]),
                lenY = int.Parse(lengths[1]);

            //make sure the position of the rover doesn't go out of the grid
            if ((x <= lenX && x >= 0) && (y <= lenY && y >= 0))
                return true;
            else
                return false;
        }

        public static string moveRoverFromInstructions(string position, string inst) {
            //get the position of the rover
            string[] points = position.Split(" ");
            int x = int.Parse(points[0]),
                y = int.Parse(points[1]);
            string z = points[2];            

            //run through each instruction with a for loop
            char[] instC = inst.ToCharArray();
            for(int i = 0; i < instC.Length; i++) 
            {
                //change the position of the rover based on the instructions
                if (instC[i] == 'L' || instC[i] == 'R')
                    z = changeDirection(instC[i], z);
                else if (instC[i] == 'M' && z == "N")
                    y++; 
                else if (instC[i] == 'M' && z == "S")
                    y--;
                else if (instC[i] == 'M' && z == "E")
                    x++; 
                else if (instC[i] == 'M' && z == "W")
                    x--;
            }

            //return the final position
            return x + " " + y + " " + z;
        }

        private static string changeDirection(char instC, string z) {
            if (instC == 'L') 
            {
                switch(char.Parse(z)) 
                {
                    case 'N':
                        return "W";
                    case 'E':
                        return "N";
                    case 'S':
                        return "E";
                    case 'W':
                        return "S";
                }
            } 
            else if (instC == 'R')
            {
                switch(char.Parse(z)) 
                {
                    case 'N':
                        return "E";
                    case 'E':
                        return "S";
                    case 'S':
                        return "W";
                    case 'W':
                        return "N";
                }
            }

            return "N";
        }
    }
}