using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AngazmanZaposlenihController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiAngazmaneZaposlenih")]
        public IActionResult PreuzmiAngazmaneZaposlenih()
        {
            List<AngazmanZaposlenihDTO> lista = DataProvider.VratiSveAngazmaneZaposlenih();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiAngazmanZaposlenih/{id}")]
        public IActionResult PreuzmiAngazmanZaposlenih(int id)
        {
            AngazmanZaposlenihDTO angazman = DataProvider.VratiAngazmanZaposlenih(id);
            if (angazman == null)
            {
                return NotFound("Angažman zaposlenog nije pronađen.");
            }
            return Ok(angazman);
        }

        [HttpPost]
        [Route("DodajAngazmanZaposlenih")]
        public IActionResult DodajAngazmanZaposlenih([FromBody] AngazmanZaposlenihDTO noviAngazman)
        {
            DataProvider.DodajAngazmanZaposlenih(noviAngazman);
            return Ok("Angažman zaposlenog je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniAngazmanZaposlenih")]
        public IActionResult IzmeniAngazmanZaposlenih([FromBody] AngazmanZaposlenihDTO izmenjeniAngazman)
        {
            DataProvider.IzmeniAngazmanZaposlenih(izmenjeniAngazman);
            return Ok("Podaci o angažmanu zaposlenog su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiAngazmanZaposlenih/{id}")]
        public IActionResult ObrisiAngazmanZaposlenih(int id)
        {
            DataProvider.ObrisiAngazmanZaposlenih(id);
            return Ok("Angažman zaposlenog je uspešno obrisan.");
        }
    }
}