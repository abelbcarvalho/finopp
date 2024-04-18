using System.Numerics;
using IControllerUsers;
using ModelUser;
using ServiceUser;
using UserLoginDTO;

namespace ControllerUser
{
    public class UserController : IUserController
    {
        private readonly UserService serviceUser = new();
        
        public async Task CreateUser(User user)
        {
            await this.serviceUser.CreateUser(user);
        }

        public async Task DisableUser(BigInteger id)
        {
            await this.serviceUser.DisableUser(id);
        }

        public async Task EnableUser(User user)
        {
            await this.serviceUser.EnableUser(user);
        }

        public async Task<User> MakeLogin(DTOUserLogin userLogin)
        {
            return await this.serviceUser.MakeLogin(userLogin);
        }

        public async Task<User> RecoveryAccess(User user)
        {
            return await this.serviceUser.RecoveryAccess(user);
        }
    }
}