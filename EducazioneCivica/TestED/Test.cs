using NUnit.Framework;
using Nammasp;
using System;

namespace TestED
{
    public class Tests
    {
        private Tests _test { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _test = new Tests();
        }

        [Test]
        public void Primo_Equal_test()
        {
            var expected = "msky";
            var actual = Classe1.Primo("ciao",10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Primo_Equal_test2()
        {
            var expected = "hujifc";
            var actual = Classe1.Primo("napoli", 20);
            Assert.AreEqual(expected, actual);
        }
    }
}