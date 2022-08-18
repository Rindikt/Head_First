
namespace WeatherStation
{
    internal sealed class StatisticsDisplay : IObserver, IDisplayElement
    {
        public void Display()
        {
            Console.WriteLine("Cтатистика");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
