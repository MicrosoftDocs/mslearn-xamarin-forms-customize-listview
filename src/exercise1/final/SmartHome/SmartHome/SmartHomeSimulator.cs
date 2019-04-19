using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SmartHome
{
    public class SmartHomeSimulator
    {
        IList<SmartDevice> devices;

        static Random rand = new Random();

        public SmartHomeSimulator ()
        {
            devices = DeviceRepository.Devices;
        }

        public void Run()
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), OnTick);
        }

        bool OnTick ()
        {
            foreach (var device in devices)
            {
                if (device is DoorBell)
                    UpdateDoorBell(device as DoorBell);

                if (device is SmokeDetector)
                    UpdateSmokeDetector(device as SmokeDetector);
            }

            return true;
        }

        void UpdateSmokeDetector (SmokeDetector smokeDetector)
        {
            int value = rand.Next() % 9;

            if (value == 0)
                smokeDetector.DetectorStatus = SmokeDetector.Status.Fire;
            else if (value == 1)
                smokeDetector.DetectorStatus = SmokeDetector.Status.Smoke;
            else
                smokeDetector.DetectorStatus = SmokeDetector.Status.Normal;
        }

        void UpdateDoorBell (DoorBell doorBell)
        {
            if (rand.Next(4) == 0)
            {
                var index = rand.Next(5) + 1;

                doorBell.IconUrl = $"camera{index}.png";
                doorBell.DoorBellStatus = DoorBell.Status.Ringing;
            }
            else
            {
                doorBell.IconUrl = "door.png";
                doorBell.DoorBellStatus = DoorBell.Status.Normal;
            }
        }
    }
}