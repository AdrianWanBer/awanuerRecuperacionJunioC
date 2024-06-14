namespace awanuerRecuperacionJunioC.Dtos
{
    internal class VehiculoDto
    {
        double id;
        string matricula;
        string fhcMatriculacion;

        public VehiculoDto()
        {
        }

        public double Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string FhcMatriculacion { get => fhcMatriculacion; set => fhcMatriculacion = value; }
    }
}
