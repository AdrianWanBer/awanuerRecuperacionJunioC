using awanuerRecuperacionJunioC.Dtos;
using awanuerRecuperacionJunioC.Servicios;

namespace awanuerRecuperacionJunioC.Controladores
{
    class program
    {
        public static List<PropietarioDto> listaPropietarios = new List<PropietarioDto>();
        public static List<VehiculoDto> listaVehiculos = new List<VehiculoDto>();


        static public void Main(string[] args)
        {
            //declaracion de las variables
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();

            fi.cargaInicialFichero();

            foreach (PropietarioDto propietario in listaPropietarios)
            {
                Console.WriteLine(propietario.ToString());
            }

            bool cerrarAplicacion = false;

            while (!cerrarAplicacion)
            {
                int seleccion = mi.menuPrincipal();
                switch (seleccion)
                {
                    case 0: //Cerrar Aplicacion
                        cerrarAplicacion = true;
                        break;
                    case 1: //Mostrar numero historicos
                        break;
                    case 2: //Dar alta nuevo propietario
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
