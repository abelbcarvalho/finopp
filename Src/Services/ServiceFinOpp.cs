using System.Numerics;
using EnumFinType;
using IServiceFinOpp;
using ModelFinOpp;
using PersistFinOpp;

namespace ServiceFinOpp
{
    public class FinOppService : IFinOppService
    {
        private readonly FinOppPersistDB finOppPersistDB = new();

        public async Task CreateFinOpp(FinOpp finOpp)
        {
            await this.finOppPersistDB.CreateFinOpp(finOpp);
        }

        public async Task<List<FinOpp>> FindByCategory(string category, bool finish, BigInteger userId)
        {
            return await this.finOppPersistDB.FindByCategory(category, finish, userId);
        }

        public async Task<List<FinOpp>> FindByDate(DateTime date, bool finish, BigInteger userId)
        {
            return await this.finOppPersistDB.FindByDate(date, finish, userId);
        }

        public async Task<List<FinOpp>> FindByDateRange(DateTime firstDate, DateTime lastDate, bool finish, BigInteger userId)
        {
            return await this.finOppPersistDB.FindByDateRange(firstDate, lastDate, finish, userId);
        }

        public async Task<List<FinOpp>> FindByFinType(FinTypeEnum finTypeEnum, bool finish, BigInteger userId)
        {
            return await this.finOppPersistDB.FindByFinType(finTypeEnum, finish, userId);
        }

        public async Task<List<FinOpp>> FindByMoneyGreaterThanEquals(decimal money, bool finish, BigInteger userId)
        {
            return await this.finOppPersistDB.FindByMoneyGreaterThanEquals(money, finish, userId);
        }

        public async Task<List<FinOpp>> FindByMoneyRange(decimal moneyFirst, decimal moneyLast, bool finish, BigInteger userId)
        {
            return await this.finOppPersistDB.FindByMoneyRange(moneyFirst, moneyLast, finish, userId);
        }

        public async Task FinishFinOpp(BigInteger id)
        {
            await this.finOppPersistDB.FinishFinOpp(id);
        }

        public async Task UpdateFinOpp(FinOpp finOpp)
        {
            await this.finOppPersistDB.UpdateFinOpp(finOpp);
        }
    }
}