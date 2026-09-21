using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class UgovorSubjekat
    {
        public virtual int UgovorId { get; set; }
        public virtual SponzorskiUgovor Ugovor { get; set; }
        public virtual Tim Tim { get; set; }
        public virtual Igrac Igrac { get; set; }
        public virtual Takmicenje Takmicenje { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var other = obj as UgovorSubjekat;
            if (other == null) return false;
            return UgovorId == other.UgovorId;
        }

        public override int GetHashCode()
        {
            return UgovorId.GetHashCode();
        }
    }
}
