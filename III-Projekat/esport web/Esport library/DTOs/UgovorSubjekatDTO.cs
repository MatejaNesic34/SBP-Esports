namespace ESPORT
{
    public class UgovorSubjekatDTO
    {
        public int UgovorId { get; set; }
        public int? TimId { get; set; }
        public string NazivTima { get; set; }
        public int? IgracId { get; set; }
        public string ImePrezimeIgraca { get; set; }
        public int? TakmicenjeId { get; set; }
        public string NazivTakmicenja { get; set; }

        public UgovorSubjekatDTO() { }

        public UgovorSubjekatDTO(int ugovorId, int? timId, string nazivTima, int? igracId, string imePrezimeIgraca, int? takmicenjeId, string nazivTakmicenja)
        {
            UgovorId = ugovorId;
            TimId = timId;
            NazivTima = nazivTima;
            IgracId = igracId;
            ImePrezimeIgraca = imePrezimeIgraca;
            TakmicenjeId = takmicenjeId;
            NazivTakmicenja = nazivTakmicenja;
        }
    }
}