using Xamarin.Forms;

namespace SmartHome
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = DeviceManager.Instance.Value.Devices;
        }
    }
}
