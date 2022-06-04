using LeaveManagement.Web.Constant;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "5c72a9cb-58cd-4122-99a4-845a5db735pp",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "cc61a9cb-60cd-4198-85a4-845a5db735pp",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }); ;
        }
    }
}