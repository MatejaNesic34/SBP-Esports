using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MecController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiMeceve")]
        public IActionResult PreuzmiMeceve()
        {
            List<MecDTO> lista = DataProvider.VratiSveMeceve();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiMec/{id}")]
        public IActionResult PreuzmiMec(int id)
        {
            MecDTO mec = DataProvider.VratiMec(id);
            if (mec == null)
            {
                return NotFound("Meč nije pronađen.");
            }
            return Ok(mec);
        }

        [HttpPost]
        [Route("DodajMec")]
        public IActionResult DodajMec([FromBody] MecDTO noviMec)
        {
            DataProvider.DodajMec(noviMec);
            return Ok("Meč je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniMec")]
        public IActionResult IzmeniMec([FromBody] MecDTO izmenjeniMec)
        {
            DataProvider.IzmeniMec(izmenjeniMec);
            return Ok("Podaci o meču su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiMec/{id}")]
        public IActionResult ObrisiMec(int id)
        {
            DataProvider.ObrisiMec(id);
            return Ok("Meč je uspešno obrisan.");
        }
    }
}