using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHome
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThermostatViewCell : ViewCell
    {
        public ThermostatViewCell()
        {
            InitializeComponent();

            btnDown.Clicked += BtnDown_Clicked;
            btnUp.Clicked += BtnUp_Clicked;
        }

        void BtnUp_Clicked(object sender, System.EventArgs e)
        {
            var thermostat = BindingContext as Thermostat;
            DeviceManager.Instance.Value.IncreaseTemperature(thermostat.Id);
        }

        void BtnDown_Clicked(object sender, System.EventArgs e)
        {
            var thermostat = BindingContext as Thermostat;
            DeviceManager.Instance.Value.DecreaseTemperature(thermostat.Id);
        }
    }
}