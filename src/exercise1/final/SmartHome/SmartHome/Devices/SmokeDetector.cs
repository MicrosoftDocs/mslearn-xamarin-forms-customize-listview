using System;

namespace SmartHome
{
    public class SmokeDetector : SmartDevice
    {
        public enum Status
        {
            Normal,
            Smoke,
            Fire,
        }

        public SmokeDetector.Status DetectorStatus
        {
            get => detectorStatus;
            set
            {
                ChangePropertyValue(ref detectorStatus, value);
                TimeStamp = DateTime.Now;
            }
        }
        SmokeDetector.Status detectorStatus = Status.Normal;
    }
}