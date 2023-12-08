using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Diagnostics.CodeAnalysis;



namespace Streaming_API.Models;

[Table("Users")]
    #nullable enable
    public class ApplicationUser : IdentityUser
    {
        // public ApplicationUser()
        // {
        //     Role = new Role(); 
        // }



        public int UserId {get; set; }
        [Required]
        [MaxLength(100)]

        [AllowNull]
        public override string? Email
        {
            get => base.Email;
            set => base.Email = value;
        }
        
        [Required]
        [MaxLength(50)]
        
        // Add additional properties here
        public string FirstName { get; set; } = string.Empty;   // Default empty string
        public string LastName { get; set; } = string.Empty;   // Default empty string
        // Other custom properties

       
        public override string? PasswordHash {get; set; }
        
        public string? PasswordSalt {get; set; }
        

        public int RoleId {get; set; }

        public virtual Role Role {get; set; }


    }

