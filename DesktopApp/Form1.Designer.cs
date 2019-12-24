namespace DesktopApp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rozdeleni = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttUlozit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttGol = new System.Windows.Forms.Button();
            this.textGolHrac = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttAssist = new System.Windows.Forms.Button();
            this.textAsistHrac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textTestDelka = new System.Windows.Forms.TextBox();
            this.textTestDuvod = new System.Windows.Forms.TextBox();
            this.textTestHrac = new System.Windows.Forms.TextBox();
            this.buttTrest = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttPridejZapas = new System.Windows.Forms.Button();
            this.textZapasKomentar = new System.Windows.Forms.TextBox();
            this.textZapasHoste = new System.Windows.Forms.TextBox();
            this.textZapasDomaci = new System.Windows.Forms.TextBox();
            this.textZapasRozhoci = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttOdeberHrace = new System.Windows.Forms.Button();
            this.textOdeberHrace = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttPridejHrace = new System.Windows.Forms.Button();
            this.textPridejHracePozice = new System.Windows.Forms.TextBox();
            this.textPridejHraceCislo = new System.Windows.Forms.TextBox();
            this.textPridejHraceRok = new System.Windows.Forms.TextBox();
            this.textPridejHracePrijmeni = new System.Windows.Forms.TextBox();
            this.textPridejHraceJmeno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPridejHraceTym = new System.Windows.Forms.TextBox();
            this.Rozdeleni.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rozdeleni
            // 
            this.Rozdeleni.Controls.Add(this.tabPage3);
            this.Rozdeleni.Controls.Add(this.tabPage4);
            this.Rozdeleni.Location = new System.Drawing.Point(13, 13);
            this.Rozdeleni.Name = "Rozdeleni";
            this.Rozdeleni.SelectedIndex = 0;
            this.Rozdeleni.Size = new System.Drawing.Size(610, 526);
            this.Rozdeleni.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttUlozit);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(602, 497);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Rozhodčí";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttUlozit
            // 
            this.buttUlozit.Location = new System.Drawing.Point(221, 421);
            this.buttUlozit.Name = "buttUlozit";
            this.buttUlozit.Size = new System.Drawing.Size(139, 71);
            this.buttUlozit.TabIndex = 17;
            this.buttUlozit.Text = "Ukončit zapisování do zápasu a uložit";
            this.buttUlozit.UseVisualStyleBackColor = true;
            this.buttUlozit.Click += new System.EventHandler(this.buttUlozit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttGol);
            this.groupBox4.Controls.Add(this.textGolHrac);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(6, 289);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 126);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Přidat gól";
            // 
            // buttGol
            // 
            this.buttGol.Location = new System.Drawing.Point(74, 80);
            this.buttGol.Name = "buttGol";
            this.buttGol.Size = new System.Drawing.Size(117, 32);
            this.buttGol.TabIndex = 15;
            this.buttGol.Text = "Přidat gól";
            this.buttGol.UseVisualStyleBackColor = true;
            this.buttGol.Click += new System.EventHandler(this.buttGol_Click);
            // 
            // textGolHrac
            // 
            this.textGolHrac.Location = new System.Drawing.Point(161, 36);
            this.textGolHrac.Name = "textGolHrac";
            this.textGolHrac.Size = new System.Drawing.Size(100, 22);
            this.textGolHrac.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID Hráče:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttAssist);
            this.groupBox3.Controls.Add(this.textAsistHrac);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(286, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Přidat asistenci";
            // 
            // buttAssist
            // 
            this.buttAssist.Location = new System.Drawing.Point(100, 80);
            this.buttAssist.Name = "buttAssist";
            this.buttAssist.Size = new System.Drawing.Size(117, 32);
            this.buttAssist.TabIndex = 15;
            this.buttAssist.Text = "Přidat asistenci";
            this.buttAssist.UseVisualStyleBackColor = true;
            this.buttAssist.Click += new System.EventHandler(this.buttAssist_Click);
            // 
            // textAsistHrac
            // 
            this.textAsistHrac.Location = new System.Drawing.Point(204, 36);
            this.textAsistHrac.Name = "textAsistHrac";
            this.textAsistHrac.Size = new System.Drawing.Size(100, 22);
            this.textAsistHrac.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID Hráče:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textTestDelka);
            this.groupBox2.Controls.Add(this.textTestDuvod);
            this.groupBox2.Controls.Add(this.textTestHrac);
            this.groupBox2.Controls.Add(this.buttTrest);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(286, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Přidat trest";
            // 
            // textTestDelka
            // 
            this.textTestDelka.Location = new System.Drawing.Point(204, 60);
            this.textTestDelka.Name = "textTestDelka";
            this.textTestDelka.Size = new System.Drawing.Size(100, 22);
            this.textTestDelka.TabIndex = 15;
            // 
            // textTestDuvod
            // 
            this.textTestDuvod.Location = new System.Drawing.Point(204, 94);
            this.textTestDuvod.Multiline = true;
            this.textTestDuvod.Name = "textTestDuvod";
            this.textTestDuvod.Size = new System.Drawing.Size(100, 22);
            this.textTestDuvod.TabIndex = 14;
            // 
            // textTestHrac
            // 
            this.textTestHrac.Location = new System.Drawing.Point(204, 25);
            this.textTestHrac.Name = "textTestHrac";
            this.textTestHrac.Size = new System.Drawing.Size(100, 22);
            this.textTestHrac.TabIndex = 12;
            // 
            // buttTrest
            // 
            this.buttTrest.Location = new System.Drawing.Point(100, 141);
            this.buttTrest.Name = "buttTrest";
            this.buttTrest.Size = new System.Drawing.Size(117, 32);
            this.buttTrest.TabIndex = 11;
            this.buttTrest.Text = "Přidat trest";
            this.buttTrest.UseVisualStyleBackColor = true;
            this.buttTrest.Click += new System.EventHandler(this.buttTrest_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Důvod vyloučení:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Délka trestu (min):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID Hráče:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttPridejZapas);
            this.groupBox1.Controls.Add(this.textZapasKomentar);
            this.groupBox1.Controls.Add(this.textZapasHoste);
            this.groupBox1.Controls.Add(this.textZapasDomaci);
            this.groupBox1.Controls.Add(this.textZapasRozhoci);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nový zápas";
            // 
            // buttPridejZapas
            // 
            this.buttPridejZapas.Location = new System.Drawing.Point(76, 232);
            this.buttPridejZapas.Name = "buttPridejZapas";
            this.buttPridejZapas.Size = new System.Drawing.Size(117, 32);
            this.buttPridejZapas.TabIndex = 10;
            this.buttPridejZapas.Text = "Přidat zápas";
            this.buttPridejZapas.UseVisualStyleBackColor = true;
            this.buttPridejZapas.Click += new System.EventHandler(this.buttPridejZapas_Click);
            // 
            // textZapasKomentar
            // 
            this.textZapasKomentar.Location = new System.Drawing.Point(163, 148);
            this.textZapasKomentar.Multiline = true;
            this.textZapasKomentar.Name = "textZapasKomentar";
            this.textZapasKomentar.Size = new System.Drawing.Size(100, 78);
            this.textZapasKomentar.TabIndex = 9;
            // 
            // textZapasHoste
            // 
            this.textZapasHoste.Location = new System.Drawing.Point(163, 109);
            this.textZapasHoste.Name = "textZapasHoste";
            this.textZapasHoste.Size = new System.Drawing.Size(100, 22);
            this.textZapasHoste.TabIndex = 8;
            // 
            // textZapasDomaci
            // 
            this.textZapasDomaci.Location = new System.Drawing.Point(163, 67);
            this.textZapasDomaci.Name = "textZapasDomaci";
            this.textZapasDomaci.Size = new System.Drawing.Size(100, 22);
            this.textZapasDomaci.TabIndex = 7;
            // 
            // textZapasRozhoci
            // 
            this.textZapasRozhoci.Location = new System.Drawing.Point(163, 28);
            this.textZapasRozhoci.Name = "textZapasRozhoci";
            this.textZapasRozhoci.Size = new System.Drawing.Size(100, 22);
            this.textZapasRozhoci.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Komentář:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID týmu hostů:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID týmu domácích:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Rozhodčího:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(602, 497);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Trenér";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttOdeberHrace);
            this.groupBox6.Controls.Add(this.textOdeberHrace);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(286, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(310, 126);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Odebrání hráče";
            // 
            // buttOdeberHrace
            // 
            this.buttOdeberHrace.Location = new System.Drawing.Point(100, 80);
            this.buttOdeberHrace.Name = "buttOdeberHrace";
            this.buttOdeberHrace.Size = new System.Drawing.Size(117, 32);
            this.buttOdeberHrace.TabIndex = 15;
            this.buttOdeberHrace.Text = "Odebrat hráče";
            this.buttOdeberHrace.UseVisualStyleBackColor = true;
            this.buttOdeberHrace.Click += new System.EventHandler(this.buttOdeberHrace_Click);
            // 
            // textOdeberHrace
            // 
            this.textOdeberHrace.Location = new System.Drawing.Point(204, 36);
            this.textOdeberHrace.Name = "textOdeberHrace";
            this.textOdeberHrace.Size = new System.Drawing.Size(100, 22);
            this.textOdeberHrace.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "ID Hráče:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textPridejHraceTym);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.buttPridejHrace);
            this.groupBox5.Controls.Add(this.textPridejHracePozice);
            this.groupBox5.Controls.Add(this.textPridejHraceCislo);
            this.groupBox5.Controls.Add(this.textPridejHraceRok);
            this.groupBox5.Controls.Add(this.textPridejHracePrijmeni);
            this.groupBox5.Controls.Add(this.textPridejHraceJmeno);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(7, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 316);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Přidání hráče";
            // 
            // buttPridejHrace
            // 
            this.buttPridejHrace.Location = new System.Drawing.Point(68, 263);
            this.buttPridejHrace.Name = "buttPridejHrace";
            this.buttPridejHrace.Size = new System.Drawing.Size(117, 32);
            this.buttPridejHrace.TabIndex = 12;
            this.buttPridejHrace.Text = "Přidat hráče";
            this.buttPridejHrace.UseVisualStyleBackColor = true;
            this.buttPridejHrace.Click += new System.EventHandler(this.buttPridejHrace_Click);
            // 
            // textPridejHracePozice
            // 
            this.textPridejHracePozice.Location = new System.Drawing.Point(153, 174);
            this.textPridejHracePozice.Name = "textPridejHracePozice";
            this.textPridejHracePozice.Size = new System.Drawing.Size(100, 22);
            this.textPridejHracePozice.TabIndex = 9;
            // 
            // textPridejHraceCislo
            // 
            this.textPridejHraceCislo.Location = new System.Drawing.Point(153, 140);
            this.textPridejHraceCislo.Name = "textPridejHraceCislo";
            this.textPridejHraceCislo.Size = new System.Drawing.Size(100, 22);
            this.textPridejHraceCislo.TabIndex = 8;
            // 
            // textPridejHraceRok
            // 
            this.textPridejHraceRok.Location = new System.Drawing.Point(153, 102);
            this.textPridejHraceRok.Name = "textPridejHraceRok";
            this.textPridejHraceRok.Size = new System.Drawing.Size(100, 22);
            this.textPridejHraceRok.TabIndex = 7;
            // 
            // textPridejHracePrijmeni
            // 
            this.textPridejHracePrijmeni.Location = new System.Drawing.Point(153, 68);
            this.textPridejHracePrijmeni.Name = "textPridejHracePrijmeni";
            this.textPridejHracePrijmeni.Size = new System.Drawing.Size(100, 22);
            this.textPridejHracePrijmeni.TabIndex = 6;
            // 
            // textPridejHraceJmeno
            // 
            this.textPridejHraceJmeno.Location = new System.Drawing.Point(153, 32);
            this.textPridejHraceJmeno.Name = "textPridejHraceJmeno";
            this.textPridejHraceJmeno.Size = new System.Drawing.Size(100, 22);
            this.textPridejHraceJmeno.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Pozice:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Číslo dresu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Rok narození:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Příjmení:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tým:";
            // 
            // textPridejHraceTym
            // 
            this.textPridejHraceTym.Location = new System.Drawing.Point(153, 208);
            this.textPridejHraceTym.Name = "textPridejHraceTym";
            this.textPridejHraceTym.Size = new System.Drawing.Size(100, 22);
            this.textPridejHraceTym.TabIndex = 14;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(635, 550);
            this.Controls.Add(this.Rozdeleni);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Rozdeleni.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl Rozdeleni;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttPridejZapas;
        private System.Windows.Forms.TextBox textZapasKomentar;
        private System.Windows.Forms.TextBox textZapasHoste;
        private System.Windows.Forms.TextBox textZapasDomaci;
        private System.Windows.Forms.TextBox textZapasRozhoci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttGol;
        private System.Windows.Forms.TextBox textGolHrac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttAssist;
        private System.Windows.Forms.TextBox textAsistHrac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textTestDuvod;
        private System.Windows.Forms.TextBox textTestHrac;
        private System.Windows.Forms.Button buttTrest;
        private System.Windows.Forms.Button buttUlozit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttOdeberHrace;
        private System.Windows.Forms.TextBox textOdeberHrace;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttPridejHrace;
        private System.Windows.Forms.TextBox textPridejHracePozice;
        private System.Windows.Forms.TextBox textPridejHraceCislo;
        private System.Windows.Forms.TextBox textPridejHraceRok;
        private System.Windows.Forms.TextBox textPridejHracePrijmeni;
        private System.Windows.Forms.TextBox textPridejHraceJmeno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textTestDelka;
        private System.Windows.Forms.TextBox textPridejHraceTym;
        private System.Windows.Forms.Label label2;
    }
}

