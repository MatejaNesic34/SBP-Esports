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
}
