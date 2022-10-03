using Moq;
namespace MockingWeekend.Tests
{
    [TestClass]
    public class GreeterTests
    {
        [TestMethod]
        public void GetMessage_Returns_Party_When_WeekendDay()
        {
            var dateGetter = new Mock<IDateGetter>();
            dateGetter.Setup(x => x.GetDate()).Returns(new DateTime(2022, 10, 1));
            var greeter = new Greeter(dateGetter.Object);
            var result = greeter.GetMessage();
            var expected = "Party time.....it's weekend";
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetMessage_Returns_Work_When_WeekDay()
        {
            var dateGetter = new Mock<IDateGetter>();
            dateGetter.Setup(x => x.GetDate()).Returns(new DateTime(2022, 09, 30));
            var greeter = new Greeter(dateGetter.Object);
            var result = greeter.GetMessage();
            var expected = "Work hard, weekend is on his way....";
            Assert.AreEqual(expected, result);
        }
    }
}