using Samaritan.Domain.Common;

namespace Samaritan.Domain.Interfaces {
    public interface ITradingClient
    {
       void getPlatformStatus(TradingPlatform platform);  
    } 
}