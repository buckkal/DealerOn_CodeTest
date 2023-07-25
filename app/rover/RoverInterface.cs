using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.properties;

namespace app.rover
{
    public interface RoverInterface
    {
        public static int loop = 0;
        public static string gridSize = "";
        public static List<RoverData> roverData = new List<RoverData>();
    }
}