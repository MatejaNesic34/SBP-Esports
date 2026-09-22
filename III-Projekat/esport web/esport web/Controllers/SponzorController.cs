using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SponzorController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSponzore")]
        public IActionResult PreuzmiSponzore()
        {
            List<SponzorDTO> lista = DataProvider.VratiSveSponzore();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiSponzora/{id}")]
        public IActionResult PreuzmiSponzora(int id)
        {
            SponzorDTO sponzor = DataProvider.VratiSponzora(id);
            if (sponzor == null)
            {
                return NotFound("Sponzor nije pronađen.");
            }
            return Ok(sponzor);
        }

        [HttpPost]
        [Route("DodajSponzora")]
        public IActionResult DodajSponzora([FromBody] SponzorDTO noviSponzor)
        {
            DataProvider.DodajSponzora(noviSponzor);
            return Ok("Sponzor je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniSponzora")]
        public IActionResult IzmeniSponzora([FromBody] SponzorDTO izmenjeniSponzor)
        {
            DataProvider.IzmeniSponzora(izmenjeniSponzor);
            return Ok("Podaci o sponzoru su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiSponzora/{id}")]
        public IActionResult ObrisiSponzora(int id)
        {
            DataProvider.ObrisiSponzora(id);
            return Ok("Sponzor je uspešno obrisan.");
        }
    }
}