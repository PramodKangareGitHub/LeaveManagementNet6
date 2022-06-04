using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = "5c72a9cb-58cd-4122-99a4-845a5db735pp",
                UserId = "1c61a9cb-58cd-4098-85a4-845a5db735cc"
            },
            new IdentityUserRole<string>
            {
                RoleId = "cc61a9cb-60cd-4198-85a4-845a5db735pp",
                UserId = "9c61a9cb-58cd-4098-85a4-999a5db735cc"
            });
        }
    }
}