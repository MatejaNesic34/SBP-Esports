using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FizioterapeutController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiFizioterapeute")]
        public IActionResult PreuzmiFizioterapeute()
        {
            List<FizioterapeutDTO> lista = DataProvider.VratiSveFizioterapeute();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiFizioterapeuta/{id}")]
        public IActionResult PreuzmiFizioterapeuta(int id)
        {
            FizioterapeutDTO fizioterapeut = DataProvider.VratiFizioterapeuta(id);
            if (fizioterapeut == null)
            {
                return NotFound("Fizioterapeut nije pronađen.");
            }
            return Ok(fizioterapeut);
        }

        [HttpPost]
        [Route("DodajFizioterapeuta")]
        public IActionResult DodajFizioterapeuta([FromBody] FizioterapeutDTO noviFizioterapeut)
        {
            DataProvider.DodajFizioterapeuta(noviFizioterapeut);
            return Ok("Fizioterapeut je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniFizioterapeuta")]
        public IActionResult IzmeniFizioterapeuta([FromBody] FizioterapeutDTO izmenjeniFizioterapeut)
        {
            DataProvider.IzmeniFizioterapeuta(izmenjeniFizioterapeut);
            return Ok("Podaci o fizioterapeutu su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiFizioterapeuta/{id}")]
        public IActionResult ObrisiFizioterapeuta(int id)
        {
            DataProvider.ObrisiFizioterapeuta(id);
            return Ok("Fizioterapeut je uspešno obrisan.");
        }
    }
}