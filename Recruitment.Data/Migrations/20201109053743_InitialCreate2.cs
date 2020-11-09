using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recruitment.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Feedbacks",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "475bf7a0-c85f-44e2-b43c-7b82a44c3597");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0"),
                column: "ConcurrencyStamp",
                value: "9d654601-0110-40ac-827f-8bd08e9acd6a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("041684eb-cf97-40c6-881c-b766ae9c416a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ead85d7-b6e5-43cd-930f-263f021de33a", "AQAAAAEAACcQAAAAEOE5ii73HJpXxvKeIv93eQ1zj0u4qrwJe8eV8Dc2RXRZM3l8EacqC/xexvKS0YyuRA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("157b9908-7d9c-4d3c-ad32-a15db858ac34"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0caf8596-8154-4b48-8dd8-5942d7b8ffcd", "AQAAAAEAACcQAAAAEEexvHdLJIYHZ74xNCZh3856wbyLpeHAzfDF2Uay3K8zhPMx3rxcD7OW1khOItXq7w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbdbdae3-5af0-4028-a87d-91d83d4a9848", "AQAAAAEAACcQAAAAEGwzjhaznxrAaEI0uhbzzpBc3ViahSmkuXU85PWUGKJLgbcYXmRW22VrP1Iq3EI7eg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9bc1bf33-d875-42b2-a39e-b0cfc3fb6f2c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b20ac603-eb19-4b52-8ff7-0678f3c31e17", "AQAAAAEAACcQAAAAEFgVPfX/FK738362V+bN0Drd1h1w35rAZ4Vycza2Hl4NvFmERQW8sGr0xW79gIrZ5w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6c06a9-e0c7-4d63-bd24-5f3ece98ebc0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df58c63f-361c-4667-9d56-16b3d80a07f5", "AQAAAAEAACcQAAAAEKOFBjlVAjA1LMUQLr3swqPYbRJfXjH5jBahhMj3k3tAeyPE4Sw1jZ7U2Hb3uTB70Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7b7ce9e-f39f-4fea-9f2a-487a5355fbe9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b5dd3c0-1069-45c4-8cb8-005eb9464816", "AQAAAAEAACcQAAAAEAtogtsOqnM3ZSQo8tr6+Ibut8PvHuyS4SHszFAyI/0jLFfQBdEAYiB43IT1hbc+Uw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Feedbacks");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "379af30f-8608-4854-b597-f69c5e983fa2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0"),
                column: "ConcurrencyStamp",
                value: "3f27fa0b-d91a-47ad-ae6e-69df12537611");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("041684eb-cf97-40c6-881c-b766ae9c416a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec387513-16ad-4d57-837b-888c61804c1c", "AQAAAAEAACcQAAAAEMFx55cKbrfNBVAY2eWqMIMNSDLm3fXQokKbDjuci/wAIXpZB40sM274Vt+DPzsfbQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("157b9908-7d9c-4d3c-ad32-a15db858ac34"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c5692f6-950e-4bb3-a031-c424eefc2ddb", "AQAAAAEAACcQAAAAEHobPhouLTH50vPLkPZncdW5MWRcWJER7VuQ7E1g3X7dbx7JMjNWNLRNxVpAZLYu5g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4a7307d9-bd86-4d11-852f-9ff44d36b188", "AQAAAAEAACcQAAAAEMH7J6ZdGZMLt3Khtb0vbcjO/4wQx9wOtEcfFGvp/sucFazqoueGr/uILFvqccX4pQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9bc1bf33-d875-42b2-a39e-b0cfc3fb6f2c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0def40fb-c6fc-4d2d-aa9c-09e3ebb371ee", "AQAAAAEAACcQAAAAEMxyOkSaa/hclIwNHnNTd34XmldZQ3wvMY+8l5Nb/vLUnQidqDEEgdilKqvPDwt1+A==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6c06a9-e0c7-4d63-bd24-5f3ece98ebc0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aec9edab-85d7-46f0-9bec-188c09c3a425", "AQAAAAEAACcQAAAAEI9HnUwdtz2IOoQXkqOuAQJK1twRT2RBEzDPWZHlghb+viRnWkxUBBoOpnj4WBg2Iw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7b7ce9e-f39f-4fea-9f2a-487a5355fbe9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bd0e18f2-281a-4e24-9ac4-585091499c5b", "AQAAAAEAACcQAAAAENWl5JHZxQNrz2gQ2UO06tLYDhtShG8mesFHYBEvRWe5VgNXgyBBXDnJbnl6Dee0Xg==" });
        }
    }
}
