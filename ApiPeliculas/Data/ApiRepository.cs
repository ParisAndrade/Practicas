using System.Collections.Generic;
using System.Threading.Tasks;
using ApiPeliculas.Data.Interfaces;
using ApiPeliculas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPeliculas.Data
{
    public class ApiRepository : IApiRepository
    {
        private readonly DataContext _context;
        public ApiRepository (DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<IEnumerable<Pelicula>> GetPeliculaAsync()
        {
            var peliculas = await _context.Peliculas.ToListAsync();
            return peliculas;
        }

        public async Task<Pelicula> GetPeliculaByIdAsync(int Id)
        {
            var pelicula = await _context.Peliculas.FirstOrDefaultAsync(u => u.Id == Id);
            return pelicula;
        }

        public async Task<Pelicula> GetPeliculaByNombreAsync(string Titulo)
        {
            var peliculas = await _context.Peliculas.FirstOrDefaultAsync(u => u.Titulo == Titulo);
            return peliculas;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0 ;
        }
    }
}