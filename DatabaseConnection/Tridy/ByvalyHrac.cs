using System;

namespace DTO.Tridy
{
    public class ByvalyHrac
    {
        public int HracId { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int RokNarozeni { get; set; }
        public int CisloDresu { get; set; }
        public string Pozice { get; set; }
        public DateTime DatumZapisu { get; set; }
    }
}
