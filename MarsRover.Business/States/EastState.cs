using System;

namespace MarsRover.Business.States
{
    public class EastState : State
    {
        public EastState(State state) 
            : this(state.PlateauTopX, state.PlateauTopY, state.X, state.Y, state.Rover)
        { }

        public EastState(int plateauTopX, int plateauTopY, int x, int y, MRover rover)
        {
            this.PlateauTopX = plateauTopX;
            this.PlateauTopY = plateauTopY;
            this.X = x;
            this.Y = y;
            this.Rover = rover;
        }

        public override void MoveForward()
        {
            X++;
            if (X > PlateauTopX)
                X = 0;
        }

        public override void TurnLeft()
        {
            this.Rover.State = new NorthState(this);
        }

        public override void TurnRight()
        {
            this.Rover.State = new SouthState(this);
        }
        public override string GetPosition()
        {
            return string.Format("{0} {1} E", X, Y);
        }
    }
}
