using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Streaming_API.Models;

[Table("Users")]
    public class ApplicationUser : IdentityUser
    {
        public int UserId {get; set; }
        [Required]
        [MaxLength(100)]

        public string Email {get; set; }
        [Required]
        [MaxLength(50)]
        
        // Add additional properties here
        public string FirstName { get; set; } = string.Empty;   // Default empty string
        public string LastName { get; set; } = string.Empty;   // Default empty string
        // Other custom properties

        public string? PasswordHash {get; set; }

        public string? PasswordSalt {get; set; }

        public int RoleId {get; set; }

        public virtual Role Role {get; set; }


    }

