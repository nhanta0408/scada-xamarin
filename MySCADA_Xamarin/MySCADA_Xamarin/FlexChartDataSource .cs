using System;
using System.Collections.Generic;
using System.Text;

namespace MySCADA_Xamarin
{
    public class FlexChartDataSource
    {
        private List<Quarter> appData;

        public List<Quarter> Data
        {
            get { return appData; }
        }

        public FlexChartDataSource()
        {
            //// appData  
            appData = new List<Quarter>();
            var quarterNames = "Q1, Q2, Q3, Q4".Split(',');
            var salesData = new[] { 6833, 11100, 10833, 15350 };
            var downloadsData = new[] { 8500, 7933, 11666, 12350 };
            var expensesData = new[] { 11166, 10166, 7333, 8166 };
            for (int j = 0; j < 4; j++)
            {
                Quarter tempQuarter = new Quarter();
                tempQuarter.Name = quarterNames[j];
                tempQuarter.Sales = salesData[j];
                tempQuarter.Downloads = downloadsData[j];
                tempQuarter.Expenses = expensesData[j];
                appData.Add(tempQuarter);

            }
        }
    }
    public class Quarter
    {
        string _name;
        long _sales, _downloads, _expenses;  

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public long Sales
        {
            get { return _sales; }
            set { _sales = value; }
        }

        public long Downloads
        {
            get { return _downloads; }
            set { _downloads = value; }
        }
        public long Expenses
        {
            get { return _expenses; }
            set { _expenses = value; }
        }
    }
}
