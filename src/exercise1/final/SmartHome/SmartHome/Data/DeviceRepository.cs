using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SmartHome
{
    public static class DeviceRepository
    {
        public static IList<SmartDevice> Devices;

        static DeviceRepository ()
        {
            Devices = new ObservableCollection<SmartDevice>()
            {
                new DoorBell() { Name = "Front Door" },
                new DoorBell() { Name = "Side Door" },

                new SmokeDetector() { Name = "Kitchen" },
                new SmokeDetector() { Name = "Garage" },
                new SmokeDetector() { Name = "Upstairs" },

                new Thermostat() { Name = "Family Room", TargetTemperature = 22, CurrentTemperature = 23 },
                new Thermostat() { Name = "Kitchen", TargetTemperature = 23, CurrentTemperature = 23 },
                new Thermostat() { Name = "Garage",  TargetTemperature = 24, CurrentTemperature = 23 },
                new Thermostat() { Name = "Master Bedroom", TargetTemperature = 24, CurrentTemperature = 23 },
                new Thermostat() { Name = "Office", TargetTemperature = 24, CurrentTemperature = 23 }
            };
        }
    }
}