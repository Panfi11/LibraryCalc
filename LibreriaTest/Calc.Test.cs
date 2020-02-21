using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCalc;

namespace LibreriaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomma()
        {
            double num2 = 2;
            double num1 = 4;
            double ris = 6;
            double somma = calc.Somma(num1, num2);
            Assert.AreEqual(ris, somma);
        }
            [TestMethod]
        public void Testdivisione()
        {
            double num2 = 2;
            double num1 = 12;
            double ris = 6;
            double somma = calc.divisione(num1, num2);
            Assert.AreEqual(ris, somma);
        }

        [DataTestMethod]
        [DataRow(1,3,4)]
        [DataRow(1, 6, 7)]
        [DataRow(1, 0, 1)]
        [DataRow(-1, -7, -8)] 
        public void TestSommaGenerico (double a , double b , double ris)
        {
            double somma = calc.Somma(a, b);
            Assert.AreEqual(ris, somma);
        }
    }

}
