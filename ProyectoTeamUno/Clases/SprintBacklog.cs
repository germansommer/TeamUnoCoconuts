using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoTeamUno.Clases
{
    //Declaracion de la clase SprintBacklog.
    class SprintBacklog
    {
        //Atributos de la clase.
        private List<Tarea> ListadoDeTareas = new List<Tarea>();
        private int DuracionDeSprint;

        //Funcion para calcular la duracion del SprintBacklog sumando las duraciones de las tareas incluidas en el mismo.
        public int CalcularDuracion()
        {
            int Duracion = 0;
            foreach (Tarea t in ListadoDeTareas)
            {
                Duracion += t.getHorasConDesvio();
            }
            DuracionDeSprint = Duracion;
            return Duracion;
        }
        
        //Funcion para agregar tareas al Backlog.
        public void AgregarTarea(string UserStory, int Horas, int Dificultad)
        {    
            // Control ingreso Fibonacci (Mas o menos).
            while ((Horas != 1) & (Horas != 2) & (Horas != 3) & (Horas != 5) & (Horas != 8) & (Horas != 13) & (Horas != 21)  & (Horas != 34) & (Horas != 55))
            {
                Console.WriteLine("Ingrese horas nuevamente: ");
                try
                {
                    Horas = (int.Parse(Console.ReadLine()));
                }
                catch (FormatException) { }               
            }
            //Control ingreso Dificultad.
            while ((Dificultad != 1) & (Dificultad != 2) & (Dificultad != 3))
            {
                Console.WriteLine("Ingrese dificultad nuevamente: ");
                try
                {
                    Dificultad = (int.Parse(Console.ReadLine()));
                }
                catch (FormatException) { }                
            }
            //Asignacion de dificultad.
            switch (Dificultad)
            {
                case 1:
                    var tarea1 = new Tarea(UserStory, Horas, Tarea.NivelDificultad.Facil);
                    ListadoDeTareas.Add(tarea1);
                    break;
                case 2:
                    var tarea2 = new Tarea(UserStory, Horas, Tarea.NivelDificultad.Complicada);
                    ListadoDeTareas.Add(tarea2);
                    break;
                case 3:
                    var tarea3 = new Tarea(UserStory, Horas, Tarea.NivelDificultad.SuperComplicada);
                    ListadoDeTareas.Add(tarea3);
                    break;
            }           
        }
    }
}
