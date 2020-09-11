using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public double average;
        public double maximum;
        public double minimum;
    }
    public class StatsComputer
    {
        double computeAverage(List<double> numbers)
        {
            if (numbers.Count == 0) return double.NaN;

            double sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Count;
        }

        double computeMax(List<double> numbers)
        {
            if (numbers.Count == 0) return double.NaN;

            double max = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max) max = numbers[i];
            }

            return max;
        }

        double computeMin(List<double> numbers)
        {
            if (numbers.Count == 0) return double.NaN;

            double min = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min) min = numbers[i];
            }

            return min;
        }

        public Stats CalculateStatistics(List<double> numbers)
        {
            Stats obj = new Stats();
            obj.average = computeAverage(numbers);
            obj.maximum = computeMax(numbers);
            obj.minimum = computeMin(numbers);
            return obj;
        }
    }
}



