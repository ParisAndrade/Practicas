using System;
using System.Collections.Generic;
using System.Linq;
using ResistorApp.Domain.Dtos;
using ResistorApp.Domain.Entities;
using ResistorApp.Infrastructure.Repositories;

namespace ResistorApp.Application.Services
{
    public class ResistenciaServices
    {
        private IEnumerable<ColorBanda> _ColoresBanda1;
        private IEnumerable<ColorBanda> _ColoresBanda2;
        private IEnumerable<ColorBanda> _ColoresBanda3;
        private IEnumerable<ColorBanda> _ColoresBanda4;
        private string[] _banda3Divisor = {"dorado","plata"};
        private readonly Resistencia _resistencia;
        public ResistenciaServices(Resistencia resistencia)
        {
            var repository = new ResistenciaRepository();
            _ColoresBanda1 = repository.GetColorFirstBand();
            _ColoresBanda2 = repository.GetColorSecodBand();
            _ColoresBanda3 = repository.GetColorThirdBand();
            _ColoresBanda4 = repository.GetColorFourthBand();
            _resistencia = resistencia;
        }

        
        public bool Validar()
        {
            // validar reglas banda 1
            if(!ValidarBanda1(_resistencia.Banda1))
                return false;
            
            if(!ValidarBanda2(_resistencia.Banda2))
                return false;

            if(!ValidarBanda3(_resistencia.Banda3))
                return false;

            if(!ValidarBanda4(_resistencia.Banda4))
                return false;

            return true;
        }

        private bool ValidarBanda1(string color)
        {
            return _ColoresBanda1.Any(x => x.Color == color);
        }
        private bool ValidarBanda2(string color)
        {
            return _ColoresBanda2.Any(x => x.Color == color);
        }
        private bool ValidarBanda3(string color)
        {
            return _ColoresBanda3.Any(x => x.Color == color);
        }
        private bool ValidarBanda4(string color)
        {
            return _ColoresBanda4.Any(x => x.Color == color);
        }

        public ResistenciaResponse Calcular()
        {            
            if(!Validar())
                return new ResistenciaResponse(Value:0, Unit: string.Empty, Tolerance:0);

            // obtener valores de primera y segunda banda
            var baseValue = GetBase();

            //Obtener valor de la tercer banda
            double valorResistencia = 0.0;
            if(_banda3Divisor.Any( x => x == _resistencia.Banda3))
                valorResistencia = GetDivisor(_resistencia.Banda3, baseValue);
            else
                valorResistencia = GetMultiplicador(_resistencia.Banda3, baseValue);            

            // obtener valor de tercerabanda
            var tolerancia = _ColoresBanda4.FirstOrDefault(x => x.Color == _resistencia.Banda4);

            return new ResistenciaResponse(Value: GetValue(valorResistencia), Unit: GetUnidad(valorResistencia), Tolerance: tolerancia.Value);
        }

        private double GetValue(double value)
        {
            if(value < 1000)
                return value;

            var omhs = value/1000;

            return omhs;
        }

        private string GetUnidad(double value)
        {
            if(value < 1000)
                return "Omhs";
                        
            return "KOmhs";
        }

        private int GetBase()
        {
            //obtener valor de la primer banda
            var primeraBanda = _ColoresBanda1.FirstOrDefault(x => x.Color == _resistencia.Banda1);

            //Obtener valor de la segunda banda
            var segundaBanda = _ColoresBanda2.FirstOrDefault(x => x.Color == _resistencia.Banda2);

            return primeraBanda.Value + segundaBanda.Value;
        }

        private int GetMultiplicador(string color, int baseValue)
        {
            var multiplicador = _ColoresBanda3.FirstOrDefault(x => x.Color == color);
            return baseValue * multiplicador.Value;
        }

        private double GetDivisor(string color, int baseValue)
        {
            var divisor = _ColoresBanda3.FirstOrDefault(x => x.Color == color);
            return (double)baseValue/divisor.Value;
        }
    }
}