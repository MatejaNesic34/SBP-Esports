using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UgovorIgracaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiUgovoreIgraca")]
        public IActionResult PreuzmiUgovoreIgraca()
        {
            List<UgovorIgracaDTO> lista = DataProvider.VratiSveUgovoreIgraca();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiUgovorIgraca/{id}")]
        public IActionResult PreuzmiUgovorIgraca(int id)
        {
            UgovorIgracaDTO ugovor = DataProvider.VratiUgovorIgraca(id);
            if (ugovor == null)
            {
                return NotFound("Ugovor igrača nije pronađen.");
            }
            return Ok(ugovor);
        }

        [HttpPost]
        [Route("DodajUgovorIgraca")]
        public IActionResult DodajUgovorIgraca([FromBody] UgovorIgracaDTO noviUgovor)
        {
            DataProvider.DodajUgovorIgraca(noviUgovor);
            return Ok("Ugovor igrača je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniUgovorIgraca")]
        public IActionResult IzmeniUgovorIgraca([FromBody] UgovorIgracaDTO izmenjeniUgovor)
        {
            DataProvider.IzmeniUgovorIgraca(izmenjeniUgovor);
            return Ok("Podaci o ugovoru igrača su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiUgovorIgraca/{id}")]
        public IActionResult ObrisiUgovorIgraca(int id)
        {
            DataProvider.ObrisiUgovorIgraca(id);
            return Ok("Ugovor igrača je uspešno obrisan.");
        }
    }
}