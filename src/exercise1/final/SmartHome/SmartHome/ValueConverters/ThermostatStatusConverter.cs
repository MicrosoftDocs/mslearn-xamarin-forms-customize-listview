using System;
using System.Globalization;
using Xamarin.Forms;

namespace SmartHome
{
    class ThermostatStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (Thermostat.Status)value;

            switch(status)
            {
                case Thermostat.Status.Cooling:
                    return Color.FromHex("#00ACE5");
                case Thermostat.Status.Heating:
                    return Color.FromHex("#FF4800");
                default:
                    return Color.Black;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
