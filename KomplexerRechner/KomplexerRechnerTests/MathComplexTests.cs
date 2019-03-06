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
        [DataTestMethod]
        [DataRow(2.0, 4.6, 1.2, 4.4, 3.2, 9.0)]
        [DataRow(1, 2, 3, 4, 4, 6)]
        [DataRow(12, 4, -4.2, 1.5, 7.8, 5.5)]
        public void AddTest(double number1Real, double number1Imag, double number2Real, double number2Imag, double soulutionReal, double solutionImag)
        {
            ComplexNumber number1 = new ComplexNumber(number1Real, number1Imag);
            ComplexNumber number2 = new ComplexNumber(number2Real, number2Imag);
            ComplexNumber solution = MathComplex.Add(number1, number2);

            Assert.AreEqual(soulutionReal, solution.Real);
            Assert.AreEqual(solutionImag, solution.Imag);
        }

        [DataTestMethod]
        [DataRow(2.0, 4.6, 1.2, 4.4, 0.8, 0.2)]
        [DataRow(1, 2, 3, 4, -2, -2)]
        [DataRow(12, 4, -4.2, 1.5, 16.2, 2.5)]
        public void SubTest(double number1Real, double number1Imag, double number2Real, double number2Imag, double soulutionReal, double solutionImag)
        {
            ComplexNumber number1 = new ComplexNumber(number1Real, number1Imag);
            ComplexNumber number2 = new ComplexNumber(number2Real, number2Imag);
            ComplexNumber solution = MathComplex.Sub(number1, number2);

            Assert.AreEqual(soulutionReal, solution.Real);
            Assert.AreEqual(solutionImag, solution.Imag);
        }

        [DataTestMethod]
        [DataRow(2.0, 4.6, 1.2, 4.4, 11.2, 25.76)]
        [DataRow(1, 2, 3, 4, -5, 10)]
        [DataRow(12, 4, -4.2, 1.5, -56.2, 1.2)]
        public void MulTest(double number1Real, double number1Imag, double number2Real, double number2Imag, double soulutionReal, double solutionImag)
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

        [DataTestMethod]
        [DataRow(2.0, 4.6, 1.2, 4.4, 5.0/14, 23.0/28)]
        [DataRow(1, 2, 3, 4, 11.0 / 25, 2.0 / 25)]
        [DataRow(12, 4, -4.2, 1.5, 1480.0 / 663, 1160.0 / 663)]
        public void DivTest(double number1Real, double number1Imag, double number2Real, double number2Imag, double soulutionReal, double solutionImag)
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

            Assert.AreEqual(Math.Round(  18.0 / 85.0, 3), solution.Real);
            Assert.AreEqual(Math.Round( 149.0 / 85.0, 3), solution.Imag);
        }
    }
}