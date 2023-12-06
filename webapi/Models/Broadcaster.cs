using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Streaming_API.Models
{
    public class Broadcaster
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProfileImageUrl { get; set; } = string.Empty;   // Default empty string

        [Required]
        public string Name { get; set; } = string.Empty;   // Default empty string

        public string Bio { get; set; } = string.Empty;   // Default empty string

        // Navigation property
        public List<Video>? Videos { get; set; }
    }
}
