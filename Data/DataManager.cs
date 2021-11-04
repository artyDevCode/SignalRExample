using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRExample.Models;

namespace SignalRExample.Data
{
    public static class DataManager
    {
        public static Chart GetData()
        {
            Chart chartData = new Chart();
            var rand = new Random();

            chartData.xValues = new List<string>();
            chartData.xValues.Add("Italy");
            chartData.xValues.Add("France");
            chartData.xValues.Add("Spain");
            chartData.xValues.Add("USA");
            chartData.xValues.Add("Argentina");

            chartData.yValues = new List<int>();
            chartData.yValues.Add(rand.Next(10, 60));
            chartData.yValues.Add(rand.Next(10, 60));
            chartData.yValues.Add(rand.Next(10, 60));
            chartData.yValues.Add(rand.Next(10, 60));
            chartData.yValues.Add(rand.Next(10, 60));

            chartData.barColors = new List<string>();
            chartData.barColors.Add("red");
            chartData.barColors.Add("green");
            chartData.barColors.Add("blue");
            chartData.barColors.Add("orange");
            chartData.barColors.Add("brown");
            return chartData;
        }

    }
}
