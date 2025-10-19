using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace EMS.Core.Utilities
{
    public static class ChartHelper
    {
        public static void ClearChart(Chart chart)
        {
            if (chart == null) return;
            chart.Series.Clear();
        }

        public static void AddLineSeries<T>(Chart chart, string seriesName, IEnumerable<T> data, Func<T, DateTime> xSelector, Func<T, double> ySelector)
        {
            if (chart == null) return;
            var series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime
            };

            var ordered = data?.OrderBy(xSelector) ?? Enumerable.Empty<T>();
            foreach (var item in ordered)
            {
                var x = xSelector(item);
                var y = ySelector(item);
                series.Points.AddXY(x, y);
            }

            chart.Series.Add(series);
        }

        public static void AddBarSeries<T>(Chart chart, string seriesName, IEnumerable<T> data, Func<T, DateTime> xSelector, Func<T, double> ySelector)
        {
            if (chart == null) return;
            var series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.DateTime
            };

            var ordered = data?.OrderBy(xSelector) ?? Enumerable.Empty<T>();
            foreach (var item in ordered)
            {
                var x = xSelector(item);
                var y = ySelector(item);
                series.Points.AddXY(x, y);
            }

            chart.Series.Add(series);
        }

        public static void AddPieSeriesFromGroups(Chart chart, string seriesName, IEnumerable<KeyValuePair<string, double>> groups)
        {
            if (chart == null) return;
            var series = new Series(seriesName)
            {
                ChartType = SeriesChartType.Pie
            };

            foreach (var kv in groups)
            {
                var point = new DataPoint
                {
                    AxisLabel = kv.Key,
                    YValues = new[] { kv.Value }
                };
                series.Points.Add(point);
            }

            chart.Series.Add(series);
        }
    }
}
