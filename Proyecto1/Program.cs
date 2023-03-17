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

        }
    }


    class Circulo
    {
        double pi = 3.1216;

        double calculoArea(int radio)
        {

            return pi * radio * radio;
        }

    }
}
