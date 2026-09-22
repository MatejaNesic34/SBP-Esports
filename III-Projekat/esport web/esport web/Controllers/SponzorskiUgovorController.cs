using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SponzorskiUgovorController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSponzorskeUgovore")]
        public IActionResult PreuzmiSponzorskeUgovore()
        {
            List<SponzorskiUgovorDTO> lista = DataProvider.VratiSveSponzorskeUgovore();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiSponzorskiUgovor/{id}")]
        public IActionResult PreuzmiSponzorskiUgovor(int id)
        {
            SponzorskiUgovorDTO ugovor = DataProvider.VratiSponzorskiUgovor(id);
            if (ugovor == null)
            {
                return NotFound("Sponzorski ugovor nije pronađen.");
            }
            return Ok(ugovor);
        }

        [HttpPost]
        [Route("DodajSponzorskiUgovor")]
        public IActionResult DodajSponzorskiUgovor([FromBody] SponzorskiUgovorDTO noviUgovor)
        {
            DataProvider.DodajSponzorskiUgovor(noviUgovor);
            return Ok("Sponzorski ugovor je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniSponzorskiUgovor")]
        public IActionResult IzmeniSponzorskiUgovor([FromBody] SponzorskiUgovorDTO izmenjeniUgovor)
        {
            DataProvider.IzmeniSponzorskiUgovor(izmenjeniUgovor);
            return Ok("Podaci o sponzorskom ugovoru su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiSponzorskiUgovor/{id}")]
        public IActionResult ObrisiSponzorskiUgovor(int id)
        {
            DataProvider.ObrisiSponzorskiUgovor(id);
            return Ok("Sponzorski ugovor je uspešno obrisan.");
        }
    }
}