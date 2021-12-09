using System.Threading.Tasks;
using Alcohol.Domain;
using Alcohol.Infraestructure;
using Microsoft.AspNetCore.Mvc;
using Alcohol.Application;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Alcoholcontroller : ControllerBase
    {
        [HttpGet]
        [Route("{calcular}")]
        public IActionResult GetAlcohol([FromBody] Alcoholemia alcoholemia)
        {
            var alcohol = new AlcoholService();
            var result = alcohol.AlcoholD(alcoholemia);

            return Ok(result);

        }

    }
}

//https://localhost:5001/api/alcohol/calcular
/*{
    
"nombebida":"cerveza", 
"numbebida":"3",
"cantidadml":"330", 
"edad":"34", 
"peso":"80"
    
}*/
