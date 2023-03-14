using System.Collections.Generic;
using Abp;
using FormBizz.Chat.Dto;
using FormBizz.Dto;

namespace FormBizz.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
