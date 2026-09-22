using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelefonController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTelefone")]
        public IActionResult PreuzmiTelefone()
        {
            List<OsobaDTO> lista = DataProvider.VratiSveTelefoneOsoba();
            return Ok(lista);
        }

        [HttpPost]
        [Route("DodajTelefon/{osobaId}/{brojTelefona}")]
        public IActionResult DodajTelefon(int osobaId, string brojTelefona)
        {
            DataProvider.DodajTelefonZaOsobu(osobaId, brojTelefona);
            return Ok("Telefon je uspešno dodat osobi.");
        }

        [HttpDelete]
        [Route("ObrisiTelefon/{osobaId}/{brojTelefona}")]
        public IActionResult ObrisiTelefon(int osobaId, string brojTelefona)
        {
            DataProvider.ObrisiTelefonZaOsobu(osobaId, brojTelefona);
            return Ok("Telefon je uspešno obrisan.");
        }
    }
}