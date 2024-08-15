using ShareIt.Models;

namespace ShareIt.DTO
{
    public class ShareDTO
    {
        public int SharingID { get; set; }
        public string Text { get; set; }=null!;
        public UserDTO User { get; set; }

        
    }
    
}