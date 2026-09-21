namespace ESPORT.Entiteti
{
    public class IndividualniRezultat
    {
        public virtual int RezultatId { get; set; }
        public virtual Igrac Igrac { get; set; }
        public virtual string NazivPriznanja { get; set; }
        public virtual DateTime? DatumOstvarivanja { get; set; }
        public virtual Takmicenje Takmicenje { get; set; }
        public virtual string Opis { get; set; }
    }
}