using NUnit.Framework;
using Merkkijono;
using System;

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

        [Test]
        public void nolla()
        {
            var jono = new Merkkit();
            int pituus = jono.laske("");
            Assert.AreEqual(0, pituus);
        }

        [Test]
        public void annaNumero()
        {
            var jono = new Merkkit();
            int pituus = jono.laske("9");
            Assert.AreEqual(9, pituus);

        }
        [Test]
        public void yhdistä()
        {
            var jono = new Merkkit();
            int pituus = jono.laske("9,9");
            Assert.AreEqual(18, pituus);
        }

        [Test]
        public void n()
        {
            var jono = new Merkkit();
            int pituus = jono.laske("0,8\n9");
            Assert.AreEqual(17, pituus);
        }

        [Test]
        public void eiylituhat()
        {
            var jono = new Merkkit();
            int pituus = jono.laske("1001,1");
            Assert.AreEqual(1, pituus);
        }
    }
}