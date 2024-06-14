namespace awanuerRecuperacionJunioC.Dtos
{
    internal class PropietarioDto
    {
        /// <summary>
        /// Variables de los propietarios
        /// awb
        /// </summary>
        double id;
        string dni;
        string fchCompra;
        string matricula = "9999d";
        bool esHistorico = false;

        /// <summary>
        /// Constructor de el propietario con todos los parametros
        /// awb
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dni"></param>
        /// <param name="fchCompra"></param>
        /// <param name="matricula"></param>
        /// <param name="esHistorico"></param>
        public PropietarioDto(double id, string dni, string fchCompra, string matricula, bool esHistorico)
        {
            this.id = id;
            this.dni = dni;
            this.fchCompra = fchCompra;
            this.matricula = matricula;
            this.esHistorico = esHistorico;
        }

        /// <summary>
        /// Constructo vacio
        /// awb
        /// </summary>
        public PropietarioDto() { }

        /// <summary>
        /// Getters y setters
        /// awb
        /// </summary>
        public double Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FchCompra { get => fchCompra; set => fchCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }
    }
}
