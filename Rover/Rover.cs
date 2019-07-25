using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class Rover
    {
        public Map RoverMap;
        public Processor RoverProcessor=new Processor();
        public Rover(Map roverMap)
        {
            RoverMap = roverMap;
        }
        public void ReadSignals(String signals)
        {
            foreach (char signal in signals)
                Move(RoverProcessor.Process(signal));
        }
        public void Move(IMovement movement)
        {
            movement.Update(RoverMap);
        }
        public string SendLocationDetails()
        {
            return RoverMap.GetStatus();
        }
    }
}
