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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void KartRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RB = sender as RadioButton;
            if(RB.Checked)
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

        }

        private void BTSave_Click(object sender, EventArgs e)
        {
            
            string name, R, I;
            name = textBoxName.Text;
            R = InputKarReal.Text;
            I = InputKarImag.Text;
            dataGridView1.Rows.Add(name, R, I);
        }
    }
}
