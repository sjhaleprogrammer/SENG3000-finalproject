using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Streaming_API.Models;

[Table("Roles")]

public class Role
{

    public int RoleId {get; set; }
    [Required]
    [MaxLength(50)]

    public string? RoleName {get; set; }

}