using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AngazmanTreneraController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiAngazmaneTrenera")]
        public IActionResult PreuzmiAngazmaneTrenera()
        {
            List<AngazmanTreneraDTO> lista = DataProvider.VratiSveAngazmaneTrenera();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiAngazmanTrenera/{id}")]
        public IActionResult PreuzmiAngazmanTrenera(int id)
        {
            AngazmanTreneraDTO angazman = DataProvider.VratiAngazmanTrenera(id);
            if (angazman == null)
            {
                return NotFound("Angažman trenera nije pronađen.");
            }
            return Ok(angazman);
        }

        [HttpPost]
        [Route("DodajAngazmanTrenera")]
        public IActionResult DodajAngazmanTrenera([FromBody] AngazmanTreneraDTO noviAngazman)
        {
            DataProvider.DodajAngazmanTrenera(noviAngazman);
            return Ok("Angažman trenera je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniAngazmanTrenera")]
        public IActionResult IzmeniAngazmanTrenera([FromBody] AngazmanTreneraDTO izmenjeniAngazman)
        {
            DataProvider.IzmeniAngazmanTrenera(izmenjeniAngazman);
            return Ok("Podaci o angažmanu trenera su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiAngazmanTrenera/{id}")]
        public IActionResult ObrisiAngazmanTrenera(int id)
        {
            DataProvider.ObrisiAngazmanTrenera(id);
            return Ok("Angažman trenera je uspešno obrisan.");
        }
    }
}