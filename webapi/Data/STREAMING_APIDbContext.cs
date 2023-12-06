
using Microsoft.EntityFrameworkCore;
using Streaming_API.Models;

namespace Streaming_API.Data;

    public class STREAMING_APIDbContext : DbContext
    {
        public STREAMING_APIDbContext(DbContextOptions<STREAMING_APIDbContext> options)
            : base(options)
        {
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Broadcaster> Broadcasters { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers {get; set; }

        public DbSet<Role> Roles {get; set; }

    }

