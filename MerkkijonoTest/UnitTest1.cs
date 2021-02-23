using NUnit.Framework;
using Merkkijono;

namespace MerkkijonoTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Luokka()
        {
            var jono = new Merkkit();
            Assert.IsInstanceOf<Merkkit>(jono);
        }

        public void nolla()
        {
            var jono = new Merkkit();
            int pituus = jono.laske("");
            Assert.AreEqual(0, pituus);
        }
    }
}