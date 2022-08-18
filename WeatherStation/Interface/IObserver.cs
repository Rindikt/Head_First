
namespace WeatherStation
{
    internal interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
