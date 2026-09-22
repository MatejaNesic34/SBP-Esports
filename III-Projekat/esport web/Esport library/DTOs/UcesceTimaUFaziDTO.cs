using System;

namespace ESPORT
{
    public class UcesceTimaUFaziDTO
    {
        public int FazaId { get; set; }
        public int TimId { get; set; }
        public string NazivFaze { get; set; }
        public string NazivTima { get; set; }
        public string Status { get; set; }
        public string OstvareniRezultat { get; set; }
        public int BrojPobeda { get; set; }
        public int BrojPoraza { get; set; }
        public int OsvojeniBodovi { get; set; }
        public int? KonacanPlasman { get; set; }

        public UcesceTimaUFaziDTO() { }

        public UcesceTimaUFaziDTO(
            int fazaId,
            int timId,
            string nazivFaze,
            string nazivTima,
            string status,
            string ostvareniRezultat,
            int brojPobeda,
            int brojPoraza,
            int osvojeniBodovi,
            int? konacanPlasman)
        {
            FazaId = fazaId;
            TimId = timId;
            NazivFaze = nazivFaze;
            NazivTima = nazivTima;
            Status = status;
            OstvareniRezultat = ostvareniRezultat;
            BrojPobeda = brojPobeda;
            BrojPoraza = brojPoraza;
            OsvojeniBodovi = osvojeniBodovi;
            KonacanPlasman = konacanPlasman;
        }
    }
}