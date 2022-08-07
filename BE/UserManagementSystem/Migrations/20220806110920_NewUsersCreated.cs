using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManagementSystem.Migrations
{
    public partial class NewUsersCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                columns: new[] { "Email", "Password", "Status", "Username" },
                values: new object[] { "jwaitz@rambler.ru", "xf0JYDbALF", "active", "jwaitz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("494c3228-3444-4a49-9cc0-e8532edc59b2"),
                columns: new[] { "Email", "Password", "Status", "Username" },
                values: new object[] { "cnussgen2@tmall.com", "v05mT7Xz4", "inactive", "veli099" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                columns: new[] { "Email", "Password", "Status", "Username" },
                values: new object[] { "call@yolasite.com", "DOIm5h", "active", "cal" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("187f09fe-847f-4167-8798-fb6b646f1712"), "willdewill@tmall.com", "Will", "Wimsett", "ZG7AZi", "active", "willdewill" },
                    { new Guid("198139bf-de0f-4c78-9a45-ec66df49413c"), "hillhed@tmall.com", "Hedwiga", "Hillatt", "ued8qu4Y", "active", "hillhed" },
                    { new Guid("374793ec-aeae-4013-8b72-6c48690286af"), "savinas@tmall.com", "Savina", " Spriddle", "9y3m9I", "inactive", "savinas" },
                    { new Guid("4dd40884-e54b-41bb-93a7-13e35710debc"), "bobby76@tmall.com", "Bob", "Baalham", "O2kIiMy7", "active", "bobby76" },
                    { new Guid("79ac0db0-d44c-4c06-94ac-2d130b193542"), "warnall@tmall.com", "Keelby", " Warnals", "v05dasdmT7Xz43", "active", "wwyord" },
                    { new Guid("7cfa6f3f-2384-467c-b802-ea0188a375fd"), "connnorwannabe@tmall.com", "Connor", "Cockerill", "8VSTlTbA", "active", "wwyord" },
                    { new Guid("d3e757a9-5850-4625-abb8-c69aed20ffbe"), "cnussgen2@tmall.com", "Felipe", "Verna", "v05mT7Xz43", "inactive", "verna" },
                    { new Guid("e3852ef6-1655-4f43-b3cd-79d6616552ff"), "biaggi23@tmall.com", "Saraann", " De Biaggi", "m80JXxgWb", "active", "Biaggi23" },
                    { new Guid("e502b86f-542a-4cc7-ba23-218d1ff622e5"), "cast@tmall.com", "Sterling", "Castelli", "ssssterling32312321", "active", "ssssterling" },
                    { new Guid("f5891e36-4d39-4da3-82d5-2f02bb156cdd"), "ag342@tmall.com", "Ailsun", " Agutter", "123456", "active", "ag342" },
                    { new Guid("fe132df5-8293-48e8-8fc6-79b79332e2c4"), "maren@tmall.com", "Maren", "MacConchie", "XFtOsOHaeF", "inactive", "MacConchie34" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("187f09fe-847f-4167-8798-fb6b646f1712"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("198139bf-de0f-4c78-9a45-ec66df49413c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("374793ec-aeae-4013-8b72-6c48690286af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dd40884-e54b-41bb-93a7-13e35710debc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79ac0db0-d44c-4c06-94ac-2d130b193542"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7cfa6f3f-2384-467c-b802-ea0188a375fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3e757a9-5850-4625-abb8-c69aed20ffbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3852ef6-1655-4f43-b3cd-79d6616552ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e502b86f-542a-4cc7-ba23-218d1ff622e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5891e36-4d39-4da3-82d5-2f02bb156cdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe132df5-8293-48e8-8fc6-79b79332e2c4"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");
        }
    }
}
