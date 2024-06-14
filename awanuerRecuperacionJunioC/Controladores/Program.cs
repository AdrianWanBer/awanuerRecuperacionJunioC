using awanuerRecuperacionJunioC.Dtos;
using awanuerRecuperacionJunioC.Servicios;
using System.Collections;

namespace awanuerRecuperacionJunioC.Controladores
{
    class program
    {
        public static List<PropietarioDto> listaPropietarios = new List<PropietarioDto>();
        public static List<VehiculoDto> listaVehiculos = new List<VehiculoDto>();
        public static ArrayList logs = new ArrayList();

        static public void Main(string[] args)
        {
            //declaracion de las variables
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();

            fi.cargaInicialFichero();

            /*foreach (PropietarioDto propietario in listaPropietarios)
            {
                Console.WriteLine(propietario.ToString());
            }*/

            bool cerrarAplicacion = false;

            while (!cerrarAplicacion)
            {

                int seleccion = mi.menuPrincipal();
                logs.Add("Se abre la aplicacion");
                switch (seleccion)
                {
                    case 0: //Cerrar Aplicacion
                        logs.Add("Se Cierra la aplicacion");
                        fi.ficheroLog();
                        cerrarAplicacion = true;
                        break;
                    case 1: //Mostrar numero historicos
                        logs.Add("Se muestra el historico");
                        break;
                    case 2: //Dar alta nuevo propietario
                        logs.Add("Se da alta un nuevo propietario");
                        oi.darAltaPropietario();
                        break;

                    default:
                        Console.WriteLine("Opcion seleccionada no valida");
                        break;

                }
            }
        }
    }
}
