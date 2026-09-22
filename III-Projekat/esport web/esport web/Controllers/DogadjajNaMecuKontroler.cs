using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogadjajNaMecuController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiDogadjajeNaMecu")]
        public IActionResult PreuzmiDogadjajeNaMecu()
        {
            List<DogadjajNaMecuDTO> lista = DataProvider.VratiSveDogadjajeNaMecu();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiDogadjajNaMecu/{id}")]
        public IActionResult PreuzmiDogadjajNaMecu(int id)
        {
            DogadjajNaMecuDTO dogadjaj = DataProvider.VratiDogadjajNaMecu(id);
            if (dogadjaj == null)
            {
                return NotFound("Događaj na meču nije pronađen.");
            }
            return Ok(dogadjaj);
        }

        [HttpPost]
        [Route("DodajDogadjajNaMecu")]
        public IActionResult DodajDogadjajNaMecu([FromBody] DogadjajNaMecuDTO noviDogadjaj)
        {
            DataProvider.DodajDogadjajNaMecu(noviDogadjaj);
            return Ok("Događaj na meču je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniDogadjajNaMecu")]
        public IActionResult IzmeniDogadjajNaMecu([FromBody] DogadjajNaMecuDTO izmenjeniDogadjaj)
        {
            DataProvider.IzmeniDogadjajNaMecu(izmenjeniDogadjaj);
            return Ok("Podaci o događaju na meču su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiDogadjajNaMecu/{id}")]
        public IActionResult ObrisiDogadjajNaMecu(int id)
        {
            DataProvider.ObrisiDogadjajNaMecu(id);
            return Ok("Događaj na meču je uspešno obrisan.");
        }
    }
}