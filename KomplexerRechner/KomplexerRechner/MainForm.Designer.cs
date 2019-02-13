namespace KomplexerRechner
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.KartRadio = new System.Windows.Forms.RadioButton();
            this.GonioRadio = new System.Windows.Forms.RadioButton();
            this.ExponRadio = new System.Windows.Forms.RadioButton();
            this.InputReal = new System.Windows.Forms.TextBox();
            this.InputImag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GonioPanel = new System.Windows.Forms.Panel();
            this.InputWinkel = new System.Windows.Forms.TextBox();
            this.InputBetrag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExponPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KartPanel = new System.Windows.Forms.Panel();
            this.Btn_DoMath = new System.Windows.Forms.Button();
            this.GonioPanel.SuspendLayout();
            this.ExponPanel.SuspendLayout();
            this.KartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KartRadio
            // 
            this.KartRadio.AutoSize = true;
            this.KartRadio.Location = new System.Drawing.Point(12, 18);
            this.KartRadio.Name = "KartRadio";
            this.KartRadio.Size = new System.Drawing.Size(106, 17);
            this.KartRadio.TabIndex = 0;
            this.KartRadio.TabStop = true;
            this.KartRadio.Text = "Kartesische Form";
            this.KartRadio.UseVisualStyleBackColor = true;
            this.KartRadio.CheckedChanged += new System.EventHandler(this.KartRadio_CheckedChanged);
            // 
            // GonioRadio
            // 
            this.GonioRadio.AutoSize = true;
            this.GonioRadio.Location = new System.Drawing.Point(12, 51);
            this.GonioRadio.Name = "GonioRadio";
            this.GonioRadio.Size = new System.Drawing.Size(124, 17);
            this.GonioRadio.TabIndex = 1;
            this.GonioRadio.TabStop = true;
            this.GonioRadio.Text = "Goniometrische Form";
            this.GonioRadio.UseVisualStyleBackColor = true;
            this.GonioRadio.CheckedChanged += new System.EventHandler(this.GonioRadio_CheckedChanged);
            // 
            // ExponRadio
            // 
            this.ExponRadio.AutoSize = true;
            this.ExponRadio.Location = new System.Drawing.Point(12, 84);
            this.ExponRadio.Name = "ExponRadio";
            this.ExponRadio.Size = new System.Drawing.Size(100, 17);
            this.ExponRadio.TabIndex = 2;
            this.ExponRadio.TabStop = true;
            this.ExponRadio.Text = "Exponentialform";
            this.ExponRadio.UseVisualStyleBackColor = true;
            this.ExponRadio.CheckedChanged += new System.EventHandler(this.ExponRadio_CheckedChanged);
            // 
            // InputReal
            // 
            this.InputReal.Location = new System.Drawing.Point(35, 3);
            this.InputReal.Name = "InputReal";
            this.InputReal.Size = new System.Drawing.Size(140, 20);
            this.InputReal.TabIndex = 3;
            this.InputReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // InputImag
            // 
            this.InputImag.Location = new System.Drawing.Point(205, 3);
            this.InputImag.Name = "InputImag";
            this.InputImag.Size = new System.Drawing.Size(140, 20);
            this.InputImag.TabIndex = 4;
            this.InputImag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "z =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "+ i";
            // 
            // GonioPanel
            // 
            this.GonioPanel.Controls.Add(this.InputWinkel);
            this.GonioPanel.Controls.Add(this.InputBetrag);
            this.GonioPanel.Controls.Add(this.label6);
            this.GonioPanel.Controls.Add(this.label5);
            this.GonioPanel.Enabled = false;
            this.GonioPanel.Location = new System.Drawing.Point(142, 45);
            this.GonioPanel.Name = "GonioPanel";
            this.GonioPanel.Size = new System.Drawing.Size(348, 27);
            this.GonioPanel.TabIndex = 7;
            // 
            // InputWinkel
            // 
            this.InputWinkel.Location = new System.Drawing.Point(205, 3);
            this.InputWinkel.Name = "InputWinkel";
            this.InputWinkel.Size = new System.Drawing.Size(140, 20);
            this.InputWinkel.TabIndex = 8;
            this.InputWinkel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // InputBetrag
            // 
            this.InputBetrag.Location = new System.Drawing.Point(35, 3);
            this.InputBetrag.Name = "InputBetrag";
            this.InputBetrag.Size = new System.Drawing.Size(140, 20);
            this.InputBetrag.TabIndex = 7;
            this.InputBetrag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "φ =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "r =";
            // 
            // ExponPanel
            // 
            this.ExponPanel.Controls.Add(this.textBox1);
            this.ExponPanel.Controls.Add(this.textBox2);
            this.ExponPanel.Controls.Add(this.label3);
            this.ExponPanel.Controls.Add(this.label4);
            this.ExponPanel.Enabled = false;
            this.ExponPanel.Location = new System.Drawing.Point(142, 78);
            this.ExponPanel.Name = "ExponPanel";
            this.ExponPanel.Size = new System.Drawing.Size(348, 27);
            this.ExponPanel.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "e^z =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "+ i";
            // 
            // KartPanel
            // 
            this.KartPanel.Controls.Add(this.InputImag);
            this.KartPanel.Controls.Add(this.InputReal);
            this.KartPanel.Controls.Add(this.label1);
            this.KartPanel.Controls.Add(this.label2);
            this.KartPanel.Location = new System.Drawing.Point(142, 12);
            this.KartPanel.Name = "KartPanel";
            this.KartPanel.Size = new System.Drawing.Size(348, 27);
            this.KartPanel.TabIndex = 9;
            // 
            // Btn_DoMath
            // 
            this.Btn_DoMath.Location = new System.Drawing.Point(415, 111);
            this.Btn_DoMath.Name = "Btn_DoMath";
            this.Btn_DoMath.Size = new System.Drawing.Size(75, 23);
            this.Btn_DoMath.TabIndex = 10;
            this.Btn_DoMath.Text = "Berechnen";
            this.Btn_DoMath.UseVisualStyleBackColor = true;
            this.Btn_DoMath.Click += new System.EventHandler(this.Btn_DoMath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.Btn_DoMath);
            this.Controls.Add(this.KartPanel);
            this.Controls.Add(this.ExponPanel);
            this.Controls.Add(this.GonioPanel);
            this.Controls.Add(this.ExponRadio);
            this.Controls.Add(this.GonioRadio);
            this.Controls.Add(this.KartRadio);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GonioPanel.ResumeLayout(false);
            this.GonioPanel.PerformLayout();
            this.ExponPanel.ResumeLayout(false);
            this.ExponPanel.PerformLayout();
            this.KartPanel.ResumeLayout(false);
            this.KartPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton KartRadio;
        private System.Windows.Forms.RadioButton GonioRadio;
        private System.Windows.Forms.RadioButton ExponRadio;
        private System.Windows.Forms.TextBox InputReal;
        private System.Windows.Forms.TextBox InputImag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel GonioPanel;
        private System.Windows.Forms.Panel ExponPanel;
        private System.Windows.Forms.Panel KartPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputWinkel;
        private System.Windows.Forms.TextBox InputBetrag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_DoMath;
    }
}

