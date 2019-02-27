using Microsoft.VisualStudio.TestTools.UnitTesting;
using KomplexerRechner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexerRechner.Tests
{
    [TestClass()]
    public class ComplexTests
    {
        [TestMethod()]
        public void AddTest()
        {
            ComplexNumber number1 = new ComplexNumber
            {
                Real = 2,
                Imag = 4.6
            };

            ComplexNumber number2 = new ComplexNumber
            {
                Real = 1.2,
                Imag = 4.4
            };

            ComplexNumber solution = MathComplex.Add(number1, number2);

            Assert.AreEqual(3.2, solution.Real);
            Assert.AreEqual(9.0, solution.Imag);
        }

        [TestMethod()]
        public void SubTest()
        {
            ComplexNumber number1 = new ComplexNumber
            {
                Real = 2,
                Imag = 4.6
            };

            ComplexNumber number2 = new ComplexNumber
            {
                Real = 1.2,
                Imag = 4.4
            };

            ComplexNumber solution = MathComplex.Sub(number1, number2);

            Assert.AreEqual(0.8, solution.Real);
            Assert.AreEqual(0.2, solution.Imag);
        }

        [TestMethod()]
        public void MulTest()
        {
            ComplexNumber number1 = new ComplexNumber
            {
                Real = 2,
                Imag = 2.5
            };

            ComplexNumber number2 = new ComplexNumber
            {
                Real = 3.2,
                Imag = 3
            };

            ComplexNumber solution = MathComplex.Mul(number1, number2);

            Assert.AreEqual(-1.1, solution.Real);
            Assert.AreEqual(14.0, solution.Imag);
        }

        [TestMethod()]
        public void DivTest()
        {
            ComplexNumber number1 = new ComplexNumber
            {
                Real = 2.4,
                Imag = 2.2
            };

            ComplexNumber number2 = new ComplexNumber
            {
                Real = 1.4,
                Imag = -1.2
            };

            ComplexNumber solution = MathComplex.Div(number1, number2);

            Assert.AreEqual(Math.Round( 18.0 / 85.0, 3), solution.Real);
            Assert.AreEqual(Math.Round(149.0 / 85.0, 3), solution.Imag);
        }
        //(2.4+2.2i)/(1.4-1.2i) = (18/85)+(149/85)*1i

    }
}