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
            builder.HasData(new Employee
            {
                Id = "1c61a9cb-58cd-4098-85a4-845a5db735cc",
                FirstName = "System",
                LastName = "Admin",
                Email = "pramodkangare2@gmail.com",
                NormalizedEmail = "PRAMODKANGARE2@gmail.com",
                UserName = "pramodkangare2@gmail.com",
                NormalizedUserName = "PRAMODKANGARE2@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "14355@Pramod")
            },
            new Employee
            {
                Id = "9c61a9cb-58cd-4098-85a4-999a5db735cc",
                FirstName = "System",
                LastName = "User",
                Email = "pramodkangare3@gmail.com",
                NormalizedEmail = "PRAMODKANGARE3@gmail.com",
                UserName = "pramodkangare3@gmail.com",
                NormalizedUserName = "PRAMODKANGARE3@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "14355@Pramod")
            }); ;
        }
    }
}