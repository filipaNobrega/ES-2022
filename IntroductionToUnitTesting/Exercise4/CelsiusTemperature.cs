using System;

namespace Exercise4
{
    public class CelsiusTemperature : ITemperature
    {
        public CelsiusTemperature(double degrees)
        {
            Degrees = degrees;
        }

        public double Degrees { get; }

        public double Convert()
        {
            return Math.Round(1.8 * Degrees + 32.0, 1);
        }
    }
}