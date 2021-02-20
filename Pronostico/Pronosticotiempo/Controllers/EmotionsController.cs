using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pronosticotiempo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmotionsController : ControllerBase
    {
       [HttpGet]
       [Route("ConNumero")]
       public string Emocion(int suerte)
        {
            if (suerte == 0)
                return "Sos una persona indiferente";
            if (suerte == 1)
                return "Sos una persona feliz";
            if (suerte == 3)
                return "Sos una persona aburrida";
            return "Estoy muy ocupado, no te puedo atender en este momento";
        }
        [HttpPost]
        [Route("ConNumero")]
        public string Emocion2([FromHeader]int suerte)
        {
            if (suerte == 0)
                return "Sos una persona indiferente";
            if (suerte == 1)
                return "Sos una persona feliz";
            if (suerte == 3)
                return "Sos una persona aburrida";
            return "Estoy muy ocupado, no te puedo atender en este momento";
        }
    }
}
