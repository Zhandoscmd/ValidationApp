using System.ComponentModel.DataAnnotations;
using ValidationApp.Validation;

namespace ValidationApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Атыңызды енгізіңіз")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Аты 2-50 таңба болуы керек")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email енгізіңіз")]
        [EmailAddress(ErrorMessage = "Email форматы қате")]
        [GmailOnly]
        public string Email { get; set; } = string.Empty;

        [Range(16, 100, ErrorMessage = "Жас 16-100 аралығында болуы керек")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Құпиясөз енгізіңіз")]
        [StringLength(30, MinimumLength = 6,
            ErrorMessage = "Құпиясөз 6-30 таңба болуы керек")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage = "Құпиясөздер сәйкес емес")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}