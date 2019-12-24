using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Tridy;
using DatabaseConnection.Tabulky;

namespace ByznysVrstva
{
    public class Zapis
    {
        public void AktualizujZapas(int a = -1)
        {
            ZapasyTable zapasyTable = new ZapasyTable();
            GolyTable golyTable = new GolyTable();
            HraciTable hraciTable = new HraciTable();
            List<Zapas> zapasy = zapasyTable.Select();
            List<Gol> goly = golyTable.Select();
            List<Hrac> hraci = hraciTable.Select();
            Zapas zapas = new Zapas();
            Hrac hrac = new Hrac();
            int posledni, golyDomaci = 0, golyHoste = 0;

            if (a == -1)
            {
                posledni = zapasyTable.PosledniZapas();
            }
            else
            {
                posledni = a;
            }

            for (int i = 0; i < zapasy.Count; i++)
            {
                if (zapasy[i].ZapasId == posledni)
                {
                    zapas = zapasy[i];
                    break;
                }
            }

            for (int i = 0; i < goly.Count; i++)
            {
                if (goly[i].Zapas.ZapasId == zapas.ZapasId)
                {
                    for (int j = 0; j < hraci.Count; j++)
                    {
                        if (goly[i].Hrac.HracId == hraci[j].HracId)
                        {
                            hrac = hraci[j];
                        }
                    }

                    if (hrac.Tym.TymId == zapas.Domaci.TymId)
                    {
                        golyDomaci++;
                    }
                    else
                    {
                        golyHoste++;
                    }
                }
            }

            //Console.WriteLine("Update zapasu " + posledni + " " + golyDomaci + " " + golyHoste);

            zapasyTable.Update(posledni, golyDomaci, golyHoste);
            AktualizujGolyTymu(zapas);
            CheckHattrick(zapas);
        }

        public void ZapisZapas(Zapas z)
        {
            ZapasyTable zapasyTable = new ZapasyTable();

            zapasyTable.Insert(z);
        }

        public void ZapisTrest(Trest t)
        {
            HraciTable ht = new HraciTable();
            TrestyTable tt = new TrestyTable();
            List<Hrac> hraci = ht.Select();
            List<Trest> tresty = tt.Select();

            for (int i = 0; i < hraci.Count; i++)
            {
                if (t.Hrac.HracId == hraci[i].HracId)
                {
                    hraci[i].TrestneMinuty += t.Delka;
                    ht.Update(t.Hrac.HracId, hraci[i].TrestneMinuty);
                    tt.Insert(t);
                    break;
                }
            }
        }

        public void ZapisGol(Gol g)
        {
            GolyTable golyTable = new GolyTable();

            golyTable.Insert(g);
        }

        public void ZapisAsistenci(Asistence a)
        {
            AsistenceTable asistenceTable = new AsistenceTable();
            asistenceTable.Insert(a);
        }

        public void AktualizujGolyTymu(Zapas zapas)
        {
            TymyTable tymyTable = new TymyTable();
            List<Tym> tymy = tymyTable.Select();
            Tym domaci = new Tym();
            Tym hoste = new Tym();

            if (zapas.GolyDomaci > zapas.GolyHoste)
            {
                for (int i = 0; i < tymy.Count; i++)
                {
                    if (tymy[i].TymId == zapas.Domaci.TymId)
                    {
                        tymy[i].PocetVyher += 1;
                        domaci = tymy[i];
                    }
                    else if (tymy[i].TymId == zapas.Hoste.TymId)
                    {
                        tymy[i].PocetProher += 1;
                        hoste = tymy[i];
                    }
                }
            }
            else if (zapas.GolyDomaci == zapas.GolyHoste)
            {
                for (int i = 0; i < tymy.Count; i++)
                {
                    if (tymy[i].TymId == zapas.Domaci.TymId)
                    {
                        tymy[i].PocetRemiz += 1;
                        domaci = tymy[i];
                    }
                    else if (tymy[i].TymId == zapas.Hoste.TymId)
                    {
                        tymy[i].PocetRemiz += 1;
                        hoste = tymy[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < tymy.Count; i++)
                {
                    if (tymy[i].TymId == zapas.Domaci.TymId)
                    {
                        tymy[i].PocetProher += 1;
                        domaci = tymy[i];
                    }
                    else if (tymy[i].TymId == zapas.Hoste.TymId)
                    {
                        tymy[i].PocetVyher += 1;
                        hoste = tymy[i];
                    }
                }
            }

            tymyTable.Update(domaci);
            tymyTable.Update(hoste);
        }

        public void CheckHattrick(Zapas zapas)
        {
            GolyTable golyTable = new GolyTable();
            HattrickTable hattrickTable = new HattrickTable();
            List<Gol> goly = golyTable.Select();
            var slovnik = new Dictionary<int, int>();

            for (int i = 0; i < goly.Count; i++)
            {
                if (goly[i].Zapas.ZapasId == zapas.ZapasId)
                {
                    if (slovnik.ContainsKey(goly[i].Hrac.HracId))
                    {
                        slovnik[goly[i].Hrac.HracId] += 1;
                    }
                    else
                    {
                        slovnik.Add(goly[i].Hrac.HracId, 1);
                    }
                }
            }

            for (int i = 0; i < slovnik.Count; i++)
            {
                if (slovnik[slovnik.Keys.ElementAt(i)] > 2)
                {
                    hattrickTable.Insert(slovnik.Keys.ElementAt(i), zapas.Datum);

                }
            }

        }

        public void SmazHrace(int id)
        {
            HraciTable hraciTable = new HraciTable();
            ByvaliHraciTable byvaliHraciTable = new ByvaliHraciTable();
            List<Hrac> hraci = hraciTable.Select();
            Hrac h = new Hrac();

            for (int i = 0; i < hraci.Count; i++)
            {
                if (hraci[i].HracId == id)
                {
                    h = hraci[i];
                    break;
                }
            }

            ByvalyHrac byvalyHrac = new ByvalyHrac
            {
                Jmeno = h.Jmeno,
                Prijmeni = h.Prijmeni,
                CisloDresu = h.CisloDresu,
                Pozice = h.Pozice,
                RokNarozeni = h.RokNarozeni,
                Datum = DateTime.Now
            };

            hraciTable.Delete(h.HracId);
            byvaliHraciTable.Insert(byvalyHrac);
        }

        public void PridejHrace(Hrac h)
        {
            HraciTable hraciTable = new HraciTable();
            hraciTable.Insert(h);
        }

    }
}
