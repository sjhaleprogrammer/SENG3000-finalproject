using Microsoft.AspNetCore.Identity;

namespace Streaming_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add additional properties here
        public string FirstName { get; set; } = string.Empty;   // Default empty string
        public string LastName { get; set; } = string.Empty;   // Default empty string
        // Other custom properties
    }
}
