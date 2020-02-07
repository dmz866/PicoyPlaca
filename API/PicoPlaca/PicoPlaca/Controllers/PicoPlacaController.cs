using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PicoPlaca.DataModel;
using Microsoft.AspNetCore.Authorization;
 
namespace PicoPlaca.Controllers
{
    [AllowAnonymous]
    [Route("/api/[controller]")]
    public class PicoPlacaController : Controller
    {

        //[HttpGet("{city}/{country}")]
        [HttpGet]
        public ActionResult checkPicoPlaca()
        {
            try
            {
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}