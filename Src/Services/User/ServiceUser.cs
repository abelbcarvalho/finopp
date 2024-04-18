using System.Numerics;
using IServiceUser;
using ModelUser;
using PersistUser;
using UserLoginDTO;

namespace ServiceUser
{
    public class UserService : IUserService
    {
        private readonly UserPersistDB userPersistDB = new();

        public async Task CreateUser(User user)
        {
            await this.userPersistDB.CreateUser(user);
        }

        public async Task DisableUser(BigInteger id)
        {
            await this.userPersistDB.DisableUser(id);
        }

        public async Task EnableUser(User user)
        {
            await this.userPersistDB.EnableUser(user);
        }

        public async Task<User> MakeLogin(DTOUserLogin userLogin)
        {
            return await this.userPersistDB.MakeLogin(userLogin);
        }

        public async Task<User> RecoveryAccess(User user)
        {
            return await this.userPersistDB.RecoveryAccess(user);
        }
    }
}