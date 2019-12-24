using System;
using System.Windows.Forms;
using ByznysVrstva;
using DTO.Tridy;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        private Zapis z = new Zapis();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttOdeberHrace_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textOdeberHrace.Text);
            z.SmazHrace(id);
            textOdeberHrace.Text = "";
        }

        private void buttPridejHrace_Click(object sender, EventArgs e)
        {
            string jmeno = textPridejHraceJmeno.Text;
            string prijmeni = textPridejHracePrijmeni.Text;
            int rok = Int32.Parse(textPridejHraceRok.Text);
            int cislo = Int32.Parse(textPridejHraceCislo.Text);
            string pozice = textPridejHracePozice.Text;
            int tym = Int32.Parse(textPridejHraceTym.Text);

            Tym t = new Tym()
            {
                TymId = tym
            };

            Hrac h = new Hrac()
            {
                Jmeno = jmeno,
                Prijmeni = prijmeni,
                CisloDresu = cislo,
                RokNarozeni = rok,
                Pozice = pozice,
                Tym = t
            };

            z.PridejHrace(h);

            textPridejHraceJmeno.Text = "";
            textPridejHracePrijmeni.Text = "";
            textPridejHraceRok.Text = "";
            textPridejHraceCislo.Text = "";
            textPridejHracePozice.Text = "";
            textPridejHraceTym.Text = "";
        }

        private void buttPridejZapas_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int domaci = Int32.Parse(textZapasDomaci.Text);
            int hoste = Int32.Parse(textZapasHoste.Text);
            int rozhodci = Int32.Parse(textZapasRozhoci.Text);
            string koment = textZapasKomentar.Text;

            Tym d = new Tym()
            {
                TymId = domaci
            };
            Tym h = new Tym()
            {
                TymId = hoste
            };
            Rozhodci r = new Rozhodci()
            {
                RozhodciId = rozhodci
            };
            Zapas zapas = new Zapas()
            {
                Datum = dateTime,
                Domaci = d,
                Hoste = h,
                Rozhodci = r,
                Komentar = koment
            };

            z.ZapisZapas(zapas);

            textZapasDomaci.Text = "";
            textZapasHoste.Text = "";
            textZapasKomentar.Text = "";
            textZapasRozhoci.Text = "";
        }

        private void buttTrest_Click(object sender, EventArgs e)
        {
            int hrac = Int32.Parse(textTestHrac.Text);
            int delka = Int32.Parse(textTestDelka.Text);
            string duvod = textTestDuvod.Text;

            Hrac h = new Hrac()
            {
                HracId = hrac
            };
            Trest t = new Trest()
            {
                Hrac = h,
                Delka = delka,
                Duvod = duvod
            };

            z.ZapisTrest(t);

            textTestHrac.Text = "";
            textTestDelka.Text = "";
            textTestDuvod.Text = "";
        }

        private void buttGol_Click(object sender, EventArgs e)
        {
            int hrac = Int32.Parse(textGolHrac.Text);

            Hrac h = new Hrac()
            {
                HracId = hrac
            };

            Gol g = new Gol()
            {
                Hrac = h
            };

            z.ZapisGol(g);

            textGolHrac.Text = "";
        }

        private void buttAssist_Click(object sender, EventArgs e)
        {
            int hrac = Int32.Parse(textAsistHrac.Text);

            Hrac h = new Hrac()
            {
                HracId = hrac
            };

            Asistence a = new Asistence()
            {
                Hrac = h
            };

            z.ZapisAsistenci(a);

            textAsistHrac.Text = "";
        }

        private void buttUlozit_Click(object sender, EventArgs e)
        {
            z.AktualizujZapas();
        }
    }
}
