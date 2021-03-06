﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recruitment.Data.DataContext;

namespace Recruitment.Data.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20201109045835_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                            RoleId = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc")
                        },
                        new
                        {
                            UserId = new Guid("157b9908-7d9c-4d3c-ad32-a15db858ac34"),
                            RoleId = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc")
                        },
                        new
                        {
                            UserId = new Guid("be6c06a9-e0c7-4d63-bd24-5f3ece98ebc0"),
                            RoleId = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc")
                        },
                        new
                        {
                            UserId = new Guid("041684eb-cf97-40c6-881c-b766ae9c416a"),
                            RoleId = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc")
                        },
                        new
                        {
                            UserId = new Guid("d7b7ce9e-f39f-4fea-9f2a-487a5355fbe9"),
                            RoleId = new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0")
                        },
                        new
                        {
                            UserId = new Guid("9bc1bf33-d875-42b2-a39e-b0cfc3fb6f2c"),
                            RoleId = new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("Recruitment.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                            ConcurrencyStamp = "379af30f-8608-4854-b597-f69c5e983fa2",
                            Description = "Administrator role",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0"),
                            ConcurrencyStamp = "3f27fa0b-d91a-47ad-ae6e-69df12537611",
                            Description = "Recruitment role",
                            Name = "Recruitment",
                            NormalizedName = "RECRUITMENT"
                        });
                });

            modelBuilder.Entity("Recruitment.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<byte[]>("IdQrCode")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UrlAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4a7307d9-bd86-4d11-852f-9ff44d36b188",
                            Email = "quochieu@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Hiếu",
                            FullName = "Hồ Quốc Hiếu",
                            LastName = "Hồ Quốc",
                            LockoutEnabled = false,
                            NormalizedEmail = "QUOCHIEU@GMAIL.COM",
                            NormalizedUserName = "QUOCHIEU@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMH7J6ZdGZMLt3Khtb0vbcjO/4wQx9wOtEcfFGvp/sucFazqoueGr/uILFvqccX4pQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UrlAvatar = "client/assets/img/avt1.jpg",
                            UserName = "quochieu@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("157b9908-7d9c-4d3c-ad32-a15db858ac34"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5c5692f6-950e-4bb3-a031-c424eefc2ddb",
                            Email = "lehieu@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Hiếu",
                            FullName = "Nguyễn Phước Lê",
                            LastName = "Nguyễn Phước Lê",
                            LockoutEnabled = false,
                            NormalizedEmail = "LEHIEU@GMAIL.COM",
                            NormalizedUserName = "LEHIEU@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHobPhouLTH50vPLkPZncdW5MWRcWJER7VuQ7E1g3X7dbx7JMjNWNLRNxVpAZLYu5g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UrlAvatar = "client/assets/img/avt2.jpg",
                            UserName = "lehieu@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("be6c06a9-e0c7-4d63-bd24-5f3ece98ebc0"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aec9edab-85d7-46f0-9bec-188c09c3a425",
                            Email = "locpv@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Lộc",
                            FullName = "Phan Văn Lộc",
                            LastName = "Phan Văn",
                            LockoutEnabled = false,
                            NormalizedEmail = "LOCPV@GMAIL.COM",
                            NormalizedUserName = "LOCPV@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI9HnUwdtz2IOoQXkqOuAQJK1twRT2RBEzDPWZHlghb+viRnWkxUBBoOpnj4WBg2Iw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UrlAvatar = "client/assets/img/avt3.jpg",
                            UserName = "locpv@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("041684eb-cf97-40c6-881c-b766ae9c416a"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ec387513-16ad-4d57-837b-888c61804c1c",
                            Email = "giahuy@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Huy",
                            FullName = "Huỳnh Gia Huy",
                            LastName = "Huỳnh Gia",
                            LockoutEnabled = false,
                            NormalizedEmail = "GIAHUY@GMAIL.COM",
                            NormalizedUserName = "GIAHUY@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMFx55cKbrfNBVAY2eWqMIMNSDLm3fXQokKbDjuci/wAIXpZB40sM274Vt+DPzsfbQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UrlAvatar = "client/assets/img/avt4.jpg",
                            UserName = "giahuy@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("d7b7ce9e-f39f-4fea-9f2a-487a5355fbe9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bd0e18f2-281a-4e24-9ac4-585091499c5b",
                            Email = "vanlong@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Long",
                            FullName = "Sằn Văn Long",
                            LastName = "Sằn Văn",
                            LockoutEnabled = false,
                            NormalizedEmail = "VANLONG@GMAIL.COM",
                            NormalizedUserName = "VANLONG@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENWl5JHZxQNrz2gQ2UO06tLYDhtShG8mesFHYBEvRWe5VgNXgyBBXDnJbnl6Dee0Xg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UrlAvatar = "client/assets/img/avt5.jpg",
                            UserName = "vanlong@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("9bc1bf33-d875-42b2-a39e-b0cfc3fb6f2c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0def40fb-c6fc-4d2d-aa9c-09e3ebb371ee",
                            Email = "ankhang@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Khang",
                            FullName = "Đỗ Phúc An Khang",
                            LastName = "Đỗ Phúc An Khang",
                            LockoutEnabled = false,
                            NormalizedEmail = "ANKHANG@GMAIL.COM",
                            NormalizedUserName = "ANKHANG@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMxyOkSaa/hclIwNHnNTd34XmldZQ3wvMY+8l5Nb/vLUnQidqDEEgdilKqvPDwt1+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UrlAvatar = "client/assets/img/avt6.jpg",
                            UserName = "ankhang@gmail.com"
                        });
                });

            modelBuilder.Entity("Recruitment.Data.Entities.Candidate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CandicateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("CandicateId");

                    b.HasIndex("JobId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("Recruitment.Data.Entities.Feedback", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CommentById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CommentOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentById");

                    b.HasIndex("JobId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Recruitment.Data.Entities.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DealineForSubmission")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("JobDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<decimal>("SalaryMax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalaryMin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SalaryUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("WorkTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Job_Jobs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Recruitment.Data.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Recruitment.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Recruitment.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Recruitment.Data.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Recruitment.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Recruitment.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Recruitment.Data.Entities.Candidate", b =>
                {
                    b.HasOne("Recruitment.Data.Entities.AppUser", "Candicate")
                        .WithMany()
                        .HasForeignKey("CandicateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Recruitment.Data.Entities.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Recruitment.Data.Entities.Feedback", b =>
                {
                    b.HasOne("Recruitment.Data.Entities.AppUser", "CommentBy")
                        .WithMany()
                        .HasForeignKey("CommentById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Recruitment.Data.Entities.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
