using Samaritan.Domain.Common;
using Samaritan.Domain.Interfaces;

namespace Samaritan.Infrastructure.Network
{
    public class TradingClient : ITradingClient
    {
        public TradingClient()
        {
        }

        void ITradingClient.getPlatformStatus(TradingPlatform platform)
        {
            throw new System.NotImplementedException();
        }
    }
}