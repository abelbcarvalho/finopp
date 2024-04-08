using System.Numerics;
using EnumFinType;

namespace ModelFinOpp
{
    public class FinOpp
    {
        public BigInteger Id { set; get; }
        public string category { set; get; } = "";
        public FinTypeEnum typeOpp { set; get; } = FinTypeEnum.UNKNOWN;
        public decimal finMoney { set; get; }
        public BigInteger userId { set; get; }
        public bool Active { set; get; } = true;
        public DateTime CreateAt { set; get; }
        public DateTime? UpdateAt { set; get; }
    }
}