using MySCADA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Timer = System.Timers.Timer;

namespace MySCADA_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainScreen : ContentPage
    {
        private Timer timer, pauseTimer;
        private bool paused;
        public MainScreen()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            
            pauseTimer = new Timer();
            pauseTimer.Enabled = false;
            pauseTimer.Interval = 2000;
            pauseTimer.Elapsed += PauseTimer_Elapsed;

            pickerMode1.Items.Add("Manual");
            pickerMode1.Items.Add("Auto");
            pickerMode2.Items.Add("Manual");
            pickerMode2.Items.Add("Auto");
            pickerMode3.Items.Add("Manual");
            pickerMode3.Items.Add("Auto");

            label_Motor1.Text = "Motor 1";
            label_Motor2.Text = "Motor 2";
            label_Motor3.Text = "Valve";

            paused = false;


        }

        private void PauseTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            paused = false;
            pauseTimer.Enabled = false;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(timer.Enabled == true)
            {
                MySCADA.Task task = App.Root.FindTask("Task_1"); //VS bị confused giứa task của mình và task của system
                if (task != null)
                {
                    Tag tagMode;
                    tagMode = task.FindTag("Motor_1_Mode");
                    if (tagMode != null  && pickerMode1.IsFocused == false && !paused)
                    {
                        pickerMode1.SelectedIndex = (Int16)tagMode.Value - 1; //1 la Manual, 2 Auto
                    }
                    tagMode = task.FindTag("Motor_2_Mode");
                    if (tagMode != null && pickerMode2.IsFocused == false && !paused)
                    {
                        pickerMode2.SelectedIndex = (Int16)tagMode.Value-1;
                    }
                    tagMode = task.FindTag("Valve_Mode");
                    if (tagMode != null && pickerMode3.IsFocused == false && !paused)
                    {
                        pickerMode3.SelectedIndex = (Int16)tagMode.Value-1;
                    }

                    Tag tagRunFB, tagPos;
                    tagRunFB = task.FindTag("Motor_1_RunFB"); //Đọc RunFB Motor1
                    tagPos = task.FindTag("Motor_1_Pos");
                    if (tagRunFB != null && tagPos != null)
                    {
                        short pos = tagPos.Value;
                        img_Motor1.Source = MotorSwCaImg(tagRunFB.Value, pos);
                        img_Pipe1.Source = (tagRunFB.Value) ? "Pipe_on.png" : "Pipe_off.png";
                    }
                    tagRunFB = task.FindTag("Motor_2_RunFB"); //Đọc RunFB Motor2
                    tagPos = task.FindTag("Motor_2_Pos");
                    if (tagRunFB != null && tagPos != null)
                    {
                        short pos = tagPos.Value;
                        img_Motor2.Source = MotorSwCaImg(tagRunFB.Value, pos);
                        img_Pipe2.Source = (tagRunFB.Value) ? "Pipe_on.png" : "Pipe_off.png";
                    }
                    tagRunFB = task.FindTag("Valve_RunFB"); //Đọc RunFB Valve
                    if (tagRunFB != null)
                    {
                        img_Valve.Source = (tagRunFB.Value) ? "ValveSolinoid_on.png" : "ValveSolinoid_off.png"; ;
                    }
                    Tag tagLevel = task.FindTag("Level");
                    if (tagLevel != null)
                    {
                        progress_Level.Progress = tagLevel.Value / 100.0;
                        //Alarm sửa sau
                        //if (tagLevel.Value < Alarm.lowlow || tagLevel.Value > Alarm.highhigh)
                        //{
                        //    barLevel.TextColor = Color.FromArgb(0x990000);
                        //}
                        //else if (tagLevel.Value > Alarm.low && tagLevel.Value < Alarm.high)
                        //{
                        //    barLevel.TextColor = Color.Black;
                        //}
                        //else
                        //{
                        //    barLevel.TextColor = Color.Yellow;
                        //}
                    }
                }
            }
            
        }

        private async void img_Motor1_Tapped(object sender, EventArgs e)
        {
            timer.Stop();
            //Thread.Sleep(2000);
            //MotorFaceplate motorFaceplate1 = (MotorFaceplate)this.parent.Motor_faceplates[0];
            await Navigation.PushAsync(new MotorFaceplate(1));

        }
        private async void img_Motor2_Tapped(object sender, EventArgs e)
        {
            timer.Stop();
            //MotorFaceplate motorFaceplate2 = (MotorFaceplate)this.parent.Motor_faceplates[1];
            await Navigation.PushAsync(new MotorFaceplate(2));
        }
        private async void img_Valve_Tapped(object sender, EventArgs e)
        {
            timer.Stop();
            //MotorFaceplate motorFaceplate3 = (MotorFaceplate)this.parent.Motor_faceplates[2];
            await Navigation.PushAsync(new MotorFaceplate(3));

        }
        private string MotorSwCaImg(bool status, Int16 position)
        {
            string src = "Motor_off_1.png";
            switch (position)
            {
                case (Int16)0:
                    src = status ? "Motor_on_1.png" : "Motor_off_1.png";
                    break;
                case (Int16)1:
                    src = status ? "Motor_on_2.png" : "Motor_off_2.png";
                    break;
                case (Int16)2:
                    src = status ? "Motor_on_3.png" : "Motor_off_3.png";
                    break;
                case (Int16)3:
                    src = status ? "Motor_on_4.png" : "Motor_off_4.png";
                    break;
                case (Int16)4:
                    src = status ? "Motor_on_5.png" : "Motor_off_5.png";
                    break;
                case (Int16)5:
                    src = status ? "Motor_on_6.png" : "Motor_off_6.png";
                    break;
                case (Int16)6:
                    src = status ? "Motor_on_7.png" : "Motor_off_7.png";
                    break;
                case (Int16)7:
                    src = status ? "Motor_on_8.png" : "Motor_off_8.png";
                    break;
                default:
                    src = "Motor_off_1.png";
                    break;

            }
            return src;
        }

    
        
        private  void Button_Start3_Pressed(object sender, EventArgs e)
        {
             App.Root.S71500.WriteBool("DB3.DBX2.0", true);
        }

        private void Button_Start3_Released(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB3.DBX2.0", false);

        }

        private void Button_Stop3_Pressed(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB3.DBX2.1", true);

        }
        private void Button_Stop3_Released(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB3.DBX2.1", false);
        }

        private void Button_Start2_Pressed(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB2.DBX2.0", true);
        }

        private void Button_Start2_Released(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB2.DBX2.0", false);

        }

        private void Button_Stop2_Pressed(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB2.DBX2.1", true);
        }

        private void Button_Stop2_Released(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB2.DBX2.1", false);

        }

        private void Button_Start1_Pressed(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB1.DBX2.0", true);
        }

        private void Button_Start1_Released(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB1.DBX2.0", false);
        }

        private void Button_Stop1_Pressed(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB1.DBX2.1", true);
        }

        private void Button_Stop1_Released(object sender, EventArgs e)
        {
            App.Root.S71500.WriteBool("DB1.DBX2.1", false);

        }

        private void pickerMode1_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.Root.S71500.WriteInt("DB1.DBW0",(Int16)(pickerMode1.SelectedIndex+1));
            paused = true;
            pauseTimer.Enabled = true;
        }

        private void pickerMode2_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.Root.S71500.WriteInt("DB2.DBW0", (Int16)(pickerMode2.SelectedIndex + 1));
            paused = true;
            pauseTimer.Enabled = true;
        }

        private void pickerMode3_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.Root.S71500.WriteInt("DB3.DBW0", (Int16)(pickerMode3.SelectedIndex + 1));
            paused = true;
            pauseTimer.Enabled = true;
        }
    }
}