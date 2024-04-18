using System.Data;
using System.Numerics;
using Database;
using IPersistUser;
using UserLoginDTO;

namespace PersistUser
{
    public class UserPersistDB : IUserPersistDB
    {
        public async Task CreateUser(ModelUser.User user)
        {
            string sql = "insert into Users (name,dateborn,cpf,username,email,passwd,active,createat,updateat) values (@name,@dateborn,@cpf,@username,@email,@passwd,@active,@createat,@updateat)";

            user.CreateAt = DateTime.Now;

            try
            {
                await DBConnection.GetConnectionAsync();

                using var command = await DBConnection.CommandAsync(sql);

                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@dateborn", user.DateBorn);
                command.Parameters.AddWithValue("@cpf", user.Cpf);
                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@email", user.Email ?? "");
                command.Parameters.AddWithValue("@passwd", user.Password);
                command.Parameters.AddWithValue("@active", user.Active);
                command.Parameters.AddWithValue("@createat", user.CreateAt);
                command.Parameters.AddWithValue("@updateat", user.UpdateAt ?? user.CreateAt);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public async Task DisableUser(BigInteger id)
        {
            throw new NotImplementedException();
        }

        public async Task EnableUser(ModelUser.User user)
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