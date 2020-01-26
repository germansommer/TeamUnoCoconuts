using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoTeamUno.Clases
{
    class Proyecto
        //Declaracion de clase Proyecto
    {
        private List<SprintBacklog> ListadoDeSprintBL = new List<SprintBacklog>();
        private int DuracionDeProyecto;

        //Funcion para calcular la duracion del proyecto, sumando las duraciones de todos los Sprint Backlogs.
        public int CalcularDuracion()
        {
            int Duracion = 0;
            foreach (SprintBacklog s in ListadoDeSprintBL)
            {
                Duracion += s.CalcularDuracion();
            }
            DuracionDeProyecto = Duracion;
            return Duracion;
        }

        //Funcion para agregar Sprint Backlogs al proyecto.
        public void AgregarSprintBL(SprintBacklog SprintBacklog)
        {
            ListadoDeSprintBL.Add(SprintBacklog);
        }
    }
}
