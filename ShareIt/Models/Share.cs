using ProductsAPI.DTO;

namespace ShareIt.Models
{
    public class Sharing
    {
        public int SharingID { get; set; }
        public string Text { get; set; }=null!;
        public DateTime CreatedAt { get; set; }
        public UserDTO? User { get; set; }  // UserDTO kullanılır

    }
    
}