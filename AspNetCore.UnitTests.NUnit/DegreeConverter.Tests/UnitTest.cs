using NUnit.Framework;

namespace DegreeConverter.Tests
{
    [TestFixture]
    public class UnitTest
    {
        private Converter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new Converter();
        }

        [Test]
        public void ToFahrenheit_0Celsius_Returns32()
        {
            double result = _converter.ToFahrenheit(0);
            Assert.That(result, Is.EqualTo(32));
        }

        [Test]
        public void ToCelsius_1Fahrenheit_Returns0()
        {
            double result = _converter.ToCelsius(1);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}