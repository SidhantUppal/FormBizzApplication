using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using FormBizz.MultiTenancy.Accounting.Dto;

namespace FormBizz.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
