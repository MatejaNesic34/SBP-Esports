using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Tim
    {
        public virtual int TimId { get; set; }
        public virtual string Naziv { get; set; }
        public virtual Igra IgraId { get; set; }
        public virtual DateTime? DatumOsnivanja { get; set; }
        public virtual string DrzavaRegistracije { get; set; }
        public virtual string StatusTima { get; set; }
        public virtual string NivoTakmicenja { get; set; }

        public virtual IList<UgovorIgraca> UgovoriIgraca { get; set; } = new List<UgovorIgraca>();
        public virtual IList<Transfer> Odlasci { get; set; } = new List<Transfer>();
        public virtual IList<Transfer> Dolasci { get; set; } = new List<Transfer>();
        public virtual IList<Pozajmica> PozajmiceIzTima { get; set; } = new List<Pozajmica>();
        public virtual IList<Pozajmica> PozajmiceUTim { get; set; } = new List<Pozajmica>();
        public virtual IList<AngazmanZaposlenih> Osoblje { get; set; } = new List<AngazmanZaposlenih>();
        public virtual IList<AngazmanTrenera> Treneri { get; set; } = new List<AngazmanTrenera>();
        public virtual IList<UcesceTimaUFazi> UcescaNaTakmicenjima { get; set; } = new List<UcesceTimaUFazi>();
        public virtual IList<StatistikaTimaNaMecu> StatistikeNaMecevima { get; set; } = new List<StatistikaTimaNaMecu>();
        public virtual IList<UgovorSubjekat> SponzorskiUgovoriKaoSubjekat { get; set; } = new List<UgovorSubjekat>();
    }
}
