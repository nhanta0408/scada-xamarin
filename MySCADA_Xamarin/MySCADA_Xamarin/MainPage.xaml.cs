using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySCADA_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void img_Motor1_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MotorFaceplate(1));
        }
        private async void img_Motor2_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MotorFaceplate(2));
        }
        private async void img_Valve_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MotorFaceplate(3));
        }

    }
}