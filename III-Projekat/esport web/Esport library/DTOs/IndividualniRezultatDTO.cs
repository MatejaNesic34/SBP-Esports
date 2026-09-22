namespace ESPORT
{
    public class IndividualniRezultatDTO
    {
        public int RezultatId { get; set; }
        public int MecId { get; set; }
        public int IgracId { get; set; }
        public string ImePrezimeIgraca { get; set; }
        public int BrojUbijanja { get; set; }
        public int BrojSmrti { get; set; }
        public int BrojAsistencija { get; set; }
        public decimal OcenaUcinka { get; set; }

        public IndividualniRezultatDTO() { }

        public IndividualniRezultatDTO(int rezultatId, int mecId, int igracId, string imePrezimeIgraca, int brojUbijanja, int brojSmrti, int brojAsistencija, decimal ocenaUcinka)
        {
            RezultatId = rezultatId;
            MecId = mecId;
            IgracId = igracId;
            ImePrezimeIgraca = imePrezimeIgraca;
            BrojUbijanja = brojUbijanja;
            BrojSmrti = brojSmrti;
            BrojAsistencija = brojAsistencija;
            OcenaUcinka = ocenaUcinka;
        }
    }
}