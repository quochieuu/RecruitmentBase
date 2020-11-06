using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recruitment.Data.Migrations
{
    public partial class IniSlugggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Job_Jobs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b543677c-2a4b-4723-ac45-df5b219e7c0f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1356d9c-0017-4120-84b1-08ca464a1d31", "AQAAAAEAACcQAAAAEDOVdaPulWXZDUl/uoaMczZwLALO6rjipV3VGc6UuJDdTS7ZeTn5ueWnw0UFz+8zgQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Job_Jobs");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "24111a84-4b6a-4e31-8370-ef3fed471960");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ddbfdd4-b6d3-4a58-bde8-d3cc5da680fb", "AQAAAAEAACcQAAAAEM/vl6cEpDaSvr+fGyjr7Byx3/w8d9Tsj6TC8rTd0VCCumtxfIUDrlT3HO5cLLnAGw==" });
        }
    }
}
