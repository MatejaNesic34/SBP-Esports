using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT
{
    public class IgraDTO
    {
        public class IgraPregled
        {
            public int IgraId { get; set; }
            public string Naziv { get; set; }
            public string Zanr { get; set; }

            public IgraPregled()
            {
            }

            public IgraPregled(int igraId, string naziv, string zanr)
            {
                this.IgraId = igraId;
                this.Naziv = naziv;
                this.Zanr = zanr;
            }
        }

        // Koristi se za izmenu, unos i detaljan prikaz sa relacijama
        public class IgraBasic
        {
            public int IgraId { get; set; }
            public string Naziv { get; set; }
            public string Zanr { get; set; }

            public IList<TimBasic> Timovi { get; set; }
            public IList<TakmicenjeBasic> Takmicenja { get; set; }
            public IList<SkautBasic> Skauti { get; set; }

            public IgraBasic()
            {
                Timovi = new List<TimBasic>();
                Takmicenja = new List<TakmicenjeBasic>();
                Skauti = new List<SkautBasic>();
            }

            public IgraBasic(int igraId, string naziv, string zanr) : this()
            {
                this.IgraId = igraId;
                this.Naziv = naziv;
                this.Zanr = zanr;
            }
        }

        // Pomoćne Basic klase za relacije
        public class TimBasic
        {
            public int TimId { get; set; }
            public string Naziv { get; set; }
        }

        public class TakmicenjeBasic
        {
            public int TakmicenjeId { get; set; }
            public string Naziv { get; set; }
        }

        public class SkautBasic
        {
            public int SkautId { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
        }

    }

    public class OsobaDTO
    {
        public class OsobaPregled
        {
            public int OsobaId { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public DateTime? DatumRodjenja { get; set; }
            public string Drzava { get; set; }
            public string Email { get; set; }
            public string StatusAngazmana { get; set; }

            public OsobaPregled() { }

            public OsobaPregled(int osobaId, string ime, string prezime, DateTime? datumRodjenja, string drzava, string email, string statusAngazmana)
            {
                OsobaId = osobaId;
                Ime = ime;
                Prezime = prezime;
                DatumRodjenja = datumRodjenja;
                Drzava = drzava;
                Email = email;
                StatusAngazmana = statusAngazmana;
            }
        }

        public class OsobaBasic
        {
            public int OsobaId { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public DateTime? DatumRodjenja { get; set; }
            public string Drzava { get; set; }
            public string Email { get; set; }
            public DateTime? DatumPrvogAngazovanja { get; set; }
            public string StatusAngazmana { get; set; }

            public IList<TelefonBasic> Telefoni { get; set; }
            public IList<LicencaBasic> Licence { get; set; }
            public IList<AngazmanZaposlenihBasic> AngazmaniZaposlenog { get; set; }

            public OsobaBasic()
            {
                Telefoni = new List<TelefonBasic>();
                Licence = new List<LicencaBasic>();
                AngazmaniZaposlenog = new List<AngazmanZaposlenihBasic>();
            }

            public OsobaBasic(int osobaId, string ime, string prezime, DateTime? datumRodjenja, string drzava, string email, DateTime? datumPrvogAngazovanja, string statusAngazmana) : this()
            {
                OsobaId = osobaId;
                Ime = ime;
                Prezime = prezime;
                DatumRodjenja = datumRodjenja;
                Drzava = drzava;
                Email = email;
                DatumPrvogAngazovanja = datumPrvogAngazovanja;
                StatusAngazmana = statusAngazmana;
            }
        }

        public class TelefonBasic
        {
            public string BrojTelefona { get; set; }
        }

        public class LicencaBasic
        {
            public int LicencaId { get; set; }
            public string Naziv { get; set; }
        }

        public class AngazmanZaposlenihBasic
        {
            public int AngazmanOsobljaId { get; set; }
            public string NazivUloge { get; set; }
            public DateTime DatumOd { get; set; }
            public DateTime? DatumDo { get; set; }
            public decimal? Plata { get; set; }
            public string TimNaziv { get; set; }
        }
    }

    public class IgracDTO
    {
        public class IgracPregled
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

            public IgracPregled() { }

            public IgracPregled(int osobaId, string ime, string prezime, string nadimak,
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

        public class IgracBasic
        {
            public int OsobaId { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public DateTime? DatumRodjenja { get; set; }
            public DateTime? DatumPrvogAngazovanja { get; set; }
            public string Drzava { get; set; }
            public string Email { get; set; }
            public string StatusAngazmana { get; set; }
            public string Nadimak { get; set; }
            public string PrimarnaUloga { get; set; }
            public string SekundarnaUloga { get; set; }
            public string DominantniStil { get; set; }
            public string Rang { get; set; }
            public List<string> Telefoni { get; set; } = new List<string>();

            public IgracBasic() { }

            public IgracBasic(int osobaId, string ime, string prezime, DateTime? datumRodjenja,
                              string drzava, string email, string statusAngazmana,
                              string nadimak, string primarnaUloga, string sekundarnaUloga,
                              string dominantniStil, string rang)
            {
                OsobaId = osobaId;
                Ime = ime;
                Prezime = prezime;
                DatumRodjenja = datumRodjenja;
                Drzava = drzava;
                Email = email;
                StatusAngazmana = statusAngazmana;
                Nadimak = nadimak;
                PrimarnaUloga = primarnaUloga;
                SekundarnaUloga = sekundarnaUloga;
                DominantniStil = dominantniStil;
                Rang = rang;
            }
        }

        public class TrenerDTO
        {
            public class TrenerPregled
            {
                public int OsobaId { get; set; }
                public string Ime { get; set; }
                public string Prezime { get; set; }
                public string Nadimak { get; set; }
                public string TipUloge { get; set; }
                public string StilRada { get; set; }
                public string StatusAngazmana { get; set; }

                public TrenerPregled() { }

                public TrenerPregled(int id, string ime, string prezime, string tipUloge, string stilRada, string status)
                {
                    this.OsobaId = id;
                    this.Ime = ime;
                    this.Prezime = prezime;
                    this.TipUloge = tipUloge;
                    this.StilRada = stilRada;
                    this.StatusAngazmana = status;
                }
            }

            public class TrenerBasic
            {
                public int OsobaId { get; set; }
                public string Ime { get; set; }
                public string Prezime { get; set; }
                public DateTime? DatumRodjenja { get; set; }
                public DateTime? DatumPrvogAngazovanja { get; set; }
                public string Drzava { get; set; }
                public string Email { get; set; }
                public string StatusAngazmana { get; set; }
                public string TipUloge { get; set; }
                public string StilRada { get; set; }

                public List<string> Telefoni { get; set; } = new List<string>();

                public TrenerBasic() { }
            }
        }
    }


    public class AnaliticarDTO
    {
        // DTO za prikaz u listama / DataGridView
        public class AnaliticarPregled
        {
            public int OsobaId { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string Email { get; set; }
            public string StatusAngazmana { get; set; }
            public string OblastAnalize { get; set; }
            public string Alati { get; set; }
            public string NivoIskustva { get; set; }

            public AnaliticarPregled() { }

            public AnaliticarPregled(int osobaId, string ime, string prezime, string email,
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

        // DTO za detaljan prikaz, izmenu i dodavanje novog analitičara
        public class AnaliticarBasic
        {
            public int OsobaId { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public DateTime? DatumRodjenja { get; set; }
            public string Drzava { get; set; }
            public string Email { get; set; }
            public DateTime? DatumPrvogAngazovanja { get; set; }
            public string StatusAngazmana { get; set; }

            // Polja specifična za Analitičara
            public string OblastAnalize { get; set; }
            public string Alati { get; set; }
            public string NivoIskustva { get; set; }

            // Kolekcije nasledjene iz klase Osoba
            public IList<OsobaDTO.TelefonBasic> Telefoni { get; set; } = new List<OsobaDTO.TelefonBasic>();
            public IList<OsobaDTO.LicencaBasic> Licence { get; set; } = new List<OsobaDTO.LicencaBasic>();
            public IList<OsobaDTO.AngazmanZaposlenihBasic> AngazmaniZaposlenog { get; set; } = new List<OsobaDTO.AngazmanZaposlenihBasic>();

            public AnaliticarBasic() { }

            public AnaliticarBasic(int osobaId, string ime, string prezime, DateTime? datumRodjenja,
                                   string drzava, string email, DateTime? datumPrvogAngazovanja,
                                   string statusAngazmana, string oblastAnalize,
                                   string alati, string nivoIskustva)
            {
                OsobaId = osobaId;
                Ime = ime;
                Prezime = prezime;
                DatumRodjenja = datumRodjenja;
                Drzava = drzava;
                Email = email;
                DatumPrvogAngazovanja = datumPrvogAngazovanja;
                StatusAngazmana = statusAngazmana;
                OblastAnalize = oblastAnalize;
                Alati = alati;
                NivoIskustva = nivoIskustva;
            }
        }
    }

    public class MenadzerPregled
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public string StatusAngazmana { get; set; }
        public string OblastOdgovornosti { get; set; }

        public MenadzerPregled() { }

        public MenadzerPregled(int osobaId, string ime, string prezime, DateTime? datumRodjenja, string drzava, string email, string statusAngazmana, string oblastOdgovornosti)
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Drzava = drzava;
            Email = email;
            StatusAngazmana = statusAngazmana;
            OblastOdgovornosti = oblastOdgovornosti;
        }
    }

    // DTO za detaljan prikaz, kreiranje i izmenu menadžera
    public class MenadzerBasic
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public DateTime? DatumPrvogAngazovanja { get; set; }
        public string StatusAngazmana { get; set; }

        // Specifično polje za Menadžera
        public string OblastOdgovornosti { get; set; }

        // Kolekcije
        public IList<OsobaDTO.TelefonBasic> Telefoni { get; set; }
        public IList<OsobaDTO.LicencaBasic> Licence { get; set; }
        public IList<OsobaDTO.AngazmanZaposlenihBasic> AngazmaniZaposlenog { get; set; }

        public MenadzerBasic()
        {
            Telefoni = new List<OsobaDTO.TelefonBasic>();
            Licence = new List<OsobaDTO.LicencaBasic>();
            AngazmaniZaposlenog = new List<OsobaDTO.AngazmanZaposlenihBasic>();
        }

        public MenadzerBasic(int osobaId, string ime, string prezime, DateTime? datumRodjenja,
                             string drzava, string email, DateTime? datumPrvogAngazovanja,
                             string statusAngazmana, string oblastOdgovornosti) : this()
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Drzava = drzava;
            Email = email;
            DatumPrvogAngazovanja = datumPrvogAngazovanja;
            StatusAngazmana = statusAngazmana;
            OblastOdgovornosti = oblastOdgovornosti;
        }
    }

    public class PsihologPregled
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public string StatusAngazmana { get; set; }
        public string OblastRada { get; set; }
        public string PeriodiDostupnosti { get; set; }

        public PsihologPregled() { }

        public PsihologPregled(int osobaId, string ime, string prezime, DateTime? datumRodjenja, string drzava, string email, string statusAngazmana, string oblastRada, string periodiDostupnosti)
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Drzava = drzava;
            Email = email;
            StatusAngazmana = statusAngazmana;
            OblastRada = oblastRada;
            PeriodiDostupnosti = periodiDostupnosti;
        }
    }

    // DTO za detalje, kreiranje i izmenu
    public class PsihologBasic
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public DateTime? DatumPrvogAngazovanja { get; set; }
        public string StatusAngazmana { get; set; }

        // Specifična polja za Psihologa
        public string OblastRada { get; set; }
        public string PeriodiDostupnosti { get; set; }

        // Kolekcije
        public IList<OsobaDTO.TelefonBasic> Telefoni { get; set; }
        public IList<OsobaDTO.LicencaBasic> Licence { get; set; }
        public IList<OsobaDTO.AngazmanZaposlenihBasic> AngazmaniZaposlenog { get; set; }

        public PsihologBasic()
        {
            Telefoni = new List<OsobaDTO.TelefonBasic>();
            Licence = new List<OsobaDTO.LicencaBasic>();
            AngazmaniZaposlenog = new List<OsobaDTO.AngazmanZaposlenihBasic>();
        }

        public PsihologBasic(int osobaId, string ime, string prezime, DateTime? datumRodjenja,
                             string drzava, string email, DateTime? datumPrvogAngazovanja,
                             string statusAngazmana, string oblastRada, string periodiDostupnosti) : this()
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Drzava = drzava;
            Email = email;
            DatumPrvogAngazovanja = datumPrvogAngazovanja;
            StatusAngazmana = statusAngazmana;
            OblastRada = oblastRada;
            PeriodiDostupnosti = periodiDostupnosti;
        }
    }

    public class FizioterapeutPregled
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public string StatusAngazmana { get; set; }
        public string OblastRada { get; set; }
        public string PeriodiDostupnosti { get; set; }

        public FizioterapeutPregled() { }

        public FizioterapeutPregled(int osobaId, string ime, string prezime, DateTime? datumRodjenja, string drzava, string email, string statusAngazmana, string oblastRada, string periodiDostupnosti)
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Drzava = drzava;
            Email = email;
            StatusAngazmana = statusAngazmana;
            OblastRada = oblastRada;
            PeriodiDostupnosti = periodiDostupnosti;
        }
    }

    // DTO za detalje, kreiranje i izmenu
    public class FizioterapeutBasic
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public DateTime? DatumPrvogAngazovanja { get; set; }
        public string StatusAngazmana { get; set; }

        // Specifična polja za Fizioterapeuta
        public string OblastRada { get; set; }
        public string PeriodiDostupnosti { get; set; }

        // Kolekcije
        public IList<OsobaDTO.TelefonBasic> Telefoni { get; set; }
        public IList<OsobaDTO.LicencaBasic> Licence { get; set; }
        public IList<OsobaDTO.AngazmanZaposlenihBasic> AngazmaniZaposlenog { get; set; }

        public FizioterapeutBasic()
        {
            Telefoni = new List<OsobaDTO.TelefonBasic>();
            Licence = new List<OsobaDTO.LicencaBasic>();
            AngazmaniZaposlenog = new List<OsobaDTO.AngazmanZaposlenihBasic>();
        }

        public FizioterapeutBasic(int osobaId, string ime, string prezime, DateTime? datumRodjenja,
                                  string drzava, string email, DateTime? datumPrvogAngazovanja,
                                  string statusAngazmana, string oblastRada, string periodiDostupnosti) : this()
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Drzava = drzava;
            Email = email;
            DatumPrvogAngazovanja = datumPrvogAngazovanja;
            StatusAngazmana = statusAngazmana;
            OblastRada = oblastRada;
            PeriodiDostupnosti = periodiDostupnosti;
        }
    }


    public class SkautPregled
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public string StatusAngazmana { get; set; }
        public string NazivIgre { get; set; } // Naziv povezane igre za skauta

        public SkautPregled() { }

        public SkautPregled(int osobaId, string ime, string prezime, DateTime? datumRodjenja, string drzava, string email, string statusAngazmana, string nazivIgre)
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

    // DTO za detalje, kreiranje i izmenu
    public class SkautBasic
    {
        public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Email { get; set; }
        public DateTime? DatumPrvogAngazovanja { get; set; }
        public string StatusAngazmana { get; set; }

        // Referenca na igru
        public int? IgraId { get; set; }
        public string NazivIgre { get; set; }

        // Kolekcije nasleđene iz Osobe
        public IList<OsobaDTO.TelefonBasic> Telefoni { get; set; }
        public IList<OsobaDTO.LicencaBasic> Licence { get; set; }
        public IList<OsobaDTO.AngazmanZaposlenihBasic> AngazmaniZaposlenog { get; set; }

        public SkautBasic()
        {
            Telefoni = new List<OsobaDTO.TelefonBasic>();
            Licence = new List<OsobaDTO.LicencaBasic>();
            AngazmaniZaposlenog = new List<OsobaDTO.AngazmanZaposlenihBasic>();
        }

        public SkautBasic(int osobaId, string ime, string prezime, DateTime? datumRodjenja,
                          string drzava, string email, DateTime? datumPrvogAngazovanja,
                          string statusAngazmana, int? igraId, string nazivIgre) : this()
        {
            OsobaId = osobaId;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Drzava = drzava;
            Email = email;
            DatumPrvogAngazovanja = datumPrvogAngazovanja;
            StatusAngazmana = statusAngazmana;
            IgraId = igraId;
            NazivIgre = nazivIgre;
        }
    }
}


