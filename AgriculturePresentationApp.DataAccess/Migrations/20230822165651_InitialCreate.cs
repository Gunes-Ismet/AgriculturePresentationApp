using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgriculturePresentationApp.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutHistory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MapInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assistances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "AboutHistory", "AboutUs" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Totam atque cum alias iure in nulla ex, repellendus corrupti tempora voluptatem!", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus." });

            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "Id", "Description1", "Description2", "Description3", "Description4", "MapInfo" },
                values: new object[] { 1, "Güneş Mh. Yıldız Cd. No:22", "agriculture@gmail.com", "Kızılay Ankara", "0 530 000 00 00", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5296.639074635017!2d32.83117527991754!3d39.92476403024208!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d34f190a9cea8f%3A0xd3862ea8248d08a0!2sAn%C4%B1tkabir!5e0!3m2!1str!2str!4v1692655486283!5m2!1str!2str" });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "Date", "Description", "Status", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4335), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus.", true, "Lorem ipsum" },
                    { 2, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4345), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus.", true, "Lorem ipsum" },
                    { 3, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4346), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus.", true, "Lorem ipsum" },
                    { 4, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4347), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus.", true, "Lorem ipsum" },
                    { 5, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4348), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Possimus repudiandae ipsam numquam consectetur harum natus.", true, "Lorem ipsum" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d575f12c-a0d3-4ead-b94c-c0ee62ef7652", "0d25ad69-ef43-4e86-b2e2-09de0ff4e836", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9588b738-b7c2-4dab-96f7-5ccedde5be23", 0, "acbbbee1-c9e7-446b-958d-809fff51700a", "admin@admin.com", false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEJM76s/Hl1+6+Czt+obssWHnpudhUGuwHec8Wupi5cVo5NveoGDjqtqnZzCJzVuP6Q==", null, false, "78aa7628-96c4-43ce-93f8-9453ab83761d", false, "admin" });

            migrationBuilder.InsertData(
                table: "Assistances",
                columns: new[] { "Id", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", "61e99665-5c2c-4178-b9ab-d8aefe5bd16f_g6.jpg", "Lorem Ipsum" },
                    { 2, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", "66205b35-f8e9-4ed9-a134-71536c61eada_g7.jpg", "Lorem Ipsum" },
                    { 3, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", "a6185f8f-47fc-429f-8efb-9cb2a3137b5b_b3.jpg", "Lorem Ipsum" },
                    { 4, "Lorem ipsum dolor sit amet consectetur adipisicing elit.", "fa5e16f2-4a50-4bd0-ae7e-c8060ad4dedf_g5.jpg", "Lorem Ipsum" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Date", "Mail", "Message", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4590), "lorem@lorem.com", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", "Lorem Ipsum1" },
                    { 2, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4592), "lorem@lorem.com", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", "Lorem Ipsum2" },
                    { 3, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4593), "lorem@lorem.com", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", "Lorem Ipsum3" },
                    { 4, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4594), "lorem@lorem.com", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", "Lorem Ipsum4" },
                    { 5, new DateTime(2023, 8, 22, 19, 56, 51, 37, DateTimeKind.Local).AddTicks(4595), "lorem@lorem.com", "Lorem ipsum dolor sit amet consectetur adipisicing elit.", "Lorem Ipsum5" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet.", "68deb826-4868-458f-977f-dfaec3238a3d_cay.jpg", "Lorem Ipsum" },
                    { 2, "Lorem ipsum dolor sit amet.", "5fbf8f44-3739-46fc-9aa7-54cf1f7f5acd_bugday.jpg", "Lorem Ipsum" },
                    { 3, "Lorem ipsum dolor sit amet.", "7f388cd2-20f0-4b32-aebb-f39934edea09_b3.jpg", "Lorem Ipsum" },
                    { 4, "Lorem ipsum dolor sit amet.", "758ae01c-eb97-4396-8cf2-01da83533f42_g7.jpg", "Lorem Ipsum" },
                    { 5, "Lorem ipsum dolor sit amet.", "260b6184-3906-4712-8027-57a35540e64b_g9.jpg", "Lorem Ipsum" },
                    { 6, "Lorem ipsum dolor sit amet.", "1194798b-c2a3-4990-a489-87ca02088485_g1.jpg", "Lorem Ipsum" }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Icon", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "fa fa-facebook", "facebook", "https://facebook.com" },
                    { 2, "fa fa-twitter", "twitter", "https://facebook.com" },
                    { 3, "fa fa-linkedin", "linkedin", "https://facebook.com" },
                    { 4, "fa fa-youtube", "youtube", "https://facebook.com" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "FacebookUrl", "FullName", "ImageUrl", "InstagramUrl", "Title", "TwitterUrl", "WebSiteUrl" },
                values: new object[,]
                {
                    { 1, "#", "Lorem Ipsum", "af4ceaf0-1434-4a02-8f62-55f8d512b561_t3.jpg", "#", "Lorem", "#", "#" },
                    { 2, "#", "Lorem Ipsum", "32936630-f4fc-4972-91ea-d63dfa071104_t1.jpg", "#", "Lorem", "#", "#" },
                    { 3, "#", "Lorem Ipsum", "ba08bcd5-193b-4e37-a943-a9db7905048c_t2.jpg", "#", "Lorem", "#", "#" },
                    { 4, "#", "Lorem Ipsum", "d5648bb7-12d8-4af5-a5cd-a5de8111f7ed_t4.jpg", "#", "Lorem", "#", "#" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d575f12c-a0d3-4ead-b94c-c0ee62ef7652", "9588b738-b7c2-4dab-96f7-5ccedde5be23" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Assistances");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
