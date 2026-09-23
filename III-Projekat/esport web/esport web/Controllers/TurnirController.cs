using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurnirController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTurnire")]
        public IActionResult PreuzmiTurnire()
        {
            List<TurnirDTO> lista = DataProvider.VratiSveTurnire();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiTurnir/{id}")]
        public IActionResult PreuzmiTurnir(int id)
        {
            TurnirDTO turnir = DataProvider.VratiTurnir(id);
            if (turnir == null)
            {
                return NotFound("Turnir nije pronađen.");
            }
            return Ok(turnir);
        }

        [HttpPost]
        [Route("DodajTurnir")]
        public IActionResult DodajTurnir([FromBody] TurnirDTO noviTurnir)
        {
            DataProvider.DodajTurnir(noviTurnir);
            return Ok("Turnir je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniTurnir")]
        public IActionResult IzmeniTurnir([FromBody] TurnirDTO izmenjeniTurnir)
        {
            DataProvider.IzmeniTurnir(izmenjeniTurnir);
            return Ok("Podaci o turniru su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiTurnir/{id}")]
        public IActionResult ObrisiTurnir(int id)
        {
            DataProvider.ObrisiTurnir(id);
            return Ok("Turnir je uspešno obrisan.");
        }
    }
}