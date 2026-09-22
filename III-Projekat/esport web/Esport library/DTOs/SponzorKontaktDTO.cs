namespace ESPORT
{
    public class SponzorKontaktDTO
    {
        public int KontaktId { get; set; }
        public int SponzorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public SponzorKontaktDTO() { }

        public SponzorKontaktDTO(int kontaktId, int sponzorId, string ime, string prezime, string telefon, string email)
        {
            KontaktId = kontaktId;
            SponzorId = sponzorId;
            Ime = ime;
            Prezime = prezime;
            Telefon = telefon;
            Email = email;
        }
    }
}