namespace WeatherStation
{
    internal sealed class ThirdPartyDisplay : IObserver, IDisplayElement
    {
        public void Display()
        {
            Console.WriteLine("вывод другой информации на основе полученных данных");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            throw new NotImplementedException();
        }
    }
}
