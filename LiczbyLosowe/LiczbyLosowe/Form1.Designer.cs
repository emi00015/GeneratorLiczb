
namespace LiczbyLosowe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMin = new System.Windows.Forms.TextBox();
            this.textMax = new System.Windows.Forms.TextBox();
            this.textIle = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonPowtorzenia = new System.Windows.Forms.Button();
            this.buttonNie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.losujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.losujNiepowtarzalneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zakres losowanych liczb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(43, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(43, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maksimum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(43, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ilość liczb do wylosowania";
            // 
            // textMin
            // 
            this.textMin.Location = new System.Drawing.Point(221, 95);
            this.textMin.Name = "textMin";
            this.textMin.Size = new System.Drawing.Size(100, 22);
            this.textMin.TabIndex = 4;
            // 
            // textMax
            // 
            this.textMax.Location = new System.Drawing.Point(221, 127);
            this.textMax.Name = "textMax";
            this.textMax.Size = new System.Drawing.Size(100, 22);
            this.textMax.TabIndex = 5;
            // 
            // textIle
            // 
            this.textIle.Location = new System.Drawing.Point(126, 233);
            this.textIle.Name = "textIle";
            this.textIle.Size = new System.Drawing.Size(109, 22);
            this.textIle.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(464, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(202, 170);
            this.textBox1.TabIndex = 7;
            // 
            // buttonPowtorzenia
            // 
            this.buttonPowtorzenia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPowtorzenia.Location = new System.Drawing.Point(126, 310);
            this.buttonPowtorzenia.Name = "buttonPowtorzenia";
            this.buttonPowtorzenia.Size = new System.Drawing.Size(109, 46);
            this.buttonPowtorzenia.TabIndex = 8;
            this.buttonPowtorzenia.Text = "Losuj";
            this.buttonPowtorzenia.UseVisualStyleBackColor = false;
            this.buttonPowtorzenia.Click += new System.EventHandler(this.buttonPowtorzenia_Click);
            // 
            // buttonNie
            // 
            this.buttonNie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNie.Location = new System.Drawing.Point(499, 310);
            this.buttonNie.Name = "buttonNie";
            this.buttonNie.Size = new System.Drawing.Size(109, 46);
            this.buttonNie.TabIndex = 9;
            this.buttonNie.Text = "Losuj";
            this.buttonNie.UseVisualStyleBackColor = false;
            this.buttonNie.Click += new System.EventHandler(this.buttonNie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(44, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Losuj tak, aby liczby mogły się powtarzać";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(424, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Losuj tak, aby liczby się NIE powtarzały";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Czyść";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(459, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Wylosowane liczby:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacjeToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacjeToolStripMenuItem
            // 
            this.operacjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.losujToolStripMenuItem,
            this.losujNiepowtarzalneToolStripMenuItem,
            this.czyśćToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.operacjeToolStripMenuItem.Name = "operacjeToolStripMenuItem";
            this.operacjeToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.operacjeToolStripMenuItem.Text = "&Operacje";
            this.operacjeToolStripMenuItem.Click += new System.EventHandler(this.operacjeToolStripMenuItem_Click);
            // 
            // losujToolStripMenuItem
            // 
            this.losujToolStripMenuItem.Name = "losujToolStripMenuItem";
            this.losujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.losujToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.losujToolStripMenuItem.Text = "Losuj";
            this.losujToolStripMenuItem.Click += new System.EventHandler(this.buttonPowtorzenia_Click);
            // 
            // losujNiepowtarzalneToolStripMenuItem
            // 
            this.losujNiepowtarzalneToolStripMenuItem.Name = "losujNiepowtarzalneToolStripMenuItem";
            this.losujNiepowtarzalneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.losujNiepowtarzalneToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.losujNiepowtarzalneToolStripMenuItem.Text = "Losuj niepowtarzalne";
            this.losujNiepowtarzalneToolStripMenuItem.Click += new System.EventHandler(this.buttonNie_Click);
            // 
            // czyśćToolStripMenuItem
            // 
            this.czyśćToolStripMenuItem.Name = "czyśćToolStripMenuItem";
            this.czyśćToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.czyśćToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.czyśćToolStripMenuItem.Text = "Czyść";
            this.czyśćToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomocToolStripMenuItem.Text = "&Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonNie);
            this.Controls.Add(this.buttonPowtorzenia);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textIle);
            this.Controls.Add(this.textMax);
            this.Controls.Add(this.textMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Generator liczby";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMin;
        private System.Windows.Forms.TextBox textMax;
        private System.Windows.Forms.TextBox textIle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPowtorzenia;
        private System.Windows.Forms.Button buttonNie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem losujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem losujNiepowtarzalneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
    }
}

