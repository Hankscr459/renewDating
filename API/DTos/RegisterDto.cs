using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage="使用者名稱欄未必填")]
        public string Username { get; set; }
        [Required]
        public string KnowAs { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        
        [Required(ErrorMessage="密碼欄未必填")]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}