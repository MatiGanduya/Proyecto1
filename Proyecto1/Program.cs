using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        }
    }


    class Circulo
    {
        double pi = 3.1216;

        public double calculoArea(int radio)
        {
            
            return pi * radio * radio;
        }

    }
}
