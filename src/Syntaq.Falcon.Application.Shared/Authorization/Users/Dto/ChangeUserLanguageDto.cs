using System.ComponentModel.DataAnnotations;

namespace FormBizz.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
