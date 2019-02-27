using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexerRechner
{
    public class ComplexNumber
    {
        private double real;
        private double imag;
        private double amount;
        private double angle;

        public double Real { get => real; set => real = value; }

        public double Imag { get => imag; set => imag = value; }

        public double Amount { get => amount; set => amount = value; }

        public double Angle { get => angle; set => angle = value; }

        public void KarToPol()
        {
            amount = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imag, 2));
            angle = Math.Atan(imag / real);
        }

        public void PolToKar()
        {
            real = amount * Math.Cos(angle);
            imag = amount * Math.Sin(angle);
        }
    }
}
