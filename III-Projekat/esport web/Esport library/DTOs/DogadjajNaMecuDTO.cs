using System;

namespace ESPORT
{
    public class DogadjajNaMecuDTO
    {
        public int DogadjajId { get; set; }
        public int MecId { get; set; }
        public int RedniBrojMeca { get; set; }
        public string TipDogadjaja { get; set; }
        public DateTime VremeDogadjaja { get; set; }
        public string Opis { get; set; }
        public string OdlukaSudije { get; set; }

        public DogadjajNaMecuDTO()
        {
        }

        public DogadjajNaMecuDTO(
            int dogadjajId,
            int mecId,
            int redniBrojMeca,
            string tipDogadjaja,
            DateTime vremeDogadjaja,
            string opis,
            string odlukaSudije)
        {
            DogadjajId = dogadjajId;
            MecId = mecId;
            RedniBrojMeca = redniBrojMeca;
            TipDogadjaja = tipDogadjaja;
            VremeDogadjaja = vremeDogadjaja;
            Opis = opis;
            OdlukaSudije = odlukaSudije;
        }
    }
}