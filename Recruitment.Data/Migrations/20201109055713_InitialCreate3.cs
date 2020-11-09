using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recruitment.Data.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "aacf95e0-cfde-49b0-b22d-eb24cb56f8ef");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0"),
                column: "ConcurrencyStamp",
                value: "8160b68b-b789-4dea-bb0a-327502761be2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("041684eb-cf97-40c6-881c-b766ae9c416a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "273b0215-aea5-4d34-91ce-ae5d55e44e7d", "AQAAAAEAACcQAAAAELlKufroqiWCrjKJhnqp+5NmurJLIv+p5eKYFpz4KSXh81Qcorth/A3TibjdFQbj/g==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("157b9908-7d9c-4d3c-ad32-a15db858ac34"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9026e8dd-593e-4d44-abdd-90553d008ea3", "AQAAAAEAACcQAAAAELBw7MYdTa9TBTUb74lrG4fShFinUg6MNosxJmO8zRfJ/aa8L0n3mPqpePhkMIKsFA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b725f1ab-0c3f-4ec1-aaa9-3c604e17f42f", "AQAAAAEAACcQAAAAEMMDWpcE+FZyMY0PjZ53qkJGEfpW1NKCg2z77QubWcccBQcaUVy1am0xStlzHM3l+Q==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9bc1bf33-d875-42b2-a39e-b0cfc3fb6f2c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "89fd09fa-0a21-44ec-b0a5-590f2f63ffd8", "AQAAAAEAACcQAAAAEBfiJTEUOSy0L+bgeD+ClmMJozk4erBzLtUcwZJNKHiOyGFrNXR7ZydwxT7Laa8WrQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6c06a9-e0c7-4d63-bd24-5f3ece98ebc0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7a8b6d6-14c5-4d64-b36e-659637ef4f0c", "AQAAAAEAACcQAAAAEGKXVaEbkQa2J7qANeWZ0HSfOk7kfSpKNhj93Lx5WMkFTbHDJjlIwX/zvEtPLYff1w==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7b7ce9e-f39f-4fea-9f2a-487a5355fbe9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da7cd195-0f81-4bf8-aca5-9422af54cb08", "AQAAAAEAACcQAAAAENk7toWS2kaIXinU3AcQAStWQVezxYMsB0i6Ue10Ew65KNh5Ycoxu+wmL7KRB4Tsjg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
