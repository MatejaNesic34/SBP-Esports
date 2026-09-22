using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OsobaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiOsobe")]
        public IActionResult PreuzmiOsobe()
        {
            List<OsobaDTO> lista = DataProvider.VratiSveOsobe();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiOsobu/{id}")]
        public IActionResult PreuzmiOsobu(int id)
        {
            OsobaDTO osoba = DataProvider.VratiOsobu(id);
            if (osoba == null)
            {
                return NotFound("Osoba nije pronađena.");
            }
            return Ok(osoba);
        }

        [HttpPost]
        [Route("DodajOsobu")]
        public IActionResult DodajOsobu([FromBody] OsobaDTO novaOsoba)
        {
            DataProvider.DodajOsobu(novaOsoba);
            return Ok("Osoba je uspešno dodata.");
        }

        [HttpPut]
        [Route("IzmeniOsobu")]
        public IActionResult IzmeniOsobu([FromBody] OsobaDTO izmenjenaOsoba)
        {
            DataProvider.IzmeniOsobu(izmenjenaOsoba);
            return Ok("Podaci o osobi su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiOsobu/{id}")]
        public IActionResult ObrisiOsobu(int id)
        {
            DataProvider.ObrisiOsobu(id);
            return Ok("Osoba je uspešno obrisana.");
        }
    }
}