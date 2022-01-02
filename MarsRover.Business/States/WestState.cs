using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Business.States
{
    public class WestState : State
    {
        public WestState(State state)
            : this(state.PlateauTopX, state.PlateauTopY, state.X, state.Y, state.Rover)
        { }

        public WestState(int plateauTopX, int plateauTopY, int x, int y, MRover rover)
        {
            this.PlateauTopX = plateauTopX;
            this.PlateauTopY = plateauTopY;
            this.X = x;
            this.Y = y;
            this.Rover = rover;
        }

        public override void MoveForward()
        {
            X--;
            if (X < 0)
                X = PlateauTopX;
        }

        public override void TurnLeft()
        {
            this.Rover.State = new SouthState(this);
        }

        public override void TurnRight()
        {
            this.Rover.State = new NorthState(this);
        }

        public override string GetPosition()
        {
            return string.Format("{0} {1} W", X, Y);
        }
    }
}
