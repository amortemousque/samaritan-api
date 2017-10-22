using Samaritan.Domain.Common;
using Samaritan.Domain.Interfaces;

namespace Samaritan.Infrastructure.Network
{
    public class BitfinexTradingClient : ITradingClient
    {
        public BitfinexTradingClient()
        {
        }

        void ITradingClient.getPlatformStatus(TradingPlatform platform)
        {
            throw new System.NotImplementedException();
        }
    }
}