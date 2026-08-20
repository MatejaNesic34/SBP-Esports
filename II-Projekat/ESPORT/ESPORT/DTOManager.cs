using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESPORT.IgraDTO;

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

    }
}
