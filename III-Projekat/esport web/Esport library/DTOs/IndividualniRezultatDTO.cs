namespace ESPORT
{
    public class IndividualniRezultatDTO
    {
        public int RezultatId { get; set; }
        public string NazivPriznanja { get; set; }
        public DateTime? DatumOstvarivanja { get; set; }
        public string Opis { get; set; }
        public int IgracId { get; set; }
        public string ImePrezimeIgraca { get; set; }
        public int TakmicenjeId { get; set; }
        public string NazivTakmicenja { get; set; }

        public IndividualniRezultatDTO() { }

        public IndividualniRezultatDTO(int rezultatId, string nazivPriznanja, DateTime? datumOstvarivanja, string opis, int igracId, string imePrezimeIgraca, int takmicenjeId, string nazivTakmicenja)
        {
            RezultatId = rezultatId;
            NazivPriznanja = nazivPriznanja;
            DatumOstvarivanja = datumOstvarivanja;
            Opis = opis;
            IgracId = igracId;
            ImePrezimeIgraca = imePrezimeIgraca;
            TakmicenjeId = takmicenjeId;
            NazivTakmicenja = nazivTakmicenja;
        }
    }
}