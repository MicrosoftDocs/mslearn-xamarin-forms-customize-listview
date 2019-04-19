using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartHome
{
    public class DeviceManager
    {
        public IList<SmartDevice> Devices;

        public static Lazy<DeviceManager> Instance = new Lazy<DeviceManager>();

        public DeviceManager()
        {
            Devices = DeviceRepository.Devices;
        }

        public void IncreaseTemperature(string deviceId)
        {
            var thermostat = (Thermostat)GetDeviceFromId(deviceId);
            thermostat.TargetTemperature++;
        }

        public void DecreaseTemperature(string deviceId)
        {
            var thermostat = (Thermostat)GetDeviceFromId(deviceId);
            thermostat.TargetTemperature--;
        }

        SmartDevice GetDeviceFromId(string deviceId)
        {
            return (from d in Devices
                    where d.Id == deviceId
                    select d).FirstOrDefault();
        }
    }
}