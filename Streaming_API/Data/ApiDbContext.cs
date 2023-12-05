using Microsoft.EntityFrameworkCore;
using Streaming_API.Models;

namespace Streaming_API.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Broadcaster> Broadcasters { get; set; }
    }
}
