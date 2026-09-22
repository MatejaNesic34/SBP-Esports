using Microsoft.AspNetCore.Mvc;
using Esport_library;

namespace ESPORT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnaliticarController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiAnaliticare")]
        public IActionResult PreuzmiAnaliticare()
        {
            List<AnaliticarDTO> lista = DataProvider.VratiSveAnaliticare();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiAnaliticara/{id}")]
        public IActionResult PreuzmiAnaliticara(int id)
        {
            AnaliticarDTO analiticar = DataProvider.VratiAnaliticara(id);
            if (analiticar == null)
            {
                return NotFound("Analitičar nije pronađen.");
            }
            return Ok(analiticar);
        }

        [HttpPost]
        [Route("DodajAnaliticara")]
        public IActionResult DodajAnaliticara([FromBody] AnaliticarDTO noviAnaliticar)
        {
            DataProvider.DodajAnaliticara(noviAnaliticar);
            return Ok("Analitičar je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniAnaliticara")]
        public IActionResult IzmeniAnaliticara([FromBody] AnaliticarDTO izmenjeniAnaliticar)
        {
            DataProvider.IzmeniAnaliticara(izmenjeniAnaliticar);
            return Ok("Podaci o analitičaru su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiAnaliticara/{id}")]
        public IActionResult ObrisiAnaliticara(int id)
        {
            DataProvider.ObrisiAnaliticara(id);
            return Ok("Analitičar je uspešno obrisan.");
        }
    }
}