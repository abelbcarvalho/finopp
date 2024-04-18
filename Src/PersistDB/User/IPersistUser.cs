using System.Numerics;
using ModelUser;
using UserLoginDTO;

namespace IPersistUser
{
    public interface IUserPersistDB
    {
        abstract void CreateUser(User user);
        abstract Task<User> MakeLogin(DTOUserLogin userLogin);
        abstract Task<User> RecoveryAccess(User user);
        abstract void DisableUser(BigInteger id);
        abstract void EnableUser(User user);
    }
}