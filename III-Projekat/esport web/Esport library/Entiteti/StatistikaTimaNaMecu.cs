using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class StatistikaTimaNaMecu
    {
        public virtual Mec MecId { get; set; }
        public virtual Tim TimId { get; set; }
        public virtual int Kills { get; set; }
        public virtual int Deaths { get; set; }
        public virtual int Assists { get; set; }
        public virtual int Damage { get; set; }
        public virtual int ObjectiveScore { get; set; }
        public virtual int Gold { get; set; }

        // Neophodno za NHibernate kompozitne ključeve
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var s = obj as StatistikaTimaNaMecu;
            if (s == null) return false;

            if (MecId == null || s.MecId == null || TimId == null || s.TimId == null) return false;

            return MecId.MecId == s.MecId.MecId && TimId.TimId == s.TimId.TimId;
        }

        public override int GetHashCode()
        {
            return (MecId != null ? MecId.MecId.GetHashCode() : 0) ^
                   (TimId != null ? TimId.TimId.GetHashCode() : 0);
        }
    }
}
