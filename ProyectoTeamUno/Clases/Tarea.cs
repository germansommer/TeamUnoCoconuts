using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoTeamUno.Clases
{
    //Declaracion de la Clase Tarea.
    class Tarea
    {
        //Atributos de la Clase.
        private string UserStory;
        private int HorasEstimadas;
        public enum NivelDificultad { Facil, Complicada, SuperComplicada };
        private NivelDificultad Dificultad;
        private int HorasConDesvio;
        

        //Funciones Set y Get para acceso a los atributos de la clase.
        public void setUserStory(string UserStory)
        {
            this.UserStory = UserStory;
        }

        public void setHorasEstimadas (int HorasEstimadas)
        {
            this.HorasEstimadas = HorasEstimadas;
        }

        public void setDificultad(NivelDificultad dificultad)
        {
            this.Dificultad = dificultad;
        }

        public string getUserStory()
        {
            return this.UserStory;
        }

        public int getHorasEstimadas()
        {
            return this.HorasEstimadas;
        }

        public NivelDificultad getDificultad()
        {
            return this.Dificultad;
        }

        public int getHorasConDesvio()
        {
            return this.HorasConDesvio;
        }

        //Constructor de la clase para crear nuevos objetos de tipo Tarea
        public Tarea(string UserStory, int HorasEstimadas, NivelDificultad Dificultad)
        {
            this.setUserStory(UserStory);
            this.setHorasEstimadas(HorasEstimadas);
            this.setDificultad(Dificultad);
            EstimarDesvio(this);
        }

        //Funcion para estimar el desvio de las horas con respecto a la dificultad
        public void EstimarDesvio(Tarea tarea)
        {
            switch (tarea.Dificultad)
            {
                case NivelDificultad.Facil:
                    tarea.HorasConDesvio = tarea.HorasEstimadas;
                    break;
                case NivelDificultad.Complicada:
                    tarea.HorasConDesvio = (tarea.HorasEstimadas + (tarea.HorasEstimadas * 20 /100));
                    break;
                case NivelDificultad.SuperComplicada:
                    tarea.HorasConDesvio = (tarea.HorasEstimadas + (tarea.HorasEstimadas * 50 / 100));
                    break;
            }
        }
    }
}
