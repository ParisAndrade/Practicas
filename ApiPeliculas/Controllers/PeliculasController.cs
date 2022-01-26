using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ApiPeliculas.Data.Interfaces;
using ApiPeliculas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiPeliculas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculasController : ControllerBase
    {
        private readonly IApiRepository _repo;

        public PeliculasController(IApiRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var peliculas = await _repo.GetPeliculaAsync();
            return Ok(peliculas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pelicula = await _repo.GetPeliculaByIdAsync(id);
            if(pelicula == null  )
                return NotFound("Pelicula no encontrada");

            return Ok(pelicula);
        }

        [HttpGet("nombre/{nombre}")]
        public async Task<IActionResult> Get(string nombre)
        {
            var pelicula = await _repo.GetPeliculaByNombreAsync(nombre);
            if(pelicula == null  )
                return NotFound("Pelicula no encontrada");

            return Ok(pelicula);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Pelicula pelicula)
        {
    
            _repo.Add(pelicula);
            if(await _repo.SaveAll())
                return Ok(pelicula);

            return BadRequest();
        }

        /*
        {
        "Titulo":"Spider-Man: No Way Home",
        "Director":"Jon Watts",
        "Genero":"Accion/Aventura",
        "Puntuacion": 4,
        "Rating":"Top 1",
        "AñoPublicacion":"2021-12-15"
        }

        */



        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,Pelicula pelicula)
        {
            if (id != pelicula.Id)
                return BadRequest("Los Ids no coinciden");

        
            var peliculaUpdate = await _repo.GetPeliculaByIdAsync(pelicula.Id);

            if(peliculaUpdate == null)  
                return BadRequest();

                peliculaUpdate.Titulo = pelicula.Titulo;
                peliculaUpdate.Director = pelicula.Director;
                peliculaUpdate.Genero = pelicula.Genero;
                peliculaUpdate.Puntuacion = pelicula.Puntuacion;
                peliculaUpdate.Rating = pelicula.Rating;
                peliculaUpdate.AñoPublicacion = pelicula.AñoPublicacion;

                if(!await _repo.SaveAll())
                    return NoContent();

                return Ok(peliculaUpdate);

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
    
            var pelicula = await _repo.GetPeliculaByIdAsync(id);

            if(pelicula == null)  
                return NotFound("Pelicula no encontrado");


                _repo.Delete(pelicula);
                if(!await _repo.SaveAll())
                    return BadRequest("No se pudo eliminar la pelicula");

                return Ok("Producto eliminado");

        }
    }
}