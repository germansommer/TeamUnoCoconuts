using System;
using ProyectoTeamUno.Clases;

namespace ProyectoTeamUno
{
    class Program
    {
        static void Main(string[] args)
        {
            var proyecto = new Proyecto();
            proyecto.AgregarSprintBL();
            Console.WriteLine("**************************");
            Console.WriteLine("Duracion del Proyecto: " + proyecto.CalcularDuracion());
            Console.WriteLine("**************************");
        }
    }
}
