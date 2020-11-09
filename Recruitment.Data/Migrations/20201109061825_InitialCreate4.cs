using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recruitment.Data.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdQrCode",
                table: "AppUsers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Feedbacks",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6698dc8d-ea99-4189-bb0b-8cb3d74531d1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f52734c6-4614-4bc8-894a-8feeab71bef0"),
                column: "ConcurrencyStamp",
                value: "19e0076b-6254-4e75-bec6-190915267155");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("041684eb-cf97-40c6-881c-b766ae9c416a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a3925d3-b9dc-4f6d-802d-0a4563fde103", "AQAAAAEAACcQAAAAEGhukC1Jyg4eZ//3byOYmp4HA7jIoAIyYzt0E0pT3XcluKLyc60dE7ZzYHT0B54qvg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("157b9908-7d9c-4d3c-ad32-a15db858ac34"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c01e0a88-418d-46b6-af26-fa05133264ef", "AQAAAAEAACcQAAAAED2YpV9MgzpfKg3bhmedF1yFVW6fWI7SnMc+HkfLmjLMcVbB6cFWRuPMAKHrEZUubA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "980d784e-50bf-4eb3-ac1c-b955a28ef590", "AQAAAAEAACcQAAAAEOVqxI5KNeq+rtN7r1hDAuKsTklboAOz0A0FYK5gUFzcOZg64kEF11+FDTA72NmbJA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("9bc1bf33-d875-42b2-a39e-b0cfc3fb6f2c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "262b766f-3ad7-4727-935b-3c8421898490", "AQAAAAEAACcQAAAAEKaPPEI2ojKyo7Lid+Cn8edJucaSXysnFQSflNF79QNitEReCZpU36nq+7Doq/Fsqw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("be6c06a9-e0c7-4d63-bd24-5f3ece98ebc0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71a96eb5-9aef-4014-bf0a-a808bc49ba01", "AQAAAAEAACcQAAAAEANySjvGshLFR9sgOKp0WZ9p2q72qSttQkP/6JnSHqL8v9wsZ7n6nylE8ipdTJEQbQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("d7b7ce9e-f39f-4fea-9f2a-487a5355fbe9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "95c78d1f-1c8e-4ab0-bbaf-95dfb0bc0b39", "AQAAAAEAACcQAAAAEMzaj86vPy1uVx5phMR28GSqPgWS1b+eSzFnLj6M9EXb22kmHUi5MFimvcXTpdRx7w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Feedbacks");

            migrationBuilder.AddColumn<byte[]>(
                name: "IdQrCode",
                table: "AppUsers",
                type: "varbinary(max)",
                nullable: true);

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
    }
}
