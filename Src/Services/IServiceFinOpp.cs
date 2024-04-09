using System.Numerics;
using EnumFinType;
using ModelFinOpp;

namespace IServiceFinOpp
{
    public interface IFinOppService
    {
        abstract void CreateFinOpp(FinOpp finOpp);
        abstract List<FinOpp> FindByDate(DateTime date, bool finish, BigInteger userId);
        abstract List<FinOpp> FindByDateRange(DateTime firstDate, DateTime lastDate, bool finish, BigInteger userId);
        abstract List<FinOpp> FindByMoneyGreaterThanEquals(decimal money, bool finish, BigInteger userId);
        abstract List<FinOpp> FindByMoneyRange(decimal moneyFirst, decimal moneyLast, bool finish, BigInteger userId);
        abstract List<FinOpp> FindByCategory(string category, bool finish, BigInteger userId);
        abstract List<FinOpp> FindByFinType(FinTypeEnum finTypeEnum, bool finish, BigInteger userId);
    }
}