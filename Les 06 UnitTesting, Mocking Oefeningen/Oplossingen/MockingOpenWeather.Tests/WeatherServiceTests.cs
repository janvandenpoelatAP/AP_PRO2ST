using Moq;

namespace MockingOpenWeather.Tests
{
    [TestClass()]
    public class WeatherServiceTests
    {
        [TestMethod()]
        public void GetCurrentWeatherInAntwerp_Returns_Brrr_If_Temp_Is_Below_Zero()
        {
            //Arrange
            var openWeatherMapApi = new Mock<IOpenWeatherMapApi>();
            openWeatherMapApi.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(-1);

            //Act
            var weatherService = new WeatherService(openWeatherMapApi.Object);

            //Assert
            Assert.AreEqual("Brrrr, it's freezing", weatherService.GetCurrentWeatherInAntwerp());
        }

        [TestMethod()]
        public void GetCurrentWeatherInAntwerp_When_Temperature_Between_0_And_15_Returns_String()
        {
            var openWeatherMap = new Mock<IOpenWeatherMapApi>();
            openWeatherMap.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(5);
            var weatherService = new WeatherService(openWeatherMap.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            Assert.AreEqual("It's cold", result);
        }

        [TestMethod()]
        public void GetCurrentWeatherInAntwerp_When_Temperature_Between_15_And_24_Returns_String()
        {
            var openWeatherMap = new Mock<IOpenWeatherMapApi>();
            openWeatherMap.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(20);
            var weatherService = new WeatherService(openWeatherMap.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            Assert.AreEqual("it's ok", result);
        }

        [TestMethod()]
        public void GetCurrentWeatherInAntwerp_When_Temperature_Above_24_Returns_String()
        {
            var openWeatherMap = new Mock<IOpenWeatherMapApi>();
            openWeatherMap.Setup(x => x.GetCurrentTemperatureInAntwerp()).Returns(32);
            var weatherService = new WeatherService(openWeatherMap.Object);
            var result = weatherService.GetCurrentWeatherInAntwerp();
            Assert.AreEqual("It's HOT!!!", result);
        }
    }
}