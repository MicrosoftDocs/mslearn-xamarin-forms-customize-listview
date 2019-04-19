using System;
using System.Globalization;
using Xamarin.Forms;

namespace SmartHome
{
    //this could also be broken into two separate converters if you were using it in multiple places
    public class SmokeStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = (SmokeDetector.Status)value;

            if (targetType == typeof(Color))
                return GetColor(status);

            if (targetType == typeof(ImageSource))
                return GetImageName(status);

            throw new NotSupportedException();
        }

        string GetImageName(SmokeDetector.Status status)
        {
            switch (status)
            {
                case SmokeDetector.Status.Fire:
                    return "emergency.png";
                case SmokeDetector.Status.Smoke:
                    return "warning.png";
                default:
                    return "smoke.png";
            }
        }

        Color GetColor(SmokeDetector.Status status)
        { 
            switch(status)
            {
                case SmokeDetector.Status.Fire:
                    return Color.Red;
                case SmokeDetector.Status.Smoke:
                    return Color.Orange;
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
