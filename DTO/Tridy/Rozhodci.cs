using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Rozhodci
    {
        public Rozhodci(int rozhodciId, string jmeno, string prijmeni, int rokNarozeni)
        {
            RozhodciId = rozhodciId;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RokNarozeni = rokNarozeni;
        }

        public int RozhodciId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int RokNarozeni { get; set; }
    }
}
