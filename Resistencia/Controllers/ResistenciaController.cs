using Microsoft.AspNetCore.Mvc;
using ResistorApp.Application.Services;
using ResistorApp.Domain.Dtos;
using ResistorApp.Domain.Entities;

namespace ResistorApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResistenciaController : ControllerBase
    {
        [HttpPost]
        [Route("Calcular")]
        public IActionResult GetValue([FromBody]ResistenciaRequest resistenciaRequest)
        {
            var resistencia = CreateObjectFromDto(resistenciaRequest);
            var servicio = new ResistenciaServices(resistencia);
            var esCorrecto = servicio.Validar();

            if(!esCorrecto)
                return BadRequest("Alguno de los colores en las bandas es incorrecto...");

            var valorResistencia = servicio.Calcular();

            return Ok($"Los valores ingresados son {resistencia.Banda1}, {resistencia.Banda2}, {resistencia.Banda3}, {resistencia.Banda4} y equivale a: {valorResistencia.Value} {valorResistencia.Unit} {valorResistencia.Tolerance}%");
        }

        public Resistencia CreateObjectFromDto(ResistenciaRequest dto)
        {
            var resistencia = new Resistencia{
                Banda1 = dto.Banda1.ToLower(),
                Banda2 = dto.Banda2.ToLower(),
                Banda3 = dto.Banda3.ToLower(),
                Banda4 = dto.Banda4.ToLower()
            };

            return resistencia;
        }
    }
}