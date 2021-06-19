using MySCADA;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySCADA_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlarmPage : ContentPage
    {
        public ObservableCollection<AlarmTag> ItemList { get; set; }

        public AlarmPage()
        {
            InitializeComponent();
            List<String> dataList = new List<String>();
            ItemList = new ObservableCollection<AlarmTag>();

            Xamarin.Forms.Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                listViewAlarm.ItemsSource = null;
                Alarm alarms = App.Root.FindAlarm("Level");
                dataList.Clear();
                foreach (var alarm in alarms.alarmTag)
                { 
                    String str = alarm.Timestamp.ToString("HH:mm:ss dd/mm/yyyy") + "      " + alarm.Detail;
                    dataList.Add(str);
                }
               listViewAlarm.ItemsSource = dataList.OrderByDescending(p=>p);

                return true;
            });
        }
    }
}