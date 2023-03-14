using System.Collections.Generic;
using FormBizz.Authorization.Users.Dto;
using FormBizz.Dto;

namespace FormBizz.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}