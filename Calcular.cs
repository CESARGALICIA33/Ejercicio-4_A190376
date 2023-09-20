using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreaWebService
{

    public class Calcular
    {
        public double numero1 { get; set; }
        public double numero2 { get; set; }

        public double AreaCuadrado(double Lado1 , double Lado2)
        {
            numero1 = Lado1;
            numero2 = Lado2;
            // Calcular el área del cuadrado (lado * lado)
            return numero1 * numero2;
        }
        public double AreaTriangulo(double Base, double Altura)
        {
            var division = 2;
            numero1 = Base;
            numero2 = Altura;
            // Calcular el área del cuadrado (lado * lado)
            return ((numero1 * numero2)/ division);
        }
        public double AreaCirculo(double Radio )
        {
            
            numero1 = Radio;
            
            // Calcular el área del círculo (pi * radio * radio)
            return Math.PI * numero1 * numero1;
        }



    }

}