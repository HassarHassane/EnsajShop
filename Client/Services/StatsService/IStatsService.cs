using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnsajShop.Client.Services.StatsService
{
    interface IStatsService
    {
        Task<int> GetVisits();
        Task IncrementVisits();
    }
}
