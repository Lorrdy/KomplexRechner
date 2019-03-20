using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexerRechner
{
    public class ComplexNumber : IArithmetic<ComplexNumber>
    {
        private double real;
        private double imag;
        private double amount;
        private double angle;

        public ComplexNumber()
        {
        }

        public ComplexNumber(double realPart, double imagPart)
        {
            real = realPart;
            imag = imagPart;
        }

        public double Real { get => real; set => real = value; }

        public double Imag { get => imag; set => imag = value; }

        public double Amount { get => amount; set => amount = value; }

        public double Angle { get => angle; set => angle = value; }

        //Kartetisch zu Polar
        public void KarToPol()
        {
            amount = Math.Round(Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imag, 2)),3);
            angle = Math.Round(Math.Atan(imag / real),3);
        }

        //Polar zu Kartetisch
        public void PolToKar()
        {
            real = Math.Round(amount * Math.Cos(angle),3);
            imag = Math.Round(amount * Math.Sin(angle),3);
        }

        //Addieren
        public ComplexNumber Add(ComplexNumber number1)
        {
            ComplexNumber result = new ComplexNumber
            {
                Real = Math.Round(number1.Real + this.Real, 3),
                Imag = Math.Round(number1.Imag + this.Imag, 3)
            };
            return result;
        }
        //Addieren
        public static ComplexNumber Add(ComplexNumber number1, ComplexNumber number2)
        {            
            return number1.Add(number2);
        }

        //Subtrahieren
        public static ComplexNumber Sub(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber result = new ComplexNumber
            {
                Real = Math.Round(number1.Real - number2.Real, 3),
                Imag = Math.Round(number1.Imag - number2.Imag, 3)
            };
            return result;
        }

        //Multiplizieren
        public static ComplexNumber Mul(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber result = new ComplexNumber
            {
                Real = Math.Round((number1.Real * number2.Real) - number1.Imag * number2.Imag, 3),
                Imag = Math.Round((number1.Real * number2.Imag) + number1.Imag * number2.Real, 3)
            };
            return result;
        }

        //Dividieren
        public static ComplexNumber Div(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber solution = new ComplexNumber();
            double a, b, c;
            a = (number1.Real * number2.Real) + (number1.Imag * number2.Imag);
            b = (number1.Imag * number2.Real) - (number1.Real * number2.Imag);
            c = (number2.Real * number2.Real) + (number2.Imag * number2.Imag);

            solution.Real = Math.Round((a / c), 3);
            solution.Imag = Math.Round((b / c), 3);
            return solution;
        }
    }
}
