using NUnit.Framework;
using System;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19)] int input)
        {
            // ACT
            string output = FizzBuzzer.GetValue(input);

            // ASSERT
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_WhenDiv3_ReturnsFizz([Values(3, 6, 9, 12, 18)] int input)
        {
            // ACT
            string output = FizzBuzzer.GetValue(input);

            // ASSERT
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_WhenDiv5_ReturnsBuzz([Values(5, 10, 20)] int input)
        {
            // ACT
            string output = FizzBuzzer.GetValue(input);

            // ASSERT
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz([Values(15)] int input)
        {
            // ACT
            string output = FizzBuzzer.GetValue(input);

            // ASSERT
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
