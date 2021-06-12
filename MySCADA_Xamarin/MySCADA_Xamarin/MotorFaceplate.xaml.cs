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
    public partial class MotorFaceplate : ContentPage
    {
        private int _id;
        public MotorFaceplate(int id)
        {
            InitializeComponent();
            pickerMode.Items.Add("Manual");
            pickerMode.Items.Add("Auto");
            _id = id;
            switch (_id)
            {
                case 1:
                    label_Motor.Text = "Motor 1";
                    break;
                case 2:
                    label_Motor.Text = "Motor 2";
                    break;
                case 3:
                    label_Motor.Text = "Valve";
                    break;
                default:
                    break;
            }
        }
    }
}