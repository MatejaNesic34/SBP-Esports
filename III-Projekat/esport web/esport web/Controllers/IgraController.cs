using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IgraController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiIgre")]
        public IActionResult PreuzmiIgre()
        {
            List<IgraDTO> lista = DataProvider.VratiSveIgre();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiIgru/{id}")]
        public IActionResult PreuzmiIgru(int id)
        {
            IgraDTO igra = DataProvider.VratiIgru(id);
            if (igra == null)
            {
                return NotFound("Igra nije pronađena.");
            }
            return Ok(igra);
        }

        [HttpPost]
        [Route("DodajIgru")]
        public IActionResult DodajIgru([FromBody] IgraDTO novaIgra)
        {
            DataProvider.DodajIgru(novaIgra);
            return Ok("Igra je uspešno dodata.");
        }

        [HttpPut]
        [Route("IzmeniIgru")]
        public IActionResult IzmeniIgru([FromBody] IgraDTO izmenjenaIgra)
        {
            DataProvider.IzmeniIgru(izmenjenaIgra);
            return Ok("Podaci o igri su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiIgru/{id}")]
        public IActionResult ObrisiIgru(int id)
        {
            DataProvider.ObrisiIgru(id);
            return Ok("Igra je uspešno obrisana.");
        }
    }
}