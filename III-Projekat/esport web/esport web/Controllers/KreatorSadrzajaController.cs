using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KreatorSadrzajaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiKreatoreSadrzaja")]
        public IActionResult PreuzmiKreatoreSadrzaja()
        {
            List<OsobaDTO> lista = DataProvider.VratiSveKreatoreSadrzaja();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiKreatoraSadrzaja/{id}")]
        public IActionResult PreuzmiKreatoraSadrzaja(int id)
        {
            OsobaDTO kreator = DataProvider.VratiKreatoraSadrzaja(id);
            if (kreator == null)
            {
                return NotFound("Kreator sadržaja nije pronađen.");
            }
            return Ok(kreator);
        }

        [HttpPost]
        [Route("DodajKreatoraSadrzaja")]
        public IActionResult DodajKreatoraSadrzaja([FromBody] OsobaDTO noviKreator)
        {
            DataProvider.DodajKreatoraSadrzaja(noviKreator);
            return Ok("Kreator sadržaja je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniKreatoraSadrzaja")]
        public IActionResult IzmeniKreatoraSadrzaja([FromBody] OsobaDTO izmenjeniKreator)
        {
            DataProvider.IzmeniKreatoraSadrzaja(izmenjeniKreator);
            return Ok("Podaci o kreatoru sadržaja su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiKreatoraSadrzaja/{id}")]
        public IActionResult ObrisiKreatoraSadrzaja(int id)
        {
            DataProvider.ObrisiKreatoraSadrzaja(id);
            return Ok("Kreator sadržaja je uspešno obrisan.");
        }
    }
}