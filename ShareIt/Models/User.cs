using System.Collections;
using Microsoft.AspNetCore.Identity;

namespace ShareIt.Models
{
    public class User:IdentityUser<int>
    {
        public ICollection<Sharing>? TodoItems { get; set; }

    }
};