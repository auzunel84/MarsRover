using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Business.States
{
    public class SouthState : State
    {
        public SouthState(State state)
            : this(state.PlateauTopX, state.PlateauTopY, state.X, state.Y, state.Rover)
        { }

        public SouthState(int plateauTopX, int plateauTopY, int x, int y, MRover rover)
        {
            this.PlateauTopX = plateauTopX;
            this.PlateauTopY = plateauTopY;
            this.X = x;
            this.Y = y;
            this.Rover = rover;
        }

        public override void MoveForward()
        {
            Y--;
            if (Y < 0)
                Y = PlateauTopY;
        }

        public override void TurnLeft()
        {
            this.Rover.State = new EastState(this);
        }

        public override void TurnRight()
        {
            this.Rover.State = new WestState(this);
        }

        public override string GetPosition()
        {
            return string.Format("{0} {1} S", X, Y);
        }
    }
}
