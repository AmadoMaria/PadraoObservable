using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditiosDisplay currentConditiosDisplay = new CurrentConditiosDisplay(weatherData);
            weatherData.SetMeasurements(25, 12, 15);
            weatherData.RemoveObserver(currentConditiosDisplay);

        }
    }
}
