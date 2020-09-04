using MarsRoverApp.Entities;
using MarsRoverApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverApp
{
    public class RoverSquad : List<IRover>
    {
        public ILandingSurface LandingSurface { get; private set; }
        public RoverSquad(ILandingSurface landingSurface) 
        {
           LandingSurface = landingSurface;
        }


        public void DeployNewRover(string roverPosition, string roverCommands)
        {
            Add(new Rover(LandingSurface, roverPosition, roverCommands));
        }
    }
}
