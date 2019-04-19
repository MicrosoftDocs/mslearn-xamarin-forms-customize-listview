using System;

namespace SmartHome
{
    public class DoorBell : SmartDevice
    {
        public enum Status
        {
            Normal,
            Ringing
        }

        public Status DoorBellStatus
        {
            get => doorBellStatus;
            set
            {
                ChangePropertyValue(ref doorBellStatus, value);
                TimeStamp = DateTime.Now;
            }
        }
        Status doorBellStatus;

        public DoorBell()
        {
            IconUrl = "door.png";
        }
    }
}