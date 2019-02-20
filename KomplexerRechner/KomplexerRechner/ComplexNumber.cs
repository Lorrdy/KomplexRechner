using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexerRechner
{
    class ComplexNumber
    {
        private double kar_Real;
        private double kar_Imag;
        private double amount;
        private double angle;

        public double Kar_Real { get => kar_Real; set => kar_Real = value; }

        public double Kar_Imag { get => kar_Imag; set => kar_Imag = value; }

        public double Amount { get => amount; set => amount = value; }

        public double Angle { get => angle; set => angle = value; }

        public void KarToPol()
        {
            amount = Math.Sqrt(Math.Pow(kar_Real, 2) + Math.Pow(kar_Imag, 2));
            angle = Math.Atan(kar_Imag / kar_Real);
        }

        public void PolToKar()
        {
            kar_Real = amount * Math.Cos(angle);
            kar_Imag = amount * Math.Sin(angle);
        }
    }
}
