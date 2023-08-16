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

        public User ValidarUsersDa(string email, string password) {

            return _dbConnection.QueryFirstOrDefault<User>("SELECT * FROM users WHERE Email = @Email AND Password = @Password",
            new { Email = email, Password = password });


        }
    }
}
