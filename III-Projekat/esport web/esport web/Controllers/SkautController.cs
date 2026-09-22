using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkautController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSkaute")]
        public IActionResult PreuzmiSkaute()
        {
            List<SkautDTO> lista = DataProvider.VratiSveSkaute();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiSkauta/{id}")]
        public IActionResult PreuzmiSkauta(int id)
        {
            SkautDTO skaut = DataProvider.VratiSkauta(id);
            if (skaut == null)
            {
                return NotFound("Skaut nije pronađen.");
            }
            return Ok(skaut);
        }

        [HttpPost]
        [Route("DodajSkauta")]
        public IActionResult DodajSkauta([FromBody] SkautDTO noviSkaut)
        {
            DataProvider.DodajSkauta(noviSkaut);
            return Ok("Skaut je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniSkauta")]
        public IActionResult IzmeniSkauta([FromBody] SkautDTO izmenjeniSkaut)
        {
            DataProvider.IzmeniSkauta(izmenjeniSkaut);
            return Ok("Podaci o skautu su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiSkauta/{id}")]
        public IActionResult ObrisiSkauta(int id)
        {
            DataProvider.ObrisiSkauta(id);
            return Ok("Skaut je uspešno obrisan.");
        }
    }
}