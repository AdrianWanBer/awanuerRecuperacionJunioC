using awanuerRecuperacionJunioC.Controladores;
using awanuerRecuperacionJunioC.Dtos;

namespace awanuerRecuperacionJunioC.Servicios
{
    /// <summary>
    /// Implementacion que contendra los metodos relacionados con los ficheros
    /// awb
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {
        /// <summary>
        /// Metodo encargado de la cargaInicialç
        /// awb
        /// </summary>
        public void cargaInicialFichero()
        {
            try
            {
                StreamReader sr = null;

                int aux1 = 0;
                int aux2 = 1;
                int aux3 = 2;
                int aux4 = 3;
                string[] campos = { };
                string linea;
                sr = new StreamReader("C:\\Users\\Adrian\\source\\repos\\awanuerRecuperacionJunioC\\awanuerRecuperacionJunioC\\datosIniciales.txt");



                campos = sr.ReadToEnd().Split(':');
                /*for (int i = 0; i < campos.Length - 1; i++)
                {
                    Console.WriteLine(campos[i].ToString()); ;
                }*/
                for (int j = 0; j < 4; j++)
                {
                    VehiculoDto nuevoVehiculo = new VehiculoDto();
                    nuevoVehiculo.Matricula = campos[aux1];
                    nuevoVehiculo.FhcMatriculacion = campos[aux2];
                    string dni = campos[aux3];
                    string fechaCompra = campos[aux4];
                    program.listaVehiculos.Add(nuevoVehiculo);
                    PropietarioDto nuevoPropietario = new PropietarioDto(j, dni, fechaCompra, "", false);

                    //Suma aux
                    aux1 = aux1 + 4;
                    aux2 = aux2 + 4;
                    aux3 = aux3 + 4;
                    aux4 = aux4 + 4;
                }

            }
            catch (Exception ex)
            {
                throw ex;
                Console.WriteLine("Error-123: Fallo en la carga --> ".Concat(ex.Message));
            }


        }

        /// <summary>
        /// Metodo de la implementacion encargado de escribir los logs
        /// awb
        /// </summary>
        public void ficheroLog()
        {
            try
            {
                DateTime fecha = new DateTime();
                string fechaString = fecha.ToString("dd-MM-yyyy");
                StreamWriter sw = new StreamWriter("C:\\Users\\Adrian\\source\\repos\\awanuerRecuperacionJunioC\\awanuerRecuperacionJunioC\\Logs\\log-" + fechaString + ".txt") ;
                foreach (string log in program.logs)
                {
                    sw.WriteLine(log);
                }
                sw.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
