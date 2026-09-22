using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PozajmicaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPozajmice")]
        public IActionResult PreuzmiPozajmice()
        {
            List<PozajmicaDTO> lista = DataProvider.VratiSvePozajmice();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiPozajmicu/{id}")]
        public IActionResult PreuzmiPozajmicu(int id)
        {
            PozajmicaDTO pozajmica = DataProvider.VratiPozajmicu(id);
            if (pozajmica == null)
            {
                return NotFound("Pozajmica nije pronađena.");
            }
            return Ok(pozajmica);
        }

        [HttpPost]
        [Route("DodajPozajmicu")]
        public IActionResult DodajPozajmicu([FromBody] PozajmicaDTO novaPozajmica)
        {
            DataProvider.DodajPozajmicu(novaPozajmica);
            return Ok("Pozajmica je uspešno dodata.");
        }

        [HttpPut]
        [Route("IzmeniPozajmicu")]
        public IActionResult IzmeniPozajmicu([FromBody] PozajmicaDTO izmenjenaPozajmica)
        {
            DataProvider.IzmeniPozajmicu(izmenjenaPozajmica);
            return Ok("Podaci o pozajmici su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiPozajmicu/{id}")]
        public IActionResult ObrisiPozajmicu(int id)
        {
            DataProvider.ObrisiPozajmicu(id);
            return Ok("Pozajmica je uspešno obrisana.");
        }
    }
}