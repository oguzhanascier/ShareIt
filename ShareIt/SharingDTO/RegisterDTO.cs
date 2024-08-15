using System.ComponentModel.DataAnnotations;
using ShareIt.Models;

namespace ShareIt.DTO
{
    public class RegisterDTO
    {
        public int UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

    }
}