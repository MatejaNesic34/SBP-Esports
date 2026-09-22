using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenadzerController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiMenadzere")]
        public IActionResult PreuzmiMenadzere()
        {
            List<MenadzerDTO> lista = DataProvider.VratiSveMenadzere();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiMenadzera/{id}")]
        public IActionResult PreuzmiMenadzera(int id)
        {
            MenadzerDTO menadzer = DataProvider.VratiMenadzera(id);
            if (menadzer == null)
            {
                return NotFound("Menadžer nije pronađen.");
            }
            return Ok(menadzer);
        }

        [HttpPost]
        [Route("DodajMenadzera")]
        public IActionResult DodajMenadzera([FromBody] MenadzerDTO noviMenadzer)
        {
            DataProvider.DodajMenadzera(noviMenadzer);
            return Ok("Menadžer je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniMenadzera")]
        public IActionResult IzmeniMenadzera([FromBody] MenadzerDTO izmenjeniMenadzer)
        {
            DataProvider.IzmeniMenadzera(izmenjeniMenadzer);
            return Ok("Podaci o menadžeru su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiMenadzera/{id}")]
        public IActionResult ObrisiMenadzera(int id)
        {
            DataProvider.ObrisiMenadzera(id);
            return Ok("Menadžer je uspešno obrisan.");
        }
    }
}