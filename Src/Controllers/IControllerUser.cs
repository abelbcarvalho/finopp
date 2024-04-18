using System.Numerics;
using ModelUser;
using UserLoginDTO;

namespace IControllerUsers
{
    public interface IUserController
    {
        abstract Task CreateUser(User user);
        abstract Task<User> MakeLogin(DTOUserLogin userLogin);
        abstract Task<User> RecoveryAccess(User user);
        abstract Task DisableUser(BigInteger id);
        abstract Task EnableUser(User user);
    }
}