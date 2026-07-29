namespace ESPORT.Entiteti
{


    public class UcesceTimaUFazi
    {
        public virtual int FazaId { get; set; }
        public virtual int TimId { get; set; }
        public virtual string Status { get; set; }
        public virtual string OstvareniRezultat { get; set; }
        public virtual int BrojPobeda { get; set; }
        public virtual int BrojPoraza { get; set; }
        public virtual int OsvojeniBodovi { get; set; }
        public virtual int KonacanPlasman { get; set; }
    }

    //public class UcesceTimaUFazi
    //{
    //    public virtual UcesceTimaUFaziId Id { get; set; }
    //    public virtual string Status { get; set; }
    //    public virtual string OstvareniRezultat { get; set; }
    //    public virtual int BrojPobeda { get; set; }
    //    public virtual int BrojPoraza { get; set; }
    //    public virtual int OsvojeniBodovi { get; set; }
    //    public virtual int? KonacanPlasman { get; set; }
    //}

    //public class UcesceTimaUFaziId
    //{
    //    public virtual FazaTakmicenja Faza { get; set; }
    //    public virtual Tim Tim { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is UcesceTimaUFaziId other)
    //            return Faza?.FazaId == other.Faza?.FazaId && Tim?.TimId == other.Tim?.TimId;
    //        return false;
    //    }
    //    public override int GetHashCode() => HashCode.Combine(Faza?.FazaId, Tim?.TimId);
    //}
}