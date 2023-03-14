using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Users
{
    public class UserLoginAttemptsViewModel
    {
        public List<ComboboxItemDto> LoginAttemptResults { get; set; }
    }
}