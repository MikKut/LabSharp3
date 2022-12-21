using Lb3_CSharp.Models;

namespace Lb3_CSharp.Extensions
{
    internal static class FactoryExtensions
    {
        private const decimal InvestmentRatio = 0.4M;
        public static decimal ValueIncomeFromInvestition(this IFactory factory, decimal investiotion)
        {
            return (investiotion / factory.FactoryHR.IncomePerSlave) * InvestmentRatio + investiotion;
        }
    }
}
