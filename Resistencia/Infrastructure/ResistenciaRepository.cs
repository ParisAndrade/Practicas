using System;
using System.Collections.Generic;
using System.Linq;
using ResistorApp.Domain.Entities;

namespace ResistorApp.Infrastructure.Repositories
{
    public class ResistenciaRepository
    {
        public IEnumerable<ColorBanda> GetColorFirstBand()
        {        
            var colores = new List<ColorBanda>{
                new ColorBanda(Color:"negro", Value:0),
                new ColorBanda(Color:"cafe", Value:10),
                new ColorBanda(Color:"rojo", Value:20),
                new ColorBanda(Color:"naranja", Value:30),
                new ColorBanda(Color:"amarillo", Value:40),
                new ColorBanda(Color:"verde", Value:50),
                new ColorBanda(Color:"azul", Value:60),
                new ColorBanda(Color:"violeta", Value:70),
                new ColorBanda(Color:"gris", Value:80),
                new ColorBanda(Color:"blanco", Value:90)
            };

            return colores;
        }
        public IEnumerable<ColorBanda> GetColorSecodBand()
        {
            var colores = new List<ColorBanda>{
                new ColorBanda(Color:"negro", Value:0),
                new ColorBanda(Color:"cafe", Value:1),
                new ColorBanda(Color:"rojo", Value:2),
                new ColorBanda(Color:"naranja", Value:3),
                new ColorBanda(Color:"amarillo", Value:4),
                new ColorBanda(Color:"verde", Value:5),
                new ColorBanda(Color:"azul", Value:6),
                new ColorBanda(Color:"violeta", Value:7),
                new ColorBanda(Color:"gris", Value:8),
                new ColorBanda(Color:"blanco", Value:9)
            };

            return colores;
        }
        public IEnumerable<ColorBanda> GetColorThirdBand()
        {
            var colores = new List<ColorBanda>{
                new ColorBanda(Color:"negro", Value:1),
                new ColorBanda(Color:"cafe", Value:10),
                new ColorBanda(Color:"rojo", Value:100),
                new ColorBanda(Color:"naranja", Value:1000),
                new ColorBanda(Color:"amarillo", Value:10000),
                new ColorBanda(Color:"verde", Value:100000),
                new ColorBanda(Color:"azul", Value:1000000),
                //new ColorBanda(Color:"violeta", Value:10000000),
                //new ColorBanda(Color:"gris", Value:100000000),
                //new ColorBanda(Color:"blanco", Value:1000000000)
                new ColorBanda(Color:"dorado", Value:10),
                new ColorBanda(Color:"plata", Value:100)
            };

            return colores;
        }
        public IEnumerable<ColorBanda> GetColorFourthBand()
        {
            var colores = new List<ColorBanda>{                
                new ColorBanda(Color:"dorado", Value:5),
                new ColorBanda(Color:"plata", Value:10)
            };
            return colores;
        }
    }
}