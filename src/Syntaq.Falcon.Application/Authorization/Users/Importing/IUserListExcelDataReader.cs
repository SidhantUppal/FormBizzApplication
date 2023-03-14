using System.Collections.Generic;
using FormBizz.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace FormBizz.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
