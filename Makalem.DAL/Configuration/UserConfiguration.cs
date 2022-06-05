using Makalem.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makalem.DAL.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(a => a.FirstName).HasMaxLength(30).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(30).IsRequired();
            builder.Property(a => a.Email).HasMaxLength(40).IsRequired();
            builder.HasData(
                             new User
                             {
                                 Id = 1,
                                 FirstName = "admin",
                                 LastName = "admin",
                                 Activate = true,
                                 BirthDate = DateTime.Now,
                                 Email = "admin@hotmail.com",
                                 Description = "Bu User Sitenin Adminidir.",
                                 Password = "Admin.1989",
                                 UserName = "admin"
                             }
                                                );




        }
    }
}
