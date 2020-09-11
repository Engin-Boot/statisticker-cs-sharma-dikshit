using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats {
        public double average;
        public double maximum;
        public double minimum;
    }
    public class StatsComputer
    {
        public double sum;
        public double min;
        public double max;
        public double average;

        public Stats CalculateStatistics(List<double> numbers) {
            sum = 0;
            min = numbers[0];
            max = numbers[0];
            for (int i = 0; i < numbers.Count; i++) {
                sum += numbers[i];
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }
            average = sum / numbers.Count;

            Stats obj = new Stats();
            obj.average = average;
            obj.maximum = max;
            obj.minimum = min;

            return obj;
        }
    }
}

