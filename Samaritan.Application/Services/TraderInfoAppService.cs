using Samaritan.Application.Interfaces;

namespace Samaritan.Application.Services
{
    public enum TradingPlatform
    {
        BITFINEX
    }

    public class TraderInfoAppService : ITraderInfo
    {

        public TraderInfoAppService() {}

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void getPlatformStatus(TradingPlatform tradingPlatform)
        {
            throw new System.NotImplementedException();
        }
    }
}