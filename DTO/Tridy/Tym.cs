using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Tym
    {
        public Tym(int tymId, string nazev, int pocetVyher, int pocetRemiz, int pocetProher, Trener trener)
        {
            TymId = tymId;
            Nazev = nazev;
            PocetVyher = pocetVyher;
            PocetRemiz = pocetRemiz;
            PocetProher = pocetProher;
            Trener = trener;
        }

        public int TymId { get; set; }
        public string Nazev { get; set; }
        public int PocetVyher { get; set; }
        public int PocetRemiz { get; set; }
        public int PocetProher { get; set; }
        public Trener Trener { get; set; }
    }
}
