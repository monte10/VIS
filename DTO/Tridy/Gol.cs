using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Gol
    {
        public Gol(int golId, Hrac hrac, Zapas zapas)
        {
            GolId = golId;
            Hrac = hrac;
            Zapas = zapas;
        }

        public int GolId { get; set; }
        public Hrac Hrac { get; set; }
        public Zapas Zapas { get; set; }
    }
}
