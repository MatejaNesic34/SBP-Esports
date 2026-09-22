using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TakmicenjeController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTakmicenja")]
        public IActionResult PreuzmiTakmicenja()
        {
            List<TakmicenjeDTO> lista = DataProvider.VratiSvaTakmicenja();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiTakmicenje/{id}")]
        public IActionResult PreuzmiTakmicenje(int id)
        {
            TakmicenjeDTO takmicenje = DataProvider.VratiTakmicenje(id);
            if (takmicenje == null)
            {
                return NotFound("Takmičenje nije pronađeno.");
            }
            return Ok(takmicenje);
        }

        [HttpPost]
        [Route("DodajTakmicenje")]
        public IActionResult DodajTakmicenje([FromBody] TakmicenjeDTO novoTakmicenje)
        {
            DataProvider.DodajTakmicenje(novoTakmicenje);
            return Ok("Takmičenje je uspešno dodato.");
        }

        [HttpPut]
        [Route("IzmeniTakmicenje")]
        public IActionResult IzmeniTakmicenje([FromBody] TakmicenjeDTO izmenjenoTakmicenje)
        {
            DataProvider.IzmeniTakmicenje(izmenjenoTakmicenje);
            return Ok("Podaci o takmičenju su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiTakmicenje/{id}")]
        public IActionResult ObrisiTakmicenje(int id)
        {
            DataProvider.ObrisiTakmicenje(id);
            return Ok("Takmičenje je uspešno obrisano.");
        }
    }
}