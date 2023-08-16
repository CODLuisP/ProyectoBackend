using MySql.Data.MySqlClient;
using System.Data;
using Dapper;

using VelSatBackend.Models;

namespace VelSatBackend.Data
{
    public class EstudianteRepository
    {
        private readonly IConfiguration _config;

        public EstudianteRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection => new MySqlConnection(_config.GetConnectionString("DefaultConnection"));

        public IEnumerable<Estudiante> ObtenerTodos()
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                return conn.Query<Estudiante>("SELECT * FROM estudiantes");
            }
        }

        public Estudiante ObtenerPorId(int id)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                return conn.QueryFirstOrDefault<Estudiante>("SELECT * FROM estudiante WHERE Id = @Id", new { Id = id });
            }
        }

        public void Insertar(Estudiante estudiante)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                conn.Execute("INSERT INTO estudiante (Nombre) VALUES (@Nombre)", estudiante);
            }
        }

        public void Actualizar(Estudiante estudiante)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                conn.Execute("UPDATE estudiante SET Nombre = @Nombre WHERE Id = @Id", estudiante);
            }
        }

        public void Eliminar(int id)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                conn.Execute("DELETE FROM estudiante WHERE Id = @Id", new { Id = id });
            }
        }


    }
}
