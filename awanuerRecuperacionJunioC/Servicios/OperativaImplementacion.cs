using awanuerRecuperacionJunioC.Controladores;
using awanuerRecuperacionJunioC.Dtos;

namespace awanuerRecuperacionJunioC.Servicios
{
    /// <summary>
    /// Implementacion de los metodos de las operativas de la aplicacion
    /// awb
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        //Declaracion de variables
        double id;
        /// <summary>
        /// Metodo encargado de dar a la alta de un nuevo propietario
        /// awb
        /// </summary>
        public void darAltaPropietario()
        {
            try
            {


                DateTime ahora = DateTime.Now;
                PropietarioDto nuevoPropietado = new PropietarioDto();
                string dni = "";
                int cerrar = 0;
                while (cerrar == 0)
                {
                    Console.WriteLine("Creando nuevo propietario");
                    Console.WriteLine("Cual es su dni");
                    dni = Console.ReadLine();

                    if (dni.Count() == 9)
                    {
                        cerrar = 1;
                    }
                    else
                    {
                        Console.WriteLine("Dni no valido, vuelva a escribirlo");
                    }
                }
                nuevoPropietado.Dni = dni;
                //Calculo id
                if (program.listaPropietarios.Count() != 0)
                {
                    id = program.listaPropietarios.Count() + 1;
                }
                else
                {
                    id = 1;
                }
                nuevoPropietado.Id = id;
                nuevoPropietado.FchCompra = ahora.ToString("dd-MM-yyyy"); ;
                program.listaPropietarios.Add(nuevoPropietado);

                //Completado
                Console.WriteLine($"Nuevo propietario: {id.ToString()} - {dni.ToString()}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo que ejecuta la operativa de los historicos
        /// awb
        /// </summary>
        public void esHistorico()
        {
            Console.WriteLine("N. Históricos: ");
        }


    }

}
