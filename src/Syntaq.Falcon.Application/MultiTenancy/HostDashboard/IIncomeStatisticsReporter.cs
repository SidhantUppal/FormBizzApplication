using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FormBizz.MultiTenancy.HostDashboard.Dto;

namespace FormBizz.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}