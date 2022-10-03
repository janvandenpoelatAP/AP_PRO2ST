using Microsoft.VisualStudio.TestTools.UnitTesting;
using OefeningMockingOpenWeather;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace OefeningMockingOpenWeather.Tests
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
        public void GetCurrentWeatherInAntwerp_Returns_Brrr_If_Temp_Is_Below_Zero_IntegrationTest()
        {
            //Arrange
            var openWeatherMapApi = new OpenWeatherMapApi("http://localhost:3000/data/2.5/weather");

            //Act
            var weatherService = new WeatherService(openWeatherMapApi);

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