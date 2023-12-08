using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Streaming_API.Migrations
{
    /// <inheritdoc />
    public partial class AddedApplicationUserseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PasswordSalt", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserId", "UserName" },
                values: new object[,]
                {
                    { "f03cd5c8-f389-4292-afa5-ba79178b4cfc", 0, "1f0b8b59-6a94-45da-ad60-bab856b985e4", "JohnDoe123@gmail.com", false, "John", "Doe", false, null, null, null, "F9A1A872876AADC58149C885DEA4189F2D6A4ACF5063D4BAE254670E2083B02BEACFE490648027E25CB9002E4430B7ECB81CA0810CC18BBF5CDF3058A199C862", "954AFCE7D1D01B6A0C45C30A2B6B15A1DBF500A41B1EF53D175FABF465D9AEC78F50003431DF3708537E248BA9FA1300476E52D17269CA6F5E710A8FF9353DDA", null, false, 1, "9bf6d0a0-01fb-439f-9c7b-8c9708f18c6a", false, 1, null },
                    { "fc5c9e6f-9ceb-44be-b7b0-93d2e0b4190b", 0, "1fdeb6cc-f519-44da-aa21-e7914b70a56e", "TylerMoore456@gmail.com", false, "Tyler", "Moore", false, null, null, null, "6FED35E35437DC028EDD21AD1A7AEE340720EB68CBA8E4195C5A0C1FC9589E09DBAA9691B6A86BAA6C0DE60D297F6784FEDB973E8A5D695B7E46D912467D201F", "66D6CA0B05A8C7BF7FDF4D4BD7ECF2346E95FF42B0801C0B6570E3E3203A5DFA736355B61CB7F35D0785E2529611DDF01DAD004C979D12EC77A2C7A8D1D94B5A", null, false, 2, "910a521d-4ce7-435b-b380-3dc1787a4906", false, 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f03cd5c8-f389-4292-afa5-ba79178b4cfc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fc5c9e6f-9ceb-44be-b7b0-93d2e0b4190b");
        }
    }
}
