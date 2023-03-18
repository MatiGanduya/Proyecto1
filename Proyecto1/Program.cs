using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circulo miCirculo; //Creación de variable/objeto de tipo Circulo

            miCirculo = new Circulo(); //Iniciación de variables de tipo Circulo. Instanciar una clase

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2= new Circulo();//Declarar e iniciar en la misma linea

            Console.WriteLine(miCirculo2.calculoArea(9));

            ConversorEuroDolar obj= new ConversorEuroDolar();

            obj.cambiarValorEuro (1.05);
            Console.WriteLine (obj.Convierte(50)+" Euros");

            
        }
    }


    class Circulo
    {
        const double pi = 3.1216;

        public double calculoArea(int radio)
        {
            
            return pi * radio * radio;
        }
        
    }

    class ConversorEuroDolar
    {

        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void cambiarValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;
            else 
            euro=nuevoValor;
        }

    }
}
