using Microcharts;
using MySCADA;
using SkiaSharp;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Device = Xamarin.Forms.Device;
using Entry = Microcharts.ChartEntry;

namespace MySCADA_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Graph : ContentPage
    {
        private Random rnd = new Random();

        private List<Entry> entries = new List<Entry>
        {
            
        };

        public Graph()
        {
            InitializeComponent();
            LevelChart.Chart = new LineChart { Entries = entries, LineMode = LineMode.Straight, MaxValue = 110,
                MinValue = 0, LabelTextSize = 45, LabelOrientation = Orientation.Vertical, ValueLabelOrientation = Orientation.Vertical,
                PointMode = PointMode.Circle, };

            LevelChart.Chart.IsAnimated = false;
            Random rnd = new Random();
            int _preRear = 0;
            Historian levelHistorian = App.Root.FindHistorian("Level");
            Historian levelTimestampHistorian = App.Root.FindHistorian("LevelTimestamp");
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                //int intNum = rnd.Next(0, 100);  // creates a number between 1 and 12
                //Entry entry = new Entry(intNum);
                //entries.Add(entry);
                if (_preRear != levelHistorian.ringBuffer.rear)
                {
                    int currentLevel = levelHistorian.ringBuffer.Peek();
                    DateTime currentTimestamp = levelTimestampHistorian.ringBuffer.Peek();
                    if (entries.Count >40)
                    {
                        entries.RemoveAt(0);
                    }
                    if (levelHistorian.ringBuffer.rear % 10 == 0 )
                    {
                        entries.Add(new Entry(currentLevel)
                        {
                            Label = currentTimestamp.ToString("HH:mm:ss"),
                            ValueLabel = currentLevel.ToString(),
                            Color = SKColor.Parse("#0033cc"),
                            TextColor = SKColor.Parse("#000000"),
                        });
                    }
                    else
                    {
                        entries.Add(new Entry(currentLevel)
                        {
                            TextColor = SKColor.Parse("#000000"),
                        });
                    }

                    LevelChart.Chart.Entries = entries;
                    _preRear = levelHistorian.ringBuffer.rear;
                }

                return true;
            });
        }
    }
}