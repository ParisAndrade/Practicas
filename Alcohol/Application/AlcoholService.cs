using System;
using Alcohol.Domain;
using Alcohol.Infraestructure;

namespace Alcohol.Application
{
    public class AlcoholService
    {
        public string AlcoholD(Alcoholemia alcoholemia)
        {
            string msg ="";
        
        var repo = new AlcoholRepository();
        var alcohol = repo.msgAlcohol(alcoholemia);

        if (alcohol >= 0.8)
        {
            msg = "No cumple con el requisito para conducir, su nivel de"
            + $" alcohol es de {alcohol}, Lo sentimos XD...";
        }
        else
        {
            msg = "Si cumple con el requisito para conducir, su nivel de"
            + $" alcohol es de {alcohol}, Buen viaje XP...";
        }
        return $"{msg}";
        }
    }
}