using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Igrac : Osoba
    {
        public virtual string Nadimak { get; set; }
        public virtual string PrimarnaUloga { get; set; }
        public virtual string SekundarnaUloga { get; set; }
        public virtual string DominantniStil { get; set; }
        public virtual string Rang { get; set; }

        public virtual IList<UgovorIgraca> Ugovori { get; set; } = new List<UgovorIgraca>();
        public virtual IList<Transfer> Transferi { get; set; } = new List<Transfer>();
        public virtual IList<Pozajmica> Pozajmice { get; set; } = new List<Pozajmica>();
        public virtual IList<IndividualniRezultat> IndividualniRezultati { get; set; } = new List<IndividualniRezultat>();
        public virtual IList<UgovorSubjekat> SponzorskiUgovoriKaoSubjekat { get; set; } = new List<UgovorSubjekat>();
    }
}
