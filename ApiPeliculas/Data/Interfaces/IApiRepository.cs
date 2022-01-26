using System.Collections.Generic;
using System.Threading.Tasks;
using ApiPeliculas.Models;

namespace ApiPeliculas.Data.Interfaces
{
    public interface IApiRepository
    {
        void Add<T>(T entity) where T: class; 
        void Delete<T>(T entity) where T: class; 
        Task <bool> SaveAll();
        Task <IEnumerable<Pelicula>> GetPeliculaAsync();
        Task <Pelicula> GetPeliculaByIdAsync(int Id);
        Task <Pelicula> GetPeliculaByNombreAsync(string Titulo);

    }
}