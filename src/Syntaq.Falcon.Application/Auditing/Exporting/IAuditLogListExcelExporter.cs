using System.Collections.Generic;
using FormBizz.Auditing.Dto;
using FormBizz.Dto;

namespace FormBizz.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
