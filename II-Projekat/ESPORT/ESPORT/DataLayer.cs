using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Configuration;
using System.Windows.Forms;

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
                string cs = ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;

                var cfg = OracleManagedDataClientConfiguration.Oracle10
                            .ShowSql()
                            .ConnectionString(c => c.Is(cs));

                return Fluently.Configure()
                        .Database(cfg)
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mapiranje.OsobaMap>())
                        .BuildSessionFactory();
            }
            catch (Exception e)
            {
                string detalji = e.InnerException != null ? e.InnerException.Message : e.Message;

                MessageBox.Show($"Greška pri povezivanju sa bazom:\n{detalji}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}