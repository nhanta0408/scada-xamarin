using MySCADA;
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
        public  SCADA parent;
        private bool pausedReadMode;
        private string prefix;
        public MotorFaceplate(int id)
        {
            InitializeComponent();
            pickerMode.Items.Add("Manual");
            pickerMode.Items.Add("Auto");
            _id = id;
            pausedReadMode = false;
            switch (_id)
            {
                case 1:
                    label_Motor.Text = "Motor 1";
                    prefix = "Motor_1";
                    break;
                case 2:
                    label_Motor.Text = "Motor 2";
                    prefix = "Motor_2";
                    break;
                case 3:
                    label_Motor.Text = "Valve";
                    prefix = "Valve";
                    break;
                default:
                    break;
            }
            
                Xamarin.Forms.Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                MySCADA.Task task = parent.FindTask("Task_1"); //VS bị confused giứa task của mình và task của system
                if (task != null)
                {
                    Tag tagMode;
                    tagMode = task.FindTag($"{prefix}_Mode");
                    if(pickerMode.SelectedIndex == (Int16)tagMode.Value - 1)
                    {
                        pausedReadMode = false;
                    }
                    if (tagMode != null && pickerMode.IsFocused == false&& !pausedReadMode)
                    {
                        pickerMode.SelectedIndex = (Int16)tagMode.Value - 1; //1 la Manual, 2 Auto
                    }
                    Tag tagRunFB;
                    tagRunFB = task.FindTag($"{prefix}_RunFB"); //Đọc RunFB Motor1
                    if (tagRunFB != null)
                    {
                        Light.Color = tagRunFB.Value ? Color.Green : Color.Gray;
                     }
                }

                return true; // True = Repeat again, False = Stop the timer
            });

        }

        private void Button_Start_Pressed(object sender, EventArgs e)
        {
            parent.S71500.WriteBool($"DB{_id}.DBX2.0", true);
        }

        private void Button_Start_Released(object sender, EventArgs e)
        {
            parent.S71500.WriteBool($"DB{_id}.DBX2.0", false);
        }

        private void Button_Stop_Pressed(object sender, EventArgs e)
        {
            parent.S71500.WriteBool($"DB{_id}.DBX2.1", true);
        }

        private void Button_Stop_Released(object sender, EventArgs e)
        {
            parent.S71500.WriteBool($"DB{_id}.DBX2.1", false);
        }

        private void pickerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            pausedReadMode = true;
            parent.S71500.WriteInt($"DB{_id}.DBW0", (Int16)(pickerMode.SelectedIndex + 1));
        }
    }
}