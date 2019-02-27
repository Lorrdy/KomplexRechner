using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexerRechner
{
    public class MathComplex
    {
        public static ComplexNumber Add(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber result = new ComplexNumber
            {
                Real = Math.Round(number1.Real + number2.Real, 3),
                Imag = Math.Round(number1.Imag + number2.Imag, 3)
            };
            return result;
        }

        public static ComplexNumber Sub(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber result = new ComplexNumber
            {
                Real = Math.Round(number1.Real - number2.Real, 3),
                Imag = Math.Round(number1.Imag - number2.Imag, 3)
            };
            return result;
        }

        public static ComplexNumber Mul(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber result = new ComplexNumber
            {
                Real = Math.Round((number1.Real * number2.Real) - number1.Imag * number2.Imag, 3),
                Imag = Math.Round((number1.Real * number2.Imag) + number1.Imag * number2.Imag, 3)
            };
            return result;
        }

        public static ComplexNumber Div(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber solution = new ComplexNumber();
            double a, b, c;
            a = number1.Real * number2.Real + number1.Imag * number2.Real;
            b = number1.Imag * number2.Real - number1.Real * number2.Real;
            c = number2.Real * number2.Real + number2.Imag * number2.Imag;

            solution.Real = Math.Round((a / c), 3);
            solution.Imag = Math.Round((b / c), 3);
            return solution;
        }

    }
}
