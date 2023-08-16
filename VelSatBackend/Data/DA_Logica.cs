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

       public User ValidarUser(string _email, string _password)
        {
            return _userRepository.ValidarUsersDa(_email, _password);
        }
    }
}
