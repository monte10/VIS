using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Tym
    {
        public int TymId { get; set; }
        public string Nazev { get; set; }
        public int PocetVyher { get; set; }
        public int PocetProher { get; set; }
        public int PocetRemiz { get; set; }
        public Trener Trener { get; set; }
    }
}
