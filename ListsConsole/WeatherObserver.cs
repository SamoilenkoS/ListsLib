using System;
using System.Collections.Generic;
using System.Text;

namespace ListsConsole
{
    public class WeatherObserver : IObserver<WeatherForecast>
    {
        public void OnCompleted()
        {
            //throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            //throw new NotImplementedException();
        }

        public void OnNext(WeatherForecast value)
        {
            Console.WriteLine($"{value.Region}:{value.Temperature}");
        }
    }
}
