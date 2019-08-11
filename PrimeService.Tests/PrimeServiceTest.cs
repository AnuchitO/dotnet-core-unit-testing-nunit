using NUnit.Framework;
using Prime.Services;

namespace Prime.Unitest.Services
{
    [TestFixture]
    public class PrimeServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPrime_inputIs1_ReturnFalse()
        {
		PrimeService ps = new PrimeService();

		Assert.IsFalse(ps.IsPrime(1), "1 should not be prime");
        }
    }
}
