using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskBibloteksProject;

namespace UnitTestProjectBog
{
    [TestClass]
    public class UnitTest1
    {
        private Bog b;

        [TestInitialize]
        public void Before()
        {
            Bog b = new Bog();
            //Bog(titel, forfatter, sideTal, lsbn13)
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestTitelForKort()
        {
            Bog b = new Bog();

            //Her testes der for argument out off range exception.
            //En charactor under det den må være.
            b.Titel = "h";
        }
        [TestMethod]
        public void TestTitelPassende()
        {
            Bog b = new Bog();
            
            //Her testes der for at den godt må være to charactors lang og længere.
            b.Titel = "hh";
            b.Titel = "Once upon a time";
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSideTalForLav()
        {
            Bog b = new Bog();

            //Her testes der for at sidetalet kaster en Out off range exception fordi det er for lavt.
            b.SideTal = 9;
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSideTalForHøj()
        {
            Bog b = new Bog();

            //Her testes der for at sidetalet kaster en Out off range exception fordi det er for højt.
            b.SideTal = 1001;
        }
        [TestMethod]
        public void TestSideTalPassende()
        {
            Bog b = new Bog();

            //Her testes der for at sidetalet kaster en Out off range exception fordi det er for højt.
            b.SideTal = 1000;
            b.SideTal = 10;
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestLsbnForLang()
        {
            Bog b = new Bog();

            //Her testes for at tekst strengen caster en Out off range exception hvis den er for lang.
            b.Lsbn13 = "jeg er 14 lang";
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestLsbnForKort()
        {
            Bog b = new Bog();

            //Her testes for at tekst strengen caster en Out off range exception hvis den er for Kort.
            b.Lsbn13 = "jeg er12lang";
        }
        [TestMethod]
        public void TestLsbnLigePræcis13Lang()
        {
            Bog b = new Bog();

            //Her testes for at tekst strengen gerne må være 13 lang.
            b.Lsbn13 = "jeg er 13lang";
        }
    }
}
