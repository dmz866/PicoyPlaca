using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PicoPlaca.DataModel;
using Microsoft.AspNetCore.Authorization;
using PicoPlaca.DataModel.CheckPicoPlaca;

namespace PicoPlaca.Controllers
{
    [AllowAnonymous]
    [Route("/api/[controller]")]
    public class PicoPlacaController : Controller
    {
        [HttpGet]
        public ActionResult checkPicoPlaca([FromBody] PicoPlacaModel picoPlaca)
        {
            try
            {
                int ultimoNum = Convert.ToInt32(picoPlaca.Placa.Substring(picoPlaca.Placa.Length - 1));
                int fechaNum = Convert.ToInt32(picoPlaca.Fecha.Day);
                string result = string.Empty;

                CheckPicoPlaca pp = new CheckPicoPlaca();
                PicoPlacaReglasModel ppModel = new PicoPlacaReglasModel((DayOfWeek) fechaNum, ultimoNum);
                result = pp.checkPlaca(ppModel);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}