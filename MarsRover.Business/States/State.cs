namespace MarsRover.Business.States
{
    public abstract class State
    {
        protected MRover rover;
        protected int x;
        protected int y;
        protected int plateauTopX;
        protected int plateauTopY;

        // Properties
        public MRover Rover
        {
            get { return rover; }
            set { rover = value; }
        }

        public int PlateauTopX
        {
            get { return plateauTopX; }
            set { plateauTopX = value; } 
        }

        public int PlateauTopY
        {
            get { return plateauTopY; }
            set { plateauTopY = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public abstract void MoveForward();
        public abstract void TurnLeft();
        public abstract void TurnRight();
        public abstract string GetPosition();
    }
}
