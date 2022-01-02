namespace MarsRover.Business.Interfaces
{
    public interface IRover
    {
        void TurnLeft();
        void TurnRight();
        void MoveForward();
        void FollowInstructions(string instructions);
        string GetPosition();
    }
}
