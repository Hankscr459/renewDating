using System.ComponentModel.DataAnnotations;

namespace API.DTos
{
    public class RegisterDto
    {
        [Required(ErrorMessage="使用者名稱欄未必填")]
        public string Username { get; set; }
        [Required(ErrorMessage="密碼欄未必填")]
        public string Password { get; set; }
    }
}