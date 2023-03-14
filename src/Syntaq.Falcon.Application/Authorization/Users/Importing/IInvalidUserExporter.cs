using System.Collections.Generic;
using FormBizz.Authorization.Users.Importing.Dto;
using FormBizz.Dto;

namespace FormBizz.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
