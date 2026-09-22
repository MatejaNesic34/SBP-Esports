using System;

namespace ESPORT
{
    public class SponzorskiUgovorDTO
    {
        public int UgovorId { get; set; }
        public int SponzorId { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public decimal Iznos { get; set; }
        public string Valuta { get; set; }
        public string TipPodrske { get; set; }
        public string MarketinskeObaveze { get; set; }
        public string NazivSponzora { get; set; }

        public SponzorskiUgovorDTO() { }

        public SponzorskiUgovorDTO(int ugovorId, int sponzorId, DateTime datumOd, DateTime datumDo, decimal iznos, string valuta, string tipPodrske, string marketinskeObaveze)
        {
            UgovorId = ugovorId;
            SponzorId = sponzorId;
            DatumOd = datumOd;
            DatumDo = datumDo;
            Iznos = iznos;
            Valuta = valuta;
            TipPodrske = tipPodrske;
            MarketinskeObaveze = marketinskeObaveze;
        }
    }
}