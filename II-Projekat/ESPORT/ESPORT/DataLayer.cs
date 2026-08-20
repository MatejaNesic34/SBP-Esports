using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Configuration;
using System.Windows.Forms; // Potrebno za MessageBox

namespace ESPORT
{
    public static class DataLayer
    {
        private static ISessionFactory? factory;
        private static readonly object lockObj = new object();

        static DataLayer()
        {
            factory = null;
        }

        public static ISession? GetSession()
        {
            if (factory == null)
            {
                lock (lockObj)
                {
                    if (factory == null)
                    {
                        factory = CreateSessionFactory();
                    }
                }
            }

            return factory?.OpenSession();
        }

        private static ISessionFactory? CreateSessionFactory()
        {
            try
            {
                // Učitavanje Connection String-a iz App.config fajla
                string cs = ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;

                // Konfiguracija za Oracle bazu (odgovara OracleDataClientConfiguration)
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                            .ShowSql()
                            .ConnectionString(c => c.Is(cs));

                return Fluently.Configure()
                        .Database(cfg)
                        // Automatski učitava sva mapiranja iz ovog assembly-ja (projekta ESPORT)
                        // Korišćenjem bilo koje tvoje mape, npr. OsobaMap ili IgraMap
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mapiranje.OsobaMap>())
                        //.ExposeConfiguration(BuildSchema)
                        .BuildSessionFactory();
            }
            catch (Exception e)
            {
                // Hvatamo unutrašnju grešku koja sadrži tačan razlog pucanja mapiranja
                string detalji = e.InnerException != null ? e.InnerException.Message : e.Message;

                MessageBox.Show($"Greška pri povezivanju sa bazom:\n{detalji}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /*
        private static void BuildSchema(NHibernate.Cfg.Configuration cfg)
        {
            // Koristi se ako želiš da NHibernate sam kreira tabele po mapiranjima
            // new SchemaExport(cfg).Create(false, true);
        }
        */
    }
}