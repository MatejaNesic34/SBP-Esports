using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTimove")]
        public IActionResult PreuzmiTimove()
        {
            List<TimDTO> lista = DataProvider.VratiSveTimove();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiTim/{id}")]
        public IActionResult PreuzmiTim(int id)
        {
            TimDTO tim = DataProvider.VratiTim(id);
            if (tim == null)
            {
                return NotFound("Tim nije pronađen.");
            }
            return Ok(tim);
        }

        [HttpPost]
        [Route("DodajTim")]
        public IActionResult DodajTim([FromBody] TimDTO noviTim)
        {
            DataProvider.DodajTim(noviTim);
            return Ok("Tim je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniTim")]
        public IActionResult IzmeniTim([FromBody] TimDTO izmenjeniTim)
        {
            DataProvider.IzmeniTim(izmenjeniTim);
            return Ok("Podaci o timu su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiTim/{id}")]
        public IActionResult ObrisiTim(int id)
        {
            DataProvider.ObrisiTim(id);
            return Ok("Tim je uspešno obrisan.");
        }
    }
}