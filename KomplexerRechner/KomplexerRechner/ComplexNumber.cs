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
        private double exp_Real;
        private double exp_Imag;
        private double amount;
        private double angle;

        public double Kar_Real { get => kar_Real; set => kar_Real = value; }

        public double Kar_Imag { get => kar_Imag; set => kar_Imag = value; }

        public double Exp_Real { get => exp_Real; set => exp_Real = value; }

        public double Exp_Imag { get => exp_Imag; set => exp_Imag = value; }

        public double Amount { get => amount; set => amount = value; }

        public double Angle { get => angle; set => angle = value; }

        public void KarToPol()
        {

        }

        public void KarToExp()
        {
            //Falsche Sache (Form nicht Funktion!)
            //exp_Real = Math.Pow(Math.E, kar_Real) * Math.Cos(kar_Imag);
            //exp_Imag = Math.Pow(Math.E, kar_Real) * Math.Sin(kar_Imag);
        }

        public void PolToKar()
        {

        }

        public void PolToExp()
        {

        }

        public void ExpToKar()
        {
            
        }

        public void ExpToPol()
        {

        }
    }
}
