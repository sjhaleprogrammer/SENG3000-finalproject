// // Data/ApiDBContext.cs
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;
// using Streaming_API.Models;
// using Streaming_API.Data;

// namespace Streaming_API.Data
// {
//     public class ApiDbContext : DbContext // Or IdentityDbContext
//     {
//         public DbSet<Video> Videos { get; set; }
//         public DbSet<Broadcaster> Broadcasters { get; set; }

//         public ApiDbContext(DbContextOptions<ApiDbContext> options)
//             : base(options)
//         {
//         }
//     }
// }
