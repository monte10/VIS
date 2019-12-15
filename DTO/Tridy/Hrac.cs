using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Hrac
    {
        public int HracId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int CisloDresu { get; set; }
        public string Pozice { get; set; }
        public int RokNarozeni { get; set; }
        public Tym Tym { get; set; }
        public int TrestneMinuty { get; set; }
        public int Body { get; set; }
        public int Goly { get; set; }
        public int Asistence { get; set; }
    }
}
