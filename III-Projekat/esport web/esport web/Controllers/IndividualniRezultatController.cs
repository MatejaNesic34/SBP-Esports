using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndividualniRezultatController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiIndividualneRezultate")]
        public IActionResult PreuzmiIndividualneRezultate()
        {
            List<IndividualniRezultatDTO> lista = DataProvider.VratiSveIndividualneRezultate();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiIndividualniRezultat/{id}")]
        public IActionResult PreuzmiIndividualniRezultat(int id)
        {
            IndividualniRezultatDTO rezultat = DataProvider.VratiIndividualniRezultat(id);
            if (rezultat == null)
            {
                return NotFound("Individualni rezultat nije pronađen.");
            }
            return Ok(rezultat);
        }

        [HttpPost]
        [Route("DodajIndividualniRezultat")]
        public IActionResult DodajIndividualniRezultat([FromBody] IndividualniRezultatDTO noviRezultat)
        {
            DataProvider.DodajIndividualniRezultat(noviRezultat);
            return Ok("Individualni rezultat je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniIndividualniRezultat")]
        public IActionResult IzmeniIndividualniRezultat([FromBody] IndividualniRezultatDTO izmenjeniRezultat)
        {
            DataProvider.IzmeniIndividualniRezultat(izmenjeniRezultat);
            return Ok("Podaci o individualnom rezultatu su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiIndividualniRezultat/{id}")]
        public IActionResult ObrisiIndividualniRezultat(int id)
        {
            DataProvider.ObrisiIndividualniRezultat(id);
            return Ok("Individualni rezultat je uspešno obrisan.");
        }
    }
}