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
            this.InputKarReal = new System.Windows.Forms.TextBox();
            this.InputKarImag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GonioPanel = new System.Windows.Forms.Panel();
            this.InputAngle = new System.Windows.Forms.TextBox();
            this.InputAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExponPanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.InputExpImag = new System.Windows.Forms.TextBox();
            this.InputExpReal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KartPanel = new System.Windows.Forms.Panel();
            this.Btn_DoMath = new System.Windows.Forms.Button();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxResultName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOpNr1 = new System.Windows.Forms.TextBox();
            this.textBoxOpNr2 = new System.Windows.Forms.TextBox();
            this.BTSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTConversion = new System.Windows.Forms.Button();
            this.BTCalculate = new System.Windows.Forms.Button();
            this.labelreslut = new System.Windows.Forms.Label();
            this.labelEXfrm = new System.Windows.Forms.Label();
            this.GonioPanel.SuspendLayout();
            this.ExponPanel.SuspendLayout();
            this.KartPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.GonioRadio.Size = new System.Drawing.Size(75, 17);
            this.GonioRadio.TabIndex = 1;
            this.GonioRadio.TabStop = true;
            this.GonioRadio.Text = "Polar Form";
            this.GonioRadio.UseVisualStyleBackColor = true;
            this.GonioRadio.CheckedChanged += new System.EventHandler(this.GonioRadio_CheckedChanged);
            // 
            // InputKarReal
            // 
            this.InputKarReal.Location = new System.Drawing.Point(35, 3);
            this.InputKarReal.Name = "InputKarReal";
            this.InputKarReal.Size = new System.Drawing.Size(140, 20);
            this.InputKarReal.TabIndex = 3;
            this.InputKarReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // InputKarImag
            // 
            this.InputKarImag.Location = new System.Drawing.Point(205, 3);
            this.InputKarImag.Name = "InputKarImag";
            this.InputKarImag.Size = new System.Drawing.Size(140, 20);
            this.InputKarImag.TabIndex = 4;
            this.InputKarImag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
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
            this.GonioPanel.Controls.Add(this.InputAngle);
            this.GonioPanel.Controls.Add(this.InputAmount);
            this.GonioPanel.Controls.Add(this.label6);
            this.GonioPanel.Controls.Add(this.label5);
            this.GonioPanel.Enabled = false;
            this.GonioPanel.Location = new System.Drawing.Point(142, 45);
            this.GonioPanel.Name = "GonioPanel";
            this.GonioPanel.Size = new System.Drawing.Size(348, 27);
            this.GonioPanel.TabIndex = 7;
            // 
            // InputAngle
            // 
            this.InputAngle.Location = new System.Drawing.Point(205, 3);
            this.InputAngle.Name = "InputAngle";
            this.InputAngle.Size = new System.Drawing.Size(140, 20);
            this.InputAngle.TabIndex = 8;
            this.InputAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // InputAmount
            // 
            this.InputAmount.Location = new System.Drawing.Point(35, 3);
            this.InputAmount.Name = "InputAmount";
            this.InputAmount.Size = new System.Drawing.Size(140, 20);
            this.InputAmount.TabIndex = 7;
            this.InputAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
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
            this.ExponPanel.Controls.Add(this.label12);
            this.ExponPanel.Controls.Add(this.InputExpImag);
            this.ExponPanel.Controls.Add(this.InputExpReal);
            this.ExponPanel.Controls.Add(this.label3);
            this.ExponPanel.Controls.Add(this.label4);
            this.ExponPanel.Enabled = false;
            this.ExponPanel.Location = new System.Drawing.Point(142, 78);
            this.ExponPanel.Name = "ExponPanel";
            this.ExponPanel.Size = new System.Drawing.Size(348, 57);
            this.ExponPanel.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "*φ";
            // 
            // InputExpImag
            // 
            this.InputExpImag.Location = new System.Drawing.Point(184, 6);
            this.InputExpImag.Name = "InputExpImag";
            this.InputExpImag.Size = new System.Drawing.Size(44, 20);
            this.InputExpImag.TabIndex = 8;
            this.InputExpImag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // InputExpReal
            // 
            this.InputExpReal.Location = new System.Drawing.Point(27, 23);
            this.InputExpReal.Name = "InputExpReal";
            this.InputExpReal.Size = new System.Drawing.Size(140, 20);
            this.InputExpReal.TabIndex = 7;
            this.InputExpReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "z=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "+e";
            // 
            // KartPanel
            // 
            this.KartPanel.Controls.Add(this.InputKarImag);
            this.KartPanel.Controls.Add(this.InputKarReal);
            this.KartPanel.Controls.Add(this.label1);
            this.KartPanel.Controls.Add(this.label2);
            this.KartPanel.Location = new System.Drawing.Point(142, 12);
            this.KartPanel.Name = "KartPanel";
            this.KartPanel.Size = new System.Drawing.Size(348, 27);
            this.KartPanel.TabIndex = 9;
            // 
            // Btn_DoMath
            // 
            this.Btn_DoMath.Location = new System.Drawing.Point(416, 141);
            this.Btn_DoMath.Name = "Btn_DoMath";
            this.Btn_DoMath.Size = new System.Drawing.Size(75, 23);
            this.Btn_DoMath.TabIndex = 10;
            this.Btn_DoMath.Text = "Berechnen";
            this.Btn_DoMath.UseVisualStyleBackColor = true;
            this.Btn_DoMath.Click += new System.EventHandler(this.Btn_DoMath_Click);
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperation.Location = new System.Drawing.Point(52, 37);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(23, 21);
            this.comboBoxOperation.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxResultName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxOpNr1);
            this.panel1.Controls.Add(this.textBoxOpNr2);
            this.panel1.Controls.Add(this.comboBoxOperation);
            this.panel1.Location = new System.Drawing.Point(20, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 70);
            this.panel1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "↓";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ErgebnissID";
            // 
            // textBoxResultName
            // 
            this.textBoxResultName.Location = new System.Drawing.Point(130, 37);
            this.textBoxResultName.Name = "textBoxResultName";
            this.textBoxResultName.Size = new System.Drawing.Size(30, 20);
            this.textBoxResultName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "=";
            // 
            // textBoxOpNr1
            // 
            this.textBoxOpNr1.Location = new System.Drawing.Point(14, 38);
            this.textBoxOpNr1.Name = "textBoxOpNr1";
            this.textBoxOpNr1.Size = new System.Drawing.Size(30, 20);
            this.textBoxOpNr1.TabIndex = 15;
            // 
            // textBoxOpNr2
            // 
            this.textBoxOpNr2.Location = new System.Drawing.Point(81, 38);
            this.textBoxOpNr2.Name = "textBoxOpNr2";
            this.textBoxOpNr2.Size = new System.Drawing.Size(25, 20);
            this.textBoxOpNr2.TabIndex = 14;
            // 
            // BTSave
            // 
            this.BTSave.Location = new System.Drawing.Point(335, 141);
            this.BTSave.Name = "BTSave";
            this.BTSave.Size = new System.Drawing.Size(75, 23);
            this.BTSave.TabIndex = 15;
            this.BTSave.Text = "Speichern";
            this.BTSave.UseVisualStyleBackColor = true;
            this.BTSave.Click += new System.EventHandler(this.BTSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(229, 144);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID:";
            // 
            // BTConversion
            // 
            this.BTConversion.Location = new System.Drawing.Point(326, 414);
            this.BTConversion.Name = "BTConversion";
            this.BTConversion.Size = new System.Drawing.Size(128, 23);
            this.BTConversion.TabIndex = 19;
            this.BTConversion.Text = "Ergebnis umrechnung";
            this.BTConversion.UseVisualStyleBackColor = true;
            this.BTConversion.Click += new System.EventHandler(this.BTConversion_Click);
            // 
            // BTCalculate
            // 
            this.BTCalculate.Location = new System.Drawing.Point(328, 443);
            this.BTCalculate.Name = "BTCalculate";
            this.BTCalculate.Size = new System.Drawing.Size(126, 23);
            this.BTCalculate.TabIndex = 24;
            this.BTCalculate.Text = "Ergebnis berechnen";
            this.BTCalculate.UseVisualStyleBackColor = true;
            this.BTCalculate.Click += new System.EventHandler(this.BTCalculate_Click);
            // 
            // labelreslut
            // 
            this.labelreslut.AutoSize = true;
            this.labelreslut.Location = new System.Drawing.Point(38, 182);
            this.labelreslut.Name = "labelreslut";
            this.labelreslut.Size = new System.Drawing.Size(0, 13);
            this.labelreslut.TabIndex = 25;
            // 
            // labelEXfrm
            // 
            this.labelEXfrm.AutoSize = true;
            this.labelEXfrm.Location = new System.Drawing.Point(12, 84);
            this.labelEXfrm.Name = "labelEXfrm";
            this.labelEXfrm.Size = new System.Drawing.Size(82, 13);
            this.labelEXfrm.TabIndex = 26;
            this.labelEXfrm.Text = "Exponentialform";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 658);
            this.Controls.Add(this.labelEXfrm);
            this.Controls.Add(this.labelreslut);
            this.Controls.Add(this.BTCalculate);
            this.Controls.Add(this.BTConversion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.BTSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_DoMath);
            this.Controls.Add(this.KartPanel);
            this.Controls.Add(this.ExponPanel);
            this.Controls.Add(this.GonioPanel);
            this.Controls.Add(this.GonioRadio);
            this.Controls.Add(this.KartRadio);
            this.Name = "MainForm";
            this.Text = "Rechner Komplexe Zahlen";
            this.GonioPanel.ResumeLayout(false);
            this.GonioPanel.PerformLayout();
            this.ExponPanel.ResumeLayout(false);
            this.ExponPanel.PerformLayout();
            this.KartPanel.ResumeLayout(false);
            this.KartPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton KartRadio;
        private System.Windows.Forms.RadioButton GonioRadio;
        private System.Windows.Forms.TextBox InputKarReal;
        private System.Windows.Forms.TextBox InputKarImag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel GonioPanel;
        private System.Windows.Forms.Panel ExponPanel;
        private System.Windows.Forms.Panel KartPanel;
        private System.Windows.Forms.TextBox InputExpImag;
        private System.Windows.Forms.TextBox InputExpReal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputAngle;
        private System.Windows.Forms.TextBox InputAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_DoMath;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxResultName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOpNr1;
        private System.Windows.Forms.TextBox textBoxOpNr2;
        private System.Windows.Forms.Button BTSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTConversion;
        private System.Windows.Forms.Button BTCalculate;
        private System.Windows.Forms.Label labelreslut;
        private System.Windows.Forms.Label labelEXfrm;
        private System.Windows.Forms.Label label12;
    }
}

