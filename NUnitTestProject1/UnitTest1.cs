using NUnit.Framework;
using Yksikkötestaus;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void FizzBuzz()
        {
            var fizzer = new FizzBuzz();
            Assert.IsInstanceOf<FizzBuzz>(fizzer);
        }

        public void jakaa3()
        {
            var fizzer = new FizzBuzz();

            string vastaus = fizzer.Luku(3);

            Assert.AreEqual("Fizz", vastaus);
        }
        public void jakaa5()
        {
            var fizzer = new FizzBuzz();

            string vastaus = fizzer.Luku(5);
            Assert.AreEqual("Buzz", vastaus);
        
        }
        public void palauttaa()
        {
            var fizzer = new FizzBuzz();
            string vastaus = fizzer.Luku(23);
            Assert.AreEqual("1", vastaus);
        }

        public void fizbuz()
        {
            var fizzer = new FizzBuzz();
            string vastays = fizzer.Luku(15);
            Assert.AreEqual("FizzBuzz", vastays);
        }
    }
}