using System;

namespace ESPORT
{
    public class TakmicenjeDTO
    {
        public int TakmicenjeId { get; set; }
        public string Naziv { get; set; }
        public string Organizator { get; set; }
        public string TipTakmicenja { get; set; }
        public string Igra { get; set; }
        public string Region { get; set; }
        public string Lokacija { get; set; }
        public string FormatTakmicenja { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public decimal NagradniFond { get; set; }
        public string ValutaNagrade { get; set; }
        public string Status { get; set; }

        public TakmicenjeDTO()
        {
        }

        public TakmicenjeDTO(
            int takmicenjeId,
            string naziv,
            string organizator,
            string tipTakmicenja,
            string igra,
            string region,
            string lokacija,
            string formatTakmicenja,
            DateTime datumPocetka,
            DateTime datumZavrsetka,
            decimal nagradniFond,
            string valutaNagrade,
            string status)
        {
            TakmicenjeId = takmicenjeId;
            Naziv = naziv;
            Organizator = organizator;
            TipTakmicenja = tipTakmicenja;
            Igra = igra;
            Region = region;
            Lokacija = lokacija;
            FormatTakmicenja = formatTakmicenja;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = datumZavrsetka;
            NagradniFond = nagradniFond;
            ValutaNagrade = valutaNagrade;
            Status = status;
        }
    }
}