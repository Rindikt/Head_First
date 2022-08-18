
namespace WeatherStation
{
    internal sealed class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;

        private WeatherData _weatherData;
        public CurrentConditionDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Температура на текущий момент {_temperature}\n Влажность на текущий момент {_humidity}" );
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();


        }
    }
}
