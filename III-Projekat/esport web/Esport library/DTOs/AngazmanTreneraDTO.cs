using System;

namespace ESPORT
{
    public class AngazmanTreneraDTO
    {
        public int AngazmanTreneraId { get; set; }
        public int OsobaId { get; set; }
        public string ImePrezimeTrenera { get; set; }
        public int TimId { get; set; }
        public string NazivTima { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public string TipAngazmana { get; set; }
        public decimal? Plata { get; set; }

        public AngazmanTreneraDTO() { }

        public AngazmanTreneraDTO(int angazmanTreneraId, int osobaId, string imePrezimeTrenera, int timId, string nazivTima, DateTime datumOd, DateTime? datumDo, string tipAngazmana, decimal? plata)
        {
            AngazmanTreneraId = angazmanTreneraId;
            OsobaId = osobaId;
            ImePrezimeTrenera = imePrezimeTrenera;
            TimId = timId;
            NazivTima = nazivTima;
            DatumOd = datumOd;
            DatumDo = datumDo;
            TipAngazmana = tipAngazmana;
            Plata = plata;
        }
    }
}