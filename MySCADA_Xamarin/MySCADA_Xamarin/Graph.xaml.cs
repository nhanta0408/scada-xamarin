using C1.Xamarin.Forms.Chart;
using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.ChartEntry;

namespace MySCADA_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Graph : ContentPage
    {
        public static FlexChart GetChartControl()
        {
            //Create an instance of the Control and set its properties  
            FlexChart chart = new FlexChart();
            chart.ChartType = ChartType.Area;
            //Set the datasource  
            FlexChartDataSource ds = new FlexChartDataSource();
            chart.ItemsSource = ds.Data;

            //Create a new chart series  
            List<ChartSeries> seriesList = new List<ChartSeries>();
            seriesList.Add(new ChartSeries());

            chart.Series.Add(seriesList[0]);
            chart.Series.Add(seriesList[1]);
            chart.Series.Add(seriesList[2]);
            return chart;
        }

        List<String> xData = new List<String>();
        List<int> yData = new List<int>();
        public Graph()
        {
            InitializeComponent();
            
            Random rnd = new Random();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                
                return true;
            });
        }
    }
}