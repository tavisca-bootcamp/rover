using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    public class Processor
    {
        public IMovement Process(char input)
        {
            return ExecuteSignal(ReadSignal(input));
        }
        public IMovement ExecuteSignal(Signal signal)
        {
            if (signal.Equals(Signal.L))
                return new RotateLeftMovement();
            if(signal.Equals(Signal.R))
                return new RotateRightMovement();
            return new ForwardMovement();
        }
        public Signal ReadSignal(char signal)
        {
            if (signal == 'L')
                return Signal.L;
            if (signal == 'R')
                return Signal.R;
            return Signal.M;
        }
    }
}
