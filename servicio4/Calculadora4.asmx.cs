using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace servicio4
{
    /// <summary>
    /// Descripción breve de Calculadora4
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculadora4 : System.Web.Services.WebService
    {

        [WebMethod]
        public double Suma(double a, double b)
        {
            return a + b;
        }

        [WebMethod]
        public double Resta(double a, double b)
        {
            return a - b;
        }

        [WebMethod]
        public double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public double Division(double a, double b)
        {
            return a / b;
        }

        [WebMethod]
        public double Potencia(double a, double b)
        {
            double resultado = Math.Pow(a, b);
            return resultado;
        }

        [WebMethod]
        public double Raiz(double a)
        {
            double resultado = Math.Sqrt(a);
            return resultado;
        }
        private double Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }

        [WebMethod(Description = "Factorial de un numero")]
        public double Fact(int n)
        {
            return Factorial(n);
        }
        [WebMethod]

        public double Coseno(double a)
        {
            double resultado = Math.Cos(a * Math.PI / 180);
            return resultado;
        }
        [WebMethod]
        public double Seno(double a)
        {
            double resultado = Math.Sin(a * Math.PI / 180);
            return resultado;
        }
        [WebMethod]
        public double Tangente(double a)
        {
            double resultado = Math.Tan(a * Math.PI / 180);
            return resultado;
        }
    }
}
