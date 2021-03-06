﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomplexerRechner
{
    public partial class MainForm : Form
    {
        ComplexNumber complex = new ComplexNumber();
        ComplexNumber complex1 = new ComplexNumber();
        ComplexNumber complex2 = new ComplexNumber();
        ComplexNumber complexresult = new ComplexNumber();
        int pos = 1;


        public MainForm()
        {
            InitializeComponent();

            
        }

        private void KartRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RB = sender as RadioButton;
            if (RB.Checked)
            {
                KartPanel.Enabled = true;
            }
            else
            {
                KartPanel.Enabled = false;
            }
        }

        private void GonioRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RB = sender as RadioButton;
            if (RB.Checked)
            {
                GonioPanel.Enabled = true;
            }
            else
            {
                GonioPanel.Enabled = false;
            }
        }

        private void ExponRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RB = sender as RadioButton;
            if (RB.Checked)
            {
                ExponPanel.Enabled = true;
            }
            else
            {
                ExponPanel.Enabled = false;
            }
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void Btn_DoMath_Click(object sender, EventArgs e)
        {
            if (KartRadio.Checked)
            {
                complex.Real = Convert.ToDouble(InputKarReal.Text);
                complex.Imag = Convert.ToDouble(InputKarImag.Text);

                complex.KarToPol();

                InputAmount.Text = Convert.ToString(complex.Amount);
                InputAngle.Text = Convert.ToString(complex.Angle);
                InputAmount2.Text = Convert.ToString(complex.Amount);
                InputAngle2.Text = Convert.ToString(complex.Angle);
            }

            if (GonioRadio.Checked)
            {
                complex.Amount = Convert.ToDouble(InputAmount.Text);
                complex.Angle = Convert.ToDouble(InputAngle.Text);

                complex.PolToKar();

                InputKarReal.Text = Convert.ToString(complex.Real);
                InputKarImag.Text = Convert.ToString(complex.Imag);
                InputAmount2.Text = Convert.ToString(complex.Amount);
                InputAngle2.Text = Convert.ToString(complex.Angle);
            }

            if (ExponRadio.Checked)
            {
                complex.Amount = Convert.ToDouble(InputAmount2.Text);
                complex.Angle = Convert.ToDouble(InputAngle2.Text);

                complex.PolToKar();

                InputKarReal.Text = Convert.ToString(complex.Real);
                InputKarImag.Text = Convert.ToString(complex.Imag);
                InputAmount.Text = Convert.ToString(complex.Amount);
                InputAngle.Text = Convert.ToString(complex.Angle);
            }
        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text == "")
            {
                textBoxName.Text = "z" + pos;
            }
            if (pos == 1)
            {
                complex1.Real = Convert.ToDouble(InputKarReal.Text);
                complex1.Imag = Convert.ToDouble(InputKarImag.Text);
                textBoxOpNr1.Text = textBoxName.Text;
            }
            if (pos == 2)
            {
                complex2.Real = Convert.ToDouble(InputKarReal.Text);
                complex2.Imag = Convert.ToDouble(InputKarImag.Text);
                textBoxOpNr2.Text = textBoxName.Text;
            }
            textBoxName.Text = "";
            pos++;
            if ( pos > 2)
            {
                pos = 1;
            }
            
        }

        private void BTCalculate_Click(object sender, EventArgs e)
        {
            if(textBoxResultName.Text == "")
            {
                textBoxResultName.Text = "Z0";
            }
            string Oparation = comboBoxOperation.Text;
            IArithmetic arithmetic = new IArithmetic();
            
            switch (Oparation)
            {
                case "+":
                    complexresult = ComplexNumber.Add(complex1, complex2);
                    break;
                case "-":
                    complexresult = ComplexNumber.Sub(complex1, complex2);
                    break;
                case "*":
                    complexresult = ComplexNumber.Mul(complex1, complex2);
                    break;
                case "/":
                    complexresult = ComplexNumber.Div(complex1, complex2);
                    break;
                default:
                    MessageBox.Show("Es ist ein Fehler aufgetreten!");
                    break;
            }
            if (complexresult.Imag > 0)
            {
                labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
            }
            else
            {
                labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
            }
        }

        private void BTConversion_Click(object sender, EventArgs e)
        {
            InputKarReal.Text = Convert.ToString(complexresult.Real);
            InputKarImag.Text = Convert.ToString(complexresult.Real);
            complexresult.KarToPol();
            InputAmount.Text = Convert.ToString(complexresult.Amount);
            InputAngle.Text = Convert.ToString(complexresult.Angle);
            InputAmount2.Text = Convert.ToString(complexresult.Amount);
            InputAngle2.Text = Convert.ToString(complexresult.Angle);

        }
    }
}
