using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FazaTakmicenjaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiFazeTakmicenja")]
        public IActionResult PreuzmiFazeTakmicenja()
        {
            List<FazaTakmicenjaDTO> lista = DataProvider.VratiSveFazeTakmicenja();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiFazuTakmicenja/{id}")]
        public IActionResult PreuzmiFazuTakmicenja(int id)
        {
            FazaTakmicenjaDTO faza = DataProvider.VratiFazuTakmicenja(id);
            if (faza == null)
            {
                return NotFound("Faza takmičenja nije pronađena.");
            }
            return Ok(faza);
        }

        [HttpPost]
        [Route("DodajFazuTakmicenja")]
        public IActionResult DodajFazuTakmicenja([FromBody] FazaTakmicenjaDTO novaFaza)
        {
            DataProvider.DodajFazuTakmicenja(novaFaza);
            return Ok("Faza takmičenja je uspešno dodata.");
        }

        [HttpPut]
        [Route("IzmeniFazuTakmicenja")]
        public IActionResult IzmeniFazuTakmicenja([FromBody] FazaTakmicenjaDTO izmenjenaFaza)
        {
            DataProvider.IzmeniFazuTakmicenja(izmenjenaFaza);
            return Ok("Podaci o fazi takmičenja su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiFazuTakmicenja/{id}")]
        public IActionResult ObrisiFazuTakmicenja(int id)
        {
            DataProvider.ObrisiFazuTakmicenja(id);
            return Ok("Faza takmičenja je uspešno obrisana.");
        }
    }
}