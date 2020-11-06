using System;
using System.Collections.Generic;
using System.Text;

using Recruitment.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Recruitment.Data.Extensions
{
  public static  class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            // Any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN",
                Description = "Administrator role"
            });
            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "jobsearch@gmail.com",
                NormalizedUserName = "JOBSEARCH@GMAIL.COM",
                Email = "jobsearch@gmail.com",
                NormalizedEmail = "JOBSEARCH@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abc123"),
                SecurityStamp = string.Empty,
                LastName = "Hồ Quốc",
                FirstName = "Hiếu",
                FullName= "Hồ Quốc Hiếu",
                UrlAvatar = "/Image/Users/Avarta1.png"
            });

            var menuId1 = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00CE");

           
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
