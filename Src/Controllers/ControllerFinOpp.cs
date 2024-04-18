using System.Numerics;
using EnumFinType;
using IControllerFinOpp;
using ModelFinOpp;
using ServiceFinOpp;

namespace ControllerFinOpp
{
    public class FinOppController : IFinOppController
    {
        private readonly FinOppService finOppService = new();

        public async Task CreateFinOpp(FinOpp finOpp)
        {
            await this.finOppService.CreateFinOpp(finOpp);
        }

        public async Task<List<FinOpp>> FindByCategory(string category, bool finish, BigInteger userId)
        {
            return await this.finOppService.FindByCategory(category, finish, userId);
        }

        public async Task<List<FinOpp>> FindByDate(DateTime date, bool finish, BigInteger userId)
        {
            return await this.finOppService.FindByDate(date, finish, userId);
        }

        public async Task<List<FinOpp>> FindByDateRange(DateTime firstDate, DateTime lastDate, bool finish, BigInteger userId)
        {
            return await this.finOppService.FindByDateRange(firstDate, lastDate, finish, userId);
        }

        public async Task<List<FinOpp>> FindByFinType(FinTypeEnum finTypeEnum, bool finish, BigInteger userId)
        {
            return await this.finOppService.FindByFinType(finTypeEnum, finish, userId);
        }

        public async Task<List<FinOpp>> FindByMoneyGreaterThanEquals(decimal money, bool finish, BigInteger userId)
        {
            return await this.finOppService.FindByMoneyGreaterThanEquals(money, finish, userId);
        }

        public async Task<List<FinOpp>> FindByMoneyRange(decimal moneyFirst, decimal moneyLast, bool finish, BigInteger userId)
        {
            return await this.finOppService.FindByMoneyRange(moneyFirst, moneyLast, finish, userId);
        }

        public async Task FinishFinOpp(BigInteger id)
        {
            await this.finOppService.FinishFinOpp(id);
        }

        public async Task UpdateFinOpp(FinOpp finOpp)
        {
            await this.finOppService.UpdateFinOpp(finOpp);
        }
    }
}