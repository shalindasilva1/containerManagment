using System.ComponentModel.DataAnnotations;

namespace Maersk.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}