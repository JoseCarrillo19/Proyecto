

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {


        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "79d7917a-0586-4a97-86a4-7b6260336884",
                    UserId = "cf0a0f31-97b7-42e6-a6ad-5e4de4322315"

                },
                new IdentityUserRole<string>
                {
                    RoleId = "7de319fc-aec2-41d6-8576-8dd7966ada69",
                    UserId = "795ee568-de71-4450-879a-a660a589838e"
                }

                );
        }
    }
}
