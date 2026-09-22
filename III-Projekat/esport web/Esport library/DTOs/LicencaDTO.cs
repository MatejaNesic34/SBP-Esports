namespace ESPORT
{
    public class LicencaDTO
    {
        public int LicencaId { get; set; }
        public int OsobaId { get; set; }
        public string ImePrezimeOsobe { get; set; }
        public string Naziv { get; set; }

        public LicencaDTO() { }

        public LicencaDTO(int licencaId, int osobaId, string imePrezimeOsobe, string naziv)
        {
            LicencaId = licencaId;
            OsobaId = osobaId;
            ImePrezimeOsobe = imePrezimeOsobe;
            Naziv = naziv;
        }
    }
}