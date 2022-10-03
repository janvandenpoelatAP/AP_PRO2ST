using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningMockingOpenWeather
{
    public class WeatherService
    {
        private readonly IOpenWeatherMapApi _openWeatherMap;

        public WeatherService(IOpenWeatherMapApi openWeatherMap)
        {
            this._openWeatherMap = openWeatherMap;
        }

        public string GetCurrentWeatherInAntwerp()
        {
            var openWeatherMapApi = _openWeatherMap;
            var temp = openWeatherMapApi.GetCurrentTemperatureInAntwerp();
            if (temp < 0)
            {
                return "Brrrr, it's freezing";
            }
            if (temp < 15)
            {
                return "It's cold";
            }
            if (temp < 24)
            {
                return "it's ok";
            }
            return "It's HOT!!!";
        }
    }
}
