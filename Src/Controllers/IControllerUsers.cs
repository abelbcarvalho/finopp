using System.Numerics;
using ModelUsers;
using UserLoginDTO;

namespace IControllerUsers
{
    public interface IUsersController
    {
        abstract void CreateUser(Users user);
        abstract Users MakeLogin(DTOUserLogin userLogin);
        abstract Users RecoveryAccess(Users user);
        abstract void DisableUser(BigInteger id);
        abstract void EnableUser(Users user);
    }
}