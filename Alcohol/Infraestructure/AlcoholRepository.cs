using System;
using System.Collections.Generic;
using Alcohol.Domain;

namespace Alcohol.Infraestructure
{
    public class AlcoholRepository
    {

        public double msgAlcohol(Alcoholemia alcoholemia)
        {

        double mililitros = 0;
        double alcoholConsumido = 0;
        double alcoholSangre = 0;
        double masaeEtanol = 0;
        double volumen = 0;
        double resultado = 1;

        

            
            switch (alcoholemia.Nombebida)
            {
                    case "cerveza":

                        if (alcoholemia.Numbebida!="")
                        {
                            if(alcoholemia.cantidadml != "")
                            {
                                mililitros = Convert.ToDouble(alcoholemia.Numbebida)*Convert.ToDouble(alcoholemia.cantidadml);

                                alcoholConsumido = mililitros*0.05;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            else
                            {
                                mililitros =Convert.ToDouble(alcoholemia.Numbebida)*330;
                                alcoholConsumido = mililitros*0.05;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            
                            
                        }
                        else
                        {
                            mililitros = Convert.ToDouble(alcoholemia.cantidadml);
                            alcoholConsumido = mililitros*0.05;
                            alcoholSangre = alcoholConsumido * 0.15;
                            masaeEtanol = 0.789 * alcoholSangre;
                            volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                            resultado = masaeEtanol/volumen;
                        }
                    

                    break;




                    case "vino":
                        if (alcoholemia.Numbebida!="")
                        {
                            if(alcoholemia.cantidadml != "")
                            {
                                mililitros = Convert.ToDouble(alcoholemia.Numbebida)*Convert.ToDouble(alcoholemia.cantidadml);

                                alcoholConsumido = mililitros*0.12;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            else
                            {
                                mililitros =Convert.ToDouble(alcoholemia.Numbebida)*100;
                                alcoholConsumido = mililitros*0.12;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            
                            
                        }
                        else
                        {
                            mililitros = Convert.ToDouble(alcoholemia.cantidadml);
                            alcoholConsumido = mililitros*0.12;
                            alcoholSangre = alcoholConsumido * 0.15;
                            masaeEtanol = 0.789 * alcoholSangre;
                            volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                            resultado = masaeEtanol/volumen;
                        }
                    break;


                    case "cava":
                        if (alcoholemia.Numbebida!="")
                        {
                            if(alcoholemia.cantidadml != "")
                            {
                                mililitros = Convert.ToDouble(alcoholemia.Numbebida)*Convert.ToDouble(alcoholemia.cantidadml);

                                alcoholConsumido = mililitros*0.12;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            else
                            {
                                mililitros =Convert.ToDouble(alcoholemia.Numbebida)*100;
                                alcoholConsumido = mililitros*0.12;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            
                            
                        }
                        else
                        {
                            mililitros = Convert.ToDouble(alcoholemia.cantidadml);
                            alcoholConsumido = mililitros*0.12;
                            alcoholSangre = alcoholConsumido * 0.15;
                            masaeEtanol = 0.789 * alcoholSangre;
                            volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                            resultado = masaeEtanol/volumen;
                        }
                    break;
                    

                    case "vermu":
                        if (alcoholemia.Numbebida!="")
                        {
                            if(alcoholemia.cantidadml != "")
                            {
                                mililitros = Convert.ToDouble(alcoholemia.Numbebida)*Convert.ToDouble(alcoholemia.cantidadml);
                                alcoholConsumido = mililitros*0.17;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            else
                            {
                                mililitros =Convert.ToDouble(alcoholemia.Numbebida)*70;
                                alcoholConsumido = mililitros*0.17;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            
                            
                        }
                        else
                        {
                            mililitros = Convert.ToDouble(alcoholemia.cantidadml);
                            alcoholConsumido = mililitros*0.17;
                            alcoholSangre = alcoholConsumido * 0.15;
                            masaeEtanol = 0.789 * alcoholSangre;
                            volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                            resultado = masaeEtanol/volumen;
                        }
                    break;


                    case "licor":
                        if (alcoholemia.Numbebida!="")
                        {
                            if(alcoholemia.cantidadml != "")
                            {
                                mililitros = Convert.ToDouble(alcoholemia.Numbebida)*Convert.ToDouble(alcoholemia.cantidadml);
                                alcoholConsumido = mililitros*0.23;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            else
                            {
                                mililitros =Convert.ToDouble(alcoholemia.Numbebida)*45;
                                alcoholConsumido = mililitros*0.23;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            
                            
                        }
                        else
                        {
                            mililitros = Convert.ToDouble(alcoholemia.cantidadml);
                            alcoholConsumido = mililitros*0.23;
                            alcoholSangre = alcoholConsumido * 0.15;
                            masaeEtanol = 0.789 * alcoholSangre;
                            volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                            resultado = masaeEtanol/volumen;
                        }
                    break;



                    case "brandy":
                        if (alcoholemia.Numbebida!="")
                        {
                            if(alcoholemia.cantidadml != "")
                            {
                                mililitros = Convert.ToDouble(alcoholemia.Numbebida)*Convert.ToDouble(alcoholemia.cantidadml);

                                alcoholConsumido = mililitros*0.38;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            else
                            {
                                mililitros =Convert.ToDouble(alcoholemia.Numbebida)*45;
                                alcoholConsumido = mililitros*0.38;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            
                            
                        }
                        else
                        {
                            mililitros = Convert.ToDouble(alcoholemia.cantidadml);
                            alcoholConsumido = mililitros*0.38;
                            alcoholSangre = alcoholConsumido * 0.15;
                            masaeEtanol = 0.789 * alcoholSangre;
                            volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                            resultado = masaeEtanol/volumen;
                        }
                    break;


                    case "combinado":
                        if (alcoholemia.Numbebida!="")
                        {
                            if(alcoholemia.cantidadml != "")
                            {
                                mililitros = Convert.ToDouble(alcoholemia.Numbebida)*Convert.ToDouble(alcoholemia.cantidadml);

                                alcoholConsumido = mililitros*0.38;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            else
                            {
                                mililitros =Convert.ToDouble(alcoholemia.Numbebida)*50;
                                alcoholConsumido = mililitros*0.38;
                                alcoholSangre = alcoholConsumido * 0.15;
                                masaeEtanol = 0.789 * alcoholSangre;
                                volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                                resultado = masaeEtanol/volumen;
                            }
                            
                            
                        }
                        else
                        {
                            mililitros = Convert.ToDouble(alcoholemia.cantidadml);
                            alcoholConsumido = mililitros*0.38;
                            alcoholSangre = alcoholConsumido * 0.15;
                            masaeEtanol = 0.789 * alcoholSangre;
                            volumen = 0.08 * Convert.ToDouble(alcoholemia.peso);
                            resultado = masaeEtanol/volumen;
                        }
                    break;
                    
            }
            
            

            return resultado;
        }

        
    }
}