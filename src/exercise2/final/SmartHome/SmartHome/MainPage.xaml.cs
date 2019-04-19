using System.Linq;
using Xamarin.Forms;

namespace SmartHome
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = DeviceManager.Instance.Value.Devices
                .OrderBy(dev => dev.Name)
                .ToLookup(dev => dev.Name[0].ToString());
        }
    }
}
