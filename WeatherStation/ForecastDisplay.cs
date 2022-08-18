
namespace WeatherStation
{
    internal sealed class ForecastDisplay : IDisplayElement, IObserver
    {
        public void Display()
        {
            Console.WriteLine("Прогноз");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
