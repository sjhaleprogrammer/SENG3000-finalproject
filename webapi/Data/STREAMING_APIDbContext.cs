
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Role>().HasData(
            new Role {RoleId = 1, RoleName="Admin"},
            new Role {RoleId = 2, RoleName= "User"}
        );

        modelBuilder.Entity<ApplicationUser>().HasData(
            //Role: Admin
            //Password:Verysecurepassword123
            new ApplicationUser {UserId = 1, Email = "JohnDoe123@gmail.com", FirstName = "John", LastName = "Doe", PasswordHash = "F9A1A872876AADC58149C885DEA4189F2D6A4ACF5063D4BAE254670E2083B02BEACFE490648027E25CB9002E4430B7ECB81CA0810CC18BBF5CDF3058A199C862", PasswordSalt = "954AFCE7D1D01B6A0C45C30A2B6B15A1DBF500A41B1EF53D175FABF465D9AEC78F50003431DF3708537E248BA9FA1300476E52D17269CA6F5E710A8FF9353DDA", RoleId = 1},
            //Role: User
            //Password:Specificpassword456
            new ApplicationUser {UserId = 2, Email = "TylerMoore456@gmail.com", FirstName = "Tyler", LastName = "Moore", PasswordHash = "6FED35E35437DC028EDD21AD1A7AEE340720EB68CBA8E4195C5A0C1FC9589E09DBAA9691B6A86BAA6C0DE60D297F6784FEDB973E8A5D695B7E46D912467D201F", PasswordSalt = "66D6CA0B05A8C7BF7FDF4D4BD7ECF2346E95FF42B0801C0B6570E3E3203A5DFA736355B61CB7F35D0785E2529611DDF01DAD004C979D12EC77A2C7A8D1D94B5A", RoleId = 2}
        );



    }

}

