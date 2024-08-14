using System.ComponentModel.DataAnnotations;
using ShareIt.Models;

namespace ProductsAPI.DTO
{
    public class UserDTO
    {
        [Required]
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public ICollection<Sharing>? TodoItems { get; set; }

    }
}