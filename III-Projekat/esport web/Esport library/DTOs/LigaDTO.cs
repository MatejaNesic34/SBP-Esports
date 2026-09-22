using System;

namespace ESPORT
{
    public class LigaDTO
    {
        public int TakmicenjeId { get; set; }
        public string NazivTakmicenja { get; set; }
        public string Organizator { get; set; }
        public string Igra { get; set; }
        public string Region { get; set; }
        public string Lokacija { get; set; }
        public string FormatTakmicenja { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public decimal NagradniFond { get; set; }
        public string ValutaNagrade { get; set; }
        public string Status { get; set; }
        public string SistemBodovanja { get; set; }

        public LigaDTO()
        {
        }

        public LigaDTO(
            int takmicenjeId,
            string nazivTakmicenja,
            string organizator,
            string igra,
            string region,
            string lokacija,
            string formatTakmicenja,
            DateTime datumPocetka,
            DateTime datumZavrsetka,
            decimal nagradniFond,
            string valutaNagrade,
            string status,
            string sistemBodovanja)
        {
            TakmicenjeId = takmicenjeId;
            NazivTakmicenja = nazivTakmicenja;
            Organizator = organizator;
            Igra = igra;
            Region = region;
            Lokacija = lokacija;
            FormatTakmicenja = formatTakmicenja;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = datumZavrsetka;
            NagradniFond = nagradniFond;
            ValutaNagrade = valutaNagrade;
            Status = status;
            SistemBodovanja = sistemBodovanja;
        }
    }
}