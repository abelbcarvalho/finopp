using System.Numerics;

namespace ModelFinOpp
{
    public class FinOpp
    {
        public BigInteger Id { set; get; }
        public string category { set; get; } = "";
        public string typeOpp { set; get; } = "";
        public decimal finMoney { set; get; }
        public BigInteger userId { set; get; }
        public DateTime CreateAt { set; get; }
        public DateTime? UpdateAt { set; get; }
    }
}