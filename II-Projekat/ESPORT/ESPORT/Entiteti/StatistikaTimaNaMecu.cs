using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class StatistikaTimaNaMecu
    {
        public virtual int MecId { get; set; }
        public virtual int TimId { get; set; }
        public virtual int Kills { get; set; }
        public virtual int Deaths { get; set; }
        public virtual int Assists { get; set; }
        public virtual int Damage { get; set; }
        public virtual int ObjectiveScore { get; set; }
        public virtual int Gold { get; set; }
    }

    //public class StatistikaTimaNaMecuId
    //{
    //    public virtual Mec Mec { get; set; }
    //    public virtual Tim Tim { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is StatistikaTimaNaMecuId other)
    //            return Mec?.MecId == other.Mec?.MecId && Tim?.TimId == other.Tim?.TimId;
    //        return false;
    //    }
    //    public override int GetHashCode() => HashCode.Combine(Mec?.MecId, Tim?.TimId);
    //}
}
