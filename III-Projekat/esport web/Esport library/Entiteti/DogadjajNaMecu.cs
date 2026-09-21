using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class DogadjajNaMecu
    {
        public virtual int DogadjajId { get; set; }
        public virtual Mec Mec { get; set; }
        public virtual string TipDogadjaja { get; set; }
        public virtual DateTime VremeDogadjaja { get; set; }
        public virtual string Opis { get; set; }
        public virtual string OdlukaSudije { get; set; }
    }
}
