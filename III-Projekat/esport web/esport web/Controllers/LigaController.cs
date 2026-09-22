using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LigaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiLige")]
        public IActionResult PreuzmiLige()
        {
            List<LigaDTO> lista = DataProvider.VratiSveLige();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiLigu/{id}")]
        public IActionResult PreuzmiLigu(int id)
        {
            LigaDTO liga = DataProvider.VratiLigu(id);
            if (liga == null)
            {
                return NotFound("Liga nije pronađena.");
            }
            return Ok(liga);
        }

        [HttpPost]
        [Route("DodajLigu")]
        public IActionResult DodajLigu([FromBody] LigaDTO novaLiga)
        {
            DataProvider.DodajLigu(novaLiga);
            return Ok("Liga je uspešno dodata.");
        }

        [HttpPut]
        [Route("IzmeniLigu")]
        public IActionResult IzmeniLigu([FromBody] LigaDTO izmenjenaLiga)
        {
            DataProvider.IzmeniLigu(izmenjenaLiga);
            return Ok("Podaci o ligi su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiLigu/{id}")]
        public IActionResult ObrisiLigu(int id)
        {
            DataProvider.ObrisiLigu(id);
            return Ok("Liga je uspešno obrisana.");
        }
    }
}