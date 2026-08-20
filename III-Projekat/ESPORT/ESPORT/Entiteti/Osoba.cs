using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPORT.Entiteti
{
    public class Osoba
    {
        public virtual int OsobaId { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime? DatumRodjenja { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime? DatumPrvogAngazovanja { get; set; }
        public virtual string StatusAngazmana { get; set; }

        // Element Collection
        public virtual IList<Telefon> Telefoni { get; set; } = new List<Telefon>();

        // One-to-Many
        public virtual IList<Licenca> Licence { get; set; } = new List<Licenca>();
        public virtual IList<AngazmanZaposlenih> AngazmaniZaposlenog { get; set; } = new List<AngazmanZaposlenih>();
    }
}
