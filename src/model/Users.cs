using System.Numerics;

namespace ModelUsers
{
    public class Users
    {
        public BigInteger Id { set; get; }
        public string Name { set; get; } = "";
        public DateOnly DateBorn { set; get; }
        public string Cpf { set; get; } = "";
        public string Username { set; get; } = "";
        public string? Email { set; get; }
        public string Password { set; get; } = "";
        public DateTime CreateAt { set; get; }
        public DateTime? UpdateAt { set; get; }
    }
}