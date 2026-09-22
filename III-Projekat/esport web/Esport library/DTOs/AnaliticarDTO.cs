using System;

namespace ESPORT
{
    public class AnaliticarDTO
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string StatusAngazmana { get; set; }
        public string OblastAnalize { get; set; }
        public string Alati { get; set; }
        public string NivoIskustva { get; set; }

        public AnaliticarDTO() { }

        public AnaliticarDTO(int osobaId, string ime, string prezime, string email,
                                 string statusAngazmana, string oblastAnalize,
                                 string alati, string nivoIskustva)
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            StatusAngazmana = statusAngazmana;
            OblastAnalize = oblastAnalize;
            Alati = alati;
            NivoIskustva = nivoIskustva;
        }
    }
}