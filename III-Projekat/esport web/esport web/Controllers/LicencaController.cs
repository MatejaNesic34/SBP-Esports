using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LicencaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiLicence")]
        public IActionResult PreuzmiLicence()
        {
            List<LicencaDTO> lista = DataProvider.VratiSveLicence();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiLicencu/{id}")]
        public IActionResult PreuzmiLicencu(int id)
        {
            LicencaDTO licenca = DataProvider.VratiLicencu(id);
            if (licenca == null)
            {
                return NotFound("Licenca nije pronađena.");
            }
            return Ok(licenca);
        }

        [HttpPost]
        [Route("DodajLicencu")]
        public IActionResult DodajLicencu([FromBody] LicencaDTO novaLicenca)
        {
            DataProvider.DodajLicencu(novaLicenca);
            return Ok("Licenca je uspješno dodana.");
        }

        [HttpPut]
        [Route("IzmeniLicencu")]
        public IActionResult IzmeniLicencu([FromBody] LicencaDTO izmenjenaLicenca)
        {
            DataProvider.IzmeniLicencu(izmenjenaLicenca);
            return Ok("Podaci o licenci su uspješno izmjenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiLicencu/{id}")]
        public IActionResult ObrisiLicencu(int id)
        {
            DataProvider.ObrisiLicencu(id);
            return Ok("Licenca je uspješno obrisana.");
        }
    }
}