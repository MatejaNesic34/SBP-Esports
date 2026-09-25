using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Licenca
    {
        public virtual int LicencaId { get; set; }
        public virtual Osoba OsobaId { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string InstitucijaIzdavac { get; set; }
        public virtual DateTime DatumSticanja { get; set; }
    }
}
