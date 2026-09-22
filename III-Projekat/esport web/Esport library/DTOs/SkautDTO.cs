using System;

namespace ESPORT
{
    public class SkautDTO
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public string StatusAngazmana { get; set; }
        public string NazivIgre { get; set; }

        public SkautDTO() { }

        public SkautDTO(int osobaId, string ime, string prezime, DateTime? datumRodjenja, string drzava, string email, string statusAngazmana, string nazivIgre)
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Drzava = drzava;
            Email = email;
            StatusAngazmana = statusAngazmana;
            NazivIgre = nazivIgre;
        }
    }
}