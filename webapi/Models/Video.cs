using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streaming_API.Models
{
    public class Video
{
    public int Id { get; set; }
    public string VideoUrl { get; set; } = string.Empty; // Default empty string
    public string Title { get; set; } = string.Empty;   // Default empty string
    public DateTime UploadDate { get; set; }
    public int BroadcasterId { get; set; }

    // Navigation property
    public Broadcaster Broadcaster { get; set; } = new Broadcaster(); // Default instance
}

}
