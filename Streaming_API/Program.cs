using Streaming_API.Models;
using Microsoft.AspNetCore.Identity;
using Streaming_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Streaming_API.Helpers;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<STREAMING_APIDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("STREAMING_APIDbContext") ?? throw new InvalidOperationException("Connection string 'STREAMING_APIDbContext' not found.")));

// Add services to the container.
builder.Services.AddSingleton<PasswordManager>();

builder.Services.AddCors( policy => 
{
        policy.AddPolicy("Streaming_API-allowall", config => 
        {
            config.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        });
});

#region JWT Validation
/*******************************************
 *  Start JWT Security Configuration
 *  ****************************************/
var secret = "MyVerySuperSecureSecretSharedKey";
var secretKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
var issuer = "http://www.ecu.edu";
var audience = "http://www.ecu.edu";

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.ClaimsIssuer = issuer;
    options.MapInboundClaims = true;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = secretKey,

        ValidateIssuer = true,
        ValidIssuer = issuer,

        ValidateAudience = true,
        ValidAudience = audience,

        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero
    };

    options.Events = new JwtBearerEvents
    {
        OnTokenValidated = context =>
        {
            return Task.CompletedTask;
        },
        OnAuthenticationFailed = context =>
        {
            return Task.CompletedTask;

            // ToDo: can check for different kinds of failures
        }
    };
});

/*****************************************
 *  End JWT Security Configuration
 *  **************************************/
#endregion

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy => policy.RequireClaim("rol", "Admin"));
    options.AddPolicy("Authenticated", policy => policy.RequireClaim("rol", "User", "Admin"));

});

builder.Services.AddControllers();


// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add authentication and authorization services
// builder.Services.AddAuthentication();
// builder.Services.AddAuthorization();

// DbContext and Identity Services
// Ensure that the connection string is correctly set in your configuration
// builder.Services.AddDbContext<STREAMING_APIDbContext>(options =>
//     options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))); 

// builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//     .AddEntityFrameworkStores<STREAMING_APIDbContext>()
//     .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("Streaming_API-allowall");

// Set up authentication and authorization
app.UseAuthentication();
app.UseAuthorization();

// Define other endpoints here...
app.MapControllers();

app.Run();
