using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UcesceTimaUFaziController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiUcescaTimovaUFazi")]
        public IActionResult PreuzmiUcescaTimovaUFazi()
        {
            List<UcesceTimaUFaziDTO> lista = DataProvider.VratiSvaUcescaTimovaUFazi();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiUcesceTimaUFazi/{fazaId}/{timId}")]
        public IActionResult PreuzmiUcesceTimaUFazi(int fazaId, int timId)
        {
            UcesceTimaUFaziDTO ucesce = DataProvider.VratiUcesceTimaUFazi(fazaId, timId);
            if (ucesce == null)
            {
                return NotFound("Učešće tima u fazi nije pronađeno.");
            }
            return Ok(ucesce);
        }

        [HttpPost]
        [Route("DodajUcesceTimaUFazi")]
        public IActionResult DodajUcesceTimaUFazi([FromBody] UcesceTimaUFaziDTO novoUcesce)
        {
            DataProvider.DodajUcesceTimaUFazi(novoUcesce);
            return Ok("Učešće tima u fazi je uspešno dodato.");
        }

        [HttpPut]
        [Route("IzmeniUcesceTimaUFazi")]
        public IActionResult IzmeniUcesceTimaUFazi([FromBody] UcesceTimaUFaziDTO izmenjenoUcesce)
        {
            DataProvider.IzmeniUcesceTimaUFazi(izmenjenoUcesce);
            return Ok("Podaci o učešću tima u fazi su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiUcesceTimaUFazi/{fazaId}/{timId}")]
        public IActionResult ObrisiUcesceTimaUFazi(int fazaId, int timId)
        {
            DataProvider.ObrisiUcesceTimaUFazi(fazaId, timId);
            return Ok("Učešće tima u fazi je uspešno obrisano.");
        }
    }
}