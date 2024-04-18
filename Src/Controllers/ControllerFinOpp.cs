using System.Numerics;
using EnumFinType;
using IControllerFinOpp;
using ModelFinOpp;

namespace ControllerFinOpp
{
    public class FinOppController : IFinOppController
    {
        public async void CreateFinOpp(FinOpp finOpp)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FinOpp>> FindByCategory(string category, bool finish, BigInteger userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FinOpp>> FindByDate(DateTime date, bool finish, BigInteger userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FinOpp>> FindByDateRange(DateTime firstDate, DateTime lastDate, bool finish, BigInteger userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FinOpp>> FindByFinType(FinTypeEnum finTypeEnum, bool finish, BigInteger userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FinOpp>> FindByMoneyGreaterThanEquals(decimal money, bool finish, BigInteger userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FinOpp>> FindByMoneyRange(decimal moneyFirst, decimal moneyLast, bool finish, BigInteger userId)
        {
            throw new NotImplementedException();
        }

        public async void FinishFinOpp(BigInteger id)
        {
            throw new NotImplementedException();
        }

        public async void UpdateFinOpp(FinOpp finOpp)
        {
            throw new NotImplementedException();
        }
    }
}