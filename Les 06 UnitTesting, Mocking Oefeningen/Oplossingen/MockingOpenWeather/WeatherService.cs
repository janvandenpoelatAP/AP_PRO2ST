namespace MockingOpenWeather
{
    public class WeatherService
    {
        private readonly IOpenWeatherMapApi openWeatherMapApi;

        public WeatherService(IOpenWeatherMapApi openWeatherMapApi)
        {
            this.openWeatherMapApi = openWeatherMapApi;
        }

        public string GetCurrentWeatherInAntwerp()
        {

            float temp;
            try
            {
                temp = openWeatherMapApi.GetCurrentTemperatureInAntwerp();
            }
            catch (Exception)
            {
                return "Failed to get temperature";
            }
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
