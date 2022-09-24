namespace Exercises.Classes
{
    public class Elevator
    {

        public int CurrentLevel { get; private set; } = 1;

        public int NumberOfLevels { get; private set; }

        public bool DoorIsOpen { get; private set; }

        public Elevator (int numberOfLevels)
        {
            this.NumberOfLevels = numberOfLevels;
        }

        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
        public void CloseDoor()
        {
            DoorIsOpen = false;
        }
        public void GoUp(int desiredFloor)
        {
            if (DoorIsOpen == false && CurrentLevel != NumberOfLevels && CurrentLevel < desiredFloor)
            {
                CurrentLevel = desiredFloor;
            }
        }
        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen == false && CurrentLevel != 1 && CurrentLevel > desiredFloor)
            {
                CurrentLevel = desiredFloor;
            }
        }



    }
}
