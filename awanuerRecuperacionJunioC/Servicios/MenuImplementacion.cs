namespace awanuerRecuperacionJunioC.Servicios
{
    /// <summary>
    /// Implementacion de los metodos relacionados con los menus
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal de la aplicacion
        /// awb
        /// </summary>
        /// <returns>seleccion</returns>
        public int menuPrincipal()
        {
            Console.WriteLine("QUE DESEA HACER");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Numero de historicos");
            Console.WriteLine("2. Alta nuevo propietario");
            int seleccion = int.Parse(Console.ReadLine());
            return seleccion;
        }
    }
}
