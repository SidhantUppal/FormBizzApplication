using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using FormBizz.EntityFrameworkCore;

namespace FormBizz.HealthChecks
{
    public class FormBizzDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public FormBizzDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("FormBizzDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("FormBizzDbContext could not connect to database"));
        }
    }
}
