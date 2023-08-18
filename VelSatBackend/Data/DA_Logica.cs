using VelSatBackend.Models;
namespace VelSatBackend.Data
{
    public class DA_Logica
    {

        private readonly UserRepository _userRepository;

        public DA_Logica(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> ListaUser()
        {
            return _userRepository.AllUsers();
    }

       public User ValidarUser(string _login, string _clave)
        {
            return _userRepository.ValidarUsersDa(_login, _clave);
        }
    }
}
