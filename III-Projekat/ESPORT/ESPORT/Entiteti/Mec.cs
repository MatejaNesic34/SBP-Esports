using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Mec
    {
        public virtual int MecId { get; set; }
        public virtual Takmicenje Takmicenje { get; set; }
        public virtual int RedniBroj { get; set; }
        public virtual DateTime DatumVremePocetka { get; set; }
        public virtual string FormatMeca { get; set; }
        public virtual int BrojOdigranihMapa { get; set; }
        public virtual string Rezultat { get; set; }
        public virtual int? Trajanje { get; set; }
        public virtual string LokacijaIgranja { get; set; }
        public virtual string Sudije { get; set; }
        public virtual string StatusMeca { get; set; }

        // One-to-Many
        public virtual IList<StatistikaTimaNaMecu> StatistikeTimova { get; set; } = new List<StatistikaTimaNaMecu>();
        public virtual IList<DogadjajNaMecu> Dogadjaji { get; set; } = new List<DogadjajNaMecu>();
    }
}
