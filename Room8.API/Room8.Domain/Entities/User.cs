using Microsoft.AspNetCore.Identity;

namespace Room8.Domain.Entities
{
    public class User : IdentityUser, IAuditable
    {
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; } 
        public bool IsDeleted { get; set; }
    }
}
