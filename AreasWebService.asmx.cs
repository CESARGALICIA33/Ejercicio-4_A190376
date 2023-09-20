using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AreaWebService
{
    /// <summary>
    /// Descripción breve de AreasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreasWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public double AreaCuadrado(double Lado1, double Lado2)
        {
            Calcular c = new Calcular();
            c.numero1 = Lado1;
            c.numero2 = Lado2;

            return c.AreaCuadrado(Lado1, Lado2);
        }
        [WebMethod]
        public double AreaTriangulo(double Base, double Altura)
        {
            Calcular c = new Calcular();
            c.numero1 = Base;
            c.numero2 = Altura;

            return c.AreaTriangulo(Base, Altura);
        }
        [WebMethod]
        public double AreaCirculo(double Radio)
        {
            Calcular c = new Calcular();
            c.numero1 = Radio;

            // Calcular el área del círculo (pi * radio * radio)
            return c.AreaCirculo(Radio);
        }
    }
}
