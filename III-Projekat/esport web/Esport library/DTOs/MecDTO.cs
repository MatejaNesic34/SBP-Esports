using System;

namespace ESPORT
{
    public class MecDTO
    {
        public int MecId { get; set; }
        public int TakmicenjeId { get; set; }
        public string NazivTakmicenja { get; set; }
        public int RedniBroj { get; set; }
        public DateTime DatumVremePocetka { get; set; }
        public string FormatMeca { get; set; }
        public int BrojOdigranihMapa { get; set; }
        public string Rezultat { get; set; }
        public int? Trajanje { get; set; }
        public string LokacijaIgranja { get; set; }
        public string Sudije { get; set; }
        public string StatusMeca { get; set; }

        public string Prikaz
        {
            get
            {
                return "Meč " + MecId + " - " + NazivTakmicenja + " - redni broj " + RedniBroj;
            }
        }

        public MecDTO()
        {
        }

        public MecDTO(
            int mecId,
            int takmicenjeId,
            string nazivTakmicenja,
            int redniBroj,
            DateTime datumVremePocetka,
            string formatMeca,
            int brojOdigranihMapa,
            string rezultat,
            int? trajanje,
            string lokacijaIgranja,
            string sudije,
            string statusMeca)
        {
            MecId = mecId;
            TakmicenjeId = takmicenjeId;
            NazivTakmicenja = nazivTakmicenja;
            RedniBroj = redniBroj;
            DatumVremePocetka = datumVremePocetka;
            FormatMeca = formatMeca;
            BrojOdigranihMapa = brojOdigranihMapa;
            Rezultat = rezultat;
            Trajanje = trajanje;
            LokacijaIgranja = lokacijaIgranja;
            Sudije = sudije;
            StatusMeca = statusMeca;
        }
    }
}