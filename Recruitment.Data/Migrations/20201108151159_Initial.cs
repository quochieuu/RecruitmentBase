using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recruitment.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    IdQrCode = table.Column<byte[]>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(nullable: true),
                    Gender = table.Column<bool>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    UrlAvatar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Job_Jobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Position = table.Column<string>(maxLength: 255, nullable: false),
                    Slug = table.Column<string>(nullable: true),
                    ApplicationEmail = table.Column<string>(maxLength: 50, nullable: false),
                    JobImage = table.Column<string>(nullable: false),
                    JobDetail = table.Column<string>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Experience = table.Column<string>(nullable: false),
                    SalaryMin = table.Column<decimal>(nullable: false),
                    SalaryMax = table.Column<decimal>(nullable: false),
                    SalaryUnit = table.Column<string>(nullable: false),
                    WorkTime = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    DealineForSubmission = table.Column<DateTimeOffset>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppRoleClaims_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserClaims_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_AppUserLogins_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_AppUserTokens_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Introduction = table.Column<string>(nullable: false),
                    Resume = table.Column<string>(nullable: false),
                    CandicateId = table.Column<Guid>(nullable: false),
                    JobId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidates_AppUsers_CandicateId",
                        column: x => x.CandicateId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidates_Job_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Job_Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    CommentOn = table.Column<DateTime>(nullable: false),
                    JobId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Job_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Job_Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "5668c341-4390-41c4-a9c3-4237a99ffc97", "Administrator role", "Admin", "ADMIN" },
                    { new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0"), "f5674c92-4bd5-442b-8f26-b17f829b9602", "Recruitment role", "Recruitment", "RECRUITMENT" }
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Comment", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "FullName", "Gender", "IdQrCode", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UrlAvatar", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, null, null, "6447f80b-d43c-4c7b-b348-05570aa3a3fb", null, "quochieu@gmail.com", true, "Hiếu", "Hồ Quốc Hiếu", null, null, "Hồ Quốc", false, null, "QUOCHIEU@GMAIL.COM", "QUOCHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEDm6nY+FwBF3hwkCtP6ZMRgBV2NNbUaCr0Y24QxiihyZrfnT5+gkbFlKe3u4ncQ+gA==", null, false, "", false, "client/assets/img/avt1.png", "quochieu@gmail.com" },
                    { new Guid("157b9908-7d9c-4d3c-ad32-a15db858ac34"), 0, null, null, "cf96e1a2-4da4-4521-a6f2-cc1751f980de", null, "lehieu@gmail.com", true, "Hiếu", "Nguyễn Phước Lê", null, null, "Nguyễn Phước Lê", false, null, "LEHIEU@GMAIL.COM", "LEHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEDXBjE9MhPmyHJ8TPSE3Jx7lbltbDtDPqenIIAfejWl4piO9hIax/mEZvwLWBwtIZA==", null, false, "", false, "client/assets/img/avt2.png", "lehieu@gmail.com" },
                    { new Guid("be6c06a9-e0c7-4d63-bd24-5f3ece98ebc0"), 0, null, null, "7bd9320b-d569-4821-ab43-d650bf692ff2", null, "locpv@gmail.com", true, "Lộc", "Phan Văn Lộc", null, null, "Phan Văn", false, null, "LOCPV@GMAIL.COM", "LOCPV@GMAIL.COM", "AQAAAAEAACcQAAAAEB9tntBCHgZOYZSpTdLhvBADKAd6CxueciSpYTbhkZp8axPZRC0ffC4OkBZ09lUARA==", null, false, "", false, "client/assets/img/avt3.png", "locpv@gmail.com" },
                    { new Guid("041684eb-cf97-40c6-881c-b766ae9c416a"), 0, null, null, "6e774019-9a6b-424c-80ab-037ca88873d0", null, "giahuy@gmail.com", true, "Huy", "Huỳnh Gia Huy", null, null, "Huỳnh Gia", false, null, "GIAHUY@GMAIL.COM", "GIAHUY@GMAIL.COM", "AQAAAAEAACcQAAAAEKzYcsNY2W4kRBNwVwSaani8dY4qh8mbuTktTiqQry6VkuumFTDLuFzFZl/H42qRwA==", null, false, "", false, "client/assets/img/avt4.png", "giahuy@gmail.com" },
                    { new Guid("d7b7ce9e-f39f-4fea-9f2a-487a5355fbe9"), 0, null, null, "6e3fd218-b9be-4a97-9e7a-d477bf5b3c0a", null, "vanlong@gmail.com", true, "Long", "Sằn Văn Long", null, null, "Sằn Văn", false, null, "VANLONG@GMAIL.COM", "VANLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEI8JZlvAsr6sAXBBDZzKNL0SWkC7eeZV0ObZ8OAMUS+OlH/hENEDpZWzPtBuSNf4gw==", null, false, "", false, "client/assets/img/avt5.png", "vanlong@gmail.com" },
                    { new Guid("9bc1bf33-d875-42b2-a39e-b0cfc3fb6f2c"), 0, null, null, "f4cdce90-c3af-441c-8128-f8be220eb70c", null, "ankhang@gmail.com", true, "Khang", "Đỗ Phúc An Khang", null, null, "Đỗ Phúc An Khang", false, null, "ANKHANG@GMAIL.COM", "ANKHANG@GMAIL.COM", "AQAAAAEAACcQAAAAEIMs46WRnyQ1gWifWkV47G4Oh5ij9HjJNyEIE2/kgXLpVmX0uDKPeM3GuYJiVcanFg==", null, false, "", false, "client/assets/img/avt6.png", "ankhang@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") },
                    { new Guid("157b9908-7d9c-4d3c-ad32-a15db858ac34"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") },
                    { new Guid("be6c06a9-e0c7-4d63-bd24-5f3ece98ebc0"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") },
                    { new Guid("041684eb-cf97-40c6-881c-b766ae9c416a"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") },
                    { new Guid("d7b7ce9e-f39f-4fea-9f2a-487a5355fbe9"), new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0") },
                    { new Guid("9bc1bf33-d875-42b2-a39e-b0cfc3fb6f2c"), new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleClaims_RoleId",
                table: "AppRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AppRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserClaims_UserId",
                table: "AppUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_RoleId",
                table: "AppUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AppUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AppUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_CandicateId",
                table: "Candidates",
                column: "CandicateId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_JobId",
                table: "Candidates",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_JobId",
                table: "Feedbacks",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Job_Jobs");
        }
    }
}
