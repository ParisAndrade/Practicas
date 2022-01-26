using ApiPeliculas.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiPeliculas.Data
{
    public class DataContext: DbContext
    {
        
        public DataContext (DbContextOptions<DataContext> options): base(options)
        {

        }
        
        public DbSet <Pelicula> Peliculas { get; set; }

    }
}