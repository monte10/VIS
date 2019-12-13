using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Zapas
    {
        public Zapas(int zapasId, DateTime datum, Tym domaci, Tym hoste, Rozhodci rozhodci, int golyDomaci, int golyHoste, string komentar)
        {
            ZapasId = zapasId;
            Datum = datum;
            Domaci = domaci;
            Hoste = hoste;
            Rozhodci = rozhodci;
            GolyDomaci = golyDomaci;
            GolyHoste = golyHoste;
            Komentar = komentar;
        }

        public int ZapasId { get; set; }
        public DateTime Datum { get; set; }
        public Tym Domaci { get; set; }
        public Tym Hoste { get; set; }
        public Rozhodci Rozhodci { get; set; }
        public int GolyDomaci { get; set; }
        public int GolyHoste { get; set; }
        public string Komentar { get; set; }
    }
}
