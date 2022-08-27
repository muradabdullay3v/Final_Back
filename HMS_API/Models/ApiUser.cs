using Microsoft.AspNetCore.Identity;

namespace HMS_API.Models
{
    public class ApiUser : IdentityUser
    {
        public bool isPersistent { get; set; }
    }
}
