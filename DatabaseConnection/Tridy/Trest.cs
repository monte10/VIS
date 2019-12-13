using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Trest
    {
        public int TrestId { get; set; }
        public int Delka { get; set; }
        public string Duvod { get; set; }
        public Hrac Hrac { get; set; }
        public Zapas Zapas { get; set; }
    }
}
