using System.Collections.Generic;
using Abp.Collections.Extensions;
using Abp.Dependency;
using FormBizz.Authorization.Users.Importing.Dto;
using FormBizz.DataExporting.Excel.NPOI;
using FormBizz.Dto;
using FormBizz.Storage;

namespace FormBizz.Authorization.Users.Importing
{
    public class InvalidUserExporter : NpoiExcelExporterBase, IInvalidUserExporter, ITransientDependency
    {
        public InvalidUserExporter(ITempFileCacheManager tempFileCacheManager)
            : base(tempFileCacheManager)
        {
        }

        public FileDto ExportToFile(List<ImportUserDto> userListDtos)
        {
            return CreateExcelPackage(
                "InvalidUserImportList.xlsx",
                excelPackage =>
                {
                    var sheet = excelPackage.CreateSheet(L("InvalidUserImports"));
                    
                    AddHeader(
                        sheet,
                        L("UserName"),
                        L("Name"),
                        L("Surname"),
                        L("EmailAddress"),
                        L("PhoneNumber"),
                        L("Password"),
                        L("Roles"),
                        L("Refuse Reason")
                    );

                    AddObjects(
                        sheet, userListDtos,
                        _ => _.UserName,
                        _ => _.Name,
                        _ => _.Surname,
                        _ => _.EmailAddress,
                        _ => _.PhoneNumber,
                        _ => _.Password,
                        _ => _.AssignedRoleNames?.JoinAsString(","),
                        _ => _.Exception
                    );

                    for (var i = 0; i < 8; i++)
                    {
                        sheet.AutoSizeColumn(i);
                    }
                });
        }
    }
}
