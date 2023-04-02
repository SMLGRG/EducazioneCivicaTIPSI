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
            var actual = Classe1.Encipher("ciao",10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Primo_Equal_test2()
        {
            var expected = "hujifc";
            var actual = Classe1.Encipher("napoli", 20);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Secondo_Equal_test1()
        {
            var expected = "ciao";
            var actual = Classe1.Decipher("msky", 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Secondo_Equal_test2()
        {
            var expected = "napoli";
            var actual = Classe1.Decipher("hujifc", 20);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Terzo_Equal_test()
        {
            var expected = 280;
            var actual = Classe1.calcolaNumeroSomma("ciao", 10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Terzo_Equal_test2()
        {
            var expected = 450;
            var actual = Classe1.calcolaNumeroSomma("abcdefghi", 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Quarto_Equal_test1()
        {
            var expected = 41;
            var actual = Classe1.calcolaNumeroProdotto("ciao", 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Quarto_Equal_test2()
        {
            var expected = 3;
            var actual = Classe1.calcolaNumeroProdotto("abcd", 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Quinto_Equal_test1()
        {
            var expected = 280;
            var actual = Classe1.ScegliFunzione("ciao", 10);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Quinto_Equal_test2()
        {
            var expected = 5;
            var actual = Classe1.ScegliFunzione("abcd", 5);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Sesto_Equal_test()
        {
            var expected = 3;
            //for (int i = 0; i < 2; i++)
                Classe1.ScegliFunzione("abcd", 5);

            var actual = Classe1.getC();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sesto_Equal_test2()
        {
            var expected = 7;
            for(int i = 0; i < 4; i++)
                Classe1.ScegliFunzione("abcd", 5);
            var actual = Classe1.getC();
            Assert.AreEqual(expected, actual);
        }
    }
}