using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrenerController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTrenere")]
        public IActionResult PreuzmiTrenere()
        {
            List<TrenerDTO> lista = DataProvider.VratiSveTreinere();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiTrenera/{id}")]
        public IActionResult PreuzmiTrenera(int id)
        {
            TrenerDTO trener = DataProvider.VratiTrenera(id);
            if (trener == null)
            {
                return NotFound("Trener nije pronađen.");
            }
            return Ok(trener);
        }

        [HttpPost]
        [Route("DodajTrenera")]
        public IActionResult DodajTrenera([FromBody] TrenerDTO noviTrener)
        {
            DataProvider.DodajTrenera(noviTrener);
            return Ok("Trener je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniTrenera")]
        public IActionResult IzmeniTrenera([FromBody] TrenerDTO izmenjeniTrener)
        {
            DataProvider.IzmeniTrenera(izmenjeniTrener);
            return Ok("Podaci o treneru su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiTrenera/{id}")]
        public IActionResult ObrisiTrenera(int id)
        {
            DataProvider.ObrisiTrenera(id);
            return Ok("Trener je uspešno obrisan.");
        }
    }
}