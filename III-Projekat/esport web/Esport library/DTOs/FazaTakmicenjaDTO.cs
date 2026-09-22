using System;

namespace ESPORT
{
    public class FazaTakmicenjaDTO
    {
        public int FazaId { get; set; }
        public int TakmicenjeId { get; set; }
        public string NazivTakmicenja { get; set; }
        public string NazivFaze { get; set; }
        public int RedniBroj { get; set; }
        public int? NadfazaId { get; set; }
        public string Prikaz { get; set; }

        public FazaTakmicenjaDTO()
        {
        }

        public FazaTakmicenjaDTO(
            int fazaId,
            int takmicenjeId,
            string nazivTakmicenja,
            string nazivFaze,
            int redniBroj,
            int? nadfazaId)
        {
            FazaId = fazaId;
            TakmicenjeId = takmicenjeId;
            NazivTakmicenja = nazivTakmicenja;
            NazivFaze = nazivFaze;
            Prikaz = $"{NazivTakmicenja} - {NazivFaze}";
            RedniBroj = redniBroj;
            NadfazaId = nadfazaId;
        }
    }
}