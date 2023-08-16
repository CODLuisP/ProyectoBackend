namespace VelSatBackend.Models
{
    public class Estudiante
    {
        public int IdEstudiantes { get; set; }

        public string Nombre { get; set; } = null!;

        public int Edad { get; set; }

        public string Correo { get; set; } = null!;
    }
}
