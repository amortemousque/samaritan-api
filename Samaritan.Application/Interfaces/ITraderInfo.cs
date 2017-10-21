using System;
using System.Collections.Generic;
using Samaritan.Application.Services;

namespace Samaritan.Application.Interfaces
{
    public interface ITraderInfo: IDisposable
    {
        void getPlatformStatus(TradingPlatform tradingPlatform);        
    }
}