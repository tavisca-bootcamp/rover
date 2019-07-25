using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class MarsRover
    {
        public string MarsRoverSentToMars(string input1,string input2,string instructions)
        {
            string[] locationData = input2.Split(' ');
            string[] surfaceAreaData= input1.Split(' ');
            Location roverLocation = new Location(Int32.Parse(locationData[0]),Int32.Parse(locationData[1]));
            SurfaceArea marsSurface = new SurfaceArea(new Location(Int32.Parse(surfaceAreaData[0]), Int32.Parse(surfaceAreaData[1])));
            Compass roverCompass = new Compass(locationData[2]);
            Map marsMap = new Map(roverLocation,marsSurface,roverCompass);
            Rover marsRover = new Rover(marsMap);
            marsRover.ReadSignals(instructions);
            return marsRover.SendLocationDetails();
        }
    }
}
