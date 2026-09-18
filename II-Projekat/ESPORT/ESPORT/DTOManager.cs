using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESPORT.AnaliticarDTO;
using static ESPORT.IgracDTO;
using static ESPORT.IgraDTO;
using static ESPORT.OsobaDTO;

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

                    IList<Trener> treneri = s.Query<Trener>().ToList();

                    foreach (Trener t in treneri)
                    {
                        treneriDTO.Add(new TrenerDTO.TrenerPregled(
                            t.OsobaId,
                            t.Ime,
                            t.Prezime,
                            t.TipUloge,
                            t.StilRada,
                            t.StatusAngazmana
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
                            a.Email,
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
    }
}

