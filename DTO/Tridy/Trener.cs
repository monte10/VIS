using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tridy
{
    public class Trener
    {
        public Trener(int trenerId, string jmeno, string prijmeni, int rokNarozeni)
        {
            TrenerId = trenerId;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RokNarozeni = rokNarozeni;
        }

        public int TrenerId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int RokNarozeni { get; set; }
    }
}
