
namespace OGRP__Okienkowy_Generator_Rozkazów_Pisemnych
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumerPociągu = new System.Windows.Forms.Label();
            this.NumerPociąguTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WynikTxt = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Rozkaz = new System.Windows.Forms.Label();
            this.Działki = new System.Windows.Forms.Label();
            this.Działka1Lb = new System.Windows.Forms.CheckBox();
            this.Działka1Txt = new System.Windows.Forms.TextBox();
            this.Działka2Lb = new System.Windows.Forms.CheckBox();
            this.Działka3Lb = new System.Windows.Forms.CheckBox();
            this.Działka4Lb = new System.Windows.Forms.CheckBox();
            this.RozkazS = new System.Windows.Forms.RadioButton();
            this.RozkazO = new System.Windows.Forms.RadioButton();
            this.RozkazN = new System.Windows.Forms.RadioButton();
            this.NumerRozkazuTxt = new System.Windows.Forms.TextBox();
            this.Działka2Txt = new System.Windows.Forms.TextBox();
            this.Działka3Txt = new System.Windows.Forms.TextBox();
            this.Działka4Txt = new System.Windows.Forms.TextBox();
            this.Konfiguruj_działka1 = new System.Windows.Forms.Button();
            this.Konfiguruj_działka2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumerPociągu
            // 
            this.NumerPociągu.AutoSize = true;
            this.NumerPociągu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumerPociągu.Location = new System.Drawing.Point(22, 227);
            this.NumerPociągu.Name = "NumerPociągu";
            this.NumerPociągu.Size = new System.Drawing.Size(107, 17);
            this.NumerPociągu.TabIndex = 0;
            this.NumerPociągu.Text = "Numer Pociągu:";
            // 
            // NumerPociąguTxt
            // 
            this.NumerPociąguTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumerPociąguTxt.Location = new System.Drawing.Point(45, 247);
            this.NumerPociąguTxt.MaxLength = 6;
            this.NumerPociąguTxt.Name = "NumerPociąguTxt";
            this.NumerPociąguTxt.Size = new System.Drawing.Size(52, 22);
            this.NumerPociąguTxt.TabIndex = 1;
            this.NumerPociąguTxt.TextChanged += new System.EventHandler(this.Numer_Pociągu_txt);
            this.NumerPociąguTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numer_Pociągu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "OKIENKOWY GENERATOR ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(545, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "ROZKAZÓW PISEMNYCH";
            // 
            // WynikTxt
            // 
            this.WynikTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.WynikTxt.Location = new System.Drawing.Point(487, 192);
            this.WynikTxt.Multiline = true;
            this.WynikTxt.Name = "WynikTxt";
            this.WynikTxt.ReadOnly = true;
            this.WynikTxt.Size = new System.Drawing.Size(301, 306);
            this.WynikTxt.TabIndex = 4;
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wynik.Location = new System.Drawing.Point(610, 165);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(55, 17);
            this.Wynik.TabIndex = 5;
            this.Wynik.Text = "WYNIK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numer Rozkazu:";
            // 
            // Rozkaz
            // 
            this.Rozkaz.AutoSize = true;
            this.Rozkaz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rozkaz.Location = new System.Drawing.Point(45, 343);
            this.Rozkaz.Name = "Rozkaz";
            this.Rozkaz.Size = new System.Drawing.Size(54, 17);
            this.Rozkaz.TabIndex = 8;
            this.Rozkaz.Text = "Rozkaz:";
            // 
            // Działki
            // 
            this.Działki.AutoSize = true;
            this.Działki.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Działki.Location = new System.Drawing.Point(277, 145);
            this.Działki.Name = "Działki";
            this.Działki.Size = new System.Drawing.Size(54, 17);
            this.Działki.TabIndex = 11;
            this.Działki.Text = "Działki:";
            // 
            // Działka1Lb
            // 
            this.Działka1Lb.AutoSize = true;
            this.Działka1Lb.Location = new System.Drawing.Point(170, 170);
            this.Działka1Lb.Name = "Działka1Lb";
            this.Działka1Lb.Size = new System.Drawing.Size(72, 19);
            this.Działka1Lb.TabIndex = 12;
            this.Działka1Lb.Text = "Działka:1";
            this.Działka1Lb.UseVisualStyleBackColor = true;
            // 
            // Działka1Txt
            // 
            this.Działka1Txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Działka1Txt.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Działka1Txt.Location = new System.Drawing.Point(170, 192);
            this.Działka1Txt.Multiline = true;
            this.Działka1Txt.Name = "Działka1Txt";
            this.Działka1Txt.ReadOnly = true;
            this.Działka1Txt.Size = new System.Drawing.Size(281, 55);
            this.Działka1Txt.TabIndex = 13;
            // 
            // Działka2Lb
            // 
            this.Działka2Lb.AutoSize = true;
            this.Działka2Lb.Location = new System.Drawing.Point(170, 258);
            this.Działka2Lb.Name = "Działka2Lb";
            this.Działka2Lb.Size = new System.Drawing.Size(72, 19);
            this.Działka2Lb.TabIndex = 14;
            this.Działka2Lb.Text = "Działka:2";
            this.Działka2Lb.UseVisualStyleBackColor = true;
            // 
            // Działka3Lb
            // 
            this.Działka3Lb.AutoSize = true;
            this.Działka3Lb.Location = new System.Drawing.Point(170, 344);
            this.Działka3Lb.Name = "Działka3Lb";
            this.Działka3Lb.Size = new System.Drawing.Size(72, 19);
            this.Działka3Lb.TabIndex = 16;
            this.Działka3Lb.Text = "Działka:3";
            this.Działka3Lb.UseVisualStyleBackColor = true;
            // 
            // Działka4Lb
            // 
            this.Działka4Lb.AutoSize = true;
            this.Działka4Lb.Location = new System.Drawing.Point(170, 425);
            this.Działka4Lb.Name = "Działka4Lb";
            this.Działka4Lb.Size = new System.Drawing.Size(72, 19);
            this.Działka4Lb.TabIndex = 18;
            this.Działka4Lb.Text = "Działka:4";
            this.Działka4Lb.UseVisualStyleBackColor = true;
            // 
            // RozkazS
            // 
            this.RozkazS.AutoSize = true;
            this.RozkazS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RozkazS.Location = new System.Drawing.Point(55, 363);
            this.RozkazS.Name = "RozkazS";
            this.RozkazS.Size = new System.Drawing.Size(32, 19);
            this.RozkazS.TabIndex = 23;
            this.RozkazS.TabStop = true;
            this.RozkazS.Text = "S";
            this.RozkazS.UseVisualStyleBackColor = true;
            this.RozkazS.Click += new System.EventHandler(this.Rozkaz_SClick);
            // 
            // RozkazO
            // 
            this.RozkazO.AutoSize = true;
            this.RozkazO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RozkazO.Location = new System.Drawing.Point(55, 388);
            this.RozkazO.Name = "RozkazO";
            this.RozkazO.Size = new System.Drawing.Size(34, 19);
            this.RozkazO.TabIndex = 24;
            this.RozkazO.TabStop = true;
            this.RozkazO.Text = "O";
            this.RozkazO.UseVisualStyleBackColor = true;
            this.RozkazO.Click += new System.EventHandler(this.Rozkaz_OClick);
            // 
            // RozkazN
            // 
            this.RozkazN.AutoSize = true;
            this.RozkazN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RozkazN.Location = new System.Drawing.Point(55, 413);
            this.RozkazN.Name = "RozkazN";
            this.RozkazN.Size = new System.Drawing.Size(34, 19);
            this.RozkazN.TabIndex = 25;
            this.RozkazN.TabStop = true;
            this.RozkazN.Text = "N";
            this.RozkazN.UseVisualStyleBackColor = true;
            this.RozkazN.Click += new System.EventHandler(this.Rozkaz_NClick);
            // 
            // NumerRozkazuTxt
            // 
            this.NumerRozkazuTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumerRozkazuTxt.Location = new System.Drawing.Point(45, 308);
            this.NumerRozkazuTxt.MaxLength = 6;
            this.NumerRozkazuTxt.Name = "NumerRozkazuTxt";
            this.NumerRozkazuTxt.Size = new System.Drawing.Size(52, 22);
            this.NumerRozkazuTxt.TabIndex = 26;
            this.NumerRozkazuTxt.TextChanged += new System.EventHandler(this.Numer_Rozkazu_txt);
            this.NumerRozkazuTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numer_Rozkazu_KeyPress);
            // 
            // Działka2Txt
            // 
            this.Działka2Txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Działka2Txt.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Działka2Txt.Location = new System.Drawing.Point(170, 278);
            this.Działka2Txt.Multiline = true;
            this.Działka2Txt.Name = "Działka2Txt";
            this.Działka2Txt.ReadOnly = true;
            this.Działka2Txt.Size = new System.Drawing.Size(281, 55);
            this.Działka2Txt.TabIndex = 27;
            // 
            // Działka3Txt
            // 
            this.Działka3Txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Działka3Txt.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Działka3Txt.Location = new System.Drawing.Point(170, 362);
            this.Działka3Txt.Multiline = true;
            this.Działka3Txt.Name = "Działka3Txt";
            this.Działka3Txt.ReadOnly = true;
            this.Działka3Txt.Size = new System.Drawing.Size(281, 52);
            this.Działka3Txt.TabIndex = 28;
            // 
            // Działka4Txt
            // 
            this.Działka4Txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.Działka4Txt.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Działka4Txt.Location = new System.Drawing.Point(170, 445);
            this.Działka4Txt.Multiline = true;
            this.Działka4Txt.Name = "Działka4Txt";
            this.Działka4Txt.ReadOnly = true;
            this.Działka4Txt.Size = new System.Drawing.Size(281, 53);
            this.Działka4Txt.TabIndex = 29;
            // 
            // Konfiguruj_działka1
            // 
            this.Konfiguruj_działka1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Konfiguruj_działka1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Konfiguruj_działka1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Konfiguruj_działka1.Location = new System.Drawing.Point(324, 165);
            this.Konfiguruj_działka1.Name = "Konfiguruj_działka1";
            this.Konfiguruj_działka1.Size = new System.Drawing.Size(127, 24);
            this.Konfiguruj_działka1.TabIndex = 30;
            this.Konfiguruj_działka1.Text = "Konfiguruj";
            this.Konfiguruj_działka1.UseVisualStyleBackColor = false;
            // 
            // Konfiguruj_działka2
            // 
            this.Konfiguruj_działka2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Konfiguruj_działka2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Konfiguruj_działka2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Konfiguruj_działka2.Location = new System.Drawing.Point(324, 253);
            this.Konfiguruj_działka2.Name = "Konfiguruj_działka2";
            this.Konfiguruj_działka2.Size = new System.Drawing.Size(127, 24);
            this.Konfiguruj_działka2.TabIndex = 31;
            this.Konfiguruj_działka2.Text = "Konfiguruj";
            this.Konfiguruj_działka2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(324, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 24);
            this.button1.TabIndex = 32;
            this.button1.Text = "Konfiguruj";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(324, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 24);
            this.button2.TabIndex = 33;
            this.button2.Text = "Konfiguruj";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(812, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Konfiguruj_działka2);
            this.Controls.Add(this.Konfiguruj_działka1);
            this.Controls.Add(this.Działka4Txt);
            this.Controls.Add(this.Działka3Txt);
            this.Controls.Add(this.Działka2Txt);
            this.Controls.Add(this.NumerRozkazuTxt);
            this.Controls.Add(this.RozkazN);
            this.Controls.Add(this.RozkazO);
            this.Controls.Add(this.RozkazS);
            this.Controls.Add(this.Działka4Lb);
            this.Controls.Add(this.Działka3Lb);
            this.Controls.Add(this.Działka2Lb);
            this.Controls.Add(this.Działka1Txt);
            this.Controls.Add(this.Działka1Lb);
            this.Controls.Add(this.Działki);
            this.Controls.Add(this.Rozkaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.WynikTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumerPociąguTxt);
            this.Controls.Add(this.NumerPociągu);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OGRP- Okienkowy Generator Rozkazów Pisemnych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumerPociągu;
        private System.Windows.Forms.TextBox NumerPociąguTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WynikTxt;
        private System.Windows.Forms.Label Wynik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Rozkaz;
        private System.Windows.Forms.Label Działki;
        private System.Windows.Forms.CheckBox Działka1Lb;
        private System.Windows.Forms.TextBox Działka1Txt;
        private System.Windows.Forms.CheckBox Działka2Lb;
        private System.Windows.Forms.CheckBox Działka3Lb;
        private System.Windows.Forms.CheckBox Działka4Lb;
        private System.Windows.Forms.RadioButton RozkazS;
        private System.Windows.Forms.RadioButton RozkazO;
        private System.Windows.Forms.RadioButton RozkazN;
        private System.Windows.Forms.TextBox NumerRozkazuTxt;
        private System.Windows.Forms.TextBox Działka2Txt;
        private System.Windows.Forms.TextBox Działka3Txt;
        private System.Windows.Forms.TextBox Działka4Txt;
        private System.Windows.Forms.Button Konfiguruj_działka1;
        private System.Windows.Forms.Button Konfiguruj_działka2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

