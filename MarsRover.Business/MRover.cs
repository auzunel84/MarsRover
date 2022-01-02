using MarsRover.Business.Interfaces;
using MarsRover.Business.States;
using System;

namespace MarsRover.Business
{
    public class MRover : IRover
    {
        private State _state;
        
        public MRover(string direction, int plateauTopX, int plateauTopY, int x, int y)
        {
            switch (direction)
            {
                case "N":
                    _state = new NorthState(plateauTopX, plateauTopY, x, y, this);
                    break;
                case "W":
                    _state = new WestState(plateauTopX, plateauTopY, x, y, this);
                    break;
                case "E":
                    _state = new EastState(plateauTopX, plateauTopY, x, y, this);
                    break;
                case "S":
                    _state = new SouthState(plateauTopX, plateauTopY, x, y, this);
                    break;
                default:
                    throw new Exception("You need to specify a proper direction(N, W, E ,S).");
                    break;
            }
        }

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void MoveForward()
        {
            _state.MoveForward();
        }

        public void TurnLeft()
        {
            _state.TurnLeft();
        }

        public void TurnRight()
        {
            _state.TurnRight();
        }

        public string GetPosition()
        {
            return _state.GetPosition();
        }

        public void FollowInstructions(string instructions)
        {
            foreach (var action in instructions)
            {
                switch (action)
                {
                    case 'M':
                        MoveForward();
                        break;
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                }
            }
        }
    }
}
