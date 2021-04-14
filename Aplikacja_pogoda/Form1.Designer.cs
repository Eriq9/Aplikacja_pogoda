
namespace Aplikacja_pogoda
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Temp_akt = new System.Windows.Forms.TextBox();
            this.Aktualna_pogoda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Temp_con = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Data = new System.Windows.Forms.TextBox();
            this.Data_convert = new System.Windows.Forms.TextBox();
            this.Historyczna_pogoda = new System.Windows.Forms.Button();
            this.pomocniczy = new System.Windows.Forms.TextBox();
            this.Temp_hist = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Temp_con2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.baza_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Temp_akt
            // 
            this.Temp_akt.AccessibleName = "Temperatura";
            this.Temp_akt.Location = new System.Drawing.Point(388, 74);
            this.Temp_akt.Multiline = true;
            this.Temp_akt.Name = "Temp_akt";
            this.Temp_akt.Size = new System.Drawing.Size(100, 104);
            this.Temp_akt.TabIndex = 0;
            this.Temp_akt.Tag = "";
            // 
            // Aktualna_pogoda
            // 
            this.Aktualna_pogoda.Location = new System.Drawing.Point(665, 74);
            this.Aktualna_pogoda.Name = "Aktualna_pogoda";
            this.Aktualna_pogoda.Size = new System.Drawing.Size(84, 38);
            this.Aktualna_pogoda.TabIndex = 1;
            this.Aktualna_pogoda.Text = "Aktualna pogoda\r\n";
            this.Aktualna_pogoda.UseVisualStyleBackColor = true;
            this.Aktualna_pogoda.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura [K]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Wrocław",
            "Londyn",
            "Moskwa",
            "Amsterdam"});
            this.comboBox1.Location = new System.Drawing.Point(18, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Temp_con
            // 
            this.Temp_con.Location = new System.Drawing.Point(511, 75);
            this.Temp_con.Name = "Temp_con";
            this.Temp_con.Size = new System.Drawing.Size(100, 20);
            this.Temp_con.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperatura [C]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista miast ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciśnienie [hPa]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wiatr [m/s]";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 104);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(39, 311);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(100, 20);
            this.Data.TabIndex = 10;
            // 
            // Data_convert
            // 
            this.Data_convert.Location = new System.Drawing.Point(158, 311);
            this.Data_convert.Name = "Data_convert";
            this.Data_convert.Size = new System.Drawing.Size(100, 20);
            this.Data_convert.TabIndex = 11;
            // 
            // Historyczna_pogoda
            // 
            this.Historyczna_pogoda.Location = new System.Drawing.Point(681, 278);
            this.Historyczna_pogoda.Name = "Historyczna_pogoda";
            this.Historyczna_pogoda.Size = new System.Drawing.Size(84, 38);
            this.Historyczna_pogoda.TabIndex = 12;
            this.Historyczna_pogoda.Text = "Historyczna pogoda";
            this.Historyczna_pogoda.UseVisualStyleBackColor = true;
            this.Historyczna_pogoda.Click += new System.EventHandler(this.Historyczna_pogoda_Click);
            // 
            // pomocniczy
            // 
            this.pomocniczy.Location = new System.Drawing.Point(39, 378);
            this.pomocniczy.Name = "pomocniczy";
            this.pomocniczy.Size = new System.Drawing.Size(752, 20);
            this.pomocniczy.TabIndex = 13;
            // 
            // Temp_hist
            // 
            this.Temp_hist.Location = new System.Drawing.Point(388, 200);
            this.Temp_hist.Multiline = true;
            this.Temp_hist.Name = "Temp_hist";
            this.Temp_hist.Size = new System.Drawing.Size(100, 104);
            this.Temp_hist.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Wiatr [m/s]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ciśnienie [hPa]";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Temperatura [K]";
            // 
            // Temp_con2
            // 
            this.Temp_con2.Location = new System.Drawing.Point(511, 200);
            this.Temp_con2.Name = "Temp_con2";
            this.Temp_con2.Size = new System.Drawing.Size(100, 20);
            this.Temp_con2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Unix Timestamp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(508, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Temperatura [C]";
            // 
            // baza_text
            // 
            this.baza_text.Location = new System.Drawing.Point(511, 132);
            this.baza_text.Name = "baza_text";
            this.baza_text.Size = new System.Drawing.Size(277, 20);
            this.baza_text.TabIndex = 22;
            this.baza_text.TextChanged += new System.EventHandler(this.baza_text_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baza_text);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Temp_con2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Temp_hist);
            this.Controls.Add(this.pomocniczy);
            this.Controls.Add(this.Historyczna_pogoda);
            this.Controls.Add(this.Data_convert);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Temp_con);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aktualna_pogoda);
            this.Controls.Add(this.Temp_akt);
            this.Name = "Form1";
            this.Tag = "Temperatura";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Temp_akt;
        private System.Windows.Forms.Button Aktualna_pogoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Temp_con;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.TextBox Data_convert;
        private System.Windows.Forms.Button Historyczna_pogoda;
        private System.Windows.Forms.TextBox pomocniczy;
        private System.Windows.Forms.TextBox Temp_hist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Temp_con2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox baza_text;
    }
}

