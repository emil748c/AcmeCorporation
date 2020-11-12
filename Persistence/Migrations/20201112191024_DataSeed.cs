using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "SerialNumbers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SerialKey = table.Column<int>(type: "int", nullable: false),
                    TimesUsed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
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
                table: "SerialNumbers",
                columns: new[] { "Id", "SerialKey", "TimesUsed" },
                values: new object[,]
                {
                    { "3b087e43-b121-44ca-90e4-40bc63802ca6", 724503, 0 },
                    { "14001f17-064a-4ca0-8d3e-acb68e8d08d8", 742236, 0 },
                    { "c3feced5-9843-43b0-a808-367273e0de49", 725793, 0 },
                    { "283ec2c1-3d76-4268-83cd-fd3ce9088b49", 769711, 0 },
                    { "9d7d53f5-03b2-4135-a2eb-26f7c1fdbafd", 775330, 0 },
                    { "09e78033-c91b-46a7-b5aa-f3bd85698dee", 693408, 0 },
                    { "6a691ebd-699e-4a07-b79a-0c265f582933", 102311, 0 },
                    { "10da9b45-7f20-465b-9ae3-397e48c4c4b8", 454703, 0 },
                    { "3fd02a40-7206-4208-b69d-7be64e2e0a2e", 557433, 0 },
                    { "7ff3ac81-1520-46e9-99f3-a826650d364d", 190959, 0 },
                    { "42aa6288-294d-46c3-a870-da28131857d4", 590966, 0 },
                    { "624786f6-013f-4bbd-a2a5-7a39c61e15a8", 158648, 0 },
                    { "a65f1759-6a7f-4b57-b176-4d5ef496385e", 160135, 0 },
                    { "096b4b16-65c3-4d83-858f-dfe781d8c01b", 495562, 0 },
                    { "8666be3e-01e2-4f0a-bd86-a0e6771b6b0b", 218574, 0 },
                    { "deb53225-3a15-4eba-8348-030c81f41683", 690491, 0 },
                    { "501bbde5-be3f-4041-a68c-a1da03c47652", 434104, 0 },
                    { "389a81e2-e770-4685-a0ec-f18b29004942", 316075, 0 },
                    { "10340a1d-3f3e-4397-9f1e-04087374dda4", 921356, 0 },
                    { "9777d31f-5d02-440d-b281-1620f42a0628", 157496, 0 },
                    { "fbc4c75b-2df1-4492-b92b-6acbeb234547", 170468, 0 },
                    { "8c47b230-ba54-4fb8-9f9e-7317974d4672", 443369, 0 },
                    { "f95d3e62-913d-4283-a501-6aab98dffaa6", 382876, 0 },
                    { "5fbe64d7-a27b-4b20-af54-8a5065410c4f", 844550, 0 },
                    { "eadea6de-2db5-43d7-8cb5-ac8a2934b816", 950561, 0 },
                    { "be806f7b-5969-4a5c-8a94-dabd007413e4", 410291, 0 },
                    { "957a8521-9164-47a0-b984-311482cd79da", 901887, 0 },
                    { "9818ec31-70f2-4178-86b4-56ddef3fb114", 398621, 0 },
                    { "ac578fa9-6ee9-49fc-a546-2c632df29ff2", 555961, 0 },
                    { "c4556e53-75fc-4ce8-932d-67b7ac47ca48", 246496, 0 },
                    { "b6d67b96-edb8-478d-b025-5bcccb4c0cf2", 241905, 0 },
                    { "7f653dc4-f9cf-46ac-a514-54e532d68cca", 270268, 0 },
                    { "cfa7bc89-4254-4d54-938a-83e8a778c3b9", 779891, 0 },
                    { "51317fa2-25b2-436f-8947-c9ff8ceb3aeb", 246640, 0 },
                    { "f6d58432-f91f-4fec-b6b1-59efc4ab9dc9", 267469, 0 },
                    { "ade7e430-94d7-4466-b9cd-731fc5ecc6f6", 453767, 0 },
                    { "b1eb522b-f670-4c1a-9e19-5aa9cb57d575", 698040, 0 },
                    { "eb4a84af-ce3a-4eb5-8b25-a40795a9b1ca", 625490, 0 },
                    { "066088e0-68fa-411e-b562-257d12445896", 582154, 0 },
                    { "6bde6b4b-e1b2-42a1-8fdf-4bbfaa57a5bf", 459624, 0 },
                    { "d7b11994-f713-417f-ba72-01ea2279d4fe", 929201, 0 },
                    { "f352bf7c-d0e5-46f2-86ed-dd86740a4af6", 833345, 0 }
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "SerialKey", "TimesUsed" },
                values: new object[,]
                {
                    { "5a24c4de-7fbc-4e32-8b59-2abd3d9bbedd", 235187, 0 },
                    { "47b06a39-7d41-476a-af43-f92ca79d25b6", 350597, 0 },
                    { "b52bf386-bfee-43ae-83af-1e6203c47c59", 605913, 0 },
                    { "e4d4ff88-40c5-46bb-96fc-a2c36351bb9d", 287587, 0 },
                    { "7e4def2c-887a-411c-874d-0a089462fbd0", 330720, 0 },
                    { "6e755887-d01e-4371-9621-294976ee8a20", 634472, 0 },
                    { "e0141255-26d8-43cc-bdea-255d4fc8fdc6", 235828, 0 },
                    { "e91a98cf-b864-47b0-b9a1-9f26dcbcb64e", 305473, 0 },
                    { "18999856-e902-445b-b57e-190ae61ac4a5", 857721, 0 },
                    { "e7698a27-9921-4e02-982b-a17833339335", 803146, 0 },
                    { "c9ca1b7c-b429-4ea6-8fe2-36e3af715dc4", 991742, 0 },
                    { "0128f5f8-49b1-4bc9-9e30-d723d1dd43d2", 566660, 0 },
                    { "37c7ecbf-ec51-434d-929a-854f8aebe797", 924936, 0 },
                    { "f91f9b76-72f6-4f14-8435-993581d091ab", 102717, 0 },
                    { "e47a9d27-fbba-4549-b7ff-f426e9666f16", 586554, 0 },
                    { "4062c9a0-4b09-4965-a49e-7849633ffd5f", 883708, 0 },
                    { "e0377c56-d74d-4975-9424-e162ef4c3e51", 238047, 0 },
                    { "a3d105ec-13e7-488b-9fce-6a1f42f82d58", 782235, 0 },
                    { "84e3208b-dea0-48f4-af2c-7333c944aa15", 513575, 0 },
                    { "678c5118-8f10-4b04-a745-bb2ec78445d9", 223212, 0 },
                    { "a8dcfce4-538f-472e-b5ce-1a3ce5696f55", 526293, 0 },
                    { "1d3d1ec7-c65e-455c-92dd-fbfaae9917ba", 517665, 0 },
                    { "3e858001-b483-4ae2-881b-86af4e4fa661", 186420, 0 },
                    { "782a35be-ae75-477b-ab1d-361dd9d601be", 293324, 0 },
                    { "735018d9-42dc-4578-9b22-c81ea50da274", 751204, 0 },
                    { "70c782cc-8d57-424e-820d-aa02c556a2af", 129505, 0 },
                    { "c14fec24-0442-4010-8670-4bec6c4cb4ab", 305147, 0 },
                    { "fffae6ee-12ba-4442-917f-32bc2bc7648c", 262356, 0 },
                    { "4a6a4c87-31c7-40c3-a1b9-5691e65fe437", 307196, 0 },
                    { "53ceaddd-13dc-4b4b-9506-48074ae27b5c", 856872, 0 },
                    { "66952d51-b8e1-45b7-abd7-f5d71641de6e", 640796, 0 },
                    { "1106b082-d851-464b-97ed-6937f8ea07d6", 873090, 0 },
                    { "554f135f-cc97-46a4-aa27-ff7ec6150519", 571863, 0 },
                    { "ae3f257a-4219-4414-a5ce-50bc84aba4c4", 186572, 0 },
                    { "e11e842e-3d46-44b6-8634-d204e5eae171", 498754, 0 },
                    { "15f0748d-06ab-45af-9bcb-2d2174a8c1e9", 835974, 0 },
                    { "fb60b3cc-8bc0-4a69-aae5-cc749c62d4f1", 965948, 0 },
                    { "90617c2e-bb91-41d7-bd74-ded790e11f81", 685503, 0 },
                    { "d21fedf4-58d8-4e91-becc-c06249e79bf9", 410075, 0 },
                    { "31932592-8ac8-429e-8c52-65d7736a0060", 492855, 0 },
                    { "60e91dc0-6d72-49d5-bf1c-6255e0bc63a4", 457269, 0 },
                    { "1272de4f-dd79-405d-88b0-e53563a6512e", 616097, 0 }
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "SerialKey", "TimesUsed" },
                values: new object[,]
                {
                    { "d3183187-d51d-49e1-b61e-0f05a2975bc8", 642059, 0 },
                    { "e8c6cb9b-9bcc-4c72-988f-c77d560cc81b", 360480, 0 },
                    { "310ee8d4-b2aa-4d6c-807d-6a55e93afaf6", 319115, 0 },
                    { "c0142edd-46fd-4391-9371-c1a5f1b30d21", 860760, 0 },
                    { "ccf90fac-708a-49f6-a4fc-33484ccb9c95", 462715, 0 },
                    { "abd119b5-be72-4a01-aa3f-85bcb79c71ad", 188827, 0 },
                    { "ba7780e8-03b5-4177-ab9d-a4c96cb8420f", 511264, 0 },
                    { "7951d0f0-9084-4274-a26a-d02435d08f62", 768508, 0 },
                    { "9c24fe43-08b7-423c-ae37-65c8431abd7e", 968859, 0 },
                    { "04c13716-9661-4ff1-bfb1-62dec2ecf6d5", 426706, 0 },
                    { "727c8c73-fa44-4084-a3f4-095e11d79854", 595452, 0 },
                    { "5c194c97-4e79-40e0-88d3-178b1d5f6486", 234675, 0 },
                    { "d8839100-2592-4c1a-9fba-d03fdd940425", 691068, 0 },
                    { "48fe2145-fa30-4bda-aafc-369fc2d4fdba", 633942, 0 },
                    { "f1d88c76-4b60-4260-8d73-823255b2f7b8", 213996, 0 },
                    { "40eb73c2-5613-454a-9bb7-4c241a9b1581", 228070, 0 }
                });

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
                name: "SerialNumbers");

            migrationBuilder.DropTable(
                name: "Submissions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
