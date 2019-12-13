using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Hrac
    {
        public Hrac(int hracId, string jmeno, string prijmeni, int cisloDresu, string pozice, int rokNarozeni, Tym tym, int trestneMinuty)
        {
            HracId = hracId;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            CisloDresu = cisloDresu;
            Pozice = pozice;
            RokNarozeni = rokNarozeni;
            Tym = tym;
            TrestneMinuty = trestneMinuty;
        }

        public int HracId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int CisloDresu { get; set; }
        public string Pozice { get; set; }
        public int RokNarozeni { get; set; }
        public Tym Tym { get; set; }
        public int TrestneMinuty { get; set; }
    }
}
