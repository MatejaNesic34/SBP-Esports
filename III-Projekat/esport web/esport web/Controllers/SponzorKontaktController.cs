using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SponzorKontaktController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSponzorKontakte")]
        public IActionResult PreuzmiSponzorKontakte()
        {
            List<SponzorKontaktDTO> lista = DataProvider.VratiSveSponzorKontakte();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiSponzorKontakt/{id}")]
        public IActionResult PreuzmiSponzorKontakt(int id)
        {
            SponzorKontaktDTO kontakt = DataProvider.VratiSponzorKontakt(id);
            if (kontakt == null)
            {
                return NotFound("Kontakt sponzora nije pronađen.");
            }
            return Ok(kontakt);
        }

        [HttpPost]
        [Route("DodajSponzorKontakt")]
        public IActionResult DodajSponzorKontakt([FromBody] SponzorKontaktDTO noviKontakt)
        {
            DataProvider.DodajSponzorKontakt(noviKontakt);
            return Ok("Kontakt sponzora je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniSponzorKontakt")]
        public IActionResult IzmeniSponzorKontakt([FromBody] SponzorKontaktDTO izmenjeniKontakt)
        {
            DataProvider.IzmeniSponzorKontakt(izmenjeniKontakt);
            return Ok("Podaci o kontaktu sponzora su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiSponzorKontakt/{id}")]
        public IActionResult ObrisiSponzorKontakt(int id)
        {
            DataProvider.ObrisiSponzorKontakt(id);
            return Ok("Kontakt sponzora je uspešno obrisan.");
        }
    }
}