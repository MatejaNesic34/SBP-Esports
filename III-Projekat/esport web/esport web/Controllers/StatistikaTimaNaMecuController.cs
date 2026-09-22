using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ESPORT;
using Esport_library;

namespace esport_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatistikaTimaNaMecuController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiStatistikeTimovaNaMecu")]
        public IActionResult PreuzmiStatistikeTimovaNaMecu()
        {
            List<StatistikaTimaNaMecuDTO> lista = DataProvider.VratiSveStatistikeTimovaNaMecu();
            return Ok(lista);
        }

        [HttpGet]
        [Route("PreuzmiStatistikuTimaNaMecu/{mecId}/{timId}")]
        public IActionResult PreuzmiStatistikuTimaNaMecu(int mecId, int timId)
        {
            StatistikaTimaNaMecuDTO statistika = DataProvider.VratiStatistikuTimaNaMecu(mecId, timId);
            if (statistika == null)
            {
                return NotFound("Statistika tima na meču nije pronađena.");
            }
            return Ok(statistika);
        }

        [HttpPost]
        [Route("DodajStatistikuTimaNaMecu")]
        public IActionResult DodajStatistikuTimaNaMecu([FromBody] StatistikaTimaNaMecuDTO novaStatistika)
        {
            DataProvider.DodajStatistikuTimaNaMecu(novaStatistika);
            return Ok("Statistika tima na meču je uspešno dodata.");
        }

        [HttpPut]
        [Route("IzmeniStatistikuTimaNaMecu")]
        public IActionResult IzmeniStatistikuTimaNaMecu([FromBody] StatistikaTimaNaMecuDTO izmenjenaStatistika)
        {
            DataProvider.IzmeniStatistikuTimaNaMecu(izmenjenaStatistika);
            return Ok("Podaci o statistici tima na meču su uspešno izmenjeni.");
        }

        [HttpDelete]
        [Route("ObrisiStatistikuTimaNaMecu/{mecId}/{timId}")]
        public IActionResult ObrisiStatistikuTimaNaMecu(int mecId, int timId)
        {
            DataProvider.ObrisiStatistikuTimaNaMecu(mecId, timId);
            return Ok("Statistika tima na meču je uspešno obrisana.");
        }
    }
}