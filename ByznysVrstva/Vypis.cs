using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Tridy;
using DatabaseConnection.Tabulky;

namespace ByznysVrstva
{
    public class Vypis
    {
        public List<Tym> StavSouteze()
        {
            TymyTable t = new TymyTable();
            List<Tym> data = t.Select();

            for (int i = 0; i < data.Count; i++)
            {
                data[i].Body = data[i].PocetVyher * 3 + data[i].PocetRemiz;
            }

            data = data.OrderByDescending(x => x.Body).ThenBy(x => x.PocetVyher).ToList();

            return data;
        }

        public List<Hrac> Kanada()
        {
            HraciTable hraciTable = new HraciTable();
            GolyTable golyTable = new GolyTable();
            AsistenceTable asistenceTable = new AsistenceTable();

            List<Hrac> hraci = hraciTable.Select();
            List<Gol> goly = golyTable.Select();
            List<Asistence> asistence = asistenceTable.Select();

            for (int i = 0; i < hraci.Count; i++)
            {
                int countG = 0;
                int countA = 0;
                for (int j = 0; j < goly.Count; j++)
                {
                    if (goly[j].Hrac.HracId == hraci[i].HracId)
                    {
                        countG++;
                    }
                }

                for (int j = 0; j < asistence.Count; j++)
                {
                    if (asistence[j].Hrac.HracId == hraci[i].HracId)
                    {
                        countA++;
                    }
                }

                hraci[i].Body = countG + countA;
                hraci[i].Goly = countG;
                hraci[i].Asistence = countA;
            }

            return hraci.OrderByDescending(x => x.Body).ThenByDescending(x => x.Goly).ToList();
        }

        public List<Tym> GolyTymy()
        {
            TymyTable tt = new TymyTable();
            ZapasyTable zt = new ZapasyTable();
            List<Tym> tymy = tt.Select();
            List<Zapas> zapasy = zt.Select();

            for (int i = 0; i < tymy.Count; i++)
            {
                int goly = 0;
                for (int j = 0; j < zapasy.Count; j++)
                {
                    if (tymy[i].TymId == zapasy[j].Domaci.TymId)
                    {
                        goly += zapasy[j].GolyDomaci;
                    }
                    else if (tymy[i].TymId == zapasy[j].Hoste.TymId)
                    {
                        goly += zapasy[j].GolyHoste;
                    }
                }
                tymy[i].Goly = goly;
            }
            return tymy.OrderByDescending(x => x.Goly).ToList();
        }

        public List<Hrac> TabulkaTrestne()
        {
            HraciTable ht = new HraciTable();
            TrestyTable tt = new TrestyTable();
            List<Hrac> hraci = ht.Select();
            List<Trest> tresty = tt.Select();

            for (int i = 0; i < hraci.Count; i++)
            {
                int minuty = 0;
                for (int j = 0; j < tresty.Count; j++)
                {
                    if (tresty[j].Hrac.HracId == hraci[i].HracId)
                    {
                        minuty += tresty[j].Delka;
                    }
                }
                hraci[i].TrestneMinuty = minuty;
            }

            return hraci.OrderByDescending(x => x.TrestneMinuty).ToList();
        }
    }
}
