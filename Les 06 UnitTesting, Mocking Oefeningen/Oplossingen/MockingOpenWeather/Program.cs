using MockingOpenWeather;

var weatherService = new WeatherService(new OpenWeatherMapApi());

Console.WriteLine(weatherService.GetCurrentWeatherInAntwerp());
