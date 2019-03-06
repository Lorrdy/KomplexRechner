using System;
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
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
                InputExpReal.Text = Convert.ToString(complex.Amount);
                InputExpImag.Text = Convert.ToString(complex.Angle);
            }

            if (GonioRadio.Checked)
            {
                complex.Amount = Convert.ToDouble(InputAmount.Text);
                complex.Angle = Convert.ToDouble(InputAngle.Text);

                complex.PolToKar();

                InputKarReal.Text = Convert.ToString(complex.Real);
                InputKarImag.Text = Convert.ToString(complex.Imag);
                InputExpReal.Text = Convert.ToString(complex.Amount);
                InputExpImag.Text = Convert.ToString(complex.Angle);
            }
        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            //int i, x, Anzahl;
            //string name, R, I, cell, cellzero;
            //bool match;
            //name = textBoxName.Text;
            //R = InputKarReal.Text;
            //I = InputKarImag.Text;
            //i = 0;
            //x = 1;
            //Anzahl = dataGridView1.RowCount;
            //cellzero = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
            //if (String.IsNullOrEmpty(name))
            //{
            //    if (String.IsNullOrEmpty(cellzero))
            //    {
            //        name= "z1";   
            //    }
            //    else
            //    {
            //        do
            //        {
            //            name = "z" + x;
            //            match = false;
            //            i = -1;
            //            do
            //            {
            //                i++;
            //                cell = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);

            //                if (cell == name)
            //                {
            //                    match = true;
            //                }

            //            } while (match == false && i < Anzahl-1);
            //            x++;
            //        } while (match == true );
            //    }

            //}
            //else
            //{
            //    if (String.IsNullOrEmpty(cellzero))
            //    {
            //    }
            //    else
            //    {
            //        match = false;
            //        i = -1;
            //        do
            //        {
            //            i++;
            //            cell = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
            //            if (cell == name)
            //            {
            //                match = true;
            //            }
            //            i++;
            //        } while (match == false && i == Anzahl-1);
            //        if (match == true)
            //        {
            //            MessageBox.Show("ID wird schon verwendet");
            //            return;
            //        }
            //    }
            //}
            //dataGridView1.Rows.Add(name, R, I);
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
            pos++;
            if ( pos > 2)
            {
                pos = 1;
            }
            
        }

        private void BTClear_Click(object sender, EventArgs e)
        {
            bool match=false;
            string ID, cell, cellzero;
            int i,Anzahl;
            ID=textBoxClear.Text;
            i = 0;
            Anzahl = dataGridView1.RowCount;
            cellzero = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
            if (String.IsNullOrEmpty(cellzero))
            {
                MessageBox.Show("Es gibt keinen Datensatz zum Löschen!");
                return;
            }
            do
            {
                cell = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                if (cell == ID)
                {
                    match = true;
                }
            } while (match == false|| i<Anzahl-1);
            if (match == false)
            {
                MessageBox.Show("Datensatz mit angegebener ID nicht vorhanden!");
                return;
            }
            else
            {
                dataGridView1.Rows.RemoveAt(i);
            }

        }

        private void BTCalculate_Click(object sender, EventArgs e)
        {
            string Oparation = comboBoxOperation.Text;
            switch (Oparation)
            {
                case "+":
                    complexresult = MathComplex.Add(complex1, complex2);
                    if (complexresult.Imag > 0)
                    {
                        labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
                    }
                    else
                    {
                        labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
                    }
                    break;
                case "-":
                    complexresult = MathComplex.Sub(complex1, complex2);
                    if (complexresult.Imag > 0)
                    {
                        labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
                    }
                    else
                    {
                        labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
                    }
                    break;
                case "*":
                    complexresult = MathComplex.Mul(complex1, complex2);
                    if (complexresult.Imag > 0)
                    {
                        labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
                    }
                    else
                    {
                        labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
                    }
                    break;
                case "/":
                    complexresult = MathComplex.Div(complex1, complex2);
                    if (complexresult.Imag > 0)
                    {
                        labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
                    }
                    else
                    {
                        labelreslut.Text = "Das Ergebniss der Rechenoperation lautet:" + Environment.NewLine + textBoxResultName.Text + " = " + complexresult.Real + " + i" + complexresult.Imag;
                    }
                    break;
                default:
                    MessageBox.Show("Es ist ein Fehler aufgetreten!");
                    break;

            }
        }

        private void BTConversion_Click(object sender, EventArgs e)
        {
            InputKarReal.Text = Convert.ToString(complexresult.Real);
            InputKarImag.Text = Convert.ToString(complexresult.Real);
            complexresult.KarToPol();
            InputAmount.Text = Convert.ToString(complexresult.Amount);
            InputAngle.Text = Convert.ToString(complexresult.Angle);
            InputExpReal.Text = Convert.ToString(complexresult.Amount);
            InputExpImag.Text = Convert.ToString(complexresult.Angle);

        }
    }
}
