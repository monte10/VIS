using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Hattrick
    {
        public Hattrick(int hattrickId, Hrac hrac, DateTime datum)
        {
            HattrickId = hattrickId;
            Hrac = hrac;
            Datum = datum;
        }

        public int HattrickId { get; set; }
        public Hrac Hrac { get; set; }
        public DateTime Datum { get; set; }
    }
}
