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

    public class TakmicenjeDTO
    {
        public class TakmicenjePregled
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

            public TakmicenjePregled()
            {
            }

            public TakmicenjePregled(
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

        public class TakmicenjeBasic
        {
            public int TakmicenjeId { get; set; }
            public string Naziv { get; set; }
            public string Organizator { get; set; }
            public string TipTakmicenja { get; set; }
            public int IgraId { get; set; }
            public string Region { get; set; }
            public string Lokacija { get; set; }
            public string FormatTakmicenja { get; set; }
            public DateTime DatumPocetka { get; set; }
            public DateTime DatumZavrsetka { get; set; }
            public decimal NagradniFond { get; set; }
            public string ValutaNagrade { get; set; }
            public string Status { get; set; }

            public TakmicenjeBasic()
            {
            }

            public TakmicenjeBasic(
                int takmicenjeId,
                string naziv,
                string organizator,
                string tipTakmicenja,
                int igraId,
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
                IgraId = igraId;
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

    public class LigaDTO
    {
        public class LigaPregled
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

            public LigaPregled()
            {
            }

            public LigaPregled(
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

        public class LigaBasic
        {
            public int TakmicenjeId { get; set; }
            public string SistemBodovanja { get; set; }

            public LigaBasic()
            {
            }

            public LigaBasic(int takmicenjeId, string sistemBodovanja)
            {
                TakmicenjeId = takmicenjeId;
                SistemBodovanja = sistemBodovanja;
            }
        }
    }

    public class TurnirDTO
    {
        public class TurnirPregled
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

            public string TipKostura { get; set; }
            public string PravilaNapredovanja { get; set; }
            public string BrojMecevaPoRundi { get; set; }

            public TurnirPregled()
            {
            }

            public TurnirPregled(
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
                string tipKostura,
                string pravilaNapredovanja,
                string brojMecevaPoRundi)
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
                TipKostura = tipKostura;
                PravilaNapredovanja = pravilaNapredovanja;
                BrojMecevaPoRundi = brojMecevaPoRundi;
            }
        }

        public class TurnirBasic
        {
            public int TakmicenjeId { get; set; }
            public string TipKostura { get; set; }
            public string PravilaNapredovanja { get; set; }
            public string BrojMecevaPoRundi { get; set; }

            public TurnirBasic()
            {
            }

            public TurnirBasic(
                int takmicenjeId,
                string tipKostura,
                string pravilaNapredovanja,
                string brojMecevaPoRundi)
            {
                TakmicenjeId = takmicenjeId;
                TipKostura = tipKostura;
                PravilaNapredovanja = pravilaNapredovanja;
                BrojMecevaPoRundi = brojMecevaPoRundi;
            }
        }
    }

    public class FazaTakmicenjaDTO
    {
        public class FazaTakmicenjaPregled
        {
            public int FazaId { get; set; }
            public int TakmicenjeId { get; set; }
            public string NazivTakmicenja { get; set; }
            public string NazivFaze { get; set; }
            public int RedniBroj { get; set; }
            public int? NadfazaId { get; set; }

            public string Prikaz { get; set; }

            public FazaTakmicenjaPregled()
            {
            }

            public FazaTakmicenjaPregled(
                int fazaId,
                int takmicenjeId,
                string nazivTakmicenja,
                string nazivFaze,
                int redniBroj,
                int? nadfazaId)
            {
                FazaId = fazaId;
                TakmicenjeId = takmicenjeId;
                NazivTakmicenja = nazivTakmicenja;
                NazivFaze = nazivFaze;

                Prikaz = $"{NazivTakmicenja} - {NazivFaze}";

                RedniBroj = redniBroj;
                NadfazaId = nadfazaId;
            }
        }

        public class FazaTakmicenjaBasic
        {
            public int FazaId { get; set; }
            public int TakmicenjeId { get; set; }
            public string NazivFaze { get; set; }
            public int RedniBroj { get; set; }
            public int? NadfazaId { get; set; }

            public FazaTakmicenjaBasic()
            {
            }

            public FazaTakmicenjaBasic(
                int fazaId,
                int takmicenjeId,
                string nazivFaze,
                int redniBroj,
                int? nadfazaId)
            {
                FazaId = fazaId;
                TakmicenjeId = takmicenjeId;
                NazivFaze = nazivFaze;
                RedniBroj = redniBroj;
                NadfazaId = nadfazaId;
            }
        }
    }

    public class MecDTO
    {
        public class MecPregled
        {
            public int MecId { get; set; }
            public int TakmicenjeId { get; set; }
            public string NazivTakmicenja { get; set; }

            public int RedniBroj { get; set; }
            public DateTime DatumVremePocetka { get; set; }
            public string FormatMeca { get; set; }
            public int BrojOdigranihMapa { get; set; }
            public string Rezultat { get; set; }
            public int? Trajanje { get; set; }
            public string LokacijaIgranja { get; set; }
            public string Sudije { get; set; }
            public string StatusMeca { get; set; }

            public string Prikaz
            {
                get
                {
                    return "Meč " + MecId +
                           " - " + NazivTakmicenja +
                           " - redni broj " + RedniBroj;
                }
            }

            public MecPregled()
            {
            }

            public MecPregled(
                int mecId,
                int takmicenjeId,
                string nazivTakmicenja,
                int redniBroj,
                DateTime datumVremePocetka,
                string formatMeca,
                int brojOdigranihMapa,
                string rezultat,
                int? trajanje,
                string lokacijaIgranja,
                string sudije,
                string statusMeca)
            {
                MecId = mecId;
                TakmicenjeId = takmicenjeId;
                NazivTakmicenja = nazivTakmicenja;
                RedniBroj = redniBroj;
                DatumVremePocetka = datumVremePocetka;
                FormatMeca = formatMeca;
                BrojOdigranihMapa = brojOdigranihMapa;
                Rezultat = rezultat;
                Trajanje = trajanje;
                LokacijaIgranja = lokacijaIgranja;
                Sudije = sudije;
                StatusMeca = statusMeca;
            }
        }

        public class MecBasic
        {
            public int MecId { get; set; }
            public int TakmicenjeId { get; set; }

            public int RedniBroj { get; set; }
            public DateTime DatumVremePocetka { get; set; }
            public string FormatMeca { get; set; }
            public int BrojOdigranihMapa { get; set; }
            public string Rezultat { get; set; }
            public int? Trajanje { get; set; }
            public string LokacijaIgranja { get; set; }
            public string Sudije { get; set; }
            public string StatusMeca { get; set; }


            public MecBasic()
            {
            }

            public MecBasic(
                int mecId,
                int takmicenjeId,
                int redniBroj,
                DateTime datumVremePocetka,
                string formatMeca,
                int brojOdigranihMapa,
                string rezultat,
                int? trajanje,
                string lokacijaIgranja,
                string sudije,
                string statusMeca)
            {
                MecId = mecId;
                TakmicenjeId = takmicenjeId;
                RedniBroj = redniBroj;
                DatumVremePocetka = datumVremePocetka;
                FormatMeca = formatMeca;
                BrojOdigranihMapa = brojOdigranihMapa;
                Rezultat = rezultat;
                Trajanje = trajanje;
                LokacijaIgranja = lokacijaIgranja;
                Sudije = sudije;
                StatusMeca = statusMeca;
            }
        }
    }

    public class DogadjajNaMecuDTO
    {
        public class DogadjajNaMecuPregled
        {
            public int DogadjajId { get; set; }
            public int MecId { get; set; }
            public int RedniBrojMeca { get; set; }
            public string TipDogadjaja { get; set; }
            public DateTime VremeDogadjaja { get; set; }
            public string Opis { get; set; }
            public string OdlukaSudije { get; set; }

            public DogadjajNaMecuPregled()
            {
            }

            public DogadjajNaMecuPregled(
                int dogadjajId,
                int mecId,
                int redniBrojMeca,
                string tipDogadjaja,
                DateTime vremeDogadjaja,
                string opis,
                string odlukaSudije)
            {
                DogadjajId = dogadjajId;
                MecId = mecId;
                RedniBrojMeca = redniBrojMeca;
                TipDogadjaja = tipDogadjaja;
                VremeDogadjaja = vremeDogadjaja;
                Opis = opis;
                OdlukaSudije = odlukaSudije;
            }
        }

        public class DogadjajNaMecuBasic
        {
            public int DogadjajId { get; set; }
            public int MecId { get; set; }
            public string TipDogadjaja { get; set; }
            public DateTime VremeDogadjaja { get; set; }
            public string Opis { get; set; }
            public string OdlukaSudije { get; set; }

            public DogadjajNaMecuBasic()
            {
            }

            public DogadjajNaMecuBasic(
                int dogadjajId,
                int mecId,
                string tipDogadjaja,
                DateTime vremeDogadjaja,
                string opis,
                string odlukaSudije)
            {
                DogadjajId = dogadjajId;
                MecId = mecId;
                TipDogadjaja = tipDogadjaja;
                VremeDogadjaja = vremeDogadjaja;
                Opis = opis;
                OdlukaSudije = odlukaSudije;
            }
        }
    }

    public class UcesceTimaUFaziDTO
    {
        public class UcescePregled
        {
            public int FazaId { get; set; }
            public int TimId { get; set; }

            public string NazivFaze { get; set; }
            public string NazivTima { get; set; }

            public string Status { get; set; }
            public string OstvareniRezultat { get; set; }
            public int BrojPobeda { get; set; }
            public int BrojPoraza { get; set; }
            public int OsvojeniBodovi { get; set; }
            public int? KonacanPlasman { get; set; }

            public UcescePregled(
                int fazaId,
                int timId,
                string nazivFaze,
                string nazivTima,
                string status,
                string ostvareniRezultat,
                int brojPobeda,
                int brojPoraza,
                int osvojeniBodovi,
                int? konacanPlasman)
            {
                FazaId = fazaId;
                TimId = timId;
                NazivFaze = nazivFaze;
                NazivTima = nazivTima;
                Status = status;
                OstvareniRezultat = ostvareniRezultat;
                BrojPobeda = brojPobeda;
                BrojPoraza = brojPoraza;
                OsvojeniBodovi = osvojeniBodovi;
                KonacanPlasman = konacanPlasman;
            }
        }

        public class UcesceBasic
        {
            public int FazaId { get; set; }
            public int TimId { get; set; }

            public string Status { get; set; }
            public string OstvareniRezultat { get; set; }
            public int BrojPobeda { get; set; }
            public int BrojPoraza { get; set; }
            public int OsvojeniBodovi { get; set; }
            public int? KonacanPlasman { get; set; }

            public UcesceBasic(
                int fazaId,
                int timId,
                string status,
                string ostvareniRezultat,
                int brojPobeda,
                int brojPoraza,
                int osvojeniBodovi,
                int? konacanPlasman)
            {
                FazaId = fazaId;
                TimId = timId;
                Status = status;
                OstvareniRezultat = ostvareniRezultat;
                BrojPobeda = brojPobeda;
                BrojPoraza = brojPoraza;
                OsvojeniBodovi = osvojeniBodovi;
                KonacanPlasman = konacanPlasman;
            }
        }
    }

    public class TimDTO
    {
        public class TimPregled
        {
            public int TimId { get; set; }
            public string Naziv { get; set; }

            public TimPregled(
                int timId,
                string naziv)
            {
                TimId = timId;
                Naziv = naziv;
            }

            public override string ToString()
            {
                return Naziv;
            }
        }
    }
}