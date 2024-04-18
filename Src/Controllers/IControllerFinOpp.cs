using System.Numerics;
using EnumFinType;
using ModelFinOpp;

namespace IControllerFinOpp
{
    public interface IFinOppController
    {
        abstract void CreateFinOpp(FinOpp finOpp);
        abstract Task<List<FinOpp>> FindByDate(DateTime date, bool finish, BigInteger userId);
        abstract Task<List<FinOpp>> FindByDateRange(DateTime firstDate, DateTime lastDate, bool finish, BigInteger userId);
        abstract Task<List<FinOpp>> FindByMoneyGreaterThanEquals(decimal money, bool finish, BigInteger userId);
        abstract Task<List<FinOpp>> FindByMoneyRange(decimal moneyFirst, decimal moneyLast, bool finish, BigInteger userId);
        abstract Task<List<FinOpp>> FindByCategory(string category, bool finish, BigInteger userId);
        abstract Task<List<FinOpp>> FindByFinType(FinTypeEnum finTypeEnum, bool finish, BigInteger userId);
        abstract void UpdateFinOpp(FinOpp finOpp);
        abstract void FinishFinOpp(BigInteger id);
    }
}