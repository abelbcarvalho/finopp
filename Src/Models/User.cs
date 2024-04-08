using System.Numerics;

namespace ModelUser
{
    public class User
    {
        public BigInteger Id { set; get; }
        public string Name { set; get; } = "";
        public DateOnly DateBorn { set; get; }
        public string Cpf { set; get; } = "";
        public string Username { set; get; } = "";
        public string? Email { set; get; }
        public string Password { set; get; } = "";
        public bool Active { set; get; } = true;
        public DateTime CreateAt { set; get; }
        public DateTime? UpdateAt { set; get; }
    }
}