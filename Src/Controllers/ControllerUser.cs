using System.Numerics;
using IControllerUsers;
using ModelUser;
using UserLoginDTO;

namespace ControllerUser
{
    public class UserController : IUserController
    {
        public async void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public async void DisableUser(BigInteger id)
        {
            throw new NotImplementedException();
        }

        public async void EnableUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> MakeLogin(DTOUserLogin userLogin)
        {
            throw new NotImplementedException();
        }

        public async Task<User> RecoveryAccess(User user)
        {
            throw new NotImplementedException();
        }
    }
}