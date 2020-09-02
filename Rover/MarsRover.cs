using MarsRover.Factories;
using MarsRover.Interfaces;
using MarsRover.Models;
using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class MarsRover
    {
        #region properties
        string[] Setup;
        public ISurface Plateau { get; set; }
        public List<IRover> Rovers;
        private List<string> roverCommands;

        #endregion
        public MarsRover(string[] setup)
        {
            if (setup.Length == 0)
                throw new ArgumentException("Input is Empty");

            Setup = setup;
            Rovers = new List<IRover>();
            roverCommands = new List<string>();

            SetupSurface();
            SetupRovers();
        }

        #region Private methods
        /// <summary>
        /// Setup surface for rovers to navigate upon
        /// </summary>
        private void SetupSurface()
        {
            SurfaceFactory surfaceFactory = new SurfaceFactory();
            Plateau = surfaceFactory.GetSurface(Setup[0]);
        }

        /// <summary>
        /// Setup Rovers using user input
        /// </summary>
        private void SetupRovers()
        {
            RoverFactory roverFactory = new RoverFactory();
            DirectionFactory directionFactory = new DirectionFactory();
            try
            {
                for (int i = 1; i < Setup.Length; i = i + 2)
                {
                    string[] location = Setup[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    Location coOrdinates = new Location(Convert.ToInt32(location[0]), Convert.ToInt32(location[1]));
                    IDirection direction = directionFactory.GetDirection(location[2][0]);

                    IRover rover = roverFactory.GetRover(coOrdinates, direction);
                    rover.Commands = Setup[i + 1];
                    Rovers.Add(rover);
                    //roverCommands.Add(Setup[i + 1]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Send commands to configured Rovers
        /// </summary>
        public void RunRovers()
        {
            int counter = 0;
            try
            {
                foreach (IRover rover in Rovers)
                {
                    rover.SendCommandSequence();
                    if (!rover.IsWithinBoundaries(Plateau))
                        throw new ArgumentException("Invalid Command Sequence. Rover crossed the surface boundaries.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get positions of rovers after sending the commands
        /// </summary>
        /// <returns>New positions of all configured Rovers</returns>
        public string[] GetRoverPositions()
        {
            string[] roverPositions = new string[Rovers.Count];
            int counter = 0;

            foreach (IRover rover in Rovers)
            {
                roverPositions[counter++] = String.Format("{0} {1} {2}",
                     rover.CurrentLocation.X.ToString(),
                     rover.CurrentLocation.Y.ToString(),
                     rover.Direction.GetDirectionString());
            }
            return roverPositions;
        } 
        #endregion
    }
}
