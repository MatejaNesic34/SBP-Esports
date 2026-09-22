using System;

namespace ESPORT
{
    public class SponzorDTO
    {
        public int SponzorId { get; set; }
        public string Naziv { get; set; }
        public string Drzava { get; set; }
        public string TipSponzora { get; set; }
        public string OblastPoslovanja { get; set; }

        public SponzorDTO() { }

        public SponzorDTO(int id, string naziv, string drzava, string tipSponzora, string oblastPoslovanja)
        {
            SponzorId = id;
            Naziv = naziv;
            Drzava = drzava;
            TipSponzora = tipSponzora;
            OblastPoslovanja = oblastPoslovanja;
        }
    }
}