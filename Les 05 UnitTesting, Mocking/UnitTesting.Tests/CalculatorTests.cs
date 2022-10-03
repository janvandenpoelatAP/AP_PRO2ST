namespace UnitTesting.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void SumTest()
        {
            var calculator = new Calculator();  // Maak een nieuwe calculator instantie
            var a = 2;                          // Waarde voor parameter a
            var b = 3;                          // Waarde voor parameter b
            var expected = 5;                   // Verwacht resultaat
            var result = calculator.Sum(a, b);  // Sum methode aanroepen
            Assert.AreEqual(expected, result);  // Testen of resultaat gelijk is aan verwachte waarde 
        }
    }
}