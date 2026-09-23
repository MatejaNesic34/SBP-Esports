using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransferController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTransfere")]
        public IActionResult PreuzmiTransfere()
        {
            List<TransferDTO> lista = DataProvider.VratiSveTransfere();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiTransfer/{id}")]
        public IActionResult PreuzmiTransfer(int id)
        {
            TransferDTO transfer = DataProvider.VratiTransfer(id);
            if (transfer == null)
            {
                return NotFound("Transfer nije pronađen.");
            }
            return Ok(transfer);
        }

        [HttpPost]
        [Route("DodajTransfer")]
        public IActionResult DodajTransfer([FromBody] TransferDTO noviTransfer)
        {
            DataProvider.DodajTransfer(noviTransfer);
            return Ok("Transfer je uspešno dodat.");
        }

        [HttpPut]
        [Route("IzmeniTransfer")]
        public IActionResult IzmeniTransfer([FromBody] TransferDTO izmenjeniTransfer)
        {
            DataProvider.IzmeniTransfer(izmenjeniTransfer);
            return Ok("Podaci o transferu su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiTransfer/{id}")]
        public IActionResult ObrisiTransfer(int id)
        {
            DataProvider.ObrisiTransfer(id);
            return Ok("Transfer je uspešno obrisan.");
        }
    }
}