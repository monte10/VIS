using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Asistence
    {
        public int AsistenceId { get; set; }
        public Hrac Hrac { get; set; }
        public Zapas Zapas { get; set; }
        public Gol Gol { get; set; }
    }
}
