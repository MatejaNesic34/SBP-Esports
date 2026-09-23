using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UgovorSubjekatController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiUgovoreSubjekte")]
        public IActionResult PreuzmiUgovoreSubjekte()
        {
            List<UgovorSubjekatDTO> lista = DataProvider.VratiSveUgovoreSubjekte();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiUgovorSubjekat/{id}")]
        public IActionResult PreuzmiUgovorSubjekat(int id)
        {
            UgovorSubjekatDTO subjekat = DataProvider.VratiUgovorSubjekat(id);
            if (subjekat == null)
            {
                return NotFound("Subjekat ugovora nije pronađen.");
            }
            return Ok(subjekat);
        }

        [HttpPost]
        [Route("DodajUgovorSubjekat")]
        public IActionResult DodajUgovorSubjekat([FromBody] UgovorSubjekatDTO noviSubjekat)
        {
            DataProvider.DodajUgovorSubjekat(noviSubjekat);
            return Ok("Subjekat ugovora je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniUgovorSubjekat")]
        public IActionResult IzmeniUgovorSubjekat([FromBody] UgovorSubjekatDTO izmenjeniSubjekat)
        {
            DataProvider.IzmeniUgovorSubjekat(izmenjeniSubjekat);
            return Ok("Podaci o subjektu ugovora su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiUgovorSubjekat/{id}")]
        public IActionResult ObrisiUgovorSubjekat(int id)
        {
            DataProvider.ObrisiUgovorSubjekat(id);
            return Ok("Subjekat ugovora je uspešno obrisan.");
        }
    }
}