using ESPORT.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESPORT.AnaliticarDTO;
using static ESPORT.DogadjajNaMecuDTO;
using static ESPORT.FazaTakmicenjaDTO;
using static ESPORT.IgracDTO;
using static ESPORT.IgraDTO;
using static ESPORT.LigaDTO;
using static ESPORT.MecDTO;
using static ESPORT.OsobaDTO;
using static ESPORT.TakmicenjeDTO;
using static ESPORT.TimDTO;
using static ESPORT.TurnirDTO;
using static ESPORT.UcesceTimaUFaziDTO;
using static ESPORT.TransferDTO;
using static ESPORT.PozajmicaDTO;
using static ESPORT.StatistikaTimaNaMecuDTO;
using static ESPORT.IndividualniRezultatDTO;
using static ESPORT.AngazmanTreneraDTO;

namespace ESPORT
{
    public class DTOManager
    {
        public static List<IgraPregled> vratiSveIgre()
        {
            List<IgraPregled> igre = new List<IgraPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return igre; // Zaštita ako je konekcija pukla

                    // Umesto LINQ sintakse, moderniji i kraći zapis:
                    List<ESPORT.Entiteti.Igra> sveIgre = s.Query<ESPORT.Entiteti.Igra>().OrderBy(i => i.IgraId).ToList();

                    foreach (ESPORT.Entiteti.Igra i in sveIgre)
                    {
                        igre.Add(new IgraPregled(i.IgraId, i.Naziv, i.Zanr));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška u DTOManager-u: {ec.Message}");
            }

            return igre;
        }

        public static void dodajIgru(IgraBasic i)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    // Pokretanje transakcije je obavezno za upis u bazu
                    using (ITransaction tx = s.BeginTransaction())
                    {
                        Igra o = new Igra();

                        o.Naziv = i.Naziv;
                        o.Zanr = i.Zanr;

                        s.Save(o);

                        // Potvrđivanje upisa u Oracle bazu
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show($"Greška pri dodavanju u bazu: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }



        public static IgraBasic vratiIgru(int id)
        {
            IgraBasic ib = new IgraBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Igra o = s.Load<Igra>(id);
                ib = new IgraBasic(o.IgraId, o.Naziv, o.Zanr);

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return ib;
        }

        public static void obrisiIgru(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        // Učitavamo objekat iz baze po ID-ju
                        ESPORT.Entiteti.Igra o = s.Load<ESPORT.Entiteti.Igra>(id);

                        // Brišemo objekat
                        s.Delete(o);

                        // Potvrđujemo izmene u bazi
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju igre: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // IZMENA IGRE
        public static void azurirajIgru(IgraBasic i)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        // Učitavamo postojeći objekat
                        ESPORT.Entiteti.Igra o = s.Load<ESPORT.Entiteti.Igra>(i.IgraId);

                        // Ažuriramo njegova svojstva
                        o.Naziv = i.Naziv;
                        o.Zanr = i.Zanr;

                        // Cuvamo izmene
                        s.Update(o);

                        // Potvrđujemo transakciju
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju igre: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }


        }

        public static List<OsobaPregled> vratiSveOsobe()
        {
            List<OsobaPregled> osobe = new List<OsobaPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return osobe;

                    List<ESPORT.Entiteti.Osoba> sveOsobe = s.Query<ESPORT.Entiteti.Osoba>().OrderBy(o => o.OsobaId).ToList();

                    foreach (ESPORT.Entiteti.Osoba o in sveOsobe)
                    {
                        osobe.Add(new OsobaPregled(o.OsobaId, o.Ime, o.Prezime, o.DatumRodjenja, o.Drzava, o.Email, o.StatusAngazmana));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška u DTOManager-u (vratiSveOsobe): {ec.Message}");
            }

            return osobe;
        }

        // 2. DODAVANJE NOVE OSOBE
        public static void dodajOsobu(OsobaBasic oBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Osoba o = new ESPORT.Entiteti.Osoba();

                        o.Ime = oBasic.Ime;
                        o.Prezime = oBasic.Prezime;
                        o.DatumRodjenja = oBasic.DatumRodjenja;
                        o.Drzava = oBasic.Drzava;
                        o.Email = oBasic.Email;
                        o.DatumPrvogAngazovanja = oBasic.DatumPrvogAngazovanja;
                        o.StatusAngazmana = oBasic.StatusAngazmana;

                        s.Save(o);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju osobe: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 3. PRIKAZ JEDNE OSOBE (Detalji / Izmena)
        public static OsobaBasic vratiOsobu(int id)
        {
            OsobaBasic ob = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    ESPORT.Entiteti.Osoba o = s.Get<ESPORT.Entiteti.Osoba>(id);
                    if (o == null) return null;

                    ob = new OsobaBasic(
                        o.OsobaId,
                        o.Ime,
                        o.Prezime,
                        o.DatumRodjenja,
                        o.Drzava,
                        o.Email,
                        o.DatumPrvogAngazovanja,
                        o.StatusAngazmana
                    );

                    // 1. Telefoni (BrojTelefona)
                    foreach (var tel in o.Telefoni)
                    {
                        ob.Telefoni.Add(new TelefonBasic
                        {
                            BrojTelefona = tel.BrojTelefona
                        });
                    }

                    // 2. Licence
                    foreach (var lic in o.Licence)
                    {
                        ob.Licence.Add(new LicencaBasic
                        {
                            LicencaId = lic.LicencaId,
                            Naziv = lic.Naziv
                        });
                    }

                    // 3. Angažmani Zaposlenog (AngazmanOsobljaId)
                    foreach (var ang in o.AngazmaniZaposlenog)
                    {
                        ob.AngazmaniZaposlenog.Add(new AngazmanZaposlenihBasic
                        {
                            AngazmanOsobljaId = ang.AngazmanOsobljaId,
                            NazivUloge = ang.NazivUloge,
                            DatumOd = ang.DatumOd,
                            DatumDo = ang.DatumDo,
                            Plata = ang.Plata,
                            TimNaziv = ang.Tim?.Naziv
                        });
                    }
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show($"Greška pri preuzimanju osobe: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }

            return ob;
        }

        // 4. AŽURIRANJE OSOBE
        public static void azurirajOsobu(OsobaBasic oBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Osoba o = s.Load<ESPORT.Entiteti.Osoba>(oBasic.OsobaId);

                        o.Ime = oBasic.Ime;
                        o.Prezime = oBasic.Prezime;
                        o.DatumRodjenja = oBasic.DatumRodjenja;
                        o.Drzava = oBasic.Drzava;
                        o.Email = oBasic.Email;
                        o.DatumPrvogAngazovanja = oBasic.DatumPrvogAngazovanja;
                        o.StatusAngazmana = oBasic.StatusAngazmana;

                        s.Update(o);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju osobe: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 5. BRISANJE OSOBE
        public static void obrisiOsobu(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Osoba o = s.Load<ESPORT.Entiteti.Osoba>(id);

                        s.Delete(o);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju osobe: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        public static List<IgracPregled> vratiSveIgrace()
        {
            List<IgracPregled> igraci = new List<IgracPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return igraci;

                    List<Igrac> sviIgraci = s.Query<Igrac>().OrderBy(i => i.OsobaId).ToList();

                    foreach (Igrac i in sviIgraci)
                    {
                        string telefoniStr = i.Telefoni != null ? string.Join(", ", i.Telefoni.Select(t => t.BrojTelefona)) : "";

                        igraci.Add(new IgracPregled(
                            i.OsobaId,
                            i.Ime,
                            i.Prezime,
                            i.Nadimak,
                            i.PrimarnaUloga,
                            i.SekundarnaUloga,
                            i.DominantniStil,
                            i.Rang,
                            i.Drzava,
                            i.Email,
                            i.StatusAngazmana,
                            telefoniStr
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri učitavanju igrača: {ec.Message}");
            }
            return igraci;
        }

        public static IgracBasic vratiIgraca(int id)
        {
            IgracBasic ib = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    Igrac i = s.Get<Igrac>(id);
                    if (i != null)
                    {
                        ib = new IgracBasic(
                            i.OsobaId,
                            i.Ime,
                            i.Prezime,
                            i.DatumRodjenja,
                            i.Drzava,
                            i.Email,
                            i.StatusAngazmana,
                            i.Nadimak,
                            i.PrimarnaUloga,
                            i.SekundarnaUloga,
                            i.DominantniStil,
                            i.Rang
                        );

                        if (i.Telefoni != null)
                        {
                            ib.Telefoni = i.Telefoni.Select(t => t.BrojTelefona).ToList();
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri učitavanju igrača: {ec.Message}");
            }
            return ib;
        }

        public static void dodajIgraca(IgracBasic ib)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    Igrac i = new Igrac
                    {
                        Ime = ib.Ime,
                        Prezime = ib.Prezime,
                        DatumRodjenja = ib.DatumRodjenja,
                        DatumPrvogAngazovanja = ib.DatumPrvogAngazovanja ?? DateTime.Now,
                        Drzava = ib.Drzava,
                        Email = ib.Email,
                        StatusAngazmana = ib.StatusAngazmana,
                        Nadimak = ib.Nadimak,
                        PrimarnaUloga = ib.PrimarnaUloga,
                        SekundarnaUloga = ib.SekundarnaUloga,
                        DominantniStil = ib.DominantniStil,
                        Rang = ib.Rang
                    };

                    foreach (string tel in ib.Telefoni)
                    {
                        i.Telefoni.Add(new Telefon { OsobaId = i, BrojTelefona = tel });
                    }

                    s.Save(i);
                    s.Flush();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju igrača: {ec.Message}");
            }
        }

        public static void izmeniIgraca(IgracBasic ib)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        // 1. Učitavamo postojeci entitet iz baze
                        Igrac i = s.Get<Igrac>(ib.OsobaId);

                        if (i != null)
                        {
                            // 2. Ažuriramo polja klase Osoba/Igrac
                            i.Ime = ib.Ime;
                            i.Prezime = ib.Prezime;
                            i.DatumRodjenja = ib.DatumRodjenja;
                            i.Drzava = ib.Drzava;
                            i.Email = ib.Email;
                            i.StatusAngazmana = ib.StatusAngazmana;
                            i.Nadimak = ib.Nadimak;
                            i.PrimarnaUloga = ib.PrimarnaUloga;
                            i.SekundarnaUloga = ib.SekundarnaUloga;
                            i.DominantniStil = ib.DominantniStil;
                            i.Rang = ib.Rang;

                            // 3. Ažuriramo telefone
                            i.Telefoni.Clear();
                            if (ib.Telefoni != null)
                            {
                                foreach (string tel in ib.Telefoni)
                                {
                                    i.Telefoni.Add(new Telefon { OsobaId = i, BrojTelefona = tel });
                                }
                            }

                            // 4. EKSPLICITNO sprovodimo i potvrdjujemo izmene
                            s.Update(i);
                            tx.Commit();
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri izmeni igrača: {ec.Message}");
            }
        }

        public static void obrisiIgraca(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    Igrac i = s.Get<Igrac>(id);
                    if (i != null)
                    {
                        s.Delete(i);
                        s.Flush();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju igrača: {ec.Message}");
            }
        }


        public static List<TrenerDTO.TrenerPregled> vratiSveTrenere()
        {
            List<TrenerDTO.TrenerPregled> treneriDTO = new List<TrenerDTO.TrenerPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return treneriDTO;

                    IList<Trener> treneri = s.Query<Trener>().OrderBy(i => i.OsobaId).ToList();

                    foreach (Trener t in treneri)
                    {
                        // Ako entitet Trener ima listu telefona, spajamo ih u jedan string
                        string telefoniString = t.Telefoni != null ? string.Join(", ", t.Telefoni) : "";

                        treneriDTO.Add(new TrenerDTO.TrenerPregled(
                            t.OsobaId,
                            t.Ime,
                            t.Prezime,
                            t.DatumRodjenja,
                            t.DatumPrvogAngazovanja,
                            t.Drzava,
                            t.Email,
                            t.TipUloge,
                            t.StilRada,
                            t.StatusAngazmana,
                            telefoniString
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri učitavanju trenera: {ec.Message}");
            }
            return treneriDTO;
        }

        // Učitavanje pojedinačnog trenera za izmenu
        public static TrenerDTO.TrenerBasic vratiTrenera(int id)
        {
            TrenerDTO.TrenerBasic tb = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    Trener t = s.Get<Trener>(id);
                    if (t != null)
                    {
                        tb = new TrenerDTO.TrenerBasic
                        {
                            OsobaId = t.OsobaId,
                            Ime = t.Ime,
                            Prezime = t.Prezime,
                            DatumRodjenja = t.DatumRodjenja,
                            DatumPrvogAngazovanja = t.DatumPrvogAngazovanja,
                            Drzava = t.Drzava,
                            Email = t.Email,
                            StatusAngazmana = t.StatusAngazmana,
                            TipUloge = t.TipUloge,
                            StilRada = t.StilRada
                        };

                        foreach (var tel in t.Telefoni)
                        {
                            tb.Telefoni.Add(tel.BrojTelefona);
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju trenera: {ec.Message}");
            }
            return tb;
        }

        // Dodavanje novog trenera
        public static void dodajTrenera(TrenerDTO.TrenerBasic tb)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        Trener t = new Trener
                        {
                            Ime = tb.Ime,
                            Prezime = tb.Prezime,
                            DatumRodjenja = tb.DatumRodjenja,
                            DatumPrvogAngazovanja = tb.DatumPrvogAngazovanja ?? DateTime.Now,
                            Drzava = tb.Drzava,
                            Email = tb.Email,
                            StatusAngazmana = tb.StatusAngazmana,
                            TipUloge = tb.TipUloge,
                            StilRada = tb.StilRada
                        };

                        if (tb.Telefoni != null)
                        {
                            foreach (string tel in tb.Telefoni)
                            {
                                t.Telefoni.Add(new Telefon { OsobaId = t, BrojTelefona = tel });
                            }
                        }

                        s.Save(t);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju trenera: {ec.Message}");
            }
        }

        // Izmena trenera
        public static void izmeniTrenera(TrenerDTO.TrenerBasic tb)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        Trener t = s.Get<Trener>(tb.OsobaId);
                        if (t != null)
                        {
                            t.Ime = tb.Ime;
                            t.Prezime = tb.Prezime;
                            t.DatumRodjenja = tb.DatumRodjenja;
                            t.DatumPrvogAngazovanja = tb.DatumPrvogAngazovanja;
                            t.Drzava = tb.Drzava;
                            t.Email = tb.Email;
                            t.StatusAngazmana = tb.StatusAngazmana;
                            t.TipUloge = tb.TipUloge;
                            t.StilRada = tb.StilRada;

                            t.Telefoni.Clear();
                            if (tb.Telefoni != null)
                            {
                                foreach (string tel in tb.Telefoni)
                                {
                                    t.Telefoni.Add(new Telefon { OsobaId = t, BrojTelefona = tel });
                                }
                            }

                            s.Update(t);
                            tx.Commit();
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri izmeni trenera: {ec.Message}");
            }
        }

        // Brisanje trenera
        public static void obrisiTrenera(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        Trener t = s.Get<Trener>(id);
                        if (t != null)
                        {
                            s.Delete(t);
                            tx.Commit();
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju trenera: {ec.Message}");
            }
        }


        public static List<AnaliticarPregled> vratiSveAnaliticare()
        {
            List<AnaliticarPregled> analiticari = new List<AnaliticarPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return analiticari;

                    List<ESPORT.Entiteti.Analiticar> sviAnaliticari = s.Query<ESPORT.Entiteti.Analiticar>()
                                                                      .OrderBy(a => a.OsobaId)
                                                                      .ToList();

                    foreach (ESPORT.Entiteti.Analiticar a in sviAnaliticari)
                    {
                        analiticari.Add(new AnaliticarPregled(
                            a.OsobaId,
                            a.Ime,
                            a.Prezime,
                            a.DatumRodjenja,
                            a.Drzava,
                            a.Email,
                            a.DatumPrvogAngazovanja,
                            a.StatusAngazmana,
                            a.OblastAnalize,
                            a.Alati,
                            a.NivoIskustva
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show($"Greška pri preuzimanju analitičara: {ec.Message}");
            }

            return analiticari;
        }

        // 2. DODAJ NOVOG ANALITIČARA
        public static void dodajAnaliticara(AnaliticarBasic aBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Analiticar a = new ESPORT.Entiteti.Analiticar();

                        // Polja nasledjena iz Osoba
                        a.Ime = aBasic.Ime;
                        a.Prezime = aBasic.Prezime;
                        a.DatumRodjenja = aBasic.DatumRodjenja;
                        a.Drzava = aBasic.Drzava;
                        a.Email = aBasic.Email;
                        a.DatumPrvogAngazovanja = aBasic.DatumPrvogAngazovanja;
                        a.StatusAngazmana = aBasic.StatusAngazmana;

                        // Polja specifična za Analitičara
                        a.OblastAnalize = aBasic.OblastAnalize;
                        a.Alati = aBasic.Alati;
                        a.NivoIskustva = aBasic.NivoIskustva;

                        s.Save(a);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show($"Greška pri dodavanju analitičara: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 3. VRATI JEDNOG ANALITIČARA (sa svim detaljima i kolekcijama)
        public static AnaliticarBasic vratiAnaliticara(int id)
        {
            AnaliticarBasic ab = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    ESPORT.Entiteti.Analiticar a = s.Get<ESPORT.Entiteti.Analiticar>(id);
                    if (a == null) return null;

                    ab = new AnaliticarBasic(
                        a.OsobaId,
                        a.Ime,
                        a.Prezime,
                        a.DatumRodjenja,
                        a.Drzava,
                        a.Email,
                        a.DatumPrvogAngazovanja,
                        a.StatusAngazmana,
                        a.OblastAnalize,
                        a.Alati,
                        a.NivoIskustva
                    );

                    // Telefoni
                    foreach (var tel in a.Telefoni)
                    {
                        ab.Telefoni.Add(new OsobaDTO.TelefonBasic
                        {
                            BrojTelefona = tel.BrojTelefona
                        });
                    }

                    // Licence
                    foreach (var lic in a.Licence)
                    {
                        ab.Licence.Add(new OsobaDTO.LicencaBasic
                        {
                            LicencaId = lic.LicencaId,
                            Naziv = lic.Naziv
                        });
                    }

                    // Angažmani
                    foreach (var ang in a.AngazmaniZaposlenog)
                    {
                        ab.AngazmaniZaposlenog.Add(new OsobaDTO.AngazmanZaposlenihBasic
                        {
                            AngazmanOsobljaId = ang.AngazmanOsobljaId,
                            NazivUloge = ang.NazivUloge,
                            DatumOd = ang.DatumOd,
                            DatumDo = ang.DatumDo,
                            Plata = ang.Plata,
                            TimNaziv = ang.Tim?.Naziv
                        });
                    }
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show($"Greška pri preuzimanju detalja analitičara: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }

            return ab;
        }

        // 4. AŽURIRAJ ANALITIČARA
        public static void azurirajAnaliticara(AnaliticarBasic aBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Analiticar a = s.Load<ESPORT.Entiteti.Analiticar>(aBasic.OsobaId);

                        // Polja nasledjena iz Osoba
                        a.Ime = aBasic.Ime;
                        a.Prezime = aBasic.Prezime;
                        a.DatumRodjenja = aBasic.DatumRodjenja;
                        a.Drzava = aBasic.Drzava;
                        a.Email = aBasic.Email;
                        a.DatumPrvogAngazovanja = aBasic.DatumPrvogAngazovanja;
                        a.StatusAngazmana = aBasic.StatusAngazmana;

                        // Polja specifična za Analitičara
                        a.OblastAnalize = aBasic.OblastAnalize;
                        a.Alati = aBasic.Alati;
                        a.NivoIskustva = aBasic.NivoIskustva;

                        s.Update(a);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show($"Greška pri ažuriranju analitičara: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 5. OBRIŠI ANALITIČARA
        public static void obrisiAnaliticara(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Analiticar a = s.Load<ESPORT.Entiteti.Analiticar>(id);

                        s.Delete(a);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show($"Greška pri brisanju analitičara: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }
        // 1. VRATI SVE MENADŽERE (za tabelarni prikaz)
        public static List<MenadzerPregled> vratiSveMenadzere()
        {
            List<MenadzerPregled> menadzeri = new List<MenadzerPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return menadzeri;

                    List<ESPORT.Entiteti.Menadzer> sviMenadzeri = s.Query<ESPORT.Entiteti.Menadzer>()
                                                                   .OrderBy(m => m.OsobaId)
                                                                   .ToList();

                    foreach (ESPORT.Entiteti.Menadzer m in sviMenadzeri)
                    {
                        menadzeri.Add(new MenadzerPregled(
                            m.OsobaId,
                            m.Ime,
                            m.Prezime,
                            m.DatumRodjenja,
                            m.Drzava,
                            m.Email,
                            m.StatusAngazmana,
                            m.OblastOdgovornosti
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju menadžera: {ec.Message}");
            }

            return menadzeri;
        }

        // 2. DODAJ NOVOG MENADŽERA
        public static void dodajMenadzera(MenadzerBasic mBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Menadzer m = new ESPORT.Entiteti.Menadzer();

                        // Polja nasleđena iz Osoba
                        m.Ime = mBasic.Ime;
                        m.Prezime = mBasic.Prezime;
                        m.DatumRodjenja = mBasic.DatumRodjenja;
                        m.Drzava = mBasic.Drzava;
                        m.Email = mBasic.Email;
                        m.DatumPrvogAngazovanja = mBasic.DatumPrvogAngazovanja;
                        m.StatusAngazmana = mBasic.StatusAngazmana;

                        // Polje specifično za Menadžera
                        m.OblastOdgovornosti = mBasic.OblastOdgovornosti;

                        s.Save(m);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju menadžera: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 3. VRATI JEDNOG MENADŽERA (sa detaljima i kolekcijama)
        public static MenadzerBasic vratiMenadzera(int id)
        {
            MenadzerBasic mb = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    ESPORT.Entiteti.Menadzer m = s.Get<ESPORT.Entiteti.Menadzer>(id);
                    if (m == null) return null;

                    mb = new MenadzerBasic(
                        m.OsobaId,
                        m.Ime,
                        m.Prezime,
                        m.DatumRodjenja,
                        m.Drzava,
                        m.Email,
                        m.DatumPrvogAngazovanja,
                        m.StatusAngazmana,
                        m.OblastOdgovornosti
                    );

                    // Telefoni
                    foreach (var tel in m.Telefoni)
                    {
                        mb.Telefoni.Add(new OsobaDTO.TelefonBasic
                        {
                            BrojTelefona = tel.BrojTelefona
                        });
                    }

                    // Licence
                    foreach (var lic in m.Licence)
                    {
                        mb.Licence.Add(new OsobaDTO.LicencaBasic
                        {
                            LicencaId = lic.LicencaId,
                            Naziv = lic.Naziv
                        });
                    }

                    // Angažmani
                    foreach (var ang in m.AngazmaniZaposlenog)
                    {
                        mb.AngazmaniZaposlenog.Add(new OsobaDTO.AngazmanZaposlenihBasic
                        {
                            AngazmanOsobljaId = ang.AngazmanOsobljaId,
                            NazivUloge = ang.NazivUloge,
                            DatumOd = ang.DatumOd,
                            DatumDo = ang.DatumDo,
                            Plata = ang.Plata,
                            TimNaziv = ang.Tim?.Naziv
                        });
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju detalja menadžera: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }

            return mb;
        }

        // 4. AŽURIRAJ MENADŽERA
        public static void azurirajMenadzera(MenadzerBasic mBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Menadzer m = s.Load<ESPORT.Entiteti.Menadzer>(mBasic.OsobaId);

                        // Polja nasleđena iz Osoba
                        m.Ime = mBasic.Ime;
                        m.Prezime = mBasic.Prezime;
                        m.DatumRodjenja = mBasic.DatumRodjenja;
                        m.Drzava = mBasic.Drzava;
                        m.Email = mBasic.Email;
                        m.DatumPrvogAngazovanja = mBasic.DatumPrvogAngazovanja;
                        m.StatusAngazmana = mBasic.StatusAngazmana;

                        // Polje specifično za Menadžera
                        m.OblastOdgovornosti = mBasic.OblastOdgovornosti;

                        s.Update(m);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju menadžera: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 5. OBRIŠI MENADŽERA
        public static void obrisiMenadzera(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Menadzer m = s.Load<ESPORT.Entiteti.Menadzer>(id);

                        s.Delete(m);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju menadžera: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        public static List<PsihologPregled> vratiSvePsihologe()
        {
            List<PsihologPregled> psiholozi = new List<PsihologPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return psiholozi;

                    List<ESPORT.Entiteti.Psiholog> sviPsiholozi = s.Query<ESPORT.Entiteti.Psiholog>()
                                                                   .OrderBy(p => p.OsobaId)
                                                                   .ToList();

                    foreach (ESPORT.Entiteti.Psiholog p in sviPsiholozi)
                    {
                        psiholozi.Add(new PsihologPregled(
                            p.OsobaId,
                            p.Ime,
                            p.Prezime,
                            p.DatumRodjenja,
                            p.Drzava,
                            p.Email,
                            p.StatusAngazmana,
                            p.OblastRada,
                            p.PeriodiDostupnosti
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju psihologa: {ec.Message}");
            }

            return psiholozi;
        }

        // 2. DODAJ NOVOG PSIHOLOGA
        public static void dodajPsihologa(PsihologBasic pBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Psiholog p = new ESPORT.Entiteti.Psiholog();

                        p.Ime = pBasic.Ime;
                        p.Prezime = pBasic.Prezime;
                        p.DatumRodjenja = pBasic.DatumRodjenja;
                        p.Drzava = pBasic.Drzava;
                        p.Email = pBasic.Email;
                        p.DatumPrvogAngazovanja = pBasic.DatumPrvogAngazovanja;
                        p.StatusAngazmana = pBasic.StatusAngazmana;

                        // Specifična polja
                        p.OblastRada = pBasic.OblastRada;
                        p.PeriodiDostupnosti = pBasic.PeriodiDostupnosti;

                        s.Save(p);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju psihologa: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 3. VRATI JEDNOG PSIHOLOGA
        public static PsihologBasic vratiPsihologa(int id)
        {
            PsihologBasic pb = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    ESPORT.Entiteti.Psiholog p = s.Get<ESPORT.Entiteti.Psiholog>(id);
                    if (p == null) return null;

                    pb = new PsihologBasic(
                        p.OsobaId,
                        p.Ime,
                        p.Prezime,
                        p.DatumRodjenja,
                        p.Drzava,
                        p.Email,
                        p.DatumPrvogAngazovanja,
                        p.StatusAngazmana,
                        p.OblastRada,
                        p.PeriodiDostupnosti
                    );

                    foreach (var tel in p.Telefoni)
                    {
                        pb.Telefoni.Add(new OsobaDTO.TelefonBasic { BrojTelefona = tel.BrojTelefona });
                    }

                    foreach (var lic in p.Licence)
                    {
                        pb.Licence.Add(new OsobaDTO.LicencaBasic { LicencaId = lic.LicencaId, Naziv = lic.Naziv });
                    }

                    foreach (var ang in p.AngazmaniZaposlenog)
                    {
                        pb.AngazmaniZaposlenog.Add(new OsobaDTO.AngazmanZaposlenihBasic
                        {
                            AngazmanOsobljaId = ang.AngazmanOsobljaId,
                            NazivUloge = ang.NazivUloge,
                            DatumOd = ang.DatumOd,
                            DatumDo = ang.DatumDo,
                            Plata = ang.Plata,
                            TimNaziv = ang.Tim?.Naziv
                        });
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju detalja psihologa: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }

            return pb;
        }

        // 4. AŽURIRAJ PSIHOLOGA
        public static void azurirajPsihologa(PsihologBasic pBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Psiholog p = s.Load<ESPORT.Entiteti.Psiholog>(pBasic.OsobaId);

                        p.Ime = pBasic.Ime;
                        p.Prezime = pBasic.Prezime;
                        p.DatumRodjenja = pBasic.DatumRodjenja;
                        p.Drzava = pBasic.Drzava;
                        p.Email = pBasic.Email;
                        p.DatumPrvogAngazovanja = pBasic.DatumPrvogAngazovanja;
                        p.StatusAngazmana = pBasic.StatusAngazmana;

                        p.OblastRada = pBasic.OblastRada;
                        p.PeriodiDostupnosti = pBasic.PeriodiDostupnosti;

                        s.Update(p);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju psihologa: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 5. OBRIŠI PSIHOLOGA
        public static void obrisiPsihologa(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Psiholog p = s.Load<ESPORT.Entiteti.Psiholog>(id);

                        s.Delete(p);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju psihologa: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        public static List<FizioterapeutPregled> vratiSveFizioterapeute()
        {
            List<FizioterapeutPregled> fizioterapeuti = new List<FizioterapeutPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return fizioterapeuti;

                    List<ESPORT.Entiteti.Fizioterapeut> sviFizioterapeuti = s.Query<ESPORT.Entiteti.Fizioterapeut>()
                                                                             .OrderBy(f => f.OsobaId)
                                                                             .ToList();

                    foreach (ESPORT.Entiteti.Fizioterapeut f in sviFizioterapeuti)
                    {
                        fizioterapeuti.Add(new FizioterapeutPregled(
                            f.OsobaId,
                            f.Ime,
                            f.Prezime,
                            f.DatumRodjenja,
                            f.Drzava,
                            f.Email,
                            f.StatusAngazmana,
                            f.OblastRada,
                            f.PeriodiDostupnosti
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju fizioterapeuta: {ec.Message}");
            }

            return fizioterapeuti;
        }

        // 2. DODAJ NOVOG FIZIOTERAPEUTA
        public static void dodajFizioterapeuta(FizioterapeutBasic fBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Fizioterapeut f = new ESPORT.Entiteti.Fizioterapeut();

                        f.Ime = fBasic.Ime;
                        f.Prezime = fBasic.Prezime;
                        f.DatumRodjenja = fBasic.DatumRodjenja;
                        f.Drzava = fBasic.Drzava;
                        f.Email = fBasic.Email;
                        f.DatumPrvogAngazovanja = fBasic.DatumPrvogAngazovanja;
                        f.StatusAngazmana = fBasic.StatusAngazmana;

                        // Specifična polja
                        f.OblastRada = fBasic.OblastRada;
                        f.PeriodiDostupnosti = fBasic.PeriodiDostupnosti;

                        s.Save(f);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju fizioterapeuta: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 3. VRATI JEDNOG FIZIOTERAPEUTA
        public static FizioterapeutBasic vratiFizioterapeuta(int id)
        {
            FizioterapeutBasic fb = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    ESPORT.Entiteti.Fizioterapeut f = s.Get<ESPORT.Entiteti.Fizioterapeut>(id);
                    if (f == null) return null;

                    fb = new FizioterapeutBasic(
                        f.OsobaId,
                        f.Ime,
                        f.Prezime,
                        f.DatumRodjenja,
                        f.Drzava,
                        f.Email,
                        f.DatumPrvogAngazovanja,
                        f.StatusAngazmana,
                        f.OblastRada,
                        f.PeriodiDostupnosti
                    );

                    foreach (var tel in f.Telefoni)
                    {
                        fb.Telefoni.Add(new OsobaDTO.TelefonBasic { BrojTelefona = tel.BrojTelefona });
                    }

                    foreach (var lic in f.Licence)
                    {
                        fb.Licence.Add(new OsobaDTO.LicencaBasic { LicencaId = lic.LicencaId, Naziv = lic.Naziv });
                    }

                    foreach (var ang in f.AngazmaniZaposlenog)
                    {
                        fb.AngazmaniZaposlenog.Add(new OsobaDTO.AngazmanZaposlenihBasic
                        {
                            AngazmanOsobljaId = ang.AngazmanOsobljaId,
                            NazivUloge = ang.NazivUloge,
                            DatumOd = ang.DatumOd,
                            DatumDo = ang.DatumDo,
                            Plata = ang.Plata,
                            TimNaziv = ang.Tim?.Naziv
                        });
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju detalja fizioterapeuta: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }

            return fb;
        }

        // 4. AŽURIRAJ FIZIOTERAPEUTA
        public static void azurirajFizioterapeuta(FizioterapeutBasic fBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Fizioterapeut f = s.Load<ESPORT.Entiteti.Fizioterapeut>(fBasic.OsobaId);

                        f.Ime = fBasic.Ime;
                        f.Prezime = fBasic.Prezime;
                        f.DatumRodjenja = fBasic.DatumRodjenja;
                        f.Drzava = fBasic.Drzava;
                        f.Email = fBasic.Email;
                        f.DatumPrvogAngazovanja = fBasic.DatumPrvogAngazovanja;
                        f.StatusAngazmana = fBasic.StatusAngazmana;

                        f.OblastRada = fBasic.OblastRada;
                        f.PeriodiDostupnosti = fBasic.PeriodiDostupnosti;

                        s.Update(f);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju fizioterapeuta: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 5. OBRIŠI FIZIOTERAPEUTA
        public static void obrisiFizioterapeuta(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Fizioterapeut f = s.Load<ESPORT.Entiteti.Fizioterapeut>(id);

                        s.Delete(f);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju fizioterapeuta: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }


        public static List<SkautPregled> vratiSveSkaute()
        {
            List<SkautPregled> skauti = new List<SkautPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return skauti;

                    List<Skaut> sviSkauti = s.Query<Skaut>()
                                             .OrderBy(sk => sk.OsobaId)
                                             .ToList();

                    foreach (Skaut sk in sviSkauti)
                    {
                        skauti.Add(new SkautPregled(
                            sk.OsobaId,
                            sk.Ime,
                            sk.Prezime,
                            sk.DatumRodjenja,
                            sk.DatumPrvogAngazovanja,
                            sk.Drzava,
                            sk.Email,
                            sk.StatusAngazmana,
                            sk.Igra?.Naziv ?? "Nije dodeljena"
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju skauta: {ec.Message}");
            }

            return skauti;
        }

        // 2. DODAJ NOVOG SKAUTA
        public static void dodajSkauta(SkautBasic sBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        Skaut sk = new Skaut();

                        sk.Ime = sBasic.Ime;
                        sk.Prezime = sBasic.Prezime;
                        sk.DatumRodjenja = sBasic.DatumRodjenja;
                        sk.Drzava = sBasic.Drzava;
                        sk.Email = sBasic.Email;
                        sk.DatumPrvogAngazovanja = sBasic.DatumPrvogAngazovanja;
                        sk.StatusAngazmana = sBasic.StatusAngazmana;

                        // Povezivanje sa Igrom ako je izabrana
                        if (sBasic.IgraId.HasValue && sBasic.IgraId.Value > 0)
                        {
                            Igra igra = s.Load<Igra>(sBasic.IgraId.Value);
                            sk.Igra = igra;
                        }

                        s.Save(sk);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju skauta: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 3. VRATI JEDNOG SKAUTA
        public static SkautBasic vratiSkauta(int id)
        {
            SkautBasic sb = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    Skaut sk = s.Get<Skaut>(id);
                    if (sk == null) return null;

                    sb = new SkautBasic(
                        sk.OsobaId,
                        sk.Ime,
                        sk.Prezime,
                        sk.DatumRodjenja,
                        sk.Drzava,
                        sk.Email,
                        sk.DatumPrvogAngazovanja,
                        sk.StatusAngazmana,
                        sk.Igra?.IgraId,
                        sk.Igra?.Naziv
                    );

                    foreach (var tel in sk.Telefoni)
                    {
                        sb.Telefoni.Add(new OsobaDTO.TelefonBasic { BrojTelefona = tel.BrojTelefona });
                    }

                    foreach (var lic in sk.Licence)
                    {
                        sb.Licence.Add(new OsobaDTO.LicencaBasic { LicencaId = lic.LicencaId, Naziv = lic.Naziv });
                    }

                    foreach (var ang in sk.AngazmaniZaposlenog)
                    {
                        sb.AngazmaniZaposlenog.Add(new OsobaDTO.AngazmanZaposlenihBasic
                        {
                            AngazmanOsobljaId = ang.AngazmanOsobljaId,
                            NazivUloge = ang.NazivUloge,
                            DatumOd = ang.DatumOd,
                            DatumDo = ang.DatumDo,
                            Plata = ang.Plata,
                            TimNaziv = ang.Tim?.Naziv
                        });
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju detalja skauta: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }

            return sb;
        }

        // 4. AŽURIRAJ SKAUTA
        public static void azurirajSkauta(SkautBasic sBasic)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        Skaut sk = s.Load<Skaut>(sBasic.OsobaId);

                        sk.Ime = sBasic.Ime;
                        sk.Prezime = sBasic.Prezime;
                        sk.DatumRodjenja = sBasic.DatumRodjenja;
                        sk.Drzava = sBasic.Drzava;
                        sk.Email = sBasic.Email;
                        sk.DatumPrvogAngazovanja = sBasic.DatumPrvogAngazovanja;
                        sk.StatusAngazmana = sBasic.StatusAngazmana;

                        // Ažuriranje veze sa Igrom
                        if (sBasic.IgraId.HasValue && sBasic.IgraId.Value > 0)
                        {
                            Igra igra = s.Load<Igra>(sBasic.IgraId.Value);
                            sk.Igra = igra;
                        }
                        else
                        {
                            sk.Igra = null;
                        }

                        s.Update(sk);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju skauta: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // 5. OBRIŠI SKAUTA
        public static void obrisiSkauta(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        Skaut sk = s.Load<Skaut>(id);

                        s.Delete(sk);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju skauta: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        public static List<TakmicenjePregled> vratiSvaTakmicenja()
        {
            List<TakmicenjePregled> takmicenja =
                new List<TakmicenjePregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ESPORT.Entiteti.Takmicenje> svaTakmicenja =
                    from t in s.Query<ESPORT.Entiteti.Takmicenje>()
                    select t;

                foreach (ESPORT.Entiteti.Takmicenje t in svaTakmicenja)
                {
                    takmicenja.Add(
                        new TakmicenjePregled(
                            t.TakmicenjeId,
                            t.Naziv,
                            t.Organizator,
                            t.TipTakmicenja,
                            t.Igra != null ? t.Igra.Naziv : "",
                            t.Region,
                            t.Lokacija,
                            t.FormatTakmicenja,
                            t.DatumPocetka,
                            t.DatumZavrsetka,
                            t.NagradniFond,
                            t.ValutaNagrade,
                            t.Status
                        )
                    );
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška u DTOManager-u: {ec.Message}");
            }

            return takmicenja;
        }

        public static bool dodajTakmicenje(TakmicenjeDTO.TakmicenjeBasic t)
        {
            try
            {
                if (t == null)
                {
                    MessageBox.Show(
                        "Podaci o takmičenju nisu prosleđeni.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.Naziv))
                {
                    MessageBox.Show(
                        "Naziv takmičenja je obavezan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.Organizator))
                {
                    MessageBox.Show(
                        "Organizator je obavezan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.TipTakmicenja))
                {
                    MessageBox.Show(
                        "Tip takmičenja je obavezan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.TipTakmicenja != "Liga" &&
                    t.TipTakmicenja != "Turnir")
                {
                    MessageBox.Show(
                        "Tip takmičenja mora biti 'Liga' ili 'Turnir'.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.IgraId <= 0)
                {
                    MessageBox.Show(
                        "Igra je obavezna.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.DatumZavrsetka < t.DatumPocetka)
                {
                    MessageBox.Show(
                        "Datum završetka ne može biti pre datuma početka.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.Status))
                {
                    MessageBox.Show(
                        "Status takmičenja je obavezan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.Status != "Najava" &&
                    t.Status != "U toku" &&
                    t.Status != "Završeno" &&
                    t.Status != "Otkazano")
                {
                    MessageBox.Show(
                        "Status mora biti 'Najava', 'U toku', 'Završeno' ili 'Otkazano'.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Igra igra =
                    s.Get<ESPORT.Entiteti.Igra>(t.IgraId);

                if (igra == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrana igra ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Takmicenje o =
                    new ESPORT.Entiteti.Takmicenje();

                o.Naziv = t.Naziv;
                o.Organizator = t.Organizator;
                o.TipTakmicenja = t.TipTakmicenja;
                o.Region = t.Region;
                o.Lokacija = t.Lokacija;
                o.FormatTakmicenja = t.FormatTakmicenja;
                o.DatumPocetka = t.DatumPocetka;
                o.DatumZavrsetka = t.DatumZavrsetka;
                o.NagradniFond = t.NagradniFond;
                o.ValutaNagrade = t.ValutaNagrade;
                o.Status = t.Status;
                o.Igra = igra;

                s.SaveOrUpdate(o);

                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri dodavanju takmičenja: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static void obrisiTakmicenje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Takmicenje o =
                    s.Load<ESPORT.Entiteti.Takmicenje>(id);

                s.Delete(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri brisanju takmičenja: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}");
            }
        }

        public static bool azurirajTakmicenje(
    TakmicenjeDTO.TakmicenjeBasic t)
        {
            try
            {
                if (t == null)
                {
                    MessageBox.Show(
                        "Podaci o takmičenju nisu prosleđeni.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.Naziv))
                {
                    MessageBox.Show(
                        "Naziv takmičenja je obavezan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.Organizator))
                {
                    MessageBox.Show(
                        "Organizator je obavezan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.TipTakmicenja))
                {
                    MessageBox.Show(
                        "Tip takmičenja je obavezan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.TipTakmicenja != "Liga" &&
                    t.TipTakmicenja != "Turnir")
                {
                    MessageBox.Show(
                        "Tip takmičenja mora biti 'Liga' ili 'Turnir'.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.IgraId <= 0)
                {
                    MessageBox.Show(
                        "Igra je obavezna.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.DatumZavrsetka < t.DatumPocetka)
                {
                    MessageBox.Show(
                        "Datum završetka ne može biti pre datuma početka.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.Status))
                {
                    MessageBox.Show(
                        "Status takmičenja je obavezan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.Status != "Najava" &&
                    t.Status != "U toku" &&
                    t.Status != "Završeno" &&
                    t.Status != "Otkazano")
                {
                    MessageBox.Show(
                        "Status mora biti 'Najava', 'U toku', 'Završeno' ili 'Otkazano'.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Takmicenje o =
                    s.Get<ESPORT.Entiteti.Takmicenje>(t.TakmicenjeId);

                if (o == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Takmičenje ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Igra igra =
                    s.Get<ESPORT.Entiteti.Igra>(t.IgraId);

                if (igra == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrana igra ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                o.Naziv = t.Naziv;
                o.Organizator = t.Organizator;
                o.TipTakmicenja = t.TipTakmicenja;
                o.Region = t.Region;
                o.Lokacija = t.Lokacija;
                o.FormatTakmicenja = t.FormatTakmicenja;
                o.DatumPocetka = t.DatumPocetka;
                o.DatumZavrsetka = t.DatumZavrsetka;
                o.NagradniFond = t.NagradniFond;
                o.ValutaNagrade = t.ValutaNagrade;
                o.Status = t.Status;
                o.Igra = igra;

                s.Update(o);

                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri ažuriranju takmičenja: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static TakmicenjeDTO.TakmicenjeBasic vratiTakmicenje(int id)
        {
            TakmicenjeDTO.TakmicenjeBasic tb =
                new TakmicenjeDTO.TakmicenjeBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Takmicenje o =
                    s.Load<ESPORT.Entiteti.Takmicenje>(id);

                tb = new TakmicenjeDTO.TakmicenjeBasic(
                    o.TakmicenjeId,
                    o.Naziv,
                    o.Organizator,
                    o.TipTakmicenja,
                    o.Igra != null ? o.Igra.IgraId : 0,
                    o.Region,
                    o.Lokacija,
                    o.FormatTakmicenja,
                    o.DatumPocetka,
                    o.DatumZavrsetka,
                    o.NagradniFond,
                    o.ValutaNagrade,
                    o.Status
                );

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri učitavanju takmičenja: {ec.Message}");
            }

            return tb;
        }

        public static List<LigaDTO.LigaPregled> vratiSveLige()
        {
            List<LigaDTO.LigaPregled> lige = new List<LigaDTO.LigaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ESPORT.Entiteti.Liga> sveLige =
                    from l in s.Query<ESPORT.Entiteti.Liga>()
                    where l.TipTakmicenja == "Liga"
                    select l;

                foreach (ESPORT.Entiteti.Liga l in sveLige)
                {
                    lige.Add(new LigaDTO.LigaPregled(
                        l.TakmicenjeId,
                        l.Naziv,
                        l.Organizator,
                        l.Igra.Naziv,
                        l.Region,
                        l.Lokacija,
                        l.FormatTakmicenja,
                        l.DatumPocetka,
                        l.DatumZavrsetka,
                        l.NagradniFond,
                        l.ValutaNagrade,
                        l.Status,
                        l.SistemBodovanja));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri učitavanju liga: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return lige;
        }

        public static bool dodajLigu(LigaDTO.LigaBasic l)
        {
            try
            {
                if (l == null)
                {
                    MessageBox.Show(
                        "Podaci o ligi nisu prosleđeni!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (l.TakmicenjeId <= 0)
                {
                    MessageBox.Show(
                        "ID takmičenja mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(l.SistemBodovanja))
                {
                    MessageBox.Show(
                        "Sistem bodovanja je obavezan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                string tipTakmicenja =
                    s.CreateSQLQuery(
                        "SELECT TIP_TAKMICENJA FROM TAKMICENJE WHERE TAKMICENJE_ID = :id")
                    .SetParameter("id", l.TakmicenjeId)
                    .UniqueResult<string>();

                if (tipTakmicenja == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Takmičenje sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (tipTakmicenja != "Liga")
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrano takmičenje nije tipa Liga!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                int postoji =
                    Convert.ToInt32(
                        s.CreateSQLQuery(
                            "SELECT COUNT(*) FROM LIGA WHERE TAKMICENJE_ID = :id")
                        .SetParameter("id", l.TakmicenjeId)
                        .UniqueResult());

                if (postoji > 0)
                {
                    s.Close();

                    MessageBox.Show(
                        "Ovo takmičenje je već dodato kao liga!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.CreateSQLQuery(
                        "INSERT INTO LIGA (TAKMICENJE_ID, SISTEM_BODOVANJA) " +
                        "VALUES (:id, :sistem)")
                    .SetParameter("id", l.TakmicenjeId)
                    .SetParameter("sistem", l.SistemBodovanja)
                    .ExecuteUpdate();

                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri dodavanju lige: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static LigaDTO.LigaBasic vratiLigu(int id)
        {
            LigaDTO.LigaBasic lb = new LigaDTO.LigaBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Liga liga =
                    s.Load<ESPORT.Entiteti.Liga>(id);

                lb = new LigaDTO.LigaBasic(
                    liga.TakmicenjeId,
                    liga.SistemBodovanja);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri učitavanju liga: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return lb;
        }

        public static void obrisiLigu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Liga liga =
                    s.Load<ESPORT.Entiteti.Liga>(id);

                s.Delete(liga);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri brisanju lige: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static bool azurirajLigu(LigaDTO.LigaBasic l)
        {
            try
            {
                if (l == null)
                {
                    MessageBox.Show(
                        "Podaci o ligi nisu prosleđeni!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (l.TakmicenjeId <= 0)
                {
                    MessageBox.Show(
                        "ID takmičenja mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(l.SistemBodovanja))
                {
                    MessageBox.Show(
                        "Sistem bodovanja je obavezan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Liga liga =
                    s.Get<ESPORT.Entiteti.Liga>(l.TakmicenjeId);

                if (liga == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Liga sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                liga.SistemBodovanja = l.SistemBodovanja;

                s.Update(liga);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri ažuriranju lige: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static List<TurnirDTO.TurnirPregled> vratiSveTurnire()
        {
            List<TurnirDTO.TurnirPregled> turniri =
                new List<TurnirDTO.TurnirPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ESPORT.Entiteti.Turnir> sviTurniri =
                    from t in s.Query<ESPORT.Entiteti.Turnir>()
                    where t.TipTakmicenja == "Turnir"
                    select t;

                foreach (ESPORT.Entiteti.Turnir t in sviTurniri)
                {
                    turniri.Add(new TurnirDTO.TurnirPregled(
                        t.TakmicenjeId,
                        t.Naziv,
                        t.Organizator,
                        t.Igra.Naziv,
                        t.Region,
                        t.Lokacija,
                        t.FormatTakmicenja,
                        t.DatumPocetka,
                        t.DatumZavrsetka,
                        t.NagradniFond,
                        t.ValutaNagrade,
                        t.Status,
                        t.TipKostura,
                        t.PravilaNapredovanja,
                        t.BrojMecevaPoRundi));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return turniri;
        }

        public static bool dodajTurnir(TurnirDTO.TurnirBasic t)
        {
            try
            {
                if (t == null)
                {
                    MessageBox.Show(
                        "Podaci o turniru nisu prosleđeni!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.TakmicenjeId <= 0)
                {
                    MessageBox.Show(
                        "ID takmičenja mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.TipKostura))
                {
                    MessageBox.Show(
                        "Tip kostura je obavezan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                string tipTakmicenja =
                    s.CreateSQLQuery(
                        "SELECT TIP_TAKMICENJA FROM TAKMICENJE WHERE TAKMICENJE_ID = :id")
                    .SetParameter("id", t.TakmicenjeId)
                    .UniqueResult<string>();

                if (tipTakmicenja == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Takmičenje sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (tipTakmicenja != "Turnir")
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrano takmičenje nije tipa Turnir!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                int postoji =
                    Convert.ToInt32(
                        s.CreateSQLQuery(
                            "SELECT COUNT(*) FROM TURNIR WHERE TAKMICENJE_ID = :id")
                        .SetParameter("id", t.TakmicenjeId)
                        .UniqueResult());

                if (postoji > 0)
                {
                    s.Close();

                    MessageBox.Show(
                        "Ovo takmičenje je već dodato kao turnir!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.CreateSQLQuery(
                        "INSERT INTO TURNIR " +
                        "(TAKMICENJE_ID, TIP_KOSTURA, PRAVILA_NAPREDOVANJA, BROJ_MECEVA_PO_RUNDI) " +
                        "VALUES (:id, :tipKostura, :pravila, :brojMeceva)")
                    .SetParameter("id", t.TakmicenjeId)
                    .SetParameter("tipKostura", t.TipKostura)
                    .SetParameter("pravila", t.PravilaNapredovanja)
                    .SetParameter("brojMeceva", t.BrojMecevaPoRundi)
                    .ExecuteUpdate();

                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri dodavanju turnira: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static TurnirDTO.TurnirBasic vratiTurnir(int id)
        {
            TurnirDTO.TurnirBasic tb = new TurnirDTO.TurnirBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Turnir turnir =
                    s.Load<ESPORT.Entiteti.Turnir>(id);

                tb = new TurnirDTO.TurnirBasic(
                    turnir.TakmicenjeId,
                    turnir.TipKostura,
                    turnir.PravilaNapredovanja,
                    turnir.BrojMecevaPoRundi);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri učitavanju turnira: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tb;
        }

        public static void obrisiTurnir(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Turnir turnir =
                    s.Load<ESPORT.Entiteti.Turnir>(id);

                s.Delete(turnir);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri brisanju turnira: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static bool azurirajTurnir(
     TurnirDTO.TurnirBasic t)
        {
            try
            {
                if (t == null)
                {
                    MessageBox.Show(
                        "Podaci o turniru nisu prosleđeni!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (t.TakmicenjeId <= 0)
                {
                    MessageBox.Show(
                        "ID takmičenja mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(t.TipKostura))
                {
                    MessageBox.Show(
                        "Tip kostura je obavezan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Turnir turnir =
                    s.Get<ESPORT.Entiteti.Turnir>(t.TakmicenjeId);

                if (turnir == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Turnir sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                turnir.TipKostura = t.TipKostura;
                turnir.PravilaNapredovanja = t.PravilaNapredovanja;
                turnir.BrojMecevaPoRundi = t.BrojMecevaPoRundi;

                s.Update(turnir);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri ažuriranju turnira: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static List<FazaTakmicenjaDTO.FazaTakmicenjaPregled> vratiSveFaze()
        {
            List<FazaTakmicenjaDTO.FazaTakmicenjaPregled> faze =
                new List<FazaTakmicenjaDTO.FazaTakmicenjaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ESPORT.Entiteti.FazaTakmicenja> sveFaze =
                    from f in s.Query<ESPORT.Entiteti.FazaTakmicenja>()
                    select f;

                foreach (ESPORT.Entiteti.FazaTakmicenja f in sveFaze)
                {
                    faze.Add(
                        new FazaTakmicenjaDTO.FazaTakmicenjaPregled(
                            f.FazaId,
                            f.Turnir.TakmicenjeId,
                            f.Turnir.Naziv,
                            f.NazivFaze,
                            f.RedniBroj,
                            f.Nadfaza != null
                                ? f.Nadfaza.FazaId
                                : (int?)null));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return faze;
        }

        public static FazaTakmicenjaDTO.FazaTakmicenjaBasic vratiFazu(int id)
        {
            FazaTakmicenjaDTO.FazaTakmicenjaBasic faza = null;

            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.FazaTakmicenja f =
                    s.Get<ESPORT.Entiteti.FazaTakmicenja>(id);

                if (f != null)
                {
                    faza =
                        new FazaTakmicenjaDTO.FazaTakmicenjaBasic(
                            f.FazaId,
                            f.Turnir.TakmicenjeId,
                            f.NazivFaze,
                            f.RedniBroj,
                            f.Nadfaza != null
                                ? f.Nadfaza.FazaId
                                : (int?)null);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return faza;
        }

        public static bool dodajFazu(
     FazaTakmicenjaDTO.FazaTakmicenjaBasic f)
        {
            try
            {
                if (f == null)
                {
                    MessageBox.Show(
                        "Podaci o fazi nisu prosleđeni!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (f.TakmicenjeId <= 0)
                {
                    MessageBox.Show(
                        "ID takmičenja mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(f.NazivFaze))
                {
                    MessageBox.Show(
                        "Naziv faze je obavezan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (f.RedniBroj <= 0)
                {
                    MessageBox.Show(
                        "Redni broj mora biti veći od 0!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                int postojiTurnir =
                    Convert.ToInt32(
                        s.CreateSQLQuery(
                            "SELECT COUNT(*) " +
                            "FROM TURNIR " +
                            "WHERE TAKMICENJE_ID = :id")
                        .SetParameter("id", f.TakmicenjeId)
                        .UniqueResult());

                if (postojiTurnir == 0)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrano takmičenje nije turnir ili ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                int postojiFaza =
                    Convert.ToInt32(
                        s.CreateSQLQuery(
                            "SELECT COUNT(*) " +
                            "FROM FAZA_TAKMICENJA " +
                            "WHERE FAZA_ID = :id")
                        .SetParameter("id", f.FazaId)
                        .UniqueResult());

                if (postojiFaza > 0)
                {
                    s.Close();

                    MessageBox.Show(
                        "Faza sa tim ID-em već postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.FazaTakmicenja novaFaza =
                    new ESPORT.Entiteti.FazaTakmicenja();

                novaFaza.NazivFaze = f.NazivFaze;
                novaFaza.RedniBroj = f.RedniBroj;

                novaFaza.Turnir =
                    s.Get<ESPORT.Entiteti.Turnir>(f.TakmicenjeId);

                if (f.NadfazaId.HasValue)
                {
                    if (f.NadfazaId.Value <= 0)
                    {
                        s.Close();

                        MessageBox.Show(
                            "ID nadfaze nije ispravan!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }

                    novaFaza.Nadfaza =
                        s.Get<ESPORT.Entiteti.FazaTakmicenja>(
                            f.NadfazaId.Value);

                    if (novaFaza.Nadfaza == null)
                    {
                        s.Close();

                        MessageBox.Show(
                            "Izabrana nadfaza ne postoji!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }

                    if (novaFaza.Nadfaza.Turnir.TakmicenjeId !=
                        f.TakmicenjeId)
                    {
                        s.Close();

                        MessageBox.Show(
                            "Nadfaza mora pripadati istom turniru!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }
                }

                s.Save(novaFaza);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri dodavanju faze: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static bool azurirajFazu(
     FazaTakmicenjaDTO.FazaTakmicenjaBasic f)
        {
            try
            {
                if (f == null)
                {
                    MessageBox.Show(
                        "Podaci o fazi nisu prosleđeni!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (f.FazaId <= 0)
                {
                    MessageBox.Show(
                        "ID faze mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (f.TakmicenjeId <= 0)
                {
                    MessageBox.Show(
                        "ID turnira mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (string.IsNullOrWhiteSpace(f.NazivFaze))
                {
                    MessageBox.Show(
                        "Naziv faze je obavezan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (f.RedniBroj <= 0)
                {
                    MessageBox.Show(
                        "Redni broj mora biti veći od 0!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.FazaTakmicenja faza =
                    s.Get<ESPORT.Entiteti.FazaTakmicenja>(f.FazaId);

                if (faza == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Faza ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                int postojiTurnir =
                    Convert.ToInt32(
                        s.CreateSQLQuery(
                            "SELECT COUNT(*) " +
                            "FROM TURNIR " +
                            "WHERE TAKMICENJE_ID = :id")
                        .SetParameter("id", f.TakmicenjeId)
                        .UniqueResult());

                if (postojiTurnir == 0)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrano takmičenje nije turnir ili ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (f.NadfazaId.HasValue &&
                    f.NadfazaId.Value == f.FazaId)
                {
                    s.Close();

                    MessageBox.Show(
                        "Faza ne može biti sama sebi nadfaza!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                faza.NazivFaze = f.NazivFaze;
                faza.RedniBroj = f.RedniBroj;

                if (f.NadfazaId.HasValue)
                {
                    faza.Nadfaza =
                        s.Get<ESPORT.Entiteti.FazaTakmicenja>(
                            f.NadfazaId.Value);

                    if (faza.Nadfaza == null)
                    {
                        s.Close();

                        MessageBox.Show(
                            "Izabrana nadfaza ne postoji!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }

                    if (faza.Nadfaza.Turnir.TakmicenjeId !=
                        f.TakmicenjeId)
                    {
                        s.Close();

                        MessageBox.Show(
                            "Nadfaza mora pripadati istom turniru!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }
                }
                else
                {
                    faza.Nadfaza = null;
                }

                s.Update(faza);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri ažuriranju faze: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static bool obrisiFazu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.FazaTakmicenja faza =
                    s.Get<ESPORT.Entiteti.FazaTakmicenja>(id);

                if (faza == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Faza ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(faza);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static List<MecDTO.MecPregled> vratiSveMeceve()
        {
            List<MecDTO.MecPregled> mecevi =
                new List<MecDTO.MecPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ESPORT.Entiteti.Mec> sviMecevi =
                    from m in s.Query<ESPORT.Entiteti.Mec>()
                    select m;

                foreach (ESPORT.Entiteti.Mec m in sviMecevi)
                {
                    mecevi.Add(
                        new MecDTO.MecPregled(
                            m.MecId,
                            m.Takmicenje.TakmicenjeId,
                            m.Takmicenje.Naziv,
                            m.RedniBroj,
                            m.DatumVremePocetka,
                            m.FormatMeca,
                            m.BrojOdigranihMapa,
                            m.Rezultat,
                            m.Trajanje,
                            m.LokacijaIgranja,
                            m.Sudije,
                            m.StatusMeca));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return mecevi;
        }

        public static bool dodajMec(MecDTO.MecBasic m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Takmicenje takmicenje =
                    s.Get<ESPORT.Entiteti.Takmicenje>(
                        m.TakmicenjeId);

                if (takmicenje == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Takmičenje sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Mec noviMec =
                    new ESPORT.Entiteti.Mec();

                noviMec.Takmicenje = takmicenje;
                noviMec.RedniBroj = m.RedniBroj;
                noviMec.DatumVremePocetka = m.DatumVremePocetka;
                noviMec.FormatMeca = m.FormatMeca;
                noviMec.BrojOdigranihMapa = m.BrojOdigranihMapa;
                noviMec.Rezultat = m.Rezultat;
                noviMec.Trajanje = m.Trajanje;
                noviMec.LokacijaIgranja = m.LokacijaIgranja;
                noviMec.Sudije = m.Sudije;
                noviMec.StatusMeca = m.StatusMeca;

                s.Save(noviMec);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.ToString(),
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static MecDTO.MecBasic vratiMec(int id)
        {
            MecDTO.MecBasic mec = null;

            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Mec m =
                    s.Get<ESPORT.Entiteti.Mec>(id);

                if (m != null)
                {
                    mec =
                        new MecDTO.MecBasic(
                            m.MecId,
                            m.Takmicenje.TakmicenjeId,
                            m.RedniBroj,
                            m.DatumVremePocetka,
                            m.FormatMeca,
                            m.BrojOdigranihMapa,
                            m.Rezultat,
                            m.Trajanje,
                            m.LokacijaIgranja,
                            m.Sudije,
                            m.StatusMeca);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return mec;
        }

        public static bool azurirajMec(MecDTO.MecBasic m)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Mec mec =
                    s.Get<ESPORT.Entiteti.Mec>(m.MecId);

                if (mec == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Meč ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Takmicenje takmicenje =
                    s.Get<ESPORT.Entiteti.Takmicenje>(
                        m.TakmicenjeId);

                if (takmicenje == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Takmičenje sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                mec.Takmicenje = takmicenje;
                mec.RedniBroj = m.RedniBroj;
                mec.DatumVremePocetka = m.DatumVremePocetka;
                mec.FormatMeca = m.FormatMeca;
                mec.BrojOdigranihMapa = m.BrojOdigranihMapa;
                mec.Rezultat = m.Rezultat;
                mec.Trajanje = m.Trajanje;
                mec.LokacijaIgranja = m.LokacijaIgranja;
                mec.Sudije = m.Sudije;
                mec.StatusMeca = m.StatusMeca;

                s.Update(mec);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static bool obrisiMec(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Mec mec =
                    s.Get<ESPORT.Entiteti.Mec>(id);

                if (mec == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Meč ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(mec);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static List<DogadjajNaMecuDTO.DogadjajNaMecuPregled> vratiSveDogadjajeNaMecu()
        {
            List<DogadjajNaMecuDTO.DogadjajNaMecuPregled> dogadjaji =
                new List<DogadjajNaMecuDTO.DogadjajNaMecuPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ESPORT.Entiteti.DogadjajNaMecu> sviDogadjaji =
                    from d in s.Query<ESPORT.Entiteti.DogadjajNaMecu>()
                    select d;

                foreach (ESPORT.Entiteti.DogadjajNaMecu d in sviDogadjaji)
                {
                    dogadjaji.Add(
                        new DogadjajNaMecuDTO.DogadjajNaMecuPregled(
                            d.DogadjajId,
                            d.Mec.MecId,
                            d.Mec.RedniBroj,
                            d.TipDogadjaja,
                            d.VremeDogadjaja,
                            d.Opis,
                            d.OdlukaSudije));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return dogadjaji;
        }

        public static bool dodajDogadjajNaMecu(DogadjajNaMecuDTO.DogadjajNaMecuBasic d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Mec mec =
                    s.Get<ESPORT.Entiteti.Mec>(d.MecId);

                if (mec == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Meč sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.DogadjajNaMecu noviDogadjaj =
                    new ESPORT.Entiteti.DogadjajNaMecu();

                noviDogadjaj.Mec = mec;
                noviDogadjaj.TipDogadjaja = d.TipDogadjaja;
                noviDogadjaj.VremeDogadjaja = d.VremeDogadjaja;
                noviDogadjaj.Opis = d.Opis;
                noviDogadjaj.OdlukaSudije = d.OdlukaSudije;

                s.Save(noviDogadjaj);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                string poruka = ec.Message;

                if (ec.InnerException != null)
                    poruka += "\n\nDetalji:\n" + ec.InnerException.Message;

                if (ec.InnerException?.InnerException != null)
                    poruka += "\n\nOracle:\n" + ec.InnerException.InnerException.Message;

                MessageBox.Show(
                    poruka,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static DogadjajNaMecuDTO.DogadjajNaMecuBasic vratiDogadjajNaMecu(int id)
        {
            DogadjajNaMecuDTO.DogadjajNaMecuBasic dogadjaj = null;

            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.DogadjajNaMecu d =
                    s.Get<ESPORT.Entiteti.DogadjajNaMecu>(id);

                if (d != null)
                {
                    dogadjaj =
                        new DogadjajNaMecuDTO.DogadjajNaMecuBasic(
                            d.DogadjajId,
                            d.Mec.MecId,
                            d.TipDogadjaja,
                            d.VremeDogadjaja,
                            d.Opis,
                            d.OdlukaSudije);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return dogadjaj;
        }

        public static bool azurirajDogadjajNaMecu(DogadjajNaMecuDTO.DogadjajNaMecuBasic d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.DogadjajNaMecu dogadjaj =
                    s.Get<ESPORT.Entiteti.DogadjajNaMecu>(d.DogadjajId);

                if (dogadjaj == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Događaj ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Mec mec =
                    s.Get<ESPORT.Entiteti.Mec>(d.MecId);

                if (mec == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Meč sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                dogadjaj.Mec = mec;
                dogadjaj.TipDogadjaja = d.TipDogadjaja;
                dogadjaj.VremeDogadjaja = d.VremeDogadjaja;
                dogadjaj.Opis = d.Opis;
                dogadjaj.OdlukaSudije = d.OdlukaSudije;

                s.Update(dogadjaj);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static bool obrisiDogadjajNaMecu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.DogadjajNaMecu dogadjaj =
                    s.Get<ESPORT.Entiteti.DogadjajNaMecu>(id);

                if (dogadjaj == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Događaj ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(dogadjaj);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static List<UcesceTimaUFaziDTO.UcescePregled> vratiSvaUcesca()
        {
            List<UcesceTimaUFaziDTO.UcescePregled> ucesca =
                new List<UcesceTimaUFaziDTO.UcescePregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ESPORT.Entiteti.UcesceTimaUFazi> svaUcesca =
                    from u in s.Query<ESPORT.Entiteti.UcesceTimaUFazi>()
                    select u;

                foreach (ESPORT.Entiteti.UcesceTimaUFazi u in svaUcesca)
                {
                    ucesca.Add(
                        new UcesceTimaUFaziDTO.UcescePregled(
                            u.FazaId.FazaId,
                            u.TimId.TimId,
                            u.FazaId.NazivFaze,
                            u.TimId.Naziv,
                            u.Status,
                            u.OstvareniRezultat,
                            u.BrojPobeda,
                            u.BrojPoraza,
                            u.OsvojeniBodovi,
                            u.KonacanPlasman));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return ucesca;
        }

        public static bool dodajUcesce(
    UcesceTimaUFaziDTO.UcesceBasic u)
        {
            try
            {
                if (u == null)
                {
                    MessageBox.Show(
                        "Podaci o učešću nisu prosleđeni!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.FazaId <= 0)
                {
                    MessageBox.Show(
                        "ID faze mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.TimId <= 0)
                {
                    MessageBox.Show(
                        "ID tima mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (!string.IsNullOrWhiteSpace(u.Status) &&
                    u.Status != "Učestvuje" &&
                    u.Status != "Kvalifikovan" &&
                    u.Status != "Eliminisan" &&
                    u.Status != "Diskvalifikovan")
                {
                    MessageBox.Show(
                        "Status učešća nije ispravan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.BrojPobeda < 0)
                {
                    MessageBox.Show(
                        "Broj pobeda ne može biti negativan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.BrojPoraza < 0)
                {
                    MessageBox.Show(
                        "Broj poraza ne može biti negativan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.OsvojeniBodovi < 0)
                {
                    MessageBox.Show(
                        "Broj osvojenih bodova ne može biti negativan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.KonacanPlasman.HasValue &&
                    u.KonacanPlasman.Value <= 0)
                {
                    MessageBox.Show(
                        "Konačan plasman mora biti veći od 0!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.FazaTakmicenja faza =
                    s.Get<ESPORT.Entiteti.FazaTakmicenja>(
                        u.FazaId);

                if (faza == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Faza sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim tim =
                    s.Get<ESPORT.Entiteti.Tim>(
                        u.TimId);

                if (tim == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Tim sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.UcesceTimaUFazi postoji =
                    s.Query<ESPORT.Entiteti.UcesceTimaUFazi>()
                     .FirstOrDefault(x =>
                         x.FazaId.FazaId == u.FazaId &&
                         x.TimId.TimId == u.TimId);

                if (postoji != null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Ovaj tim već učestvuje u izabranoj fazi!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.UcesceTimaUFazi novoUcesce =
                    new ESPORT.Entiteti.UcesceTimaUFazi();

                novoUcesce.FazaId = faza;
                novoUcesce.TimId = tim;
                novoUcesce.Status = u.Status;
                novoUcesce.OstvareniRezultat = u.OstvareniRezultat;
                novoUcesce.BrojPobeda = u.BrojPobeda;
                novoUcesce.BrojPoraza = u.BrojPoraza;
                novoUcesce.OsvojeniBodovi = u.OsvojeniBodovi;
                novoUcesce.KonacanPlasman = u.KonacanPlasman;

                s.Save(novoUcesce);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri dodavanju učešća: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static UcesceTimaUFaziDTO.UcesceBasic vratiUcesce(
    int fazaId,
    int timId)
        {
            UcesceTimaUFaziDTO.UcesceBasic ucesce = null;

            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.UcesceTimaUFazi u =
                    s.Query<ESPORT.Entiteti.UcesceTimaUFazi>()
                     .FirstOrDefault(x =>
                         x.FazaId.FazaId == fazaId &&
                         x.TimId.TimId == timId);

                if (u != null)
                {
                    ucesce =
                        new UcesceTimaUFaziDTO.UcesceBasic(
                            u.FazaId.FazaId,
                            u.TimId.TimId,
                            u.Status,
                            u.OstvareniRezultat,
                            u.BrojPobeda,
                            u.BrojPoraza,
                            u.OsvojeniBodovi,
                            u.KonacanPlasman);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return ucesce;
        }

        public static bool azurirajUcesce(
     UcesceTimaUFaziDTO.UcesceBasic u)
        {
            try
            {
                if (u == null)
                {
                    MessageBox.Show(
                        "Podaci o učešću nisu prosleđeni!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.FazaId <= 0)
                {
                    MessageBox.Show(
                        "ID faze mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.TimId <= 0)
                {
                    MessageBox.Show(
                        "ID tima mora biti pozitivan broj!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (!string.IsNullOrWhiteSpace(u.Status) &&
                    u.Status != "Učestvuje" &&
                    u.Status != "Kvalifikovan" &&
                    u.Status != "Eliminisan" &&
                    u.Status != "Diskvalifikovan")
                {
                    MessageBox.Show(
                        "Status učešća nije ispravan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.BrojPobeda < 0)
                {
                    MessageBox.Show(
                        "Broj pobeda ne može biti negativan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.BrojPoraza < 0)
                {
                    MessageBox.Show(
                        "Broj poraza ne može biti negativan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.OsvojeniBodovi < 0)
                {
                    MessageBox.Show(
                        "Broj osvojenih bodova ne može biti negativan!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (u.KonacanPlasman.HasValue &&
                    u.KonacanPlasman.Value <= 0)
                {
                    MessageBox.Show(
                        "Konačan plasman mora biti veći od 0!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.UcesceTimaUFazi ucesce =
                    s.Query<ESPORT.Entiteti.UcesceTimaUFazi>()
                     .FirstOrDefault(x =>
                         x.FazaId.FazaId == u.FazaId &&
                         x.TimId.TimId == u.TimId);

                if (ucesce == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Učešće ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ucesce.Status = u.Status;
                ucesce.OstvareniRezultat = u.OstvareniRezultat;
                ucesce.BrojPobeda = u.BrojPobeda;
                ucesce.BrojPoraza = u.BrojPoraza;
                ucesce.OsvojeniBodovi = u.OsvojeniBodovi;
                ucesce.KonacanPlasman = u.KonacanPlasman;

                s.Update(ucesce);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri ažuriranju učešća: {ec.Message}\n" +
                    $"Inner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static bool obrisiUcesce(
    int fazaId,
    int timId)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.UcesceTimaUFazi ucesce =
                    s.Query<ESPORT.Entiteti.UcesceTimaUFazi>()
                     .FirstOrDefault(x =>
                         x.FazaId.FazaId == fazaId &&
                         x.TimId.TimId == timId);

                if (ucesce == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Učešće ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(ucesce);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        // ===================== TIM =====================

        public static List<TimDTO.TimPregled> vratiSveTimove()
        {
            List<TimDTO.TimPregled> timovi =
                new List<TimDTO.TimPregled>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return timovi;

                    IList<ESPORT.Entiteti.Tim> sviTimovi =
                        s.Query<ESPORT.Entiteti.Tim>()
                         .OrderBy(t => t.TimId)
                         .ToList();

                    foreach (ESPORT.Entiteti.Tim t in sviTimovi)
                    {
                        timovi.Add(
                            new TimDTO.TimPregled(
                                t.TimId,
                                t.Naziv,
                                t.IgraId.IgraId,
                                t.IgraId.Naziv,
                                t.DatumOsnivanja,
                                t.DrzavaRegistracije,
                                t.StatusTima,
                                t.NivoTakmicenja));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return timovi;
        }

        public static bool dodajTim(TimDTO.TimBasic t)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    ESPORT.Entiteti.Igra igra =
                        s.Get<ESPORT.Entiteti.Igra>(t.IgraId);

                    if (igra == null)
                    {
                        MessageBox.Show(
                            "Igra sa tim ID-em ne postoji!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Tim noviTim =
                            new ESPORT.Entiteti.Tim();

                        noviTim.Naziv = t.Naziv;
                        noviTim.IgraId = igra;
                        noviTim.DatumOsnivanja = t.DatumOsnivanja;
                        noviTim.DrzavaRegistracije = t.DrzavaRegistracije;
                        noviTim.StatusTima = t.StatusTima;
                        noviTim.NivoTakmicenja = t.NivoTakmicenja;

                        s.Save(noviTim);
                        tx.Commit();
                    }

                    return true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri dodavanju tima: {ec.Message}\nInner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static TimDTO.TimBasic vratiTim(int id)
        {
            TimDTO.TimBasic tim = null;

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    ESPORT.Entiteti.Tim t =
                        s.Get<ESPORT.Entiteti.Tim>(id);

                    if (t != null)
                    {
                        tim =
                            new TimDTO.TimBasic(
                                t.TimId,
                                t.Naziv,
                                t.IgraId.IgraId,
                                t.DatumOsnivanja,
                                t.DrzavaRegistracije,
                                t.StatusTima,
                                t.NivoTakmicenja);
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri preuzimanju tima: {ec.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return tim;
        }

        public static bool azurirajTim(TimDTO.TimBasic t)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    ESPORT.Entiteti.Tim tim =
                        s.Get<ESPORT.Entiteti.Tim>(t.TimId);

                    if (tim == null)
                    {
                        MessageBox.Show(
                            "Tim sa tim ID-em ne postoji!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }

                    ESPORT.Entiteti.Igra igra =
                        s.Get<ESPORT.Entiteti.Igra>(t.IgraId);

                    if (igra == null)
                    {
                        MessageBox.Show(
                            "Igra sa tim ID-em ne postoji!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        tim.Naziv = t.Naziv;
                        tim.IgraId = igra;
                        tim.DatumOsnivanja = t.DatumOsnivanja;
                        tim.DrzavaRegistracije = t.DrzavaRegistracije;
                        tim.StatusTima = t.StatusTima;
                        tim.NivoTakmicenja = t.NivoTakmicenja;

                        s.Update(tim);
                        tx.Commit();
                    }

                    return true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri ažuriranju tima: {ec.Message}\nInner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static bool obrisiTim(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    ESPORT.Entiteti.Tim tim =
                        s.Get<ESPORT.Entiteti.Tim>(id);

                    if (tim == null)
                    {
                        MessageBox.Show(
                            "Tim sa tim ID-em ne postoji!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        s.Delete(tim);
                        tx.Commit();
                    }

                    return true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri brisanju tima: {ec.Message}\nInner: {ec.InnerException?.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        // =========================================================================
        // SPONZORI - METODE
        // =========================================================================

        public static List<SponzorDTO.Sponzor> vratiSveSponzore()
        {
            List<SponzorDTO.Sponzor> sponzori = new List<SponzorDTO.Sponzor>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return sponzori;

                    List<ESPORT.Entiteti.Sponzor> sviSponzori = s.Query<ESPORT.Entiteti.Sponzor>()
                                                                   .OrderBy(sp => sp.SponzorId)
                                                                   .ToList();

                    foreach (ESPORT.Entiteti.Sponzor sp in sviSponzori)
                    {
                        sponzori.Add(new SponzorDTO.Sponzor(
                            sp.SponzorId,
                            sp.Naziv,
                            sp.Drzava,
                            sp.TipSponzora,
                            sp.OblastPoslovanja
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju sponzora: {ec.Message}");
            }
            return sponzori;
        }

        public static SponzorDTO.SponzorBasic vratiSponzora(int id)
        {
            SponzorDTO.SponzorBasic sb = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    ESPORT.Entiteti.Sponzor sp = s.Get<ESPORT.Entiteti.Sponzor>(id);
                    if (sp == null) return null;

                    sb = new SponzorDTO.SponzorBasic(
                        sp.SponzorId,
                        sp.Naziv,
                        sp.Drzava,
                        sp.TipSponzora,
                        sp.OblastPoslovanja
                    );

                    foreach (var k in sp.Kontakti)
                    {
                        sb.Kontakti.Add(new SponzorDTO.SponzorKontaktBasic(
                            k.KontaktId,
                            sp.SponzorId,
                            k.Ime,
                            k.Prezime,
                            k.Telefon,
                            k.Email
                        ));
                    }

                    foreach (var u in sp.Ugovori)
                    {
                        sb.Ugovori.Add(new SponzorDTO.SponzorskiUgovorBasic(
                            u.UgovorId,
                            sp.SponzorId,
                            u.DatumOd,
                            u.DatumDo,
                            u.Iznos,
                            u.Valuta,
                            u.TipPodrske,
                            u.MarketinskeObaveze
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju detalja sponzora: {ec.Message}");
            }
            return sb;
        }

        public static bool dodajSponzora(SponzorDTO.SponzorBasic sb)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Sponzor sp = new ESPORT.Entiteti.Sponzor
                        {
                            Naziv = sb.Naziv,
                            Drzava = sb.Drzava,
                            TipSponzora = sb.TipSponzora,
                            OblastPoslovanja = sb.OblastPoslovanja
                        };

                        s.Save(sp);
                        tx.Commit();
                    }
                }
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju sponzora: {ec.Message}\nInner: {ec.InnerException?.Message}");
                return false;
            }
        }

        public static bool azurirajSponzora(SponzorDTO.SponzorBasic sb)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Sponzor sp = s.Load<ESPORT.Entiteti.Sponzor>(sb.SponzorId);
                        if (sp == null) return false;

                        sp.Naziv = sb.Naziv;
                        sp.Drzava = sb.Drzava;
                        sp.TipSponzora = sb.TipSponzora;
                        sp.OblastPoslovanja = sb.OblastPoslovanja;

                        s.Update(sp);
                        tx.Commit();
                    }
                }
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju sponzora: {ec.Message}\nInner: {ec.InnerException?.Message}");
                return false;
            }
        }

        public static void obrisiSponzora(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Sponzor sp = s.Load<ESPORT.Entiteti.Sponzor>(id);
                        s.Delete(sp);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju sponzora: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        // =========================================================================
        // SPONZOR KONTAKT - METODE
        // =========================================================================

        public static bool dodajSponzorKontakt(SponzorDTO.SponzorKontaktBasic kb)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Sponzor sponzor = s.Get<ESPORT.Entiteti.Sponzor>(kb.SponzorId);
                        if (sponzor == null) return false;

                        ESPORT.Entiteti.SponzorKontakt kontakt = new ESPORT.Entiteti.SponzorKontakt
                        {
                            Sponzor = sponzor,
                            Ime = kb.Ime,
                            Prezime = kb.Prezime,
                            Telefon = kb.Telefon,
                            Email = kb.Email
                        };

                        s.Save(kontakt);
                        tx.Commit();
                    }
                }
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju kontakta: {ec.Message}");
                return false;
            }
        }

        public static bool azurirajSponzorKontakt(SponzorDTO.SponzorKontaktBasic kb)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.SponzorKontakt kontakt = s.Load<ESPORT.Entiteti.SponzorKontakt>(kb.KontaktId);
                        if (kontakt == null) return false;

                        kontakt.Ime = kb.Ime;
                        kontakt.Prezime = kb.Prezime;
                        kontakt.Telefon = kb.Telefon;
                        kontakt.Email = kb.Email;

                        s.Update(kontakt);
                        tx.Commit();
                    }
                }
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju kontakta: {ec.Message}");
                return false;
            }
        }

        public static void obrisiSponzorKontakt(int kontaktId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.SponzorKontakt kontakt = s.Load<ESPORT.Entiteti.SponzorKontakt>(kontaktId);
                        s.Delete(kontakt);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju kontakta: {ec.Message}");
            }
        }

        // =========================================================================
        // SPONZORSKI UGOVOR - METODE
        // =========================================================================

        public static bool dodajSponzorskiUgovor(SponzorDTO.SponzorskiUgovorBasic ub)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Sponzor sponzor = s.Get<ESPORT.Entiteti.Sponzor>(ub.SponzorId);
                        if (sponzor == null) return false;

                        ESPORT.Entiteti.SponzorskiUgovor ugovor = new ESPORT.Entiteti.SponzorskiUgovor
                        {
                            Sponzor = sponzor,
                            DatumOd = ub.DatumOd,
                            DatumDo = ub.DatumDo,
                            Iznos = ub.Iznos,
                            Valuta = ub.Valuta,
                            TipPodrske = ub.TipPodrske,
                            MarketinskeObaveze = ub.MarketinskeObaveze
                        };

                        s.Save(ugovor);
                        tx.Commit();
                    }
                }
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju ugovora: {ec.Message}");
                return false;
            }
        }

        public static bool azurirajSponzorskiUgovor(SponzorDTO.SponzorskiUgovorBasic ub)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.SponzorskiUgovor ugovor = s.Load<ESPORT.Entiteti.SponzorskiUgovor>(ub.UgovorId);
                        if (ugovor == null) return false;

                        ugovor.DatumOd = ub.DatumOd;
                        ugovor.DatumDo = ub.DatumDo;
                        ugovor.Iznos = ub.Iznos;
                        ugovor.Valuta = ub.Valuta;
                        ugovor.TipPodrske = ub.TipPodrske;
                        ugovor.MarketinskeObaveze = ub.MarketinskeObaveze;

                        s.Update(ugovor);
                        tx.Commit();
                    }
                }
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju ugovora: {ec.Message}");
                return false;
            }
        }

        public static void obrisiSponzorskiUgovor(int ugovorId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.SponzorskiUgovor ugovor = s.Load<ESPORT.Entiteti.SponzorskiUgovor>(ugovorId);
                        s.Delete(ugovor);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju ugovora: {ec.Message}");
            }
        }

        public static List<SponzorDTO.SponzorskiUgovorBasic> vratiSveSponzorskeUgovore()
        {
            List<SponzorDTO.SponzorskiUgovorBasic> lista =
                new List<SponzorDTO.SponzorskiUgovorBasic>();

            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return lista;

                    IList<ESPORT.Entiteti.SponzorskiUgovor> ugovori =
                        s.Query<ESPORT.Entiteti.SponzorskiUgovor>()
                         .OrderBy(u => u.UgovorId)
                         .ToList();

                    foreach (ESPORT.Entiteti.SponzorskiUgovor u in ugovori)
                    {
                        SponzorDTO.SponzorskiUgovorBasic ub =
                            new SponzorDTO.SponzorskiUgovorBasic(
                                u.UgovorId,
                                u.Sponzor.SponzorId,
                                u.DatumOd,
                                u.DatumDo,
                                u.Iznos,
                                u.Valuta,
                                u.TipPodrske,
                                u.MarketinskeObaveze);

                        ub.NazivSponzora = $"{u.Sponzor.Naziv} ({u.DatumOd:dd.MM.yyyy} - {u.DatumDo:dd.MM.yyyy})";

                        lista.Add(ub);
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju sponzorskih ugovora: {ec.Message}");
            }

            return lista;
        }

        // =========================================================================
        // UGOVORI IGRAČA - METODE
        // =========================================================================

        public static List<UgovorDTO.UgovorIgracaBasic> vratiSveUgovoreIgraca()
        {
            List<UgovorDTO.UgovorIgracaBasic> lista = new List<UgovorDTO.UgovorIgracaBasic>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return lista;

                    var ugovori = s.Query<ESPORT.Entiteti.UgovorIgraca>().ToList();

                    foreach (var u in ugovori)
                    {
                        lista.Add(new UgovorDTO.UgovorIgracaBasic(
                            u.UgovorId,
                            u.Igrac?.OsobaId ?? 0,
                            u.Igrac != null ? $"{u.Igrac.Ime} {u.Igrac.Prezime}" : "",
                            u.Tim?.TimId ?? 0,
                            u.Tim?.Naziv ?? "",
                            u.DatumOd,
                            u.DatumDo,
                            u.TipUgovora,
                            u.Plata,
                            u.Bonusi,
                            u.KlauzulaOtkup,
                            u.ZabranaNastupa,
                            u.StatusIgraca
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri preuzimanju ugovora igrača: {ec.Message}");
            }
            return lista;
        }

        public static bool dodajUgovorIgraca(UgovorDTO.UgovorIgracaBasic ub)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        var igrac = s.Get<ESPORT.Entiteti.Igrac>(ub.IgracId);
                        var tim = s.Get<ESPORT.Entiteti.Tim>(ub.TimId);

                        if (igrac == null || tim == null)
                        {
                            MessageBox.Show("Izabrani igrač ili tim ne postoje!");
                            return false;
                        }

                        ESPORT.Entiteti.UgovorIgraca novi = new ESPORT.Entiteti.UgovorIgraca
                        {
                            Igrac = igrac,
                            Tim = tim,
                            DatumOd = ub.DatumOd,
                            DatumDo = ub.DatumDo,
                            TipUgovora = ub.TipUgovora,
                            Plata = ub.Plata,
                            Bonusi = ub.Bonusi,
                            KlauzulaOtkup = ub.KlauzulaOtkup,
                            ZabranaNastupa = ub.ZabranaNastupa,
                            StatusIgraca = ub.StatusIgraca
                        };

                        s.Save(novi);
                        tx.Commit();
                    }
                }
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju ugovora igrača: {ec.Message}");
                return false;
            }
        }

        public static bool azurirajUgovorIgraca(UgovorDTO.UgovorIgracaBasic ub)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        var ugovor = s.Load<ESPORT.Entiteti.UgovorIgraca>(ub.UgovorId);
                        var igrac = s.Get<ESPORT.Entiteti.Igrac>(ub.IgracId);
                        var tim = s.Get<ESPORT.Entiteti.Tim>(ub.TimId);

                        if (ugovor == null || igrac == null || tim == null) return false;

                        ugovor.Igrac = igrac;
                        ugovor.Tim = tim;
                        ugovor.DatumOd = ub.DatumOd;
                        ugovor.DatumDo = ub.DatumDo;
                        ugovor.TipUgovora = ub.TipUgovora;
                        ugovor.Plata = ub.Plata;
                        ugovor.Bonusi = ub.Bonusi;
                        ugovor.KlauzulaOtkup = ub.KlauzulaOtkup;
                        ugovor.ZabranaNastupa = ub.ZabranaNastupa;
                        ugovor.StatusIgraca = ub.StatusIgraca;

                        s.Update(ugovor);
                        tx.Commit();
                    }
                }
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri ažuriranju ugovora igrača: {ec.Message}");
                return false;
            }
        }

        public static void obrisiUgovorIgraca(int ugovorId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        var ugovor = s.Load<ESPORT.Entiteti.UgovorIgraca>(ugovorId);
                        s.Delete(ugovor);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju ugovora igrača: {ec.Message}");
            }
        }


        // =========================================================================
        // UGOVOR SUBJEKAT - METODE
        // =========================================================================

        public static UgovorDTO.UgovorSubjekatBasic vratiUgovorSubjekat(int ugovorId)
        {
            UgovorDTO.UgovorSubjekatBasic subjekat = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    var us = s.Get<ESPORT.Entiteti.UgovorSubjekat>(ugovorId);
                    if (us != null)
                    {
                        subjekat = new UgovorDTO.UgovorSubjekatBasic(
                            us.UgovorId,
                            us.Tim?.TimId,
                            us.Tim?.Naziv,
                            us.Igrac?.OsobaId,
                            us.Igrac != null ? $"{us.Igrac.Ime} {us.Igrac.Prezime}" : null,
                            us.Takmicenje?.TakmicenjeId,
                            us.Takmicenje?.Naziv
                        );
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri učitavanju subjekta ugovora: {ec.Message}");
            }
            return subjekat;
        }

        public static bool sacuvajUgovorSubjekat(UgovorDTO.UgovorSubjekatBasic sb)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        var sponzorskiUgovor = s.Get<ESPORT.Entiteti.SponzorskiUgovor>(sb.UgovorId);
                        if (sponzorskiUgovor == null)
                        {
                            MessageBox.Show("Glavni sponzorski ugovor ne postoji!");
                            return false;
                        }

                        var us = s.Get<ESPORT.Entiteti.UgovorSubjekat>(sb.UgovorId);
                        bool novi = (us == null);

                        if (novi)
                        {
                            us = new ESPORT.Entiteti.UgovorSubjekat
                            {
                                UgovorId = sb.UgovorId,
                                Ugovor = sponzorskiUgovor
                            };
                        }

                        us.Tim = sb.TimId.HasValue && sb.TimId.Value > 0 ? s.Get<ESPORT.Entiteti.Tim>(sb.TimId.Value) : null;
                        us.Igrac = sb.IgracId.HasValue && sb.IgracId.Value > 0 ? s.Get<ESPORT.Entiteti.Igrac>(sb.IgracId.Value) : null;
                        us.Takmicenje = sb.TakmicenjeId.HasValue && sb.TakmicenjeId.Value > 0 ? s.Get<ESPORT.Entiteti.Takmicenje>(sb.TakmicenjeId.Value) : null;

                        if (novi)
                            s.Save(us);
                        else
                            s.Update(us);

                        tx.Commit();
                    }
                }
                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri čuvanju subjekta ugovora: {ec.Message}");
                return false;
            }
        }

        // dodajUgovorSubjekat / azurirajUgovorSubjekat su uklonjeni - bili su nedovršeni
        // (nisu ni postavljali Tim/Igrac/Takmicenje, a "UgovorSubjekat" tip nije
        // ni imao potreban using ESPORT.Entiteti, pa se nisu ni kompajlirali).
        // Umesto njih koristi vratiUgovorSubjekat / sacuvajUgovorSubjekat iznad -
        // sacuvajUgovorSubjekat radi i dodavanje i izmenu (upsert po UgovorId).

        public static bool obrisiUgovorSubjekat(int ugovorId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return false;

                    ESPORT.Entiteti.UgovorSubjekat us =
                        s.Get<ESPORT.Entiteti.UgovorSubjekat>(ugovorId);

                    if (us == null)
                    {
                        MessageBox.Show(
                            "Subjekat za ovaj ugovor ne postoji!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        s.Delete(us);
                        tx.Commit();
                    }

                    return true;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    $"Greška pri brisanju subjekta ugovora: {ec.Message}",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

<<<<<<< Updated upstream
        public static List<TransferDTO.TransferPregled> vratiSveTransfere()
        {
            List<TransferDTO.TransferPregled> transferi =
                new List<TransferDTO.TransferPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ESPORT.Entiteti.Transfer> sviTransferi =
                    from t in s.Query<ESPORT.Entiteti.Transfer>()
                    select t;

                foreach (ESPORT.Entiteti.Transfer t in sviTransferi)
                {
                    transferi.Add(
                        new TransferDTO.TransferPregled(
                            t.TransferId,
                            t.Igrac.OsobaId,
                            t.Igrac.Ime + " " + t.Igrac.Prezime,
                            t.PrethodniTim != null ? t.PrethodniTim.TimId : (int?)null,
                            t.PrethodniTim != null ? t.PrethodniTim.Naziv : null,
                            t.NoviTim.TimId,
                            t.NoviTim.Naziv,
                            t.DatumPrelaska,
                            t.IznosTransfera,
                            t.Valuta,
                            t.TrajanjeUgovoraMeseci,
                            t.PosebneKlauzule));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return transferi;
        }

        public static bool dodajTransfer(TransferDTO.TransferBasic t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Igrac igrac =
                    s.Get<ESPORT.Entiteti.Igrac>(t.IgracId);

                if (igrac == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Igrač sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim noviTim =
                    s.Get<ESPORT.Entiteti.Tim>(t.NoviTimId);

                if (noviTim == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Novi tim sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim prethodniTim = null;

                if (t.PrethodniTimId.HasValue)
                {
                    prethodniTim =
                        s.Get<ESPORT.Entiteti.Tim>(t.PrethodniTimId.Value);

                    if (prethodniTim == null)
                    {
                        s.Close();

                        MessageBox.Show(
                            "Prethodni tim sa tim ID-em ne postoji!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }
                }

                ESPORT.Entiteti.Transfer noviTransfer =
                    new ESPORT.Entiteti.Transfer();

                noviTransfer.Igrac = igrac;
                noviTransfer.PrethodniTim = prethodniTim;
                noviTransfer.NoviTim = noviTim;
                noviTransfer.DatumPrelaska = t.DatumPrelaska;
                noviTransfer.IznosTransfera = t.IznosTransfera;
                noviTransfer.Valuta = t.Valuta;
                noviTransfer.TrajanjeUgovoraMeseci = t.TrajanjeUgovoraMeseci;
                noviTransfer.PosebneKlauzule = t.PosebneKlauzule;

                s.Save(noviTransfer);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static TransferDTO.TransferBasic vratiTransfer(int id)
        {
            TransferDTO.TransferBasic transfer = null;

            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Transfer t =
                    s.Get<ESPORT.Entiteti.Transfer>(id);

                if (t != null)
                {
                    transfer =
                        new TransferDTO.TransferBasic(
                            t.TransferId,
                            t.Igrac.OsobaId,
                            t.PrethodniTim != null ? t.PrethodniTim.TimId : (int?)null,
                            t.NoviTim.TimId,
                            t.DatumPrelaska,
                            t.IznosTransfera,
                            t.Valuta,
                            t.TrajanjeUgovoraMeseci,
                            t.PosebneKlauzule);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return transfer;
        }

        public static bool azurirajTransfer(TransferDTO.TransferBasic t)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Transfer transfer =
                    s.Get<ESPORT.Entiteti.Transfer>(t.TransferId);

                if (transfer == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Transfer ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Igrac igrac =
                    s.Get<ESPORT.Entiteti.Igrac>(t.IgracId);

                if (igrac == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Igrač sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim noviTim =
                    s.Get<ESPORT.Entiteti.Tim>(t.NoviTimId);

                if (noviTim == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Novi tim sa tim ID-em ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim prethodniTim = null;

                if (t.PrethodniTimId.HasValue)
                {
                    prethodniTim =
                        s.Get<ESPORT.Entiteti.Tim>(t.PrethodniTimId.Value);

                    if (prethodniTim == null)
                    {
                        s.Close();

                        MessageBox.Show(
                            "Prethodni tim sa tim ID-em ne postoji!",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }
                }

                transfer.Igrac = igrac;
                transfer.PrethodniTim = prethodniTim;
                transfer.NoviTim = noviTim;
                transfer.DatumPrelaska = t.DatumPrelaska;
                transfer.IznosTransfera = t.IznosTransfera;
                transfer.Valuta = t.Valuta;
                transfer.TrajanjeUgovoraMeseci = t.TrajanjeUgovoraMeseci;
                transfer.PosebneKlauzule = t.PosebneKlauzule;

                s.Update(transfer);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static bool obrisiTransfer(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Transfer transfer =
                    s.Get<ESPORT.Entiteti.Transfer>(id);

                if (transfer == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Transfer ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(transfer);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static List<PozajmicaDTO.PozajmicaPregled> vratiSvePozajmice()
        {
            List<PozajmicaDTO.PozajmicaPregled> lista =
                new List<PozajmicaDTO.PozajmicaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<ESPORT.Entiteti.Pozajmica> pozajmice =
                    from p in s.Query<ESPORT.Entiteti.Pozajmica>()
                    select p;

                foreach (ESPORT.Entiteti.Pozajmica p in pozajmice)
                {
                    lista.Add(
                        new PozajmicaDTO.PozajmicaPregled(
                            p.PozajmicaId,
                            p.Igrac.OsobaId,
                            p.Igrac.Ime + " " + p.Igrac.Prezime,
                            p.MaticniTim.TimId,
                            p.MaticniTim.Naziv,
                            p.TimNaPozajmici.TimId,
                            p.TimNaPozajmici.Naziv,
                            p.DatumOd,
                            p.DatumDo,
                            p.FinansijskiUslovi,
                            p.PravoOtkupa
                        ));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return lista;
        }

        public static bool dodajPozajmicu(PozajmicaDTO.PozajmicaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Igrac igrac =
                    s.Get<ESPORT.Entiteti.Igrac>(p.IgracId);

                if (igrac == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrani igrač ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim maticniTim =
                    s.Get<ESPORT.Entiteti.Tim>(p.MaticniTimId);

                if (maticniTim == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrani matični tim ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim timNaPozajmici =
                    s.Get<ESPORT.Entiteti.Tim>(p.TimNaPozajmiciId);

                if (timNaPozajmici == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrani tim na pozajmici ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (p.DatumDo < p.DatumOd)
                {
                    s.Close();

                    MessageBox.Show(
                        "Datum završetka pozajmice ne može biti pre datuma početka!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                if (p.PravoOtkupa != 0 && p.PravoOtkupa != 1)
                {
                    s.Close();

                    MessageBox.Show(
                        "Pravo otkupa mora biti 0 ili 1!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                ESPORT.Entiteti.Pozajmica novaPozajmica =
                    new ESPORT.Entiteti.Pozajmica();

                novaPozajmica.Igrac = igrac;
                novaPozajmica.MaticniTim = maticniTim;
                novaPozajmica.TimNaPozajmici = timNaPozajmici;
                novaPozajmica.DatumOd = p.DatumOd;
                novaPozajmica.DatumDo = p.DatumDo;
                novaPozajmica.FinansijskiUslovi = p.FinansijskiUslovi;
                novaPozajmica.PravoOtkupa = p.PravoOtkupa;

                s.Save(novaPozajmica);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.ToString(),
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static PozajmicaDTO.PozajmicaBasic vratiPozajmicu(int id)
        {
            PozajmicaDTO.PozajmicaBasic pozajmica = null;

            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Pozajmica p =
                    s.Get<ESPORT.Entiteti.Pozajmica>(id);

                if (p != null)
                {
                    pozajmica =
                        new PozajmicaDTO.PozajmicaBasic(
                            p.PozajmicaId,
                            p.Igrac.OsobaId,
                            p.MaticniTim.TimId,
                            p.TimNaPozajmici.TimId,
                            p.DatumOd,
                            p.DatumDo,
                            p.FinansijskiUslovi,
                            p.PravoOtkupa
                        );
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return pozajmica;
        }

        public static bool azurirajPozajmicu(PozajmicaDTO.PozajmicaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Pozajmica pozajmica =
                    s.Get<ESPORT.Entiteti.Pozajmica>(p.PozajmicaId);

                if (pozajmica == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Pozajmica ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Igrac igrac =
                    s.Get<ESPORT.Entiteti.Igrac>(p.IgracId);

                if (igrac == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrani igrač ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim maticniTim =
                    s.Get<ESPORT.Entiteti.Tim>(p.MaticniTimId);

                if (maticniTim == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrani matični tim ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim timNaPozajmici =
                    s.Get<ESPORT.Entiteti.Tim>(p.TimNaPozajmiciId);

                if (timNaPozajmici == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Izabrani tim na pozajmici ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (p.DatumDo < p.DatumOd)
                {
                    s.Close();

                    MessageBox.Show(
                        "Datum završetka pozajmice ne može biti pre datuma početka!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                if (p.PravoOtkupa != 0 && p.PravoOtkupa != 1)
                {
                    s.Close();

                    MessageBox.Show(
                        "Pravo otkupa mora biti 0 ili 1!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                pozajmica.Igrac = igrac;
                pozajmica.MaticniTim = maticniTim;
                pozajmica.TimNaPozajmici = timNaPozajmici;
                pozajmica.DatumOd = p.DatumOd;
                pozajmica.DatumDo = p.DatumDo;
                pozajmica.FinansijskiUslovi = p.FinansijskiUslovi;
                pozajmica.PravoOtkupa = p.PravoOtkupa;

                s.Update(pozajmica);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static bool obrisiPozajmicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ESPORT.Entiteti.Pozajmica pozajmica =
                    s.Get<ESPORT.Entiteti.Pozajmica>(id);

                if (pozajmica == null)
                {
                    s.Close();

                    MessageBox.Show(
                        "Pozajmica ne postoji!",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(pozajmica);
                s.Flush();
                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(
                    ec.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        public static List<StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuPregled>
    vratiSveStatistikeTimaNaMecu()
        {
            List<StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuPregled> statistike =
                new List<StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuPregled>();

            ISession s = DataLayer.GetSession();

            try
            {
                var podaci = s.Query<ESPORT.Entiteti.StatistikaTimaNaMecu>().ToList();

                foreach (var st in podaci)
                {
                    statistike.Add(
                        new StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuPregled(
                            st.MecId.MecId,
                            st.TimId.TimId,
                            st.MecId.MecId.ToString(),
                            st.TimId.Naziv,
                            st.Kills,
                            st.Deaths,
                            st.Assists,
                            st.Damage,
                            st.ObjectiveScore,
                            st.Gold));
                }

                return statistike;
            }
            finally
            {
                s.Close();
            }
        }

        public static bool dodajStatistikuTimaNaMecu(
    StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuBasic p)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.Mec mec =
                    s.Get<ESPORT.Entiteti.Mec>(p.MecId);

                ESPORT.Entiteti.Tim tim =
                    s.Get<ESPORT.Entiteti.Tim>(p.TimId);

                if (mec == null || tim == null)
                {
                    MessageBox.Show(
                        "Izabrani meč ili tim ne postoje.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                // Provera da li statistika već postoji
                var postojeca =
                    s.Query<ESPORT.Entiteti.StatistikaTimaNaMecu>()
                     .FirstOrDefault(x =>
                         x.MecId.MecId == p.MecId &&
                         x.TimId.TimId == p.TimId);

                if (postojeca != null)
                {
                    MessageBox.Show(
                        "Statistika za izabrani tim i meč već postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                if (p.Kills < 0 ||
                    p.Deaths < 0 ||
                    p.Assists < 0 ||
                    p.Damage < 0 ||
                    p.ObjectiveScore < 0 ||
                    p.Gold < 0)
                {
                    MessageBox.Show(
                        "Statistički podaci moraju biti nenegativni brojevi.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                ESPORT.Entiteti.StatistikaTimaNaMecu statistika =
                    new ESPORT.Entiteti.StatistikaTimaNaMecu();

                statistika.MecId = mec;
                statistika.TimId = tim;
                statistika.Kills = p.Kills;
                statistika.Deaths = p.Deaths;
                statistika.Assists = p.Assists;
                statistika.Damage = p.Damage;
                statistika.ObjectiveScore = p.ObjectiveScore;
                statistika.Gold = p.Gold;

                s.Save(statistika);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom dodavanja statistike:\n" + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuBasic
    vratiStatistikuTimaNaMecu(int mecId, int timId)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                var statistika =
                    s.Query<ESPORT.Entiteti.StatistikaTimaNaMecu>()
                     .FirstOrDefault(x =>
                         x.MecId.MecId == mecId &&
                         x.TimId.TimId == timId);

                if (statistika == null)
                    return null;

                return new StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuBasic(
                    statistika.MecId.MecId,
                    statistika.TimId.TimId,
                    statistika.Kills,
                    statistika.Deaths,
                    statistika.Assists,
                    statistika.Damage,
                    statistika.ObjectiveScore,
                    statistika.Gold);
            }
            finally
            {
                s.Close();
            }
        }

        public static bool azurirajStatistikuTimaNaMecu(
    StatistikaTimaNaMecuDTO.StatistikaTimaNaMecuBasic p)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                var statistika =
                    s.Query<ESPORT.Entiteti.StatistikaTimaNaMecu>()
                     .FirstOrDefault(x =>
                         x.MecId.MecId == p.MecId &&
                         x.TimId.TimId == p.TimId);

                if (statistika == null)
                {
                    MessageBox.Show(
                        "Statistika ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (p.Kills < 0 ||
                    p.Deaths < 0 ||
                    p.Assists < 0 ||
                    p.Damage < 0 ||
                    p.ObjectiveScore < 0 ||
                    p.Gold < 0)
                {
                    MessageBox.Show(
                        "Statistički podaci moraju biti nenegativni brojevi.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return false;
                }

                statistika.Kills = p.Kills;
                statistika.Deaths = p.Deaths;
                statistika.Assists = p.Assists;
                statistika.Damage = p.Damage;
                statistika.ObjectiveScore = p.ObjectiveScore;
                statistika.Gold = p.Gold;

                s.Update(statistika);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom izmene statistike:\n" + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static bool obrisiStatistikuTimaNaMecu(int mecId, int timId)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                var statistika =
                    s.Query<ESPORT.Entiteti.StatistikaTimaNaMecu>()
                     .FirstOrDefault(x =>
                         x.MecId.MecId == mecId &&
                         x.TimId.TimId == timId);

                if (statistika == null)
                {
                    MessageBox.Show(
                        "Statistika ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(statistika);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom brisanja statistike:\n" + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static List<IndividualniRezultatDTO.IndividualniRezultatPregled>
         vratiSveIndividualneRezultate()
        {
            List<IndividualniRezultatDTO.IndividualniRezultatPregled> rezultati =
                new List<IndividualniRezultatDTO.IndividualniRezultatPregled>();

            ISession s = DataLayer.GetSession();

            try
            {
                var podaci =
                    s.Query<ESPORT.Entiteti.IndividualniRezultat>().ToList();

                foreach (var r in podaci)
                {
                    rezultati.Add(
                        new IndividualniRezultatDTO.IndividualniRezultatPregled(
                            r.RezultatId,
                            r.Igrac.OsobaId,
                            r.Igrac.Nadimak,
                            r.NazivPriznanja,
                            r.DatumOstvarivanja,
                            r.Takmicenje != null
                                ? r.Takmicenje.TakmicenjeId
                                : (int?)null,
                            r.Takmicenje != null
                                ? r.Takmicenje.Naziv
                                : "",
                            r.Opis));
                }

                return rezultati;
            }
            finally
            {
                s.Close();
            }
        }

        public static bool dodajIndividualniRezultat(
    IndividualniRezultatDTO.IndividualniRezultatBasic p)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.Igrac igrac =
                    s.Get<ESPORT.Entiteti.Igrac>(p.IgracId);

                if (igrac == null)
                {
                    MessageBox.Show(
                        "Izabrani igrač ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Takmicenje takmicenje = null;

                if (p.TakmicenjeId.HasValue)
                {
                    takmicenje =
                        s.Get<ESPORT.Entiteti.Takmicenje>(p.TakmicenjeId.Value);

                    if (takmicenje == null)
                    {
                        MessageBox.Show(
                            "Izabrano takmičenje ne postoji.",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }
                }

                ESPORT.Entiteti.IndividualniRezultat rezultat =
                    new ESPORT.Entiteti.IndividualniRezultat();

                rezultat.Igrac = igrac;
                rezultat.NazivPriznanja = p.NazivPriznanja;
                rezultat.DatumOstvarivanja = p.DatumOstvarivanja;
                rezultat.Takmicenje = takmicenje;
                rezultat.Opis = p.Opis;

                s.Save(rezultat);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom dodavanja individualnog rezultata:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static IndividualniRezultatDTO.IndividualniRezultatBasic
    vratiIndividualniRezultat(int rezultatId)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                var rezultat =
                    s.Get<ESPORT.Entiteti.IndividualniRezultat>(rezultatId);

                if (rezultat == null)
                    return null;

                return new IndividualniRezultatDTO.IndividualniRezultatBasic(
                    rezultat.RezultatId,
                    rezultat.Igrac.OsobaId,
                    rezultat.NazivPriznanja,
                    rezultat.DatumOstvarivanja,
                    rezultat.Takmicenje != null
                        ? rezultat.Takmicenje.TakmicenjeId
                        : (int?)null,
                    rezultat.Opis);
            }
            finally
            {
                s.Close();
            }
        }

        public static bool azurirajIndividualniRezultat(
    IndividualniRezultatDTO.IndividualniRezultatBasic p)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                var rezultat =
                    s.Get<ESPORT.Entiteti.IndividualniRezultat>(p.RezultatId);

                if (rezultat == null)
                {
                    MessageBox.Show(
                        "Individualni rezultat ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Igrac igrac =
                    s.Get<ESPORT.Entiteti.Igrac>(p.IgracId);

                if (igrac == null)
                {
                    MessageBox.Show(
                        "Izabrani igrač ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Takmicenje takmicenje = null;

                if (p.TakmicenjeId.HasValue)
                {
                    takmicenje =
                        s.Get<ESPORT.Entiteti.Takmicenje>(p.TakmicenjeId.Value);

                    if (takmicenje == null)
                    {
                        MessageBox.Show(
                            "Izabrano takmičenje ne postoji.",
                            "Greška",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }
                }

                rezultat.Igrac = igrac;
                rezultat.NazivPriznanja = p.NazivPriznanja;
                rezultat.DatumOstvarivanja = p.DatumOstvarivanja;
                rezultat.Takmicenje = takmicenje;
                rezultat.Opis = p.Opis;

                s.Update(rezultat);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom izmene individualnog rezultata:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static bool obrisiIndividualniRezultat(int rezultatId)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                var rezultat =
                    s.Get<ESPORT.Entiteti.IndividualniRezultat>(rezultatId);

                if (rezultat == null)
                {
                    MessageBox.Show(
                        "Individualni rezultat ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(rezultat);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom brisanja individualnog rezultata:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static List<AngazmanTreneraDTO.AngazmanTreneraPregled> vratiSveAngazmaneTrenera()
        {
            ISession s = DataLayer.GetSession();

            try
            {
                var angazmani = s.Query<ESPORT.Entiteti.AngazmanTrenera>()
                    .Select(a => new AngazmanTreneraDTO.AngazmanTreneraPregled(
                        a.AngazmanTreneraId,
                        a.Trener.OsobaId,
                        a.Trener.Ime + " " + a.Trener.Prezime,
                        a.Tim.TimId,
                        a.Tim.Naziv,
                        a.TipUloge,
                        a.DatumOd,
                        a.DatumDo
                    ))
                    .ToList();

                return angazmani;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom učitavanja angažmana trenera:\n" + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return new List<AngazmanTreneraDTO.AngazmanTreneraPregled>();
            }
            finally
            {
                s.Close();
            }
        }

        public static bool dodajAngazmanTrenera(
            AngazmanTreneraDTO.AngazmanTreneraBasic p)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.Trener trener =
                    s.Get<ESPORT.Entiteti.Trener>(p.TrenerId);

                if (trener == null)
                {
                    MessageBox.Show(
                        "Izabrani trener ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim tim =
                    s.Get<ESPORT.Entiteti.Tim>(p.TimId);

                if (tim == null)
                {
                    MessageBox.Show(
                        "Izabrani tim ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (p.DatumDo.HasValue && p.DatumDo.Value < p.DatumOd)
                {
                    MessageBox.Show(
                        "Datum završetka angažmana ne može biti pre datuma početka.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.AngazmanTrenera angazman =
                    new ESPORT.Entiteti.AngazmanTrenera();

                angazman.Trener = trener;
                angazman.Tim = tim;
                angazman.TipUloge = p.TipUloge;
                angazman.DatumOd = p.DatumOd;
                angazman.DatumDo = p.DatumDo;

                s.Save(angazman);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom dodavanja angažmana trenera:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static AngazmanTreneraDTO.AngazmanTreneraBasic
            vratiAngazmanTrenera(int id)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.AngazmanTrenera angazman =
                    s.Get<ESPORT.Entiteti.AngazmanTrenera>(id);

                if (angazman == null)
                    return null;

                return new AngazmanTreneraDTO.AngazmanTreneraBasic(
                    angazman.AngazmanTreneraId,
                    angazman.Trener.OsobaId,
                    angazman.Tim.TimId,
                    angazman.TipUloge,
                    angazman.DatumOd,
                    angazman.DatumDo
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom učitavanja angažmana trenera:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
            finally
            {
                s.Close();
            }
        }

        public static bool azurirajAngazmanTrenera(
            AngazmanTreneraDTO.AngazmanTreneraBasic p)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.AngazmanTrenera angazman =
                    s.Get<ESPORT.Entiteti.AngazmanTrenera>(
                        p.AngazmanTreneraId);

                if (angazman == null)
                {
                    MessageBox.Show(
                        "Angažman trenera ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Trener trener =
                    s.Get<ESPORT.Entiteti.Trener>(p.TrenerId);

                if (trener == null)
                {
                    MessageBox.Show(
                        "Izabrani trener ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim tim =
                    s.Get<ESPORT.Entiteti.Tim>(p.TimId);

                if (tim == null)
                {
                    MessageBox.Show(
                        "Izabrani tim ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (p.DatumDo.HasValue && p.DatumDo.Value < p.DatumOd)
                {
                    MessageBox.Show(
                        "Datum završetka angažmana ne može biti pre datuma početka.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                angazman.Trener = trener;
                angazman.Tim = tim;
                angazman.TipUloge = p.TipUloge;
                angazman.DatumOd = p.DatumOd;
                angazman.DatumDo = p.DatumDo;

                s.Update(angazman);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom izmene angažmana trenera:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static bool obrisiAngazmanTrenera(int id)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.AngazmanTrenera angazman =
                    s.Get<ESPORT.Entiteti.AngazmanTrenera>(id);

                if (angazman == null)
                {
                    MessageBox.Show(
                        "Angažman trenera ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(angazman);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom brisanja angažmana trenera:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static List<AngazmanZaposlenihDTO.AngazmanZaposlenihPregled> vratiSveAngazmaneZaposlenih()
        {
            ISession s = DataLayer.GetSession();

            try
            {
                var angazmani = s.Query<ESPORT.Entiteti.AngazmanZaposlenih>()
                    .Select(a => new AngazmanZaposlenihDTO.AngazmanZaposlenihPregled(
                        a.AngazmanOsobljaId,
                        a.Osoba.OsobaId,
                        a.Osoba.Ime + " " + a.Osoba.Prezime,
                        a.Tim.TimId,
                        a.Tim.Naziv,
                        a.NazivUloge,
                        a.DatumOd,
                        a.DatumDo,
                        a.Plata
                    ))
                    .ToList();

                return angazmani;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom učitavanja angažmana zaposlenih:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return new List<AngazmanZaposlenihDTO.AngazmanZaposlenihPregled>();
            }
            finally
            {
                s.Close();
            }
        }

        public static bool dodajAngazmanZaposlenih(
            AngazmanZaposlenihDTO.AngazmanZaposlenihBasic p)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.Osoba osoba =
                    s.Get<ESPORT.Entiteti.Osoba>(p.OsobaId);

                if (osoba == null)
                {
                    MessageBox.Show(
                        "Izabrana osoba ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim tim =
                    s.Get<ESPORT.Entiteti.Tim>(p.TimId);

                if (tim == null)
                {
                    MessageBox.Show(
                        "Izabrani tim ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (p.DatumDo.HasValue &&
                    p.DatumDo.Value < p.DatumOd)
                {
                    MessageBox.Show(
                        "Datum završetka angažmana ne može biti pre datuma početka.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.AngazmanZaposlenih angazman =
                    new ESPORT.Entiteti.AngazmanZaposlenih();

                angazman.Osoba = osoba;
                angazman.Tim = tim;
                angazman.NazivUloge = p.NazivUloge;
                angazman.DatumOd = p.DatumOd;
                angazman.DatumDo = p.DatumDo;
                angazman.Plata = p.Plata;

                s.Save(angazman);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                string poruka = ex.Message;

                if (ex.InnerException != null)
                {
                    poruka += "\n\nInnerException:\n" + ex.InnerException.Message;

                    if (ex.InnerException.InnerException != null)
                    {
                        poruka += "\n\nInnerException 2:\n"
                                 + ex.InnerException.InnerException.Message;
                    }
                }

                MessageBox.Show(
                    "Greška prilikom dodavanja angažmana zaposlenih:\n\n"
                    + poruka,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static AngazmanZaposlenihDTO.AngazmanZaposlenihBasic
            vratiAngazmanZaposlenih(int id)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.AngazmanZaposlenih angazman =
                    s.Get<ESPORT.Entiteti.AngazmanZaposlenih>(id);

                if (angazman == null)
                    return null;

                return new AngazmanZaposlenihDTO.AngazmanZaposlenihBasic(
                    angazman.AngazmanOsobljaId,
                    angazman.Osoba.OsobaId,
                    angazman.Tim.TimId,
                    angazman.NazivUloge,
                    angazman.DatumOd,
                    angazman.DatumDo,
                    angazman.Plata
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom učitavanja angažmana zaposlenih:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
            finally
            {
                s.Close();
            }
        }

        public static bool azurirajAngazmanZaposlenih(
            AngazmanZaposlenihDTO.AngazmanZaposlenihBasic p)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.AngazmanZaposlenih angazman =
                    s.Get<ESPORT.Entiteti.AngazmanZaposlenih>(
                        p.AngazmanOsobljaId);

                if (angazman == null)
                {
                    MessageBox.Show(
                        "Angažman zaposlenih ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Osoba osoba =
                    s.Get<ESPORT.Entiteti.Osoba>(p.OsobaId);

                if (osoba == null)
                {
                    MessageBox.Show(
                        "Izabrana osoba ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                ESPORT.Entiteti.Tim tim =
                    s.Get<ESPORT.Entiteti.Tim>(p.TimId);

                if (tim == null)
                {
                    MessageBox.Show(
                        "Izabrani tim ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                if (p.DatumDo.HasValue &&
                    p.DatumDo.Value < p.DatumOd)
                {
                    MessageBox.Show(
                        "Datum završetka angažmana ne može biti pre datuma početka.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                angazman.Osoba = osoba;
                angazman.Tim = tim;
                angazman.NazivUloge = p.NazivUloge;
                angazman.DatumOd = p.DatumOd;
                angazman.DatumDo = p.DatumDo;
                angazman.Plata = p.Plata;

                s.Update(angazman);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom izmene angažmana zaposlenih:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }

        public static bool obrisiAngazmanZaposlenih(int id)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                ESPORT.Entiteti.AngazmanZaposlenih angazman =
                    s.Get<ESPORT.Entiteti.AngazmanZaposlenih>(id);

                if (angazman == null)
                {
                    MessageBox.Show(
                        "Angažman zaposlenih ne postoji.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                s.Delete(angazman);
                s.Flush();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Greška prilikom brisanja angažmana zaposlenih:\n"
                    + ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                s.Close();
            }
        }
=======


        public static List<LicencaDTO.LicencaPregled> vratiSveLicence()
        {
            List<LicencaDTO.LicencaPregled> licence = new List<LicencaDTO.LicencaPregled>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return licence;

                    List<ESPORT.Entiteti.Licenca> sveLicence = s.Query<ESPORT.Entiteti.Licenca>()
                                                                .OrderBy(l => l.LicencaId)
                                                                .ToList();

                    foreach (ESPORT.Entiteti.Licenca l in sveLicence)
                    {
                        int osobaId = l.OsobaId != null ? l.OsobaId.OsobaId : 0;
                        string vlasnik = l.OsobaId != null ? $"{l.OsobaId.Ime} {l.OsobaId.Prezime}" : "";

                        licence.Add(new LicencaDTO.LicencaPregled(
                            l.LicencaId,
                            osobaId,
                            l.Naziv,
                            l.InstitucijaIzdavac,
                            l.DatumSticanja,
                            vlasnik
                        ));
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška u DTOManager-u (vratiSveLicence): {ec.Message}");
            }

            return licence;
        }

        public static LicencaDTO.LicencaBasic vratiLicencu(int id)
        {
            LicencaDTO.LicencaBasic lb = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return null;

                    ESPORT.Entiteti.Licenca l = s.Get<ESPORT.Entiteti.Licenca>(id);
                    if (l != null)
                    {
                        int osobaId = l.OsobaId != null ? l.OsobaId.OsobaId : 0;
                        string vlasnik = l.OsobaId != null ? $"{l.OsobaId.Ime} {l.OsobaId.Prezime}" : "";

                        lb = new LicencaDTO.LicencaBasic(
                            l.LicencaId,
                            l.Naziv,
                            l.InstitucijaIzdavac,
                            l.DatumSticanja,
                            osobaId,
                            vlasnik
                        );
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri učitavanju licence: {ec.Message}");
            }

            return lb;
        }

        public static void dodajLicencu(LicencaDTO.LicencaBasic lb)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Licenca l = new ESPORT.Entiteti.Licenca
                        {
                            Naziv = lb.Naziv,
                            InstitucijaIzdavac = lb.InstitucijaIzdavac,
                            DatumSticanja = lb.DatumSticanja
                        };

                        if (lb.OsobaId > 0)
                        {
                            l.OsobaId = s.Load<ESPORT.Entiteti.Osoba>(lb.OsobaId);
                        }

                        s.Save(l);
                        tx.Commit();
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri dodavanju licence: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        public static void izmeniLicencu(LicencaDTO.LicencaBasic lb)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Licenca l = s.Get<ESPORT.Entiteti.Licenca>(lb.LicencaId);

                        if (l != null)
                        {
                            l.Naziv = lb.Naziv;
                            l.InstitucijaIzdavac = lb.InstitucijaIzdavac;
                            l.DatumSticanja = lb.DatumSticanja;

                            if (lb.OsobaId > 0)
                            {
                                l.OsobaId = s.Load<ESPORT.Entiteti.Osoba>(lb.OsobaId);
                            }
                            else
                            {
                                l.OsobaId = null;
                            }

                            s.Update(l);
                            tx.Commit();
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri izmeni licence: {ec.Message}\nInner: {ec.InnerException?.Message}");
            }
        }

        public static void obrisiLicencu(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    if (s == null) return;

                    using (ITransaction tx = s.BeginTransaction())
                    {
                        ESPORT.Entiteti.Licenca l = s.Get<ESPORT.Entiteti.Licenca>(id);
                        if (l != null)
                        {
                            s.Delete(l);
                            tx.Commit();
                        }
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Greška pri brisanju licence: {ec.Message}");
            }
        }

>>>>>>> Stashed changes
    }
}