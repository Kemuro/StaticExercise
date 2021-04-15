using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            TempConverter.FahrenheitToCelsius(200);
            Console.WriteLine();
            TempConverter.CelsiusToFahrenheit(150);
        }
    }
}
