using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Takmicenje
    {
        public virtual int TakmicenjeId { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Organizator { get; set; }
        public virtual string TipTakmicenja { get; set; }
        public virtual Igra Igra { get; set; }
        public virtual string Region { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string FormatTakmicenja { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime DatumZavrsetka { get; set; }
        public virtual decimal NagradniFond { get; set; }
        public virtual string ValutaNagrade { get; set; }
        public virtual string Status { get; set; }

        public virtual IList<Mec> Mecevi { get; set; } = new List<Mec>();
        public virtual IList<IndividualniRezultat> IndividualnaPriznanja { get; set; } = new List<IndividualniRezultat>();
        public virtual IList<UgovorSubjekat> SponzorskiUgovoriKaoSubjekat { get; set; } = new List<UgovorSubjekat>();
    }
}
