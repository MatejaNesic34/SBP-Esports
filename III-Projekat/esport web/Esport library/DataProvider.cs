using System;
using System.Collections.Generic;
using System.Linq;
using ESPORT;
using ESPORT.Entiteti;
using NHibernate;

namespace Esport_library
{
    public class DataProvider
    {
        // --- ANALITIČAR CRUD ---

        public static List<AnaliticarDTO> VratiSveAnaliticare()
        {
            List<AnaliticarDTO> spisak = new List<AnaliticarDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var analiticari = s.QueryOver<Analiticar>().List();
                    foreach (var a in analiticari)
                    {
                        spisak.Add(new AnaliticarDTO(
                            a.OsobaId, a.Ime, a.Prezime, a.Email, 
                            a.StatusAngazmana, a.OblastAnalize, a.Alati, a.NivoIskustva
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka po potrebi
            }
            return spisak;
        }

        public static AnaliticarDTO VratiAnaliticara(int id)
        {
            AnaliticarDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var a = s.Get<Analiticar>(id);
                    if (a != null)
                    {
                        dto = new AnaliticarDTO(
                            a.OsobaId, a.Ime, a.Prezime, a.Email,
                            a.StatusAngazmana, a.OblastAnalize, a.Alati, a.NivoIskustva
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajAnaliticara(AnaliticarDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Analiticar a = new Analiticar();
                    a.Ime = p.Ime;
                    a.Prezime = p.Prezime;
                    a.Email = p.Email;
                    a.StatusAngazmana = p.StatusAngazmana;
                    a.OblastAnalize = p.OblastAnalize;
                    a.Alati = p.Alati;
                    a.NivoIskustva = p.NivoIskustva;

                    s.Save(a);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniAnaliticara(AnaliticarDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Analiticar a = s.Get<Analiticar>(p.OsobaId);
                    if (a != null)
                    {
                        a.Ime = p.Ime;
                        a.Prezime = p.Prezime;
                        a.Email = p.Email;
                        a.StatusAngazmana = p.StatusAngazmana;
                        a.OblastAnalize = p.OblastAnalize;
                        a.Alati = p.Alati;
                        a.NivoIskustva = p.NivoIskustva;

                        s.Update(a);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiAnaliticara(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Analiticar a = s.Get<Analiticar>(id);
                    if (a != null)
                    {
                        s.Delete(a);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static List<AngazmanTreneraDTO> VratiSveAngazmaneTrenera()
        {
            List<AngazmanTreneraDTO> spisak = new List<AngazmanTreneraDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var angazmani = s.QueryOver<AngazmanTrenera>().List();
                    foreach (var a in angazmani)
                    {
                        spisak.Add(new AngazmanTreneraDTO(
                            a.AngazmanTreneraId,
                            a.Trener != null ? a.Trener.OsobaId : 0,
                            a.Trener != null ? $"{a.Trener.Ime} {a.Trener.Prezime}" : "",
                            a.Tim != null ? a.Tim.TimId : 0,
                            a.Tim != null ? a.Tim.Naziv : "",
                            a.DatumOd,
                            a.DatumDo,
                            a.TipUloge,
                            null
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static AngazmanTreneraDTO VratiAngazmanTrenera(int id)
        {
            AngazmanTreneraDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var a = s.Get<AngazmanTrenera>(id);
                    if (a != null)
                    {
                        dto = new AngazmanTreneraDTO(
                            a.AngazmanTreneraId,
                            a.Trener != null ? a.Trener.OsobaId : 0,
                            a.Trener != null ? $"{a.Trener.Ime} {a.Trener.Prezime}" : "",
                            a.Tim != null ? a.Tim.TimId : 0,
                            a.Tim != null ? a.Tim.Naziv : "",
                            a.DatumOd,
                            a.DatumDo,
                            a.TipUloge,
                            null
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajAngazmanTrenera(AngazmanTreneraDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    AngazmanTrenera a = new AngazmanTrenera();
                    a.TipUloge = p.TipAngazmana;
                    a.DatumOd = p.DatumOd;
                    a.DatumDo = p.DatumDo;

                    if (p.OsobaId > 0)
                    {
                        a.Trener = s.Get<Trener>(p.OsobaId);
                    }
                    if (p.TimId > 0)
                    {
                        a.Tim = s.Get<Tim>(p.TimId);
                    }

                    s.Save(a);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniAngazmanTrenera(AngazmanTreneraDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    AngazmanTrenera a = s.Get<AngazmanTrenera>(p.AngazmanTreneraId);
                    if (a != null)
                    {
                        a.TipUloge = p.TipAngazmana;
                        a.DatumOd = p.DatumOd;
                        a.DatumDo = p.DatumDo;

                        if (p.OsobaId > 0)
                        {
                            a.Trener = s.Get<Trener>(p.OsobaId);
                        }
                        if (p.TimId > 0)
                        {
                            a.Tim = s.Get<Tim>(p.TimId);
                        }

                        s.Update(a);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiAngazmanTrenera(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    AngazmanTrenera a = s.Get<AngazmanTrenera>(id);
                    if (a != null)
                    {
                        s.Delete(a);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- ANGAŽMAN ZAPOSLENIH CRUD ---

        public static List<AngazmanZaposlenihDTO> VratiSveAngazmaneZaposlenih()
        {
            List<AngazmanZaposlenihDTO> spisak = new List<AngazmanZaposlenihDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var angazmani = s.QueryOver<AngazmanZaposlenih>().List();
                    foreach (var a in angazmani)
                    {
                        spisak.Add(new AngazmanZaposlenihDTO(
                            a.AngazmanOsobljaId,
                            a.Osoba != null ? a.Osoba.OsobaId : 0,
                            a.Osoba != null ? $"{a.Osoba.Ime} {a.Osoba.Prezime}" : "",
                            a.Tim != null ? a.Tim.TimId : 0,
                            a.Tim != null ? a.Tim.Naziv : "",
                            a.NazivUloge,
                            a.DatumOd,
                            a.DatumDo,
                            a.Plata
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static AngazmanZaposlenihDTO VratiAngazmanZaposlenih(int id)
        {
            AngazmanZaposlenihDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var a = s.Get<AngazmanZaposlenih>(id);
                    if (a != null)
                    {
                        dto = new AngazmanZaposlenihDTO(
                            a.AngazmanOsobljaId,
                            a.Osoba != null ? a.Osoba.OsobaId : 0,
                            a.Osoba != null ? $"{a.Osoba.Ime} {a.Osoba.Prezime}" : "",
                            a.Tim != null ? a.Tim.TimId : 0,
                            a.Tim != null ? a.Tim.Naziv : "",
                            a.NazivUloge,
                            a.DatumOd,
                            a.DatumDo,
                            a.Plata
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajAngazmanZaposlenih(AngazmanZaposlenihDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    AngazmanZaposlenih a = new AngazmanZaposlenih();
                    a.NazivUloge = p.NazivUloge;
                    a.DatumOd = p.DatumOd;
                    a.DatumDo = p.DatumDo;
                    a.Plata = p.Plata;

                    if (p.OsobaId > 0)
                    {
                        a.Osoba = s.Get<Osoba>(p.OsobaId);
                    }
                    if (p.TimId > 0)
                    {
                        a.Tim = s.Get<Tim>(p.TimId);
                    }

                    s.Save(a);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniAngazmanZaposlenih(AngazmanZaposlenihDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    AngazmanZaposlenih a = s.Get<AngazmanZaposlenih>(p.AngazmanOsobljaId);
                    if (a != null)
                    {
                        a.NazivUloge = p.NazivUloge;
                        a.DatumOd = p.DatumOd;
                        a.DatumDo = p.DatumDo;
                        a.Plata = p.Plata;

                        if (p.OsobaId > 0)
                        {
                            a.Osoba = s.Get<Osoba>(p.OsobaId);
                        }
                        if (p.TimId > 0)
                        {
                            a.Tim = s.Get<Tim>(p.TimId);
                        }

                        s.Update(a);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiAngazmanZaposlenih(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    AngazmanZaposlenih a = s.Get<AngazmanZaposlenih>(id);
                    if (a != null)
                    {
                        s.Delete(a);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- DOGAĐAJ NA MEČU CRUD ---

        public static List<DogadjajNaMecuDTO> VratiSveDogadjajeNaMecu()
        {
            List<DogadjajNaMecuDTO> spisak = new List<DogadjajNaMecuDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var dogadjaji = s.QueryOver<DogadjajNaMecu>().List();
                    foreach (var d in dogadjaji)
                    {
                        spisak.Add(new DogadjajNaMecuDTO(
                            d.DogadjajId,
                            d.Mec != null ? d.Mec.MecId : 0,
                            d.Mec != null ? d.Mec.RedniBroj : 0,
                            d.TipDogadjaja,
                            d.VremeDogadjaja,
                            d.Opis,
                            d.OdlukaSudije
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static DogadjajNaMecuDTO VratiDogadjajNaMecu(int id)
        {
            DogadjajNaMecuDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var d = s.Get<DogadjajNaMecu>(id);
                    if (d != null)
                    {
                        dto = new DogadjajNaMecuDTO(
                            d.DogadjajId,
                            d.Mec != null ? d.Mec.MecId : 0,
                            d.Mec != null ? d.Mec.RedniBroj : 0,
                            d.TipDogadjaja,
                            d.VremeDogadjaja,
                            d.Opis,
                            d.OdlukaSudije
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajDogadjajNaMecu(DogadjajNaMecuDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    DogadjajNaMecu d = new DogadjajNaMecu();
                    d.TipDogadjaja = p.TipDogadjaja;
                    d.VremeDogadjaja = p.VremeDogadjaja;
                    d.Opis = p.Opis;
                    d.OdlukaSudije = p.OdlukaSudije;

                    if (p.MecId > 0)
                    {
                        d.Mec = s.Get<Mec>(p.MecId);
                    }

                    s.Save(d);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniDogadjajNaMecu(DogadjajNaMecuDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    DogadjajNaMecu d = s.Get<DogadjajNaMecu>(p.DogadjajId);
                    if (d != null)
                    {
                        d.TipDogadjaja = p.TipDogadjaja;
                        d.VremeDogadjaja = p.VremeDogadjaja;
                        d.Opis = p.Opis;
                        d.OdlukaSudije = p.OdlukaSudije;

                        if (p.MecId > 0)
                        {
                            d.Mec = s.Get<Mec>(p.MecId);
                        }

                        s.Update(d);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiDogadjajNaMecu(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    DogadjajNaMecu d = s.Get<DogadjajNaMecu>(id);
                    if (d != null)
                    {
                        s.Delete(d);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- FAZA TAKMIČENJA CRUD ---

        public static List<FazaTakmicenjaDTO> VratiSveFazeTakmicenja()
        {
            List<FazaTakmicenjaDTO> spisak = new List<FazaTakmicenjaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var faze = s.QueryOver<FazaTakmicenja>().List();
                    foreach (var f in faze)
                    {
                        spisak.Add(new FazaTakmicenjaDTO(
                            f.FazaId,
                            f.Turnir != null ? f.Turnir.TakmicenjeId : 0,
                            f.Turnir != null ? f.Turnir.Naziv : "",
                            f.NazivFaze,
                            f.RedniBroj,
                            f.Nadfaza != null ? f.Nadfaza.FazaId : (int?)null
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static FazaTakmicenjaDTO VratiFazuTakmicenja(int id)
        {
            FazaTakmicenjaDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var f = s.Get<FazaTakmicenja>(id);
                    if (f != null)
                    {
                        dto = new FazaTakmicenjaDTO(
                            f.FazaId,
                            f.Turnir != null ? f.Turnir.TakmicenjeId : 0,
                            f.Turnir != null ? f.Turnir.Naziv : "",
                            f.NazivFaze,
                            f.RedniBroj,
                            f.Nadfaza != null ? f.Nadfaza.FazaId : (int?)null
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajFazuTakmicenja(FazaTakmicenjaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    FazaTakmicenja f = new FazaTakmicenja();
                    f.NazivFaze = p.NazivFaze;
                    f.RedniBroj = p.RedniBroj;

                    if (p.TakmicenjeId > 0)
                    {
                        f.Turnir = s.Get<Turnir>(p.TakmicenjeId);
                    }

                    if (p.NadfazaId.HasValue && p.NadfazaId.Value > 0)
                    {
                        f.Nadfaza = s.Get<FazaTakmicenja>(p.NadfazaId.Value);
                    }

                    s.Save(f);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniFazuTakmicenja(FazaTakmicenjaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    FazaTakmicenja f = s.Get<FazaTakmicenja>(p.FazaId);
                    if (f != null)
                    {
                        f.NazivFaze = p.NazivFaze;
                        f.RedniBroj = p.RedniBroj;

                        if (p.TakmicenjeId > 0)
                        {
                            f.Turnir = s.Get<Turnir>(p.TakmicenjeId);
                        }

                        if (p.NadfazaId.HasValue && p.NadfazaId.Value > 0)
                        {
                            f.Nadfaza = s.Get<FazaTakmicenja>(p.NadfazaId.Value);
                        }
                        else
                        {
                            f.Nadfaza = null;
                        }

                        s.Update(f);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiFazuTakmicenja(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    FazaTakmicenja f = s.Get<FazaTakmicenja>(id);
                    if (f != null)
                    {
                        s.Delete(f);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- FIZIOTERAPEUT CRUD ---

        public static List<FizioterapeutDTO> VratiSveFizioterapeute()
        {
            List<FizioterapeutDTO> spisak = new List<FizioterapeutDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var fizioterapeuti = s.QueryOver<Fizioterapeut>().List();
                    foreach (var f in fizioterapeuti)
                    {
                        spisak.Add(new FizioterapeutDTO(
                            f.OsobaId, f.Ime, f.Prezime, f.DatumRodjenja, f.Drzava, f.Email,
                            f.StatusAngazmana, f.OblastRada, f.PeriodiDostupnosti
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static FizioterapeutDTO VratiFizioterapeuta(int id)
        {
            FizioterapeutDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var f = s.Get<Fizioterapeut>(id);
                    if (f != null)
                    {
                        dto = new FizioterapeutDTO(
                            f.OsobaId, f.Ime, f.Prezime, f.DatumRodjenja, f.Drzava, f.Email,
                            f.StatusAngazmana, f.OblastRada, f.PeriodiDostupnosti
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajFizioterapeuta(FizioterapeutDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Fizioterapeut f = new Fizioterapeut();
                    f.Ime = p.Ime;
                    f.Prezime = p.Prezime;
                    f.DatumRodjenja = p.DatumRodjenja;
                    f.Drzava = p.Drzava;
                    f.Email = p.Email;
                    f.StatusAngazmana = p.StatusAngazmana;
                    f.OblastRada = p.OblastRada;
                    f.PeriodiDostupnosti = p.PeriodiDostupnosti;

                    s.Save(f);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniFizioterapeuta(FizioterapeutDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Fizioterapeut f = s.Get<Fizioterapeut>(p.OsobaId);
                    if (f != null)
                    {
                        f.Ime = p.Ime;
                        f.Prezime = p.Prezime;
                        f.DatumRodjenja = p.DatumRodjenja;
                        f.Drzava = p.Drzava;
                        f.Email = p.Email;
                        f.StatusAngazmana = p.StatusAngazmana;
                        f.OblastRada = p.OblastRada;
                        f.PeriodiDostupnosti = p.PeriodiDostupnosti;

                        s.Update(f);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiFizioterapeuta(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Fizioterapeut f = s.Get<Fizioterapeut>(id);
                    if (f != null)
                    {
                        s.Delete(f);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- IGRA CRUD ---

        public static List<IgraDTO> VratiSveIgre()
        {
            List<IgraDTO> spisak = new List<IgraDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var igre = s.QueryOver<Igra>().List();
                    foreach (var i in igre)
                    {
                        spisak.Add(new IgraDTO(
                            i.IgraId, i.Naziv, i.Zanr
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static IgraDTO VratiIgru(int id)
        {
            IgraDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var i = s.Get<Igra>(id);
                    if (i != null)
                    {
                        dto = new IgraDTO(
                            i.IgraId, i.Naziv, i.Zanr
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajIgru(IgraDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Igra i = new Igra();
                    i.Naziv = p.Naziv;
                    i.Zanr = p.Zanr;

                    s.Save(i);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniIgru(IgraDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Igra i = s.Get<Igra>(p.IgraId);
                    if (i != null)
                    {
                        i.Naziv = p.Naziv;
                        i.Zanr = p.Zanr;

                        s.Update(i);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiIgru(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Igra i = s.Get<Igra>(id);
                    if (i != null)
                    {
                        s.Delete(i);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- IGRAČ CRUD ---

        public static List<IgracDTO> VratiSveIgrace()
        {
            List<IgracDTO> spisak = new List<IgracDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var igraci = s.QueryOver<Igrac>().List();
                    foreach (var i in igraci)
                    {
                        spisak.Add(new IgracDTO(
                            i.OsobaId, i.Ime, i.Prezime, i.Nadimak,
                            i.PrimarnaUloga, i.SekundarnaUloga, i.DominantniStil, i.Rang,
                            i.Drzava, i.Email, i.StatusAngazmana, ""
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static IgracDTO VratiIgraca(int id)
        {
            IgracDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var i = s.Get<Igrac>(id);
                    if (i != null)
                    {
                        dto = new IgracDTO(
                            i.OsobaId, i.Ime, i.Prezime, i.Nadimak,
                            i.PrimarnaUloga, i.SekundarnaUloga, i.DominantniStil, i.Rang,
                            i.Drzava, i.Email, i.StatusAngazmana, ""
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajIgraca(IgracDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Igrac i = new Igrac();
                    i.Ime = p.Ime;
                    i.Prezime = p.Prezime;
                    i.Nadimak = p.Nadimak;
                    i.PrimarnaUloga = p.PrimarnaUloga;
                    i.SekundarnaUloga = p.SekundarnaUloga;
                    i.DominantniStil = p.DominantniStil;
                    i.Rang = p.Rang;
                    i.Drzava = p.Drzava;
                    i.Email = p.Email;
                    i.StatusAngazmana = p.StatusAngazmana;

                    s.Save(i);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniIgraca(IgracDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Igrac i = s.Get<Igrac>(p.OsobaId);
                    if (i != null)
                    {
                        i.Ime = p.Ime;
                        i.Prezime = p.Prezime;
                        i.Nadimak = p.Nadimak;
                        i.PrimarnaUloga = p.PrimarnaUloga;
                        i.SekundarnaUloga = p.SekundarnaUloga;
                        i.DominantniStil = p.DominantniStil;
                        i.Rang = p.Rang;
                        i.Drzava = p.Drzava;
                        i.Email = p.Email;
                        i.StatusAngazmana = p.StatusAngazmana;

                        s.Update(i);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiIgraca(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Igrac i = s.Get<Igrac>(id);
                    if (i != null)
                    {
                        s.Delete(i);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- INDIVIDUALNI REZULTAT CRUD ---

        public static List<IndividualniRezultatDTO> VratiSveIndividualneRezultate()
        {
            List<IndividualniRezultatDTO> spisak = new List<IndividualniRezultatDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var rezultati = s.QueryOver<IndividualniRezultat>().List();
                    foreach (var r in rezultati)
                    {
                        spisak.Add(new IndividualniRezultatDTO(
                            r.RezultatId,
                            0,
                            r.Igrac != null ? r.Igrac.OsobaId : 0,
                            r.Igrac != null ? $"{r.Igrac.Ime} {r.Igrac.Prezime}" : "",
                            0, 0, 0, 0
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static IndividualniRezultatDTO VratiIndividualniRezultat(int id)
        {
            IndividualniRezultatDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var r = s.Get<IndividualniRezultat>(id);
                    if (r != null)
                    {
                        dto = new IndividualniRezultatDTO(
                            r.RezultatId,
                            0,
                            r.Igrac != null ? r.Igrac.OsobaId : 0,
                            r.Igrac != null ? $"{r.Igrac.Ime} {r.Igrac.Prezime}" : "",
                            0, 0, 0, 0
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajIndividualniRezultat(IndividualniRezultatDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    IndividualniRezultat r = new IndividualniRezultat();
                    r.NazivPriznanja = "Rezultat / Priznanje"; // Podrazumevana vrednost
                    r.Opis = "";

                    if (p.IgracId > 0)
                    {
                        r.Igrac = s.Get<Igrac>(p.IgracId);
                    }

                    s.Save(r);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniIndividualniRezultat(IndividualniRezultatDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    IndividualniRezultat r = s.Get<IndividualniRezultat>(p.RezultatId);
                    if (r != null)
                    {
                        if (p.IgracId > 0)
                        {
                            r.Igrac = s.Get<Igrac>(p.IgracId);
                        }

                        s.Update(r);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiIndividualniRezultat(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    IndividualniRezultat r = s.Get<IndividualniRezultat>(id);
                    if (r != null)
                    {
                        s.Delete(r);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- KREATOR SADRŽAJA CRUD ---

        public static List<OsobaDTO> VratiSveKreatoreSadrzaja()
        {
            List<OsobaDTO> spisak = new List<OsobaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var kreatori = s.QueryOver<KreatorSadrzaja>().List();
                    foreach (var k in kreatori)
                    {
                        spisak.Add(new OsobaDTO(
                            k.OsobaId, k.Ime, k.Prezime, k.DatumRodjenja, k.Drzava, k.Email, k.StatusAngazmana
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static OsobaDTO VratiKreatoraSadrzaja(int id)
        {
            OsobaDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var k = s.Get<KreatorSadrzaja>(id);
                    if (k != null)
                    {
                        dto = new OsobaDTO(
                            k.OsobaId, k.Ime, k.Prezime, k.DatumRodjenja, k.Drzava, k.Email, k.StatusAngazmana
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajKreatoraSadrzaja(OsobaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    KreatorSadrzaja k = new KreatorSadrzaja();
                    k.Ime = p.Ime;
                    k.Prezime = p.Prezime;
                    k.DatumRodjenja = p.DatumRodjenja;
                    k.Drzava = p.Drzava;
                    k.Email = p.Email;
                    k.StatusAngazmana = p.StatusAngazmana;

                    s.Save(k);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniKreatoraSadrzaja(OsobaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    KreatorSadrzaja k = s.Get<KreatorSadrzaja>(p.OsobaId);
                    if (k != null)
                    {
                        k.Ime = p.Ime;
                        k.Prezime = p.Prezime;
                        k.DatumRodjenja = p.DatumRodjenja;
                        k.Drzava = p.Drzava;
                        k.Email = p.Email;
                        k.StatusAngazmana = p.StatusAngazmana;

                        s.Update(k);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiKreatoraSadrzaja(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    KreatorSadrzaja k = s.Get<KreatorSadrzaja>(id);
                    if (k != null)
                    {
                        s.Delete(k);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- LICENCA CRUD ---

        public static List<LicencaDTO> VratiSveLicence()
        {
            List<LicencaDTO> spisak = new List<LicencaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var licence = s.QueryOver<Licenca>().List();
                    foreach (var l in licence)
                    {
                        spisak.Add(new LicencaDTO(
                            l.LicencaId,
                            l.OsobaId != null ? l.OsobaId.OsobaId : 0,
                            l.OsobaId != null ? $"{l.OsobaId.Ime} {l.OsobaId.Prezime}" : "",
                            l.Naziv
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static LicencaDTO VratiLicencu(int id)
        {
            LicencaDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var l = s.Get<Licenca>(id);
                    if (l != null)
                    {
                        dto = new LicencaDTO(
                            l.LicencaId,
                            l.OsobaId != null ? l.OsobaId.OsobaId : 0,
                            l.OsobaId != null ? $"{l.OsobaId.Ime} {l.OsobaId.Prezime}" : "",
                            l.Naziv
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajLicencu(LicencaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Licenca l = new Licenca();
                    l.Naziv = p.Naziv;
                    l.InstitucijaIzdavac = "Nepoznato"; // Podrazumevana vrednost ukoliko se ne prosleđuje dodatno kroz DTO
                    l.DatumSticanja = DateTime.Now;

                    if (p.OsobaId > 0)
                    {
                        l.OsobaId = s.Get<Osoba>(p.OsobaId);
                    }

                    s.Save(l);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniLicencu(LicencaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Licenca l = s.Get<Licenca>(p.LicencaId);
                    if (l != null)
                    {
                        l.Naziv = p.Naziv;

                        if (p.OsobaId > 0)
                        {
                            l.OsobaId = s.Get<Osoba>(p.OsobaId);
                        }

                        s.Update(l);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiLicencu(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Licenca l = s.Get<Licenca>(id);
                    if (l != null)
                    {
                        s.Delete(l);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- LIGA CRUD ---

        public static List<LigaDTO> VratiSveLige()
        {
            List<LigaDTO> spisak = new List<LigaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var lige = s.QueryOver<Liga>().List();
                    foreach (var l in lige)
                    {
                        spisak.Add(new LigaDTO(
                            l.TakmicenjeId,
                            l.Naziv,
                            l.Organizator,
                            l.Igra != null ? l.Igra.Naziv : "",
                            l.Region,
                            l.Lokacija,
                            l.FormatTakmicenja,
                            l.DatumPocetka,
                            l.DatumZavrsetka,
                            l.NagradniFond,
                            l.ValutaNagrade,
                            l.Status,
                            l.SistemBodovanja
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static LigaDTO VratiLigu(int id)
        {
            LigaDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var l = s.Get<Liga>(id);
                    if (l != null)
                    {
                        dto = new LigaDTO(
                            l.TakmicenjeId,
                            l.Naziv,
                            l.Organizator,
                            l.Igra != null ? l.Igra.Naziv : "",
                            l.Region,
                            l.Lokacija,
                            l.FormatTakmicenja,
                            l.DatumPocetka,
                            l.DatumZavrsetka,
                            l.NagradniFond,
                            l.ValutaNagrade,
                            l.Status,
                            l.SistemBodovanja
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajLigu(LigaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Liga l = new Liga();
                    l.Naziv = p.NazivTakmicenja;
                    l.Organizator = p.Organizator;
                    l.Region = p.Region;
                    l.Lokacija = p.Lokacija;
                    l.FormatTakmicenja = p.FormatTakmicenja;
                    l.DatumPocetka = p.DatumPocetka;
                    l.DatumZavrsetka = p.DatumZavrsetka;
                    l.NagradniFond = p.NagradniFond;
                    l.ValutaNagrade = p.ValutaNagrade;
                    l.Status = p.Status;
                    l.SistemBodovanja = p.SistemBodovanja;

                    s.Save(l);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniLigu(LigaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Liga l = s.Get<Liga>(p.TakmicenjeId);
                    if (l != null)
                    {
                        l.Naziv = p.NazivTakmicenja;
                        l.Organizator = p.Organizator;
                        l.Region = p.Region;
                        l.Lokacija = p.Lokacija;
                        l.FormatTakmicenja = p.FormatTakmicenja;
                        l.DatumPocetka = p.DatumPocetka;
                        l.DatumZavrsetka = p.DatumZavrsetka;
                        l.NagradniFond = p.NagradniFond;
                        l.ValutaNagrade = p.ValutaNagrade;
                        l.Status = p.Status;
                        l.SistemBodovanja = p.SistemBodovanja;

                        s.Update(l);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiLigu(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Liga l = s.Get<Liga>(id);
                    if (l != null)
                    {
                        s.Delete(l);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- MEČ CRUD ---

        public static List<MecDTO> VratiSveMeceve()
        {
            List<MecDTO> spisak = new List<MecDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var mecevi = s.QueryOver<Mec>().List();
                    foreach (var m in mecevi)
                    {
                        spisak.Add(new MecDTO(
                            m.MecId,
                            m.Takmicenje != null ? m.Takmicenje.TakmicenjeId : 0,
                            m.Takmicenje != null ? m.Takmicenje.Naziv : "",
                            m.RedniBroj,
                            m.DatumVremePocetka,
                            m.FormatMeca,
                            m.BrojOdigranihMapa,
                            m.Rezultat,
                            m.Trajanje,
                            m.LokacijaIgranja,
                            m.Sudije,
                            m.StatusMeca
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static MecDTO VratiMec(int id)
        {
            MecDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var m = s.Get<Mec>(id);
                    if (m != null)
                    {
                        dto = new MecDTO(
                            m.MecId,
                            m.Takmicenje != null ? m.Takmicenje.TakmicenjeId : 0,
                            m.Takmicenje != null ? m.Takmicenje.Naziv : "",
                            m.RedniBroj,
                            m.DatumVremePocetka,
                            m.FormatMeca,
                            m.BrojOdigranihMapa,
                            m.Rezultat,
                            m.Trajanje,
                            m.LokacijaIgranja,
                            m.Sudije,
                            m.StatusMeca
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajMec(MecDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Mec m = new Mec();
                    m.RedniBroj = p.RedniBroj;
                    m.DatumVremePocetka = p.DatumVremePocetka;
                    m.FormatMeca = p.FormatMeca;
                    m.BrojOdigranihMapa = p.BrojOdigranihMapa;
                    m.Rezultat = p.Rezultat;
                    m.Trajanje = p.Trajanje;
                    m.LokacijaIgranja = p.LokacijaIgranja;
                    m.Sudije = p.Sudije;
                    m.StatusMeca = p.StatusMeca;

                    if (p.TakmicenjeId > 0)
                    {
                        m.Takmicenje = s.Get<Takmicenje>(p.TakmicenjeId);
                    }

                    s.Save(m);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniMec(MecDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Mec m = s.Get<Mec>(p.MecId);
                    if (m != null)
                    {
                        m.RedniBroj = p.RedniBroj;
                        m.DatumVremePocetka = p.DatumVremePocetka;
                        m.FormatMeca = p.FormatMeca;
                        m.BrojOdigranihMapa = p.BrojOdigranihMapa;
                        m.Rezultat = p.Rezultat;
                        m.Trajanje = p.Trajanje;
                        m.LokacijaIgranja = p.LokacijaIgranja;
                        m.Sudije = p.Sudije;
                        m.StatusMeca = p.StatusMeca;

                        if (p.TakmicenjeId > 0)
                        {
                            m.Takmicenje = s.Get<Takmicenje>(p.TakmicenjeId);
                        }

                        s.Update(m);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiMec(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Mec m = s.Get<Mec>(id);
                    if (m != null)
                    {
                        s.Delete(m);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- MENADŽER CRUD ---

        public static List<MenadzerDTO> VratiSveMenadzere()
        {
            List<MenadzerDTO> spisak = new List<MenadzerDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var menadzeri = s.QueryOver<Menadzer>().List();
                    foreach (var m in menadzeri)
                    {
                        spisak.Add(new MenadzerDTO(
                            m.OsobaId, m.Ime, m.Prezime, m.DatumRodjenja, m.Drzava, m.Email,
                            m.StatusAngazmana, m.OblastOdgovornosti
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static MenadzerDTO VratiMenadzera(int id)
        {
            MenadzerDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var m = s.Get<Menadzer>(id);
                    if (m != null)
                    {
                        dto = new MenadzerDTO(
                            m.OsobaId, m.Ime, m.Prezime, m.DatumRodjenja, m.Drzava, m.Email,
                            m.StatusAngazmana, m.OblastOdgovornosti
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajMenadzera(MenadzerDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Menadzer m = new Menadzer();
                    m.Ime = p.Ime;
                    m.Prezime = p.Prezime;
                    m.DatumRodjenja = p.DatumRodjenja;
                    m.Drzava = p.Drzava;
                    m.Email = p.Email;
                    m.StatusAngazmana = p.StatusAngazmana;
                    m.OblastOdgovornosti = p.OblastOdgovornosti;

                    s.Save(m);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniMenadzera(MenadzerDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Menadzer m = s.Get<Menadzer>(p.OsobaId);
                    if (m != null)
                    {
                        m.Ime = p.Ime;
                        m.Prezime = p.Prezime;
                        m.DatumRodjenja = p.DatumRodjenja;
                        m.Drzava = p.Drzava;
                        m.Email = p.Email;
                        m.StatusAngazmana = p.StatusAngazmana;
                        m.OblastOdgovornosti = p.OblastOdgovornosti;

                        s.Update(m);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiMenadzera(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Menadzer m = s.Get<Menadzer>(id);
                    if (m != null)
                    {
                        s.Delete(m);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- OSOBA CRUD ---

        public static List<OsobaDTO> VratiSveOsobe()
        {
            List<OsobaDTO> spisak = new List<OsobaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var osobe = s.QueryOver<Osoba>().List();
                    foreach (var o in osobe)
                    {
                        spisak.Add(new OsobaDTO(
                            o.OsobaId, o.Ime, o.Prezime, o.DatumRodjenja, o.Drzava, o.Email, o.StatusAngazmana
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static OsobaDTO VratiOsobu(int id)
        {
            OsobaDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var o = s.Get<Osoba>(id);
                    if (o != null)
                    {
                        dto = new OsobaDTO(
                            o.OsobaId, o.Ime, o.Prezime, o.DatumRodjenja, o.Drzava, o.Email, o.StatusAngazmana
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajOsobu(OsobaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Osoba o = new Osoba();
                    o.Ime = p.Ime;
                    o.Prezime = p.Prezime;
                    o.DatumRodjenja = p.DatumRodjenja;
                    o.Drzava = p.Drzava;
                    o.Email = p.Email;
                    o.StatusAngazmana = p.StatusAngazmana;

                    s.Save(o);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniOsobu(OsobaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Osoba o = s.Get<Osoba>(p.OsobaId);
                    if (o != null)
                    {
                        o.Ime = p.Ime;
                        o.Prezime = p.Prezime;
                        o.DatumRodjenja = p.DatumRodjenja;
                        o.Drzava = p.Drzava;
                        o.Email = p.Email;
                        o.StatusAngazmana = p.StatusAngazmana;

                        s.Update(o);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiOsobu(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Osoba o = s.Get<Osoba>(id);
                    if (o != null)
                    {
                        s.Delete(o);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }
        // --- POZAJMICA CRUD ---

        public static List<PozajmicaDTO> VratiSvePozajmice()
        {
            List<PozajmicaDTO> spisak = new List<PozajmicaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var pozajmice = s.QueryOver<Pozajmica>().List();
                    foreach (var p in pozajmice)
                    {
                        spisak.Add(new PozajmicaDTO(
                            p.PozajmicaId,
                            p.Igrac != null ? p.Igrac.OsobaId : 0,
                            p.Igrac != null ? $"{p.Igrac.Ime} {p.Igrac.Prezime}" : "",
                            p.MaticniTim != null ? p.MaticniTim.TimId : 0,
                            p.MaticniTim != null ? p.MaticniTim.Naziv : "",
                            p.TimNaPozajmici != null ? p.TimNaPozajmici.TimId : 0,
                            p.TimNaPozajmici != null ? p.TimNaPozajmici.Naziv : "",
                            p.DatumOd,
                            p.DatumDo,
                            p.FinansijskiUslovi,
                            p.PravoOtkupa
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static PozajmicaDTO VratiPozajmicu(int id)
        {
            PozajmicaDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var p = s.Get<Pozajmica>(id);
                    if (p != null)
                    {
                        dto = new PozajmicaDTO(
                            p.PozajmicaId,
                            p.Igrac != null ? p.Igrac.OsobaId : 0,
                            p.Igrac != null ? $"{p.Igrac.Ime} {p.Igrac.Prezime}" : "",
                            p.MaticniTim != null ? p.MaticniTim.TimId : 0,
                            p.MaticniTim != null ? p.MaticniTim.Naziv : "",
                            p.TimNaPozajmici != null ? p.TimNaPozajmici.TimId : 0,
                            p.TimNaPozajmici != null ? p.TimNaPozajmici.Naziv : "",
                            p.DatumOd,
                            p.DatumDo,
                            p.FinansijskiUslovi,
                            p.PravoOtkupa
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajPozajmicu(PozajmicaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Pozajmica poz = new Pozajmica();
                    poz.DatumOd = p.DatumOd;
                    poz.DatumDo = p.DatumDo;
                    poz.FinansijskiUslovi = p.FinansijskiUslovi;
                    poz.PravoOtkupa = p.PravoOtkupa;

                    if (p.IgracId > 0)
                    {
                        poz.Igrac = s.Get<Igrac>(p.IgracId);
                    }
                    if (p.MaticniTimId > 0)
                    {
                        poz.MaticniTim = s.Get<Tim>(p.MaticniTimId);
                    }
                    if (p.TimNaPozajmiciId > 0)
                    {
                        poz.TimNaPozajmici = s.Get<Tim>(p.TimNaPozajmiciId);
                    }

                    s.Save(poz);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniPozajmicu(PozajmicaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Pozajmica poz = s.Get<Pozajmica>(p.PozajmicaId);
                    if (poz != null)
                    {
                        poz.DatumOd = p.DatumOd;
                        poz.DatumDo = p.DatumDo;
                        poz.FinansijskiUslovi = p.FinansijskiUslovi;
                        poz.PravoOtkupa = p.PravoOtkupa;

                        if (p.IgracId > 0)
                        {
                            poz.Igrac = s.Get<Igrac>(p.IgracId);
                        }
                        if (p.MaticniTimId > 0)
                        {
                            poz.MaticniTim = s.Get<Tim>(p.MaticniTimId);
                        }
                        if (p.TimNaPozajmiciId > 0)
                        {
                            poz.TimNaPozajmici = s.Get<Tim>(p.TimNaPozajmiciId);
                        }

                        s.Update(poz);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiPozajmicu(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Pozajmica poz = s.Get<Pozajmica>(id);
                    if (poz != null)
                    {
                        s.Delete(poz);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- PSIHOLOG CRUD ---

        public static List<PsihologDTO> VratiSvePsihologe()
        {
            List<PsihologDTO> spisak = new List<PsihologDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var psiholozi = s.QueryOver<Psiholog>().List();
                    foreach (var p in psiholozi)
                    {
                        spisak.Add(new PsihologDTO(
                            p.OsobaId, p.Ime, p.Prezime, p.DatumRodjenja, p.Drzava, p.Email,
                            p.StatusAngazmana, p.OblastRada, p.PeriodiDostupnosti
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static PsihologDTO VratiPsihologa(int id)
        {
            PsihologDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var p = s.Get<Psiholog>(id);
                    if (p != null)
                    {
                        dto = new PsihologDTO(
                            p.OsobaId, p.Ime, p.Prezime, p.DatumRodjenja, p.Drzava, p.Email,
                            p.StatusAngazmana, p.OblastRada, p.PeriodiDostupnosti
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajPsihologa(PsihologDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Psiholog psi = new Psiholog();
                    psi.Ime = p.Ime;
                    psi.Prezime = p.Prezime;
                    psi.DatumRodjenja = p.DatumRodjenja;
                    psi.Drzava = p.Drzava;
                    psi.Email = p.Email;
                    psi.StatusAngazmana = p.StatusAngazmana;
                    psi.OblastRada = p.OblastRada;
                    psi.PeriodiDostupnosti = p.PeriodiDostupnosti;

                    s.Save(psi);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniPsihologa(PsihologDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Psiholog psi = s.Get<Psiholog>(p.OsobaId);
                    if (psi != null)
                    {
                        psi.Ime = p.Ime;
                        psi.Prezime = p.Prezime;
                        psi.DatumRodjenja = p.DatumRodjenja;
                        psi.Drzava = p.Drzava;
                        psi.Email = p.Email;
                        psi.StatusAngazmana = p.StatusAngazmana;
                        psi.OblastRada = p.OblastRada;
                        psi.PeriodiDostupnosti = p.PeriodiDostupnosti;

                        s.Update(psi);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiPsihologa(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Psiholog psi = s.Get<Psiholog>(id);
                    if (psi != null)
                    {
                        s.Delete(psi);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- SKAUT CRUD ---

        public static List<SkautDTO> VratiSveSkaute()
        {
            List<SkautDTO> spisak = new List<SkautDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var skauti = s.QueryOver<Skaut>().List();
                    foreach (var sk in skauti)
                    {
                        spisak.Add(new SkautDTO(
                            sk.OsobaId,
                            sk.Ime,
                            sk.Prezime,
                            sk.DatumRodjenja,
                            sk.Drzava,
                            sk.Email,
                            sk.StatusAngazmana,
                            sk.Igra != null ? sk.Igra.Naziv : ""
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static SkautDTO VratiSkauta(int id)
        {
            SkautDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var sk = s.Get<Skaut>(id);
                    if (sk != null)
                    {
                        dto = new SkautDTO(
                            sk.OsobaId,
                            sk.Ime,
                            sk.Prezime,
                            sk.DatumRodjenja,
                            sk.Drzava,
                            sk.Email,
                            sk.StatusAngazmana,
                            sk.Igra != null ? sk.Igra.Naziv : ""
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajSkauta(SkautDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Skaut sk = new Skaut();
                    sk.Ime = p.Ime;
                    sk.Prezime = p.Prezime;
                    sk.DatumRodjenja = p.DatumRodjenja;
                    sk.Drzava = p.Drzava;
                    sk.Email = p.Email;
                    sk.StatusAngazmana = p.StatusAngazmana;

                    // Ukoliko se kroz naziv igre ili preko nekog ID-ja mapira igra, ovde to možemo povezati. 
                    // Pošto DTO ima string NazivIgre, možemo potražiti igru po nazivu ako je potrebno, ili ostaviti null.
                    if (!string.IsNullOrEmpty(p.NazivIgre))
                    {
                        var igra = s.QueryOver<Igra>().Where(i => i.Naziv == p.NazivIgre).SingleOrDefault();
                        if (igra != null)
                        {
                            sk.Igra = igra;
                        }
                    }

                    s.Save(sk);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniSkauta(SkautDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Skaut sk = s.Get<Skaut>(p.OsobaId);
                    if (sk != null)
                    {
                        sk.Ime = p.Ime;
                        sk.Prezime = p.Prezime;
                        sk.DatumRodjenja = p.DatumRodjenja;
                        sk.Drzava = p.Drzava;
                        sk.Email = p.Email;
                        sk.StatusAngazmana = p.StatusAngazmana;

                        if (!string.IsNullOrEmpty(p.NazivIgre))
                        {
                            var igra = s.QueryOver<Igra>().Where(i => i.Naziv == p.NazivIgre).SingleOrDefault();
                            if (igra != null)
                            {
                                sk.Igra = igra;
                            }
                        }
                        else
                        {
                            sk.Igra = null;
                        }

                        s.Update(sk);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiSkauta(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Skaut sk = s.Get<Skaut>(id);
                    if (sk != null)
                    {
                        s.Delete(sk);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- SPONZOR KONTAKT CRUD ---

        public static List<SponzorKontaktDTO> VratiSveSponzorKontakte()
        {
            List<SponzorKontaktDTO> spisak = new List<SponzorKontaktDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var kontakti = s.QueryOver<SponzorKontakt>().List();
                    foreach (var k in kontakti)
                    {
                        spisak.Add(new SponzorKontaktDTO(
                            k.KontaktId,
                            k.Sponzor != null ? k.Sponzor.SponzorId : 0,
                            k.Ime,
                            k.Prezime,
                            k.Telefon,
                            k.Email
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static SponzorKontaktDTO VratiSponzorKontakt(int id)
        {
            SponzorKontaktDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var k = s.Get<SponzorKontakt>(id);
                    if (k != null)
                    {
                        dto = new SponzorKontaktDTO(
                            k.KontaktId,
                            k.Sponzor != null ? k.Sponzor.SponzorId : 0,
                            k.Ime,
                            k.Prezime,
                            k.Telefon,
                            k.Email
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajSponzorKontakt(SponzorKontaktDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    SponzorKontakt k = new SponzorKontakt();
                    k.Ime = p.Ime;
                    k.Prezime = p.Prezime;
                    k.Telefon = p.Telefon;
                    k.Email = p.Email;

                    if (p.SponzorId > 0)
                    {
                        k.Sponzor = s.Get<Sponzor>(p.SponzorId);
                    }

                    s.Save(k);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniSponzorKontakt(SponzorKontaktDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    SponzorKontakt k = s.Get<SponzorKontakt>(p.KontaktId);
                    if (k != null)
                    {
                        k.Ime = p.Ime;
                        k.Prezime = p.Prezime;
                        k.Telefon = p.Telefon;
                        k.Email = p.Email;

                        if (p.SponzorId > 0)
                        {
                            k.Sponzor = s.Get<Sponzor>(p.SponzorId);
                        }

                        s.Update(k);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiSponzorKontakt(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    SponzorKontakt k = s.Get<SponzorKontakt>(id);
                    if (k != null)
                    {
                        s.Delete(k);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- SPONZOR CRUD ---

        public static List<SponzorDTO> VratiSveSponzore()
        {
            List<SponzorDTO> spisak = new List<SponzorDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var sponzori = s.QueryOver<Sponzor>().List();
                    foreach (var sp in sponzori)
                    {
                        spisak.Add(new SponzorDTO(
                            sp.SponzorId,
                            sp.Naziv,
                            sp.Drzava,
                            sp.TipSponzora,
                            sp.OblastPoslovanja
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static SponzorDTO VratiSponzora(int id)
        {
            SponzorDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var sp = s.Get<Sponzor>(id);
                    if (sp != null)
                    {
                        dto = new SponzorDTO(
                            sp.SponzorId,
                            sp.Naziv,
                            sp.Drzava,
                            sp.TipSponzora,
                            sp.OblastPoslovanja
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajSponzora(SponzorDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Sponzor sp = new Sponzor();
                    sp.Naziv = p.Naziv;
                    sp.Drzava = p.Drzava;
                    sp.TipSponzora = p.TipSponzora;
                    sp.OblastPoslovanja = p.OblastPoslovanja;

                    s.Save(sp);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniSponzora(SponzorDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Sponzor sp = s.Get<Sponzor>(p.SponzorId);
                    if (sp != null)
                    {
                        sp.Naziv = p.Naziv;
                        sp.Drzava = p.Drzava;
                        sp.TipSponzora = p.TipSponzora;
                        sp.OblastPoslovanja = p.OblastPoslovanja;

                        s.Update(sp);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiSponzora(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Sponzor sp = s.Get<Sponzor>(id);
                    if (sp != null)
                    {
                        s.Delete(sp);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- SPONZORSKI UGOVOR CRUD ---

        public static List<SponzorskiUgovorDTO> VratiSveSponzorskeUgovore()
        {
            List<SponzorskiUgovorDTO> spisak = new List<SponzorskiUgovorDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var ugovori = s.QueryOver<SponzorskiUgovor>().List();
                    foreach (var u in ugovori)
                    {
                        var dto = new SponzorskiUgovorDTO(
                            u.UgovorId,
                            u.Sponzor != null ? u.Sponzor.SponzorId : 0,
                            u.DatumOd,
                            u.DatumDo,
                            u.Iznos,
                            u.Valuta,
                            u.TipPodrske,
                            u.MarketinskeObaveze
                        );
                        dto.NazivSponzora = u.Sponzor != null ? u.Sponzor.Naziv : "";
                        spisak.Add(dto);
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static SponzorskiUgovorDTO VratiSponzorskiUgovor(int id)
        {
            SponzorskiUgovorDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var u = s.Get<SponzorskiUgovor>(id);
                    if (u != null)
                    {
                        dto = new SponzorskiUgovorDTO(
                            u.UgovorId,
                            u.Sponzor != null ? u.Sponzor.SponzorId : 0,
                            u.DatumOd,
                            u.DatumDo,
                            u.Iznos,
                            u.Valuta,
                            u.TipPodrske,
                            u.MarketinskeObaveze
                        );
                        dto.NazivSponzora = u.Sponzor != null ? u.Sponzor.Naziv : "";
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajSponzorskiUgovor(SponzorskiUgovorDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    SponzorskiUgovor u = new SponzorskiUgovor();
                    u.DatumOd = p.DatumOd;
                    u.DatumDo = p.DatumDo;
                    u.Iznos = p.Iznos;
                    u.Valuta = p.Valuta;
                    u.TipPodrske = p.TipPodrske;
                    u.MarketinskeObaveze = p.MarketinskeObaveze;

                    if (p.SponzorId > 0)
                    {
                        u.Sponzor = s.Get<Sponzor>(p.SponzorId);
                    }

                    s.Save(u);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniSponzorskiUgovor(SponzorskiUgovorDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    SponzorskiUgovor u = s.Get<SponzorskiUgovor>(p.UgovorId);
                    if (u != null)
                    {
                        u.DatumOd = p.DatumOd;
                        u.DatumDo = p.DatumDo;
                        u.Iznos = p.Iznos;
                        u.Valuta = p.Valuta;
                        u.TipPodrske = p.TipPodrske;
                        u.MarketinskeObaveze = p.MarketinskeObaveze;

                        if (p.SponzorId > 0)
                        {
                            u.Sponzor = s.Get<Sponzor>(p.SponzorId);
                        }

                        s.Update(u);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiSponzorskiUgovor(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    SponzorskiUgovor u = s.Get<SponzorskiUgovor>(id);
                    if (u != null)
                    {
                        s.Delete(u);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- STATISTIKA TIMA NA MEČU CRUD ---

        public static List<StatistikaTimaNaMecuDTO> VratiSveStatistikeTimovaNaMecu()
        {
            List<StatistikaTimaNaMecuDTO> spisak = new List<StatistikaTimaNaMecuDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var statistike = s.QueryOver<StatistikaTimaNaMecu>().List();
                    foreach (var st in statistike)
                    {
                        spisak.Add(new StatistikaTimaNaMecuDTO(
                            0,
                            st.MecId != null ? st.MecId.MecId : 0,
                            st.TimId != null ? st.TimId.TimId : 0,
                            st.TimId != null ? st.TimId.Naziv : "",
                            0,
                            st.Gold,
                            st.ObjectiveScore,
                            false
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static StatistikaTimaNaMecuDTO VratiStatistikuTimaNaMecu(int mecId, int timId)
        {
            StatistikaTimaNaMecuDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var mec = s.Get<Mec>(mecId);
                    var tim = s.Get<Tim>(timId);

                    if (mec != null && tim != null)
                    {
                        var kljuc = new StatistikaTimaNaMecu { MecId = mec, TimId = tim };
                        var st = s.Get<StatistikaTimaNaMecu>(kljuc);

                        if (st != null)
                        {
                            dto = new StatistikaTimaNaMecuDTO(
                                0,
                                st.MecId != null ? st.MecId.MecId : 0,
                                st.TimId != null ? st.TimId.TimId : 0,
                                st.TimId != null ? st.TimId.Naziv : "",
                                0,
                                st.Gold,
                                st.ObjectiveScore,
                                false
                            );
                        }
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajStatistikuTimaNaMecu(StatistikaTimaNaMecuDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    StatistikaTimaNaMecu st = new StatistikaTimaNaMecu();
                    st.Gold = p.UkupnoZlato;
                    st.ObjectiveScore = p.BrojUbijenihCiljeva;
                    st.Kills = 0;
                    st.Deaths = 0;
                    st.Assists = 0;
                    st.Damage = 0;

                    if (p.MecId > 0)
                    {
                        st.MecId = s.Get<Mec>(p.MecId);
                    }
                    if (p.TimId > 0)
                    {
                        st.TimId = s.Get<Tim>(p.TimId);
                    }

                    s.Save(st);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniStatistikuTimaNaMecu(StatistikaTimaNaMecuDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var mec = s.Get<Mec>(p.MecId);
                    var tim = s.Get<Tim>(p.TimId);

                    if (mec != null && tim != null)
                    {
                        var kljuc = new StatistikaTimaNaMecu { MecId = mec, TimId = tim };
                        var st = s.Get<StatistikaTimaNaMecu>(kljuc);

                        if (st != null)
                        {
                            st.Gold = p.UkupnoZlato;
                            st.ObjectiveScore = p.BrojUbijenihCiljeva;

                            s.Update(st);
                            s.Flush();
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiStatistikuTimaNaMecu(int mecId, int timId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var mec = s.Get<Mec>(mecId);
                    var tim = s.Get<Tim>(timId);

                    if (mec != null && tim != null)
                    {
                        var kljuc = new StatistikaTimaNaMecu { MecId = mec, TimId = tim };
                        var st = s.Get<StatistikaTimaNaMecu>(kljuc);

                        if (st != null)
                        {
                            s.Delete(st);
                            s.Flush();
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- TAKMIČENJE CRUD ---

        public static List<TakmicenjeDTO> VratiSvaTakmicenja()
        {
            List<TakmicenjeDTO> spisak = new List<TakmicenjeDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var takmicenja = s.QueryOver<Takmicenje>().List();
                    foreach (var t in takmicenja)
                    {
                        spisak.Add(new TakmicenjeDTO(
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
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static TakmicenjeDTO VratiTakmicenje(int id)
        {
            TakmicenjeDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var t = s.Get<Takmicenje>(id);
                    if (t != null)
                    {
                        dto = new TakmicenjeDTO(
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
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajTakmicenje(TakmicenjeDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Takmicenje t = new Takmicenje();
                    t.Naziv = p.Naziv;
                    t.Organizator = p.Organizator;
                    t.TipTakmicenja = p.TipTakmicenja;
                    t.Region = p.Region;
                    t.Lokacija = p.Lokacija;
                    t.FormatTakmicenja = p.FormatTakmicenja;
                    t.DatumPocetka = p.DatumPocetka;
                    t.DatumZavrsetka = p.DatumZavrsetka;
                    t.NagradniFond = p.NagradniFond;
                    t.ValutaNagrade = p.ValutaNagrade;
                    t.Status = p.Status;

                    if (!string.IsNullOrEmpty(p.Igra))
                    {
                        var igra = s.QueryOver<Igra>().Where(i => i.Naziv == p.Igra).SingleOrDefault();
                        if (igra != null)
                        {
                            t.Igra = igra;
                        }
                    }

                    s.Save(t);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniTakmicenje(TakmicenjeDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Takmicenje t = s.Get<Takmicenje>(p.TakmicenjeId);
                    if (t != null)
                    {
                        t.Naziv = p.Naziv;
                        t.Organizator = p.Organizator;
                        t.TipTakmicenja = p.TipTakmicenja;
                        t.Region = p.Region;
                        t.Lokacija = p.Lokacija;
                        t.FormatTakmicenja = p.FormatTakmicenja;
                        t.DatumPocetka = p.DatumPocetka;
                        t.DatumZavrsetka = p.DatumZavrsetka;
                        t.NagradniFond = p.NagradniFond;
                        t.ValutaNagrade = p.ValutaNagrade;
                        t.Status = p.Status;

                        if (!string.IsNullOrEmpty(p.Igra))
                        {
                            var igra = s.QueryOver<Igra>().Where(i => i.Naziv == p.Igra).SingleOrDefault();
                            if (igra != null)
                            {
                                t.Igra = igra;
                            }
                        }

                        s.Update(t);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiTakmicenje(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Takmicenje t = s.Get<Takmicenje>(id);
                    if (t != null)
                    {
                        s.Delete(t);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- TELEFON CRUD ---

        public static List<OsobaDTO> VratiSveTelefoneOsoba()
        {
            List<OsobaDTO> spisak = new List<OsobaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var telefoni = s.QueryOver<Telefon>().List();
                    foreach (var t in telefoni)
                    {
                        if (t.OsobaId != null)
                        {
                            spisak.Add(new OsobaDTO(
                                t.OsobaId.OsobaId, t.OsobaId.Ime, t.OsobaId.Prezime,
                                t.OsobaId.DatumRodjenja, t.OsobaId.Drzava, t.OsobaId.Email, t.OsobaId.StatusAngazmana
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static void DodajTelefonZaOsobu(int osobaId, string brojTelefona)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var osoba = s.Get<Osoba>(osobaId);
                    if (osoba != null)
                    {
                        Telefon tel = new Telefon();
                        tel.OsobaId = osoba;
                        tel.BrojTelefona = brojTelefona;

                        s.Save(tel);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiTelefonZaOsobu(int osobaId, string brojTelefona)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var osoba = s.Get<Osoba>(osobaId);
                    if (osoba != null)
                    {
                        var kljuc = new Telefon { OsobaId = osoba, BrojTelefona = brojTelefona };
                        var tel = s.Get<Telefon>(kljuc);

                        if (tel != null)
                        {
                            s.Delete(tel);
                            s.Flush();
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- TIM CRUD ---

        public static List<TimDTO> VratiSveTimove()
        {
            List<TimDTO> spisak = new List<TimDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var timovi = s.QueryOver<Tim>().List();
                    foreach (var t in timovi)
                    {
                        spisak.Add(new TimDTO(
                            t.TimId,
                            t.Naziv,
                            t.IgraId != null ? t.IgraId.IgraId : 0,
                            t.IgraId != null ? t.IgraId.Naziv : "",
                            t.DatumOsnivanja,
                            t.DrzavaRegistracije,
                            t.StatusTima,
                            t.NivoTakmicenja
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static TimDTO VratiTim(int id)
        {
            TimDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var t = s.Get<Tim>(id);
                    if (t != null)
                    {
                        dto = new TimDTO(
                            t.TimId,
                            t.Naziv,
                            t.IgraId != null ? t.IgraId.IgraId : 0,
                            t.IgraId != null ? t.IgraId.Naziv : "",
                            t.DatumOsnivanja,
                            t.DrzavaRegistracije,
                            t.StatusTima,
                            t.NivoTakmicenja
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajTim(TimDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Tim t = new Tim();
                    t.Naziv = p.Naziv;
                    t.DatumOsnivanja = p.DatumOsnivanja;
                    t.DrzavaRegistracije = p.DrzavaRegistracije;
                    t.StatusTima = p.StatusTima;
                    t.NivoTakmicenja = p.NivoTakmicenja;

                    if (p.IgraId > 0)
                    {
                        t.IgraId = s.Get<Igra>(p.IgraId);
                    }

                    s.Save(t);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniTim(TimDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Tim t = s.Get<Tim>(p.TimId);
                    if (t != null)
                    {
                        t.Naziv = p.Naziv;
                        t.DatumOsnivanja = p.DatumOsnivanja;
                        t.DrzavaRegistracije = p.DrzavaRegistracije;
                        t.StatusTima = p.StatusTima;
                        t.NivoTakmicenja = p.NivoTakmicenja;

                        if (p.IgraId > 0)
                        {
                            t.IgraId = s.Get<Igra>(p.IgraId);
                        }

                        s.Update(t);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiTim(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Tim t = s.Get<Tim>(id);
                    if (t != null)
                    {
                        s.Delete(t);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- TRANSFER CRUD ---

        public static List<TransferDTO> VratiSveTransfere()
        {
            List<TransferDTO> spisak = new List<TransferDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var transferi = s.QueryOver<Transfer>().List();
                    foreach (var tr in transferi)
                    {
                        spisak.Add(new TransferDTO(
                            tr.TransferId,
                            tr.Igrac != null ? tr.Igrac.OsobaId : 0,
                            tr.Igrac != null ? $"{tr.Igrac.Ime} {tr.Igrac.Prezime}" : "",
                            tr.PrethodniTim != null ? tr.PrethodniTim.TimId : (int?)null,
                            tr.PrethodniTim != null ? tr.PrethodniTim.Naziv : "",
                            tr.NoviTim != null ? tr.NoviTim.TimId : 0,
                            tr.NoviTim != null ? tr.NoviTim.Naziv : "",
                            tr.DatumPrelaska,
                            tr.IznosTransfera,
                            tr.Valuta,
                            tr.TrajanjeUgovoraMeseci,
                            tr.PosebneKlauzule
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static TransferDTO VratiTransfer(int id)
        {
            TransferDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var tr = s.Get<Transfer>(id);
                    if (tr != null)
                    {
                        dto = new TransferDTO(
                            tr.TransferId,
                            tr.Igrac != null ? tr.Igrac.OsobaId : 0,
                            tr.Igrac != null ? $"{tr.Igrac.Ime} {tr.Igrac.Prezime}" : "",
                            tr.PrethodniTim != null ? tr.PrethodniTim.TimId : (int?)null,
                            tr.PrethodniTim != null ? tr.PrethodniTim.Naziv : "",
                            tr.NoviTim != null ? tr.NoviTim.TimId : 0,
                            tr.NoviTim != null ? tr.NoviTim.Naziv : "",
                            tr.DatumPrelaska,
                            tr.IznosTransfera,
                            tr.Valuta,
                            tr.TrajanjeUgovoraMeseci,
                            tr.PosebneKlauzule
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajTransfer(TransferDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Transfer tr = new Transfer();
                    tr.DatumPrelaska = p.DatumPrelaska;
                    tr.IznosTransfera = p.IznosTransfera;
                    tr.Valuta = p.Valuta;
                    tr.TrajanjeUgovoraMeseci = p.TrajanjeUgovoraMeseci;
                    tr.PosebneKlauzule = p.PosebneKlauzule;

                    if (p.IgracId > 0)
                    {
                        tr.Igrac = s.Get<Igrac>(p.IgracId);
                    }
                    if (p.PrethodniTimId.HasValue && p.PrethodniTimId.Value > 0)
                    {
                        tr.PrethodniTim = s.Get<Tim>(p.PrethodniTimId.Value);
                    }
                    if (p.NoviTimId > 0)
                    {
                        tr.NoviTim = s.Get<Tim>(p.NoviTimId);
                    }

                    s.Save(tr);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniTransfer(TransferDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Transfer tr = s.Get<Transfer>(p.TransferId);
                    if (tr != null)
                    {
                        tr.DatumPrelaska = p.DatumPrelaska;
                        tr.IznosTransfera = p.IznosTransfera;
                        tr.Valuta = p.Valuta;
                        tr.TrajanjeUgovoraMeseci = p.TrajanjeUgovoraMeseci;
                        tr.PosebneKlauzule = p.PosebneKlauzule;

                        if (p.IgracId > 0)
                        {
                            tr.Igrac = s.Get<Igrac>(p.IgracId);
                        }
                        if (p.PrethodniTimId.HasValue && p.PrethodniTimId.Value > 0)
                        {
                            tr.PrethodniTim = s.Get<Tim>(p.PrethodniTimId.Value);
                        }
                        else
                        {
                            tr.PrethodniTim = null;
                        }
                        if (p.NoviTimId > 0)
                        {
                            tr.NoviTim = s.Get<Tim>(p.NoviTimId);
                        }

                        s.Update(tr);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiTransfer(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Transfer tr = s.Get<Transfer>(id);
                    if (tr != null)
                    {
                        s.Delete(tr);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- TRENER CRUD ---

        public static List<TrenerDTO> VratiSveTreinere()
        {
            List<TrenerDTO> spisak = new List<TrenerDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var treneri = s.QueryOver<Trener>().List();
                    foreach (var t in treneri)
                    {
                        spisak.Add(new TrenerDTO(
                            t.OsobaId,
                            t.Ime,
                            t.Prezime,
                            "",
                            t.TipUloge,
                            t.StilRada,
                            t.StatusAngazmana
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static TrenerDTO VratiTrenera(int id)
        {
            TrenerDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var t = s.Get<Trener>(id);
                    if (t != null)
                    {
                        dto = new TrenerDTO(
                            t.OsobaId,
                            t.Ime,
                            t.Prezime,
                            "",
                            t.TipUloge,
                            t.StilRada,
                            t.StatusAngazmana
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajTrenera(TrenerDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Trener t = new Trener();
                    t.Ime = p.Ime;
                    t.Prezime = p.Prezime;
                    t.TipUloge = p.TipUloge;
                    t.StilRada = p.StilRada;
                    t.StatusAngazmana = p.StatusAngazmana;

                    s.Save(t);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniTrenera(TrenerDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Trener t = s.Get<Trener>(p.OsobaId);
                    if (t != null)
                    {
                        t.Ime = p.Ime;
                        t.Prezime = p.Prezime;
                        t.TipUloge = p.TipUloge;
                        t.StilRada = p.StilRada;
                        t.StatusAngazmana = p.StatusAngazmana;

                        s.Update(t);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiTrenera(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Trener t = s.Get<Trener>(id);
                    if (t != null)
                    {
                        s.Delete(t);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- TURNIR CRUD ---

        public static List<TurnirDTO> VratiSveTurnire()
        {
            List<TurnirDTO> spisak = new List<TurnirDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var turniri = s.QueryOver<Turnir>().List();
                    foreach (var t in turniri)
                    {
                        spisak.Add(new TurnirDTO(
                            t.TakmicenjeId,
                            t.Naziv,
                            t.Organizator,
                            t.Igra != null ? t.Igra.Naziv : "",
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
                            t.BrojMecevaPoRundi
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static TurnirDTO VratiTurnir(int id)
        {
            TurnirDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var t = s.Get<Turnir>(id);
                    if (t != null)
                    {
                        dto = new TurnirDTO(
                            t.TakmicenjeId,
                            t.Naziv,
                            t.Organizator,
                            t.Igra != null ? t.Igra.Naziv : "",
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
                            t.BrojMecevaPoRundi
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajTurnir(TurnirDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Turnir t = new Turnir();
                    t.Naziv = p.NazivTakmicenja;
                    t.Organizator = p.Organizator;
                    t.Region = p.Region;
                    t.Lokacija = p.Lokacija;
                    t.FormatTakmicenja = p.FormatTakmicenja;
                    t.DatumPocetka = p.DatumPocetka;
                    t.DatumZavrsetka = p.DatumZavrsetka;
                    t.NagradniFond = p.NagradniFond;
                    t.ValutaNagrade = p.ValutaNagrade;
                    t.Status = p.Status;
                    t.TipKostura = p.TipKostura;
                    t.PravilaNapredovanja = p.PravilaNapredovanja;
                    t.BrojMecevaPoRundi = p.BrojMecevaPoRundi;

                    if (!string.IsNullOrEmpty(p.Igra))
                    {
                        var igra = s.QueryOver<Igra>().Where(i => i.Naziv == p.Igra).SingleOrDefault();
                        if (igra != null)
                        {
                            t.Igra = igra;
                        }
                    }

                    s.Save(t);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniTurnir(TurnirDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Turnir t = s.Get<Turnir>(p.TakmicenjeId);
                    if (t != null)
                    {
                        t.Naziv = p.NazivTakmicenja;
                        t.Organizator = p.Organizator;
                        t.Region = p.Region;
                        t.Lokacija = p.Lokacija;
                        t.FormatTakmicenja = p.FormatTakmicenja;
                        t.DatumPocetka = p.DatumPocetka;
                        t.DatumZavrsetka = p.DatumZavrsetka;
                        t.NagradniFond = p.NagradniFond;
                        t.ValutaNagrade = p.ValutaNagrade;
                        t.Status = p.Status;
                        t.TipKostura = p.TipKostura;
                        t.PravilaNapredovanja = p.PravilaNapredovanja;
                        t.BrojMecevaPoRundi = p.BrojMecevaPoRundi;

                        if (!string.IsNullOrEmpty(p.Igra))
                        {
                            var igra = s.QueryOver<Igra>().Where(i => i.Naziv == p.Igra).SingleOrDefault();
                            if (igra != null)
                            {
                                t.Igra = igra;
                            }
                        }

                        s.Update(t);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiTurnir(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    Turnir t = s.Get<Turnir>(id);
                    if (t != null)
                    {
                        s.Delete(t);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- UČEŠĆE TIMA U FAZI CRUD ---

        public static List<UcesceTimaUFaziDTO> VratiSvaUcescaTimovaUFazi()
        {
            List<UcesceTimaUFaziDTO> spisak = new List<UcesceTimaUFaziDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var ucesca = s.QueryOver<UcesceTimaUFazi>().List();
                    foreach (var u in ucesca)
                    {
                        spisak.Add(new UcesceTimaUFaziDTO(
                            u.FazaId != null ? u.FazaId.FazaId : 0,
                            u.TimId != null ? u.TimId.TimId : 0,
                            u.FazaId != null ? u.FazaId.NazivFaze : "",
                            u.TimId != null ? u.TimId.Naziv : "",
                            u.Status,
                            u.OstvareniRezultat,
                            u.BrojPobeda,
                            u.BrojPoraza,
                            u.OsvojeniBodovi,
                            u.KonacanPlasman
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static UcesceTimaUFaziDTO VratiUcesceTimaUFazi(int fazaId, int timId)
        {
            UcesceTimaUFaziDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var faza = s.Get<FazaTakmicenja>(fazaId);
                    var tim = s.Get<Tim>(timId);

                    if (faza != null && tim != null)
                    {
                        var kljuc = new UcesceTimaUFazi { FazaId = faza, TimId = tim };
                        var u = s.Get<UcesceTimaUFazi>(kljuc);

                        if (u != null)
                        {
                            dto = new UcesceTimaUFaziDTO(
                                u.FazaId != null ? u.FazaId.FazaId : 0,
                                u.TimId != null ? u.TimId.TimId : 0,
                                u.FazaId != null ? u.FazaId.NazivFaze : "",
                                u.TimId != null ? u.TimId.Naziv : "",
                                u.Status,
                                u.OstvareniRezultat,
                                u.BrojPobeda,
                                u.BrojPoraza,
                                u.OsvojeniBodovi,
                                u.KonacanPlasman
                            );
                        }
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajUcesceTimaUFazi(UcesceTimaUFaziDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    UcesceTimaUFazi u = new UcesceTimaUFazi();
                    u.Status = p.Status;
                    u.OstvareniRezultat = p.OstvareniRezultat;
                    u.BrojPobeda = p.BrojPobeda;
                    u.BrojPoraza = p.BrojPoraza;
                    u.OsvojeniBodovi = p.OsvojeniBodovi;
                    u.KonacanPlasman = p.KonacanPlasman;

                    if (p.FazaId > 0)
                    {
                        u.FazaId = s.Get<FazaTakmicenja>(p.FazaId);
                    }
                    if (p.TimId > 0)
                    {
                        u.TimId = s.Get<Tim>(p.TimId);
                    }

                    s.Save(u);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniUcesceTimaUFazi(UcesceTimaUFaziDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var faza = s.Get<FazaTakmicenja>(p.FazaId);
                    var tim = s.Get<Tim>(p.TimId);

                    if (faza != null && tim != null)
                    {
                        var kljuc = new UcesceTimaUFazi { FazaId = faza, TimId = tim };
                        var u = s.Get<UcesceTimaUFazi>(kljuc);

                        if (u != null)
                        {
                            u.Status = p.Status;
                            u.OstvareniRezultat = p.OstvareniRezultat;
                            u.BrojPobeda = p.BrojPobeda;
                            u.BrojPoraza = p.BrojPoraza;
                            u.OsvojeniBodovi = p.OsvojeniBodovi;
                            u.KonacanPlasman = p.KonacanPlasman;

                            s.Update(u);
                            s.Flush();
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiUcesceTimaUFazi(int fazaId, int timId)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var faza = s.Get<FazaTakmicenja>(fazaId);
                    var tim = s.Get<Tim>(timId);

                    if (faza != null && tim != null)
                    {
                        var kljuc = new UcesceTimaUFazi { FazaId = faza, TimId = tim };
                        var u = s.Get<UcesceTimaUFazi>(kljuc);

                        if (u != null)
                        {
                            s.Delete(u);
                            s.Flush();
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- UGOVOR IGRAČA CRUD ---

        public static List<UgovorIgracaDTO> VratiSveUgovoreIgraca()
        {
            List<UgovorIgracaDTO> spisak = new List<UgovorIgracaDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var ugovori = s.QueryOver<UgovorIgraca>().List();
                    foreach (var u in ugovori)
                    {
                        spisak.Add(new UgovorIgracaDTO(
                            u.UgovorId,
                            u.Igrac != null ? u.Igrac.OsobaId : 0,
                            u.Igrac != null ? $"{u.Igrac.Ime} {u.Igrac.Prezime}" : "",
                            u.Tim != null ? u.Tim.TimId : 0,
                            u.Tim != null ? u.Tim.Naziv : "",
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
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static UgovorIgracaDTO VratiUgovorIgraca(int id)
        {
            UgovorIgracaDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var u = s.Get<UgovorIgraca>(id);
                    if (u != null)
                    {
                        dto = new UgovorIgracaDTO(
                            u.UgovorId,
                            u.Igrac != null ? u.Igrac.OsobaId : 0,
                            u.Igrac != null ? $"{u.Igrac.Ime} {u.Igrac.Prezime}" : "",
                            u.Tim != null ? u.Tim.TimId : 0,
                            u.Tim != null ? u.Tim.Naziv : "",
                            u.DatumOd,
                            u.DatumDo,
                            u.TipUgovora,
                            u.Plata,
                            u.Bonusi,
                            u.KlauzulaOtkup,
                            u.ZabranaNastupa,
                            u.StatusIgraca
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajUgovorIgraca(UgovorIgracaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    UgovorIgraca u = new UgovorIgraca();
                    u.DatumOd = p.DatumOd;
                    u.DatumDo = p.DatumDo;
                    u.TipUgovora = p.TipUgovora;
                    u.Plata = p.Plata;
                    u.Bonusi = p.Bonusi;
                    u.KlauzulaOtkup = p.KlauzulaOtkup;
                    u.ZabranaNastupa = p.ZabranaNastupa;
                    u.StatusIgraca = p.StatusIgraca;

                    if (p.IgracId > 0)
                    {
                        u.Igrac = s.Get<Igrac>(p.IgracId);
                    }
                    if (p.TimId > 0)
                    {
                        u.Tim = s.Get<Tim>(p.TimId);
                    }

                    s.Save(u);
                    s.Flush();
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniUgovorIgraca(UgovorIgracaDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    UgovorIgraca u = s.Get<UgovorIgraca>(p.UgovorId);
                    if (u != null)
                    {
                        u.DatumOd = p.DatumOd;
                        u.DatumDo = p.DatumDo;
                        u.TipUgovora = p.TipUgovora;
                        u.Plata = p.Plata;
                        u.Bonusi = p.Bonusi;
                        u.KlauzulaOtkup = p.KlauzulaOtkup;
                        u.ZabranaNastupa = p.ZabranaNastupa;
                        u.StatusIgraca = p.StatusIgraca;

                        if (p.IgracId > 0)
                        {
                            u.Igrac = s.Get<Igrac>(p.IgracId);
                        }
                        if (p.TimId > 0)
                        {
                            u.Tim = s.Get<Tim>(p.TimId);
                        }

                        s.Update(u);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiUgovorIgraca(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    UgovorIgraca u = s.Get<UgovorIgraca>(id);
                    if (u != null)
                    {
                        s.Delete(u);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // --- UGOVOR SUBJEKAT CRUD ---

        public static List<UgovorSubjekatDTO> VratiSveUgovoreSubjekte()
        {
            List<UgovorSubjekatDTO> spisak = new List<UgovorSubjekatDTO>();
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var subjekti = s.QueryOver<UgovorSubjekat>().List();
                    foreach (var us in subjekti)
                    {
                        spisak.Add(new UgovorSubjekatDTO(
                            us.UgovorId,
                            us.Tim != null ? us.Tim.TimId : (int?)null,
                            us.Tim != null ? us.Tim.Naziv : "",
                            us.Igrac != null ? us.Igrac.OsobaId : (int?)null,
                            us.Igrac != null ? $"{us.Igrac.Ime} {us.Igrac.Prezime}" : "",
                            us.Takmicenje != null ? us.Takmicenje.TakmicenjeId : (int?)null,
                            us.Takmicenje != null ? us.Takmicenje.Naziv : ""
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                // Obrada izuzetaka
            }
            return spisak;
        }

        public static UgovorSubjekatDTO VratiUgovorSubjekat(int id)
        {
            UgovorSubjekatDTO dto = null;
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    var us = s.Get<UgovorSubjekat>(id);
                    if (us != null)
                    {
                        dto = new UgovorSubjekatDTO(
                            us.UgovorId,
                            us.Tim != null ? us.Tim.TimId : (int?)null,
                            us.Tim != null ? us.Tim.Naziv : "",
                            us.Igrac != null ? us.Igrac.OsobaId : (int?)null,
                            us.Igrac != null ? $"{us.Igrac.Ime} {us.Igrac.Prezime}" : "",
                            us.Takmicenje != null ? us.Takmicenje.TakmicenjeId : (int?)null,
                            us.Takmicenje != null ? us.Takmicenje.Naziv : ""
                        );
                    }
                }
            }
            catch (Exception ex) { }
            return dto;
        }

        public static void DodajUgovorSubjekat(UgovorSubjekatDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    // Budući da je UgovorSubjekat u 1:1 vezi preko primarnog ključa sa SponzorskiUgovor,
                    // moramo pronaći i dodeliti postojeći SponzorskiUgovor po ID-ju.
                    var ugovor = s.Get<SponzorskiUgovor>(p.UgovorId);
                    if (ugovor != null)
                    {
                        UgovorSubjekat us = new UgovorSubjekat();
                        us.UgovorId = p.UgovorId;
                        us.Ugovor = ugovor;

                        if (p.TimId.HasValue && p.TimId.Value > 0)
                        {
                            us.Tim = s.Get<Tim>(p.TimId.Value);
                        }
                        if (p.IgracId.HasValue && p.IgracId.Value > 0)
                        {
                            us.Igrac = s.Get<Igrac>(p.IgracId.Value);
                        }
                        if (p.TakmicenjeId.HasValue && p.TakmicenjeId.Value > 0)
                        {
                            us.Takmicenje = s.Get<Takmicenje>(p.TakmicenjeId.Value);
                        }

                        s.Save(us);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void IzmeniUgovorSubjekat(UgovorSubjekatDTO p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    UgovorSubjekat us = s.Get<UgovorSubjekat>(p.UgovorId);
                    if (us != null)
                    {
                        us.Tim = (p.TimId.HasValue && p.TimId.Value > 0) ? s.Get<Tim>(p.TimId.Value) : null;
                        us.Igrac = (p.IgracId.HasValue && p.IgracId.Value > 0) ? s.Get<Igrac>(p.IgracId.Value) : null;
                        us.Takmicenje = (p.TakmicenjeId.HasValue && p.TakmicenjeId.Value > 0) ? s.Get<Takmicenje>(p.TakmicenjeId.Value) : null;

                        s.Update(us);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }

        public static void ObrisiUgovorSubjekat(int id)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    UgovorSubjekat us = s.Get<UgovorSubjekat>(id);
                    if (us != null)
                    {
                        s.Delete(us);
                        s.Flush();
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}