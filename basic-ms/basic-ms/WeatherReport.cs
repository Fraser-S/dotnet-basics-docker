﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basic_ms
{
    public class WeatherReport
    {
        private static readonly string[] PossibleConditions =
        {
            "Sunny",
            "Mostly Sunny",
            "Partly Sunny",
            "Partly Cloudy",
            "Mostly Cloudy",
            "Rain"
        };

        public int HighTemperatureFahrenheit { get; }
        public int LowTemperatureFahrenheit { get; }
        public int AverageWindSpeedMph { get; }
        public string Condition { get; }

        public WeatherReport(double latitude, double longitude, int daysInFuture)
        {
            var generator = new Random((int)(latitude + longitude) + daysInFuture);

            HighTemperatureFahrenheit = generator.Next(40, 100);
            LowTemperatureFahrenheit = generator.Next(0, HighTemperatureFahrenheit);
            AverageWindSpeedMph = generator.Next(0, 45);
            Condition = PossibleConditions[generator.Next(0, PossibleConditions.Length - 1)];
        }
    }
}
