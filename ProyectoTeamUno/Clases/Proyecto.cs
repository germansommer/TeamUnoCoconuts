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
        public void AgregarSprintBL()
        {
            //Banderas de control.
            string flag, flag2 = "N";            
            do
            {   
                //Control de ingreso de datos.
                Console.WriteLine("Quiere ingresar un nuevo SprintBacklog? Y/N");
                flag = Console.ReadLine();
                while ((flag != "N") & (flag != "Y"))
                {
                    Console.WriteLine("Opcion equivocada, ingrese nuevamente.");
                    Console.WriteLine("Quiere ingresar un nuevo SprintBacklog? Y/N");
                    flag = Console.ReadLine();
                }
                if (flag == "Y")
                {
                    //Creacion de SprintBacklog
                    var SprintBacklog = new SprintBacklog();
                    ListadoDeSprintBL.Add(SprintBacklog);
                    do
                    {
                        //Control de ingreso de datos.
                        Console.WriteLine("Quiere ingresar una nueva Tarea? Y/N");
                        flag2 = Console.ReadLine();
                        while ((flag2 != "N") & (flag2 != "Y"))
                        {
                            Console.WriteLine("Opcion equivocada, ingrese nuevamente.");
                            Console.WriteLine("Quiere ingresar una nueva Tarea? Y/N");
                            flag = Console.ReadLine();
                        }
                        if (flag2 == "Y")
                        {
                            //Creacion de Tarea
                            Console.WriteLine("Ingrese una UserStory: ");
                            string US = Console.ReadLine();
                            Console.WriteLine("Ingrese una Duracion en horas (fibonacci): ");
                            int HS = 0;
                            try
                            {
                                HS = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException) { }                              
                            Console.WriteLine("Ingrese una Dificultad (1: Facil; 2: Complicada; 3: SuperComplicada): ");
                            int DF = 0;
                            try
                            {
                                DF = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException) { }                            
                            SprintBacklog.AgregarTarea(US, HS, DF);
                        }
                    } while (flag2 == "Y");
                }
            } while (flag == "Y");           
        }
    }
}
