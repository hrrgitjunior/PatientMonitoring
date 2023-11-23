using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace PatientsMonitoring
{
    class Plot
    {
        public void CreatePlot(Chart chart, Dictionary<string, double[]> seriesDict)
        {
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            // month 1-12
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 12;
            // temperature
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 36;
            objChart.AxisY.Maximum = 40;
            // clear
            chart.Series.Clear();
            // random color
            Random random = new Random();
            // loop rows
            foreach (string sensor in seriesDict.Keys)
            {
                chart.Series.Add(sensor);
                chart.Series[sensor].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart.Series[sensor].Legend = "Legend1";
                chart.Series[sensor].ChartArea = "ChartArea1";
                chart.Series[sensor].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                double[] temperature = seriesDict[sensor];
                for (int i = 0; i < temperature.Length; i++)
                {
                    chart.Series[sensor].Points.AddXY(i+1, temperature[i]);
                }
            }
        }

        public void CreatePlotByJoinedTemperature(Chart chart, List<object> temperature)
        {
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            // month 1-12
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 14;
            // temperature
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 36;
            objChart.AxisY.Maximum = 40;
            // clear
            chart.Series.Clear();
            // random color
            Random random = new Random();
            string patient = "Patient_1";
            // loop rows
            chart.Series.Add(patient);
            chart.Series[patient].Color = Color.Blue;
            chart.Series[patient].Legend = "Legend1";
            chart.Series[patient].ChartArea = "ChartArea1";
            chart.Series[patient].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i < temperature.Count; i++)
            {
                TimeEventInfo teInfo = (TimeEventInfo)temperature[i];
                chart.Series[patient].Points.AddXY(teInfo.time, teInfo.temperature);
            }
        }

        public Plot()
        {

        }
    }
}
