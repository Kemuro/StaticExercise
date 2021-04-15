using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static void FahrenheitToCelsius(double temperature)
        {
            double celsius = (temperature - 32) / 1.8000;
            Console.WriteLine($"{temperature} F is {celsius} C.");
        }
        public static void CelsiusToFahrenheit(double temperature)
        {
            double fahrenheit = (temperature * 1.8000) + 32;
            Console.WriteLine($"{temperature} C is {fahrenheit} F.");
        }
    }
}
