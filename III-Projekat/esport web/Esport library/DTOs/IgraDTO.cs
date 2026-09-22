using System;
using System.Collections.Generic;

namespace ESPORT
{
    public class IgraDTO
    {
        public int IgraId { get; set; }
        public string Naziv { get; set; }
        public string Zanr { get; set; }

        public IgraDTO()
        {
        }

        public IgraDTO(int igraId, string naziv, string zanr)
        {
            this.IgraId = igraId;
            this.Naziv = naziv;
            this.Zanr = zanr;
        }
    }
}