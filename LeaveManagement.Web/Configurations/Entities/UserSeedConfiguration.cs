using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();

            builder.HasData(
                new Employee
                {
                    Id = "2472464e-ec93-4402-b4e8-223818d7ffd1",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    UserName = "admin@test.com",
                    NormalizedUserName = "ADMIN@TEST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Akujiki1!"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "3788a3dc-1307-49de-b5e0-c7a5a053a8f5",
                    Email = "user@test.com",
                    NormalizedEmail = "USER@TEST.COM",
                    UserName = "user@test.com",
                    NormalizedUserName = "USER@TEST.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Akujiki1!"), 
                    EmailConfirmed = true
                }
            );
        }
    }
}