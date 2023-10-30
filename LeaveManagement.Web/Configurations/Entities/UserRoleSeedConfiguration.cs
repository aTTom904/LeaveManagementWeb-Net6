using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                //Admin
                new IdentityUserRole<string>
                {
                    RoleId = "689b27c6-6f69-464b-b0d9-62db8e40e12f",
                    UserId = "2472464e-ec93-4402-b4e8-223818d7ffd1"
                },
                //User
                new IdentityUserRole<string>
                {
                    RoleId = "6a75b7c6-69ac-464b-8de9-62db8e40c55f",
                    UserId = "3788a3dc-1307-49de-b5e0-c7a5a053a8f5"
                }
            );
        }
    }
}