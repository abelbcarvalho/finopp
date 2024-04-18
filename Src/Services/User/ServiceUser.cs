using System.Numerics;
using IServiceUser;
using ModelUser;
using PersistUser;
using UserLoginDTO;
using UtilCpf;
using UtilEmail;
using UtilUsername;

namespace ServiceUser
{
    public class UserService : IUserService
    {
        private readonly UserPersistDB userPersistDB = new();

        public async Task CreateUser(User user)
        {
            if (String.IsNullOrEmpty(user.Name))
            {
                throw new Exception("error: name can't be null or empty");
            }

            CpfUtil.CpfChecker(user.Cpf);
            UsernameUtil.CheckUsername(user.Username);

            if (user.Email != null)
            {
                EmailUtil.CheckEmailAddress(user.Email);
            }

            if (String.IsNullOrEmpty(user.Password))
            {
                throw new Exception("error: password can't be null or empty");
            }

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