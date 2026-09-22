using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IgracController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiIgrace")]
        public IActionResult PreuzmiIgrace()
        {
            List<IgracDTO> lista = DataProvider.VratiSveIgrace();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiIgraca/{id}")]
        public IActionResult PreuzmiIgraca(int id)
        {
            IgracDTO igrac = DataProvider.VratiIgraca(id);
            if (igrac == null)
            {
                return NotFound("Igrač nije pronađen.");
            }
            return Ok(igrac);
        }

        [HttpPost]
        [Route("DodajIgraca")]
        public IActionResult DodajIgraca([FromBody] IgracDTO noviIgrac)
        {
            DataProvider.DodajIgraca(noviIgrac);
            return Ok("Igrač je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniIgraca")]
        public IActionResult IzmeniIgraca([FromBody] IgracDTO izmenjeniIgrac)
        {
            DataProvider.IzmeniIgraca(izmenjeniIgrac);
            return Ok("Podaci o igraču su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiIgraca/{id}")]
        public IActionResult ObrisiIgraca(int id)
        {
            DataProvider.ObrisiIgraca(id);
            return Ok("Igrač je uspešno obrisan.");
        }
    }
}