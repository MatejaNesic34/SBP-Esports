using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PsihologController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPsihologe")]
        public IActionResult PreuzmiPsihologe()
        {
            List<PsihologDTO> lista = DataProvider.VratiSvePsihologe();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiPsihologa/{id}")]
        public IActionResult PreuzmiPsihologa(int id)
        {
            PsihologDTO psiholog = DataProvider.VratiPsihologa(id);
            if (psiholog == null)
            {
                return NotFound("Psiholog nije pronađen.");
            }
            return Ok(psiholog);
        }

        [HttpPost]
        [Route("DodajPsihologa")]
        public IActionResult DodajPsihologa([FromBody] PsihologDTO noviPsiholog)
        {
            DataProvider.DodajPsihologa(noviPsiholog);
            return Ok("Psiholog je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniPsihologa")]
        public IActionResult IzmeniPsihologa([FromBody] PsihologDTO izmenjeniPsiholog)
        {
            DataProvider.IzmeniPsihologa(izmenjeniPsiholog);
            return Ok("Podaci o psihologu su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiPsihologa/{id}")]
        public IActionResult ObrisiPsihologa(int id)
        {
            DataProvider.ObrisiPsihologa(id);
            return Ok("Psiholog je uspešno obrisan.");
        }
    }
}