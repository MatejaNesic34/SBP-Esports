using System;

namespace ESPORT
{
    public class AngazmanZaposlenihDTO
    {
        public int AngazmanOsobljaId { get; set; }
        public int OsobaId { get; set; }
        public string ImePrezimeOsobe { get; set; }
        public int TimId { get; set; }
        public string TimNaziv { get; set; }
        public string NazivUloge { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public decimal? Plata { get; set; }

        public AngazmanZaposlenihDTO() { }

        public AngazmanZaposlenihDTO(int angazmanOsobljaId, int osobaId, string imePrezimeOsobe, int timId, string timNaziv, string nazivUloge, DateTime datumOd, DateTime? datumDo, decimal? plata)
        {
            AngazmanOsobljaId = angazmanOsobljaId;
            OsobaId = osobaId;
            ImePrezimeOsobe = imePrezimeOsobe;
            TimId = timId;
            TimNaziv = timNaziv;
            NazivUloge = nazivUloge;
            DatumOd = datumOd;
            DatumDo = datumDo;
            Plata = plata;
        }
    }
}