using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.rover.properties;

namespace app.rover.methods
{
    public class ReadFile
    {
        public static void getFileContents()
        {
            //get file location and name from user
            Console.WriteLine("\nPlease input the file location (Ex: /home/buck/Projects/DealerOn_CodeTest/app2/files/Input1.txt)");
            string? file = Console.ReadLine();

            if (file != null)
            {
                //split file into lines
                string[] lines = File.ReadAllLines(file);

                //the first line is always the size of the grid
                RoverInterface.gridSize = lines[0];

                //each line after the first will go in this order Location, then, Instructions
                RoverData rData = new RoverData();
                for (int i = 1; i < lines.Length; i++)
                {
                    if (i % 2 == 1) {
                        rData = new RoverData();
                        rData.Location = lines[i];
                    }
                    else {
                        rData.Instructions = lines[i];
                        RoverInterface.roverData.Add(rData);
                    }
                }
            }
        }
    }
}