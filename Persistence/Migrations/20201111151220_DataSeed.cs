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

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    SerialNumberId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Submissions_SerialNumbers_SerialNumberId",
                        column: x => x.SerialNumberId,
                        principalTable: "SerialNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "SerialKey", "TimesUsed" },
                values: new object[,]
                {
                    { "e65cef35-2b18-42a7-b8e1-5edf0411aa28", 518711, 0 },
                    { "ac210891-bf98-4204-8b56-cc1e7fc191f4", 335972, 0 },
                    { "613942c7-03a0-45bd-846b-02382365181e", 463059, 0 },
                    { "89282cdb-ee41-4585-8894-65d4df4a9654", 479814, 0 },
                    { "9dae5f4d-5ded-4d9c-8952-97062e9e7f5a", 998312, 0 },
                    { "68cea172-b014-49b9-966a-0a37d4a5ffc3", 741688, 0 },
                    { "626cc23b-85d4-4896-b9f9-50238e4557b6", 465062, 0 },
                    { "996ab793-454b-4109-95ce-e620ad1cb83b", 180154, 0 },
                    { "3e52f525-b858-45bf-9a43-f0c11b9a1e66", 983630, 0 },
                    { "4187f2e1-d8eb-4e02-a65a-35f4487ae59f", 284318, 0 },
                    { "d59bcd7a-7f54-4f68-adf4-e38c2876f97b", 121077, 0 },
                    { "d26b6e99-83d0-4b8d-9064-788d67188814", 364548, 0 },
                    { "dfa5b6ba-f3a8-47b0-8ded-5659ba5385cf", 194244, 0 },
                    { "5471f025-a081-43aa-a6ea-9cb326337b2f", 828639, 0 },
                    { "80bcabcb-313e-4f11-9d30-e5dd0cdadcbf", 926302, 0 },
                    { "64918d82-7907-4c21-a1ef-883f7eaed366", 217397, 0 },
                    { "62d6f4bb-59f8-4fc9-ba84-336a8016a8eb", 110197, 0 },
                    { "f2b57a10-a158-4811-a967-262c57aab5b6", 152471, 0 },
                    { "36f80212-512f-447e-80ed-1b7b6346b627", 128565, 0 },
                    { "d7eccc89-c757-4837-b263-e290af082b1f", 792659, 0 },
                    { "8c5d2215-92ea-4e8d-9ce9-735741a7576e", 850463, 0 },
                    { "9ab75593-7ee3-431a-a261-a9680e3cafb7", 159151, 0 },
                    { "40e71aba-7bdc-40a6-9da7-1e79c3e74b11", 966139, 0 },
                    { "6625322e-89c3-44af-844f-9e45426a353e", 850279, 0 },
                    { "dec38ab0-5b71-4bc1-9003-c2f307f5e43c", 451501, 0 },
                    { "192c5526-25fe-45ee-ade0-763daa83f4fb", 580587, 0 },
                    { "8e8a98fd-1e9c-48a4-89a7-017e08056399", 888480, 0 },
                    { "867397ae-5b98-482f-8eaf-6b35cc80e577", 208152, 0 },
                    { "39cdc4c4-4931-4b6e-9f92-b603bd84ef0e", 743491, 0 },
                    { "49698db3-d31f-4dbe-bba4-0ec6eddd3eac", 249105, 0 },
                    { "985ca1a3-b9a8-4ca4-9551-088d888d1a54", 311731, 0 },
                    { "1e85bee5-0bd3-437e-87be-1b2797fea0ff", 213055, 0 },
                    { "fe58a45f-d436-4326-af6d-828e0d154d8e", 575903, 0 },
                    { "cc4cd8f2-4f4e-4b4e-bfd7-cbf5e10e3c84", 659400, 0 },
                    { "87c27e62-427a-4c1f-945d-8b7283497f3c", 599161, 0 },
                    { "c1955c17-fd10-4990-8a2f-0e7e9f5f811c", 933482, 0 },
                    { "9cb09f13-072f-445e-952f-8d8431913d5a", 250521, 0 },
                    { "be1d14f4-f016-4ad1-a8bc-cb5190a0417e", 139579, 0 },
                    { "659d80e3-514e-4e7c-8811-9291706d021c", 978092, 0 },
                    { "97da97ef-c5d1-4019-902b-74fe603ac93f", 614473, 0 },
                    { "88e2639c-4862-439f-aa24-1bd4d103a3d8", 893972, 0 },
                    { "4ee2b5a0-5711-466f-b1ad-89ff26dcde7a", 251345, 0 }
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "SerialKey", "TimesUsed" },
                values: new object[,]
                {
                    { "0ead175a-4fce-4e53-b72d-e0ae44c26e18", 173836, 0 },
                    { "098736fb-38f4-46d9-a561-365ee0083363", 244368, 0 },
                    { "d9cb7892-c0fc-4dbd-b9e9-233a159b0411", 262225, 0 },
                    { "662fc1b6-cb8e-4f6e-b06e-02c054921028", 144672, 0 },
                    { "eae58974-1d6b-4695-8cf1-051d1fa38a09", 393170, 0 },
                    { "81a16fb2-26bb-4387-91dc-38e00f34bc48", 583588, 0 },
                    { "41fe8f63-6ad2-4894-97ef-39b1e5473f73", 858511, 0 },
                    { "d3d59bfc-5351-47c6-b95a-998fb2ef3a31", 630446, 0 },
                    { "89874e9c-7137-47d1-811a-3b8373fc7c3b", 387417, 0 },
                    { "3c6becb7-4b5e-4670-8696-e4fbfcf4622d", 490146, 0 },
                    { "125ddb96-d990-466a-8126-187a2e66d400", 956290, 0 },
                    { "59d9eb7e-8011-4f82-bcb3-d63742b18f41", 289238, 0 },
                    { "fcf8f43f-05f9-4b23-b02c-cc849cd8dedc", 943885, 0 },
                    { "ac44a5ca-dda6-4b3e-8de5-cb0b669307f7", 474007, 0 },
                    { "6c536c63-565b-4e61-914f-80eadd1efcf3", 693512, 0 },
                    { "25b90053-0f96-457e-ab17-1e5c546e532b", 965916, 0 },
                    { "59ff70c8-5b1e-4999-81ea-7bcf1d6e581b", 710185, 0 },
                    { "5d3deb82-ba42-4d55-9cbf-a0b63c1254ec", 369416, 0 },
                    { "915a391b-1fab-4f3f-9032-fa0659cf1c86", 191207, 0 },
                    { "1b8341e0-7517-4987-81b9-f3cbed6142d7", 181140, 0 },
                    { "2fff297f-6cb9-4b01-a22e-0c17f101d4f8", 182362, 0 },
                    { "3e780bed-3c1a-48d4-b22c-cc46b47bfe77", 112692, 0 },
                    { "c16d8786-7115-4838-880f-b197d9045268", 494063, 0 },
                    { "41399652-2c9d-4c04-a364-bda50b1cb350", 788968, 0 },
                    { "dbc63fd3-5a5d-4b92-b268-b7a6f62a01d1", 633007, 0 },
                    { "e8bf8ba3-5f8c-4bc2-a7a8-42d31d540894", 653867, 0 },
                    { "46301537-70dd-463d-b110-a9a911e54c36", 997390, 0 },
                    { "0c7d359c-6307-49cd-8c06-aa86a4395a3e", 559063, 0 },
                    { "7b77e49c-114a-4e88-8b58-7176289a928e", 822759, 0 },
                    { "f2228d88-aa70-41ba-804e-723904e1075d", 558404, 0 },
                    { "51cd2c5e-cebf-4057-90e2-e1355029d642", 505932, 0 },
                    { "b194ec46-b0f6-4936-9fec-68131ca82cf9", 812562, 0 },
                    { "9ae55db3-4112-4877-b7a6-a1c7397801b8", 441665, 0 },
                    { "a9f2230b-e61f-48bd-a1ec-c2bdacd83ba5", 171088, 0 },
                    { "82b5dc94-b040-4479-9277-da8afe46cb54", 751389, 0 },
                    { "116c1c10-55c3-43db-96e9-03e9b4461498", 926718, 0 },
                    { "6a4ea392-8e39-496d-aaf9-efa449342817", 279440, 0 },
                    { "f5ef93e9-33fb-4498-a7c4-c0b662e2a2b5", 767889, 0 },
                    { "45063d64-4aef-4e2d-b0ae-a29be009494e", 212762, 0 },
                    { "4db76410-c91f-4536-bd76-31a0a5eadb6f", 909558, 0 },
                    { "64055eb8-d0f5-46f1-aa72-d219f3ae65de", 472701, 0 },
                    { "d7959937-e0c5-483b-a9e2-8a62b6184521", 837735, 0 }
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "SerialKey", "TimesUsed" },
                values: new object[,]
                {
                    { "34879e96-7195-44a2-af62-84b08e7f30a0", 977745, 0 },
                    { "f24f5ac0-340f-4945-862b-890c139e0c22", 238034, 0 },
                    { "f558543a-51f3-4da9-bcad-23172c087417", 928443, 0 },
                    { "6247a86e-0290-43f4-a162-e927edaf0a1e", 330453, 0 },
                    { "fb02f3be-6f06-4375-b83a-6f9b9e396b02", 711872, 0 },
                    { "bbc7c06c-8802-4a58-9603-0fdfef6712ad", 627727, 0 },
                    { "12c8412f-fe1a-413b-abf5-0454b237894a", 726143, 0 },
                    { "1ac798ed-3f23-4c35-9025-ad6f17bb31c4", 100985, 0 },
                    { "51905f69-9c96-4267-86b7-9ffb76b02936", 198731, 0 },
                    { "24e23d52-dfe7-44cf-9428-bc3206f7b55a", 828373, 0 },
                    { "f834e3ff-b256-4d8b-b32d-f1148797a0d9", 472985, 0 },
                    { "3aac48ce-107e-4051-b0c8-833733baafbc", 524419, 0 },
                    { "2fe3d78b-d518-49bd-b7fc-8ea3b3e5c095", 538763, 0 },
                    { "867faca0-cd89-4755-b34e-c0c8d6677dd0", 825226, 0 },
                    { "eed59368-c77f-4d5e-a152-5e579c14a972", 586101, 0 },
                    { "d643ad6c-c53b-40c0-bb9a-7df452fd73e4", 784258, 0 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_SerialNumberId",
                table: "Submissions",
                column: "SerialNumberId");
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
                name: "Submissions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SerialNumbers");
        }
    }
}
