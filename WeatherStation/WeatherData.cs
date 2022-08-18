
namespace WeatherStation
{
    internal sealed class WeatherData : ISubject
    {
        private float _temp;
        private float _humidity;
        private float _pressure;
        public float GetTemperature()
        {
            float result = 0;
            return result;

        }
        public float GetHumidity()
        {
            float result = 1;
            return result;
        }
        public float GetPressure()
        {
            float result = 2;
            return result;
        }
        private List<IObserver> _observers;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void MeasurementsChanged(float temp, float humidity, float pressure)
        {
            _temp = temp; 
            _humidity = humidity; 
            _pressure = pressure;

            NotifyObservers();
        }

        public void RegisterObserver(IObserver o)
        {
           _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int index = _observers.IndexOf(o);
            if (index>=0)
            {
            _observers.Remove(o);
            }
        }

        public void NotifyObservers()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                _observers[i].Update(_temp, _humidity, _pressure);
            }
        }
    }
}
