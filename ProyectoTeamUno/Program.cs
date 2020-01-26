using System;
using ProyectoTeamUno.Clases;

namespace ProyectoTeamUno
{
    class Program
    {
        static void Main(string[] args)
        {
            var proyecto = new Proyecto();
            var spbacklog = new SprintBacklog();
            var tarea1 = new Tarea("Alguna UserStory cualquiera", 10, Tarea.NivelDificultad.SuperComplicada);
            var tarea2 = new Tarea("Otra UserStory cualquiera", 10, Tarea.NivelDificultad.Complicada);
            var tarea3 = new Tarea("Tercera UserStory cualquiera", 10, Tarea.NivelDificultad.Facil);
            spbacklog.AgregarTarea(tarea1);
            spbacklog.AgregarTarea(tarea2);
            spbacklog.AgregarTarea(tarea3);
            proyecto.AgregarSprintBL(spbacklog);

            Console.WriteLine("Duracion del Proyecto: " + proyecto.CalcularDuracion());
        }
    }
}
