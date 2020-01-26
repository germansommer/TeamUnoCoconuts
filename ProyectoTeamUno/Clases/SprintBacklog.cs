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
        public void AgregarTarea(Tarea tarea)
        {
            ListadoDeTareas.Add(tarea);
        }
    }
}
