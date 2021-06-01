using NUnit.Framework;

namespace Services.UnitTests
{
    [TestFixture]
    public class CalculationTest
    {
        private Utility _utility;

        [SetUp]
        public void Setup()
        {
            _utility = new Utility();
        }

        [TestCase(4, 4, 20)]
        [TestCase(5, 10, 25)]
        public void TestGCD(int result, int a, int b)
        {
            Assert.AreEqual(result, _utility.GetGCD(a, b));
        }
    }
}