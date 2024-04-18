using System.Numerics;
using IPersistUser;
using UserLoginDTO;

namespace PersistUser
{
    public class UserPersistDB : IUserPersistDB
    {
        public async void CreateUser(ModelUser.User user)
        {
            throw new NotImplementedException();
        }

        public async void DisableUser(BigInteger id)
        {
            throw new NotImplementedException();
        }

        public async void EnableUser(ModelUser.User user)
        {
            throw new NotImplementedException();
        }

        public async Task<ModelUser.User> MakeLogin(DTOUserLogin userLogin)
        {
            throw new NotImplementedException();
        }

        public async Task<ModelUser.User> RecoveryAccess(ModelUser.User user)
        {
            throw new NotImplementedException();
        }
    }
}