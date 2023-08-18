using System.Data;
using Dapper;
using MySql.Data.MySqlClient;
using VelSatBackend.Models;

namespace VelSatBackend.Data

{
    public class UserRepository
    {
        private readonly IDbConnection _dbConnection;
        private readonly IConfiguration _config;

        public UserRepository(IDbConnection dbConnection, IConfiguration config)
        {
            _dbConnection = dbConnection;
            _config = config;
        }

        public List<User> AllUsers()
        {
            return _dbConnection.Query<User>("Select * from users").ToList();
        }

        public User ValidarUsersDa(string login, string clave) {

            return _dbConnection.QueryFirstOrDefault<User>("SELECT * FROM users WHERE Login = @Login AND Clave = @Clave",
            new { Login = login, Clave = clave });


        }
    }
}
