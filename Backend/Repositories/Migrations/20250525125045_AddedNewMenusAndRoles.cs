using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewMenusAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 25, 12, 50, 43, 396, DateTimeKind.Utc).AddTicks(1405), new DateTime(2025, 5, 25, 12, 50, 43, 396, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "AppApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 25, 12, 50, 43, 396, DateTimeKind.Utc).AddTicks(2585), new DateTime(2025, 5, 25, 12, 50, 43, 396, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 25, 12, 50, 43, 397, DateTimeKind.Utc).AddTicks(182), new DateTime(2025, 5, 25, 12, 50, 43, 397, DateTimeKind.Utc).AddTicks(183) });

            migrationBuilder.InsertData(
                table: "AppClaims",
                columns: new[] { "Id", "ClaimDescription", "ClaimName", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[,]
                {
                    { 2, "React uygulaması için yazılmış olan bir admin modül uygulamasıdır. ", "React.Admin.AdminModule", new DateTime(2025, 5, 25, 12, 50, 43, 397, DateTimeKind.Utc).AddTicks(510), null, "SeedData", true, new DateTime(2025, 5, 25, 12, 50, 43, 397, DateTimeKind.Utc).AddTicks(511), null, "SeedData" },
                    { 3, "React uygulaması Admin Modül için kullanıcıların Listelendiği ekran ", "React.Admin.AdminModule.Kullanici.Index", new DateTime(2025, 5, 25, 12, 50, 43, 397, DateTimeKind.Utc).AddTicks(513), null, "SeedData", true, new DateTime(2025, 5, 25, 12, 50, 43, 397, DateTimeKind.Utc).AddTicks(513), null, "SeedData" },
                    { 4, "React uygulaması Admin Modül için kullanıcıların Listelendiği ekran ", "React.Admin.AdminModule.Kullanici.Roller", new DateTime(2025, 5, 25, 12, 50, 43, 397, DateTimeKind.Utc).AddTicks(515), null, "SeedData", true, new DateTime(2025, 5, 25, 12, 50, 43, 397, DateTimeKind.Utc).AddTicks(515), null, "SeedData" }
                });

            migrationBuilder.InsertData(
                table: "AppMenus",
                columns: new[] { "Id", "AppApplicationTypeId", "AppClaimId", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "MenuDescription", "MenuName", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[] { 1, 2, 1, new DateTime(2025, 5, 25, 15, 50, 43, 397, DateTimeKind.Local).AddTicks(6808), null, "Sistem", true, "React uygulaması giriş yapan kullanıcıyı karşılayan sayfa", "Dashboard", new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(4281), null, "Sistem" });

            migrationBuilder.InsertData(
                table: "AppRoleClaims",
                columns: new[] { "Id", "ClaimId", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RoleId" },
                values: new object[] { 1, 1, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(9220), null, "Sistem", true, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(9224), null, "Sistem", 1 });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 25, 15, 50, 43, 399, DateTimeKind.Local).AddTicks(2194), new DateTime(2025, 5, 25, 15, 50, 43, 399, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 25, 15, 50, 43, 399, DateTimeKind.Local).AddTicks(6606), new DateTime(2025, 5, 25, 15, 50, 43, 399, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.InsertData(
                table: "AppMenus",
                columns: new[] { "Id", "AppApplicationTypeId", "AppClaimId", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "MenuDescription", "MenuName", "ModifiedDate", "ModifiedUserId", "ModifiedUserName" },
                values: new object[,]
                {
                    { 2, 2, 2, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(5542), null, "Sistem", true, "React uygulaması Admin Modül", "Admin Modül", new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(5544), null, "Sistem" },
                    { 3, 2, 2, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(5548), null, "Sistem", true, "React uygulaması Admin Modül Kullanicilar index sayfasi", "Kullanicilar", new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(5549), null, "Sistem" },
                    { 4, 2, 2, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(5551), null, "Sistem", true, "React uygulaması Admin Modül Roller index sayfasi", "Roller", new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(5552), null, "Sistem" }
                });

            migrationBuilder.InsertData(
                table: "AppReactMenus",
                columns: new[] { "Id", "MenuOrderNumber", "MenuTextName", "MenuTo", "RootId" },
                values: new object[] { 1, 1, "DashBoard", "/admin/dashboard", null });

            migrationBuilder.InsertData(
                table: "AppRoleClaims",
                columns: new[] { "Id", "ClaimId", "CreatedDate", "CreatedUserId", "CreatedUserName", "IsActive", "ModifiedDate", "ModifiedUserId", "ModifiedUserName", "RoleId" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(9516), null, "Sistem", true, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(9517), null, "Sistem", 1 },
                    { 3, 3, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(9520), null, "Sistem", true, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(9520), null, "Sistem", 1 },
                    { 4, 4, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(9522), null, "Sistem", true, new DateTime(2025, 5, 25, 15, 50, 43, 398, DateTimeKind.Local).AddTicks(9522), null, "Sistem", 1 }
                });

            migrationBuilder.InsertData(
                table: "AppReactMenus",
                columns: new[] { "Id", "MenuOrderNumber", "MenuTextName", "MenuTo", "RootId" },
                values: new object[,]
                {
                    { 2, 1, "DashBoard", "", null },
                    { 3, 1, "DashBoard", "/admin/adminmodul/kullanicilar", null },
                    { 4, 1, "Roller", "/admin/adminmodul/roller", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppReactMenus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppReactMenus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppReactMenus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppReactMenus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppRoleClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppMenus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AppApplicationType",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 19, 15, 9, 46, 704, DateTimeKind.Utc).AddTicks(8416), new DateTime(2025, 5, 19, 15, 9, 46, 704, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "AppApplicationType",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 19, 15, 9, 46, 704, DateTimeKind.Utc).AddTicks(9597), new DateTime(2025, 5, 19, 15, 9, 46, 704, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "AppClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 19, 15, 9, 46, 705, DateTimeKind.Utc).AddTicks(6642), new DateTime(2025, 5, 19, 15, 9, 46, 705, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 19, 18, 9, 46, 706, DateTimeKind.Local).AddTicks(3403), new DateTime(2025, 5, 19, 18, 9, 46, 719, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 5, 19, 18, 9, 46, 720, DateTimeKind.Local).AddTicks(1127), new DateTime(2025, 5, 19, 18, 9, 46, 720, DateTimeKind.Local).AddTicks(1131) });
        }
    }
}
