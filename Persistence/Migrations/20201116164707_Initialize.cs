using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "SerialKey", "TimesUsed" },
                values: new object[,]
                {
                    { "b9ab9184-e6c1-4f0d-b5db-c3f61b13cf8c", 634963, 0 },
                    { "68fda178-0605-420f-a79f-ef3be00f55dd", 511643, 0 },
                    { "b6eedc77-3b43-437b-8bd7-81daa247029c", 553634, 0 },
                    { "dcc12f70-3d1f-4dd4-b041-b0ac70b29f34", 823758, 0 },
                    { "bea0cb52-856f-40be-a0d1-016c58165fe6", 693153, 0 },
                    { "fd4c4a49-e1d1-476f-bbee-7072cffb9471", 310633, 0 },
                    { "2e9fee88-f456-4e7a-967c-f2ce9a072252", 565003, 0 },
                    { "69f38825-0b11-44c7-8103-6ec11b621df1", 703980, 0 },
                    { "a7388ae2-a70c-48b5-bbf6-996ce2da3037", 291700, 0 },
                    { "0730abca-b6f6-4fb2-ae98-a551e4559dc2", 764555, 0 },
                    { "7209509d-7260-46dc-8fca-923060a8b2d2", 928298, 0 },
                    { "2b47573b-d251-458d-bccd-84f75cff7424", 361798, 0 },
                    { "a6874228-2159-4b97-a042-b0e60a080205", 750648, 0 },
                    { "413cbaaa-c7b9-44e1-9318-b24425769e33", 299205, 0 },
                    { "f785e3d1-f741-46eb-9ced-d2300b0d78d1", 276536, 0 },
                    { "b20ef337-7a0b-45dc-805d-df12b432f034", 454912, 0 },
                    { "cf834dec-0607-48db-8dbc-9621a8864f48", 929206, 0 },
                    { "5b731a01-d7d1-4b8f-a72b-d4c2b0aab71d", 808500, 0 },
                    { "a9c9c139-e3cb-45b4-9d7a-20283c4d46df", 228178, 0 },
                    { "620f0df2-4b7f-48ea-8133-3fe0debebdd6", 986800, 0 },
                    { "81fb0b9d-bd5b-480f-8e22-f8af931783b3", 979599, 0 },
                    { "d69057da-6167-46b9-8710-3d549fb01a49", 549071, 0 },
                    { "9f55cf3d-b2de-4eed-acbc-87696b500d5a", 653951, 0 },
                    { "60b48075-1b49-4c2e-995e-1c1f9faf30da", 413620, 0 },
                    { "71d3b611-6e4f-41a0-82cb-920f6fde5cf0", 831337, 0 },
                    { "f125ced4-0edd-498e-818c-d1f57ea2eef8", 558494, 0 },
                    { "977b0429-ec57-4af9-8a46-bd0c15626c2f", 119991, 0 },
                    { "aa0245eb-6d04-4f4e-8172-88abfc0619ca", 994056, 0 },
                    { "ef9a76c1-f9e4-49f4-b2f2-b47196e00802", 587195, 0 },
                    { "9adbf54f-6541-4178-aa6c-c27ad2efc5ef", 133516, 0 },
                    { "9c475688-0b1a-40d4-97c0-0fa80ffa701b", 812379, 0 },
                    { "53c34f72-4d63-49b7-b36f-a58a52bff3db", 853665, 0 },
                    { "70d5c9ae-8c98-4083-906f-186c4fd06b7d", 363248, 0 },
                    { "9b4ce11e-bf29-42ae-86b9-3800f7a2a813", 791088, 0 },
                    { "12446a05-f495-45d0-82d0-d4064526d286", 297861, 0 },
                    { "41904f7c-a439-4eae-a89f-229df2c853b5", 445931, 0 },
                    { "a0dbfcc9-a3e1-47dd-adea-6dd6d92c77d5", 651682, 0 },
                    { "84335613-9c5f-46ae-b814-efe8288de522", 130235, 0 },
                    { "a24a044c-8cb4-4b22-a3d3-5f4cdfcee245", 916210, 0 },
                    { "edf3eba9-c2bf-4779-8444-560a661d08ff", 871296, 0 },
                    { "3ad26285-4477-4d04-b00c-ffc6eec4979f", 260815, 0 },
                    { "a8902983-2955-4368-8e3a-3a0f13fc70f9", 264204, 0 }
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "SerialKey", "TimesUsed" },
                values: new object[,]
                {
                    { "4997f7ae-af9e-494a-8251-faa9d26d3bfe", 591767, 0 },
                    { "90e92183-04dd-438b-b6a0-39220df7a122", 269361, 0 },
                    { "d1fcaea3-dbb6-401e-9972-7c6191f47345", 520888, 0 },
                    { "2b95da74-209a-417f-a049-7b2add1c8d4b", 939033, 0 },
                    { "3a7c13c3-953f-467f-b39e-c3fa47a7b83b", 559027, 0 },
                    { "0b200696-8542-438c-b776-5e49e916399c", 190094, 0 },
                    { "6ef04666-ee95-48b7-9bef-cc6b0c69847f", 839548, 0 },
                    { "92c4833c-007c-404e-a01c-efa82d79300d", 994019, 0 },
                    { "f0491bad-6c01-4b5d-bac1-8053e1c1d5fd", 725497, 0 },
                    { "d328f24f-46e7-4d80-9b01-3b496cb7d4da", 506785, 0 },
                    { "1b6d8c63-6dd8-47b5-891c-3a82049a5f8a", 445951, 0 },
                    { "30ffe0de-7dfb-4d14-913c-a81c007e23e9", 169183, 0 },
                    { "d606c503-7f8c-4384-8ed7-7a6adf2815bf", 886672, 0 },
                    { "25764001-71f6-4338-8633-34d9633c4c05", 500560, 0 },
                    { "7067cee3-17cf-4128-a983-be1c5f538fb8", 762213, 0 },
                    { "21eb05b1-d28f-4ed2-b292-10d162d365b7", 116215, 0 },
                    { "af9c3bf0-76f5-4520-9ed1-e4ac8a7da425", 292743, 0 },
                    { "6a30aa61-e233-4ad4-bbfe-536de419b454", 636673, 0 },
                    { "93cebfd5-f3d6-4aa7-b0ad-ccef6b01a2d5", 897737, 0 },
                    { "18383438-9dfd-43a3-9053-18b3b3c69391", 335264, 0 },
                    { "0c5c1223-9f19-4273-9793-1141136cc7e3", 771007, 0 },
                    { "1b418d0a-43aa-4584-9bc7-41ddae958e21", 994387, 0 },
                    { "3a536897-1466-4c0b-bcc8-cc1cc13acba9", 639145, 0 },
                    { "5ad3d1aa-0024-474c-bdb5-3a46db25b8fb", 516634, 0 },
                    { "9e23e20d-edef-45ed-b064-9fb58b5a7338", 640351, 0 },
                    { "6e05e60e-45fa-4f91-85f7-ab6e0e721066", 411257, 0 },
                    { "35da2379-aea9-4ef6-b816-249319483d89", 127080, 0 },
                    { "1028e35b-7150-40cb-becc-55f328aadb1b", 336314, 0 },
                    { "b8d18626-37df-48ca-bc7e-38a5ffcb0b3e", 274884, 0 },
                    { "cda17786-9626-4d71-a098-d8f21070a959", 487064, 0 },
                    { "294491b7-bf8a-4543-bdae-507a238ae5b3", 678563, 0 },
                    { "4380afaf-a6f0-4787-a37e-944b92fafe6b", 345676, 0 },
                    { "4fd363a6-26a9-4fe5-aec2-bf0255812561", 881400, 0 },
                    { "16674596-6d66-4932-92f7-6f91ea2be39b", 850543, 0 },
                    { "a54fc7a1-5a2a-4c55-a8a2-709f42212886", 620284, 0 },
                    { "50ea4053-4cbf-4a8a-83e4-296984543c0b", 681182, 0 },
                    { "ee274f10-c344-4629-9335-612a82374a9e", 460511, 0 },
                    { "72faa923-79dd-4f4b-82d9-0d34b5351def", 406642, 0 },
                    { "3c9cb313-26d7-4749-a2ea-52504a277cd1", 219536, 0 },
                    { "fd2757e4-e18e-4ca7-a34b-021d3ca80fb5", 948289, 0 },
                    { "15dc7e98-054c-496a-bdfb-57c121520024", 355856, 0 },
                    { "9b0e0e2e-e748-4c90-a86e-eb46107d43c0", 337844, 0 }
                });

            migrationBuilder.InsertData(
                table: "SerialNumbers",
                columns: new[] { "Id", "SerialKey", "TimesUsed" },
                values: new object[,]
                {
                    { "ad2f344a-972b-48fc-8bed-318ab6020ba5", 332721, 0 },
                    { "2059387f-1698-4748-aa88-4b6438ea3b50", 988915, 0 },
                    { "e8ddd41a-1ad7-4161-bac3-5a6c94ce729c", 454979, 0 },
                    { "019269b7-9e38-4d26-99c1-08df93e9392b", 308579, 0 },
                    { "43790d5f-c47f-441b-8371-740242c3b55e", 599589, 0 },
                    { "9b7d75de-8222-40df-93b9-7bc2babe8837", 426039, 0 },
                    { "6e7b7f19-2379-4d5d-9f85-151df87093d5", 432733, 0 },
                    { "eb30574a-c404-40b6-b319-f878476653ef", 631283, 0 },
                    { "e801289c-94da-405c-9306-bcc853a1e464", 579307, 0 },
                    { "9b03bb45-f29a-45a8-8f85-f4d5021d3f9e", 329831, 0 },
                    { "9dfaecf4-1a19-4a30-a587-2671b4c8961f", 710846, 0 },
                    { "9241854e-fde3-4d8b-9780-f80f3a5c14b9", 254836, 0 },
                    { "0f9a482b-629e-49f0-bf72-4d2c07b20c38", 889702, 0 },
                    { "ed17e4bd-62db-449d-a729-b31433b98b00", 212052, 0 },
                    { "6649a54c-a281-471b-9cd8-5ce9e8c90546", 292456, 0 },
                    { "931d5db2-4068-4365-94cd-f7c328a16154", 214941, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerialNumbers");

            migrationBuilder.DropTable(
                name: "Submissions");
        }
    }
}
