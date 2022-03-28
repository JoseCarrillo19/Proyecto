

using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "cf0a0f31-97b7-42e6-a6ad-5e4de4322315",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "admin@gmail.com",
                    Nombre = "jose",
                    Apellidos = "carrillo",
                    UserName = "josecarrillo",
                    NormalizedUserName = "josecarrillo",
                    PasswordHash = hasher.HashPassword(null, "carrillo19"),
                    EmailConfirmed = true,

                },
                new ApplicationUser
                {
                    Id = "795ee568-de71-4450-879a-a660a589838e",
                    Email = "carlos@gmail.com",
                    NormalizedEmail = "carlos@gmail.com",
                    Nombre = "carlos",
                    Apellidos = "villazon",
                    UserName = "carlosvillazon",
                    NormalizedUserName = "carlosvillazon",
                    PasswordHash = hasher.HashPassword(null, "carrillo19"),
                    EmailConfirmed = true,

                }


                );
        }
    }
}
