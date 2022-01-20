using System;
using System.Collections.Generic;
using System.Text;

namespace ListsConsole
{
    public class WeatherGenerator : IObservable<WeatherForecast>
    {
        private List<IObserver<WeatherForecast>> _observers;
        public WeatherGenerator()
        {
            _observers = new List<IObserver<WeatherForecast>>();
        }

        public IDisposable Subscribe(IObserver<WeatherForecast> observer)
        {
            _observers.Add(observer);

            return new Unsubscribe(_observers, observer);
        }

        public void SimulateWeather()
        {
            Random random = new Random();
            WeatherForecast weatherForecast = new WeatherForecast
            {
                Region = "test",
                Temperature = random.Next(1, 100)
            };

            foreach (var observer in _observers)
            {
                observer.OnNext(weatherForecast);
            }
        }

        private class Unsubscribe : IDisposable
        {
            private List<IObserver<WeatherForecast>> _observers;
            private IObserver<WeatherForecast> _observer;

            public Unsubscribe(List<IObserver<WeatherForecast>> observers, IObserver<WeatherForecast> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }
    }
}
