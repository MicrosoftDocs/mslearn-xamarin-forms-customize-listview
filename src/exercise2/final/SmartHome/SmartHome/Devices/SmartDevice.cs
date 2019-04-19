using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartHome
{
    public class SmartDevice : INotifyPropertyChanged
    {
        public string IconUrl
        {
            get => iconUrl;
            set => ChangePropertyValue(ref iconUrl, value);
        }
        string iconUrl;

        public string Name
        {
            get => name;
            set => ChangePropertyValue(ref name, value);
        }
        string name;

        public DateTime TimeStamp
        {
            get => timeStamp;
            set => ChangePropertyValue(ref timeStamp, value);
        }
        DateTime timeStamp = DateTime.Now;

        public string Id { get; } = Guid.NewGuid().ToString();

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool ChangePropertyValue<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (!Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);
                return true;
            }
            return false;
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}