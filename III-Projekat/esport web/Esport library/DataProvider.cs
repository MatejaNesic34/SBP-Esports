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
    }
}