using System;

namespace ESPORT
{
    public class TimDTO
    {
        public int TimId { get; set; }
        public string Naziv { get; set; }
        public int IgraId { get; set; }
        public string Igra { get; set; }
        public DateTime? DatumOsnivanja { get; set; }
        public string DrzavaRegistracije { get; set; }
        public string StatusTima { get; set; }
        public string NivoTakmicenja { get; set; }

        public TimDTO()
        {
        }

        public TimDTO(
            int timId,
            string naziv)
        {
            TimId = timId;
            Naziv = naziv;
        }

        public TimDTO(
            int timId,
            string naziv,
            int igraId,
            string igra,
            DateTime? datumOsnivanja,
            string drzavaRegistracije,
            string statusTima,
            string nivoTakmicenja)
        {
            TimId = timId;
            Naziv = naziv;
            IgraId = igraId;
            Igra = igra;
            DatumOsnivanja = datumOsnivanja;
            DrzavaRegistracije = drzavaRegistracije;
            StatusTima = statusTima;
            NivoTakmicenja = nivoTakmicenja;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}