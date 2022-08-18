using System;

namespace WeatherStation
{
    internal sealed class WeatherStation
    {
        public static void Main()
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentConditionDis = new CurrentConditionDisplay(weatherData);
            //StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            //ForecastDisplay forecastDisplay = new ForecastDisplay();

            weatherData.MeasurementsChanged(80, 65, 30.3f);
            weatherData.MeasurementsChanged(86, 15, 10.8f);
            weatherData.MeasurementsChanged(30, 55, 50.5f);

        }
    }
}
