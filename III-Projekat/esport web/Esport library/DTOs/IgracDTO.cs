using System;

namespace ESPORT
{
    public class IgracDTO
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Nadimak { get; set; }
        public string PrimarnaUloga { get; set; }
        public string SekundarnaUloga { get; set; }
        public string DominantniStil { get; set; }
        public string Rang { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public string StatusAngazmana { get; set; }
        public string TelefoniPrikaz { get; set; }

        public IgracDTO() { }

        public IgracDTO(int osobaId, string ime, string prezime, string nadimak,
                            string primarnaUloga, string sekundarnaUloga, string dominantniStil, string rang,
                            string drzava, string email, string statusAngazmana, string telefoniPrikaz)
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            Nadimak = nadimak;
            PrimarnaUloga = primarnaUloga;
            SekundarnaUloga = sekundarnaUloga;
            DominantniStil = dominantniStil;
            Rang = rang;
            Drzava = drzava;
            Email = email;
            StatusAngazmana = statusAngazmana;
            TelefoniPrikaz = telefoniPrikaz;
        }
    }
}