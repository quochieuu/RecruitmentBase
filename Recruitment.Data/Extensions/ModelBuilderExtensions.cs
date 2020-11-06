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
            var admin2Id = new Guid("157b9908-7d9c-4d3c-ad32-a15db858ac34");
            var admin3Id = new Guid("be6c06a9-e0c7-4d63-bd24-5f3ece98ebc0");
            var admin4Id = new Guid("041684eb-cf97-40c6-881c-b766ae9c416a");
            var rec1Id = new Guid("d7b7ce9e-f39f-4fea-9f2a-487a5355fbe9");
            var rec2Id = new Guid("9bc1bf33-d875-42b2-a39e-b0cfc3fb6f2c");
            var recruitmentId = new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN",
                Description = "Administrator role"
            });
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = recruitmentId,
                Name = "Recruitment",
                NormalizedName = "RECRUITMENT",
                Description = "Recruitment role"
            });
            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "quochieu@gmail.com",
                NormalizedUserName = "QUOCHIEU@GMAIL.COM",
                Email = "quochieu@gmail.com",
                NormalizedEmail = "QUOCHIEU@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abc123"),
                SecurityStamp = string.Empty,
                LastName = "Hồ Quốc",
                FirstName = "Hiếu",
                FullName= "Hồ Quốc Hiếu",
                UrlAvatar = "client/assets/img/avt1.png"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = admin2Id,
                UserName = "lehieu@gmail.com",
                NormalizedUserName = "LEHIEU@GMAIL.COM",
                Email = "lehieu@gmail.com",
                NormalizedEmail = "LEHIEU@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abc123"),
                SecurityStamp = string.Empty,
                LastName = "Nguyễn Phước Lê",
                FirstName = "Hiếu",
                FullName = "Nguyễn Phước Lê",
                UrlAvatar = "client/assets/img/avt2.png"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = admin2Id
            });

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = admin3Id,
                UserName = "locpv@gmail.com",
                NormalizedUserName = "LOCPV@GMAIL.COM",
                Email = "locpv@gmail.com",
                NormalizedEmail = "LOCPV@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abc123"),
                SecurityStamp = string.Empty,
                LastName = "Phan Văn",
                FirstName = "Lộc",
                FullName = "Phan Văn Lộc",
                UrlAvatar = "client/assets/img/avt3.png"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = admin3Id
            });

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = admin4Id,
                UserName = "giahuy@gmail.com",
                NormalizedUserName = "GIAHUY@GMAIL.COM",
                Email = "giahuy@gmail.com",
                NormalizedEmail = "GIAHUY@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abc123"),
                SecurityStamp = string.Empty,
                LastName = "Huỳnh Gia",
                FirstName = "Huy",
                FullName = "Huỳnh Gia Huy",
                UrlAvatar = "client/assets/img/avt4.png"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = admin4Id
            });

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = rec1Id,
                UserName = "vanlong@gmail.com",
                NormalizedUserName = "VANLONG@GMAIL.COM",
                Email = "vanlong@gmail.com",
                NormalizedEmail = "VANLONG@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abc123"),
                SecurityStamp = string.Empty,
                LastName = "Sằn Văn",
                FirstName = "Long",
                FullName = "Sằn Văn Long",
                UrlAvatar = "client/assets/img/avt5.png"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = recruitmentId,
                UserId = rec1Id
            });

            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = rec2Id,
                UserName = "ankhang@gmail.com",
                NormalizedUserName = "ANKHANG@GMAIL.COM",
                Email = "ankhang@gmail.com",
                NormalizedEmail = "ANKHANG@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abc123"),
                SecurityStamp = string.Empty,
                LastName = "Đỗ Phúc An Khang",
                FirstName = "Khang",
                FullName = "Đỗ Phúc An Khang",
                UrlAvatar = "client/assets/img/avt6.png"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = recruitmentId,
                UserId = rec2Id
            });

        }
    }
}
