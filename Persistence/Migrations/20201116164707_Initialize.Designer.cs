﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201116164707_Initialize")]
    partial class Initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.SerialNumber", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SerialKey")
                        .HasColumnType("int");

                    b.Property<int>("TimesUsed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SerialNumbers");

                    b.HasData(
                        new
                        {
                            Id = "b9ab9184-e6c1-4f0d-b5db-c3f61b13cf8c",
                            SerialKey = 634963,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "cda17786-9626-4d71-a098-d8f21070a959",
                            SerialKey = 487064,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "b8d18626-37df-48ca-bc7e-38a5ffcb0b3e",
                            SerialKey = 274884,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "1028e35b-7150-40cb-becc-55f328aadb1b",
                            SerialKey = 336314,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "35da2379-aea9-4ef6-b816-249319483d89",
                            SerialKey = 127080,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "6e05e60e-45fa-4f91-85f7-ab6e0e721066",
                            SerialKey = 411257,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9e23e20d-edef-45ed-b064-9fb58b5a7338",
                            SerialKey = 640351,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "5ad3d1aa-0024-474c-bdb5-3a46db25b8fb",
                            SerialKey = 516634,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "3a536897-1466-4c0b-bcc8-cc1cc13acba9",
                            SerialKey = 639145,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "1b418d0a-43aa-4584-9bc7-41ddae958e21",
                            SerialKey = 994387,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "0c5c1223-9f19-4273-9793-1141136cc7e3",
                            SerialKey = 771007,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "18383438-9dfd-43a3-9053-18b3b3c69391",
                            SerialKey = 335264,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "93cebfd5-f3d6-4aa7-b0ad-ccef6b01a2d5",
                            SerialKey = 897737,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "6a30aa61-e233-4ad4-bbfe-536de419b454",
                            SerialKey = 636673,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "af9c3bf0-76f5-4520-9ed1-e4ac8a7da425",
                            SerialKey = 292743,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "21eb05b1-d28f-4ed2-b292-10d162d365b7",
                            SerialKey = 116215,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "7067cee3-17cf-4128-a983-be1c5f538fb8",
                            SerialKey = 762213,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "25764001-71f6-4338-8633-34d9633c4c05",
                            SerialKey = 500560,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d606c503-7f8c-4384-8ed7-7a6adf2815bf",
                            SerialKey = 886672,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "30ffe0de-7dfb-4d14-913c-a81c007e23e9",
                            SerialKey = 169183,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "1b6d8c63-6dd8-47b5-891c-3a82049a5f8a",
                            SerialKey = 445951,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d328f24f-46e7-4d80-9b01-3b496cb7d4da",
                            SerialKey = 506785,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "294491b7-bf8a-4543-bdae-507a238ae5b3",
                            SerialKey = 678563,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "4380afaf-a6f0-4787-a37e-944b92fafe6b",
                            SerialKey = 345676,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "4fd363a6-26a9-4fe5-aec2-bf0255812561",
                            SerialKey = 881400,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "16674596-6d66-4932-92f7-6f91ea2be39b",
                            SerialKey = 850543,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "ed17e4bd-62db-449d-a729-b31433b98b00",
                            SerialKey = 212052,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "0f9a482b-629e-49f0-bf72-4d2c07b20c38",
                            SerialKey = 889702,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9241854e-fde3-4d8b-9780-f80f3a5c14b9",
                            SerialKey = 254836,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9dfaecf4-1a19-4a30-a587-2671b4c8961f",
                            SerialKey = 710846,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9b03bb45-f29a-45a8-8f85-f4d5021d3f9e",
                            SerialKey = 329831,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "e801289c-94da-405c-9306-bcc853a1e464",
                            SerialKey = 579307,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "eb30574a-c404-40b6-b319-f878476653ef",
                            SerialKey = 631283,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "6e7b7f19-2379-4d5d-9f85-151df87093d5",
                            SerialKey = 432733,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9b7d75de-8222-40df-93b9-7bc2babe8837",
                            SerialKey = 426039,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "43790d5f-c47f-441b-8371-740242c3b55e",
                            SerialKey = 599589,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "6649a54c-a281-471b-9cd8-5ce9e8c90546",
                            SerialKey = 292456,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "019269b7-9e38-4d26-99c1-08df93e9392b",
                            SerialKey = 308579,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "2059387f-1698-4748-aa88-4b6438ea3b50",
                            SerialKey = 988915,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "ad2f344a-972b-48fc-8bed-318ab6020ba5",
                            SerialKey = 332721,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9b0e0e2e-e748-4c90-a86e-eb46107d43c0",
                            SerialKey = 337844,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "15dc7e98-054c-496a-bdfb-57c121520024",
                            SerialKey = 355856,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "fd2757e4-e18e-4ca7-a34b-021d3ca80fb5",
                            SerialKey = 948289,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "3c9cb313-26d7-4749-a2ea-52504a277cd1",
                            SerialKey = 219536,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "72faa923-79dd-4f4b-82d9-0d34b5351def",
                            SerialKey = 406642,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "ee274f10-c344-4629-9335-612a82374a9e",
                            SerialKey = 460511,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "50ea4053-4cbf-4a8a-83e4-296984543c0b",
                            SerialKey = 681182,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "a54fc7a1-5a2a-4c55-a8a2-709f42212886",
                            SerialKey = 620284,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "f0491bad-6c01-4b5d-bac1-8053e1c1d5fd",
                            SerialKey = 725497,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "92c4833c-007c-404e-a01c-efa82d79300d",
                            SerialKey = 994019,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "6ef04666-ee95-48b7-9bef-cc6b0c69847f",
                            SerialKey = 839548,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "60b48075-1b49-4c2e-995e-1c1f9faf30da",
                            SerialKey = 413620,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d69057da-6167-46b9-8710-3d549fb01a49",
                            SerialKey = 549071,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "81fb0b9d-bd5b-480f-8e22-f8af931783b3",
                            SerialKey = 979599,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "620f0df2-4b7f-48ea-8133-3fe0debebdd6",
                            SerialKey = 986800,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "a9c9c139-e3cb-45b4-9d7a-20283c4d46df",
                            SerialKey = 228178,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "5b731a01-d7d1-4b8f-a72b-d4c2b0aab71d",
                            SerialKey = 808500,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "cf834dec-0607-48db-8dbc-9621a8864f48",
                            SerialKey = 929206,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "b20ef337-7a0b-45dc-805d-df12b432f034",
                            SerialKey = 454912,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "f785e3d1-f741-46eb-9ced-d2300b0d78d1",
                            SerialKey = 276536,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "413cbaaa-c7b9-44e1-9318-b24425769e33",
                            SerialKey = 299205,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "a6874228-2159-4b97-a042-b0e60a080205",
                            SerialKey = 750648,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "2b47573b-d251-458d-bccd-84f75cff7424",
                            SerialKey = 361798,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "7209509d-7260-46dc-8fca-923060a8b2d2",
                            SerialKey = 928298,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "0730abca-b6f6-4fb2-ae98-a551e4559dc2",
                            SerialKey = 764555,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "a7388ae2-a70c-48b5-bbf6-996ce2da3037",
                            SerialKey = 291700,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "69f38825-0b11-44c7-8103-6ec11b621df1",
                            SerialKey = 703980,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "2e9fee88-f456-4e7a-967c-f2ce9a072252",
                            SerialKey = 565003,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "fd4c4a49-e1d1-476f-bbee-7072cffb9471",
                            SerialKey = 310633,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "bea0cb52-856f-40be-a0d1-016c58165fe6",
                            SerialKey = 693153,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "dcc12f70-3d1f-4dd4-b041-b0ac70b29f34",
                            SerialKey = 823758,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "b6eedc77-3b43-437b-8bd7-81daa247029c",
                            SerialKey = 553634,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "68fda178-0605-420f-a79f-ef3be00f55dd",
                            SerialKey = 511643,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9f55cf3d-b2de-4eed-acbc-87696b500d5a",
                            SerialKey = 653951,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "71d3b611-6e4f-41a0-82cb-920f6fde5cf0",
                            SerialKey = 831337,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "0b200696-8542-438c-b776-5e49e916399c",
                            SerialKey = 190094,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "f125ced4-0edd-498e-818c-d1f57ea2eef8",
                            SerialKey = 558494,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "3a7c13c3-953f-467f-b39e-c3fa47a7b83b",
                            SerialKey = 559027,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "2b95da74-209a-417f-a049-7b2add1c8d4b",
                            SerialKey = 939033,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d1fcaea3-dbb6-401e-9972-7c6191f47345",
                            SerialKey = 520888,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "90e92183-04dd-438b-b6a0-39220df7a122",
                            SerialKey = 269361,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "4997f7ae-af9e-494a-8251-faa9d26d3bfe",
                            SerialKey = 591767,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "a8902983-2955-4368-8e3a-3a0f13fc70f9",
                            SerialKey = 264204,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "3ad26285-4477-4d04-b00c-ffc6eec4979f",
                            SerialKey = 260815,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "edf3eba9-c2bf-4779-8444-560a661d08ff",
                            SerialKey = 871296,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "a24a044c-8cb4-4b22-a3d3-5f4cdfcee245",
                            SerialKey = 916210,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "84335613-9c5f-46ae-b814-efe8288de522",
                            SerialKey = 130235,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "a0dbfcc9-a3e1-47dd-adea-6dd6d92c77d5",
                            SerialKey = 651682,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "41904f7c-a439-4eae-a89f-229df2c853b5",
                            SerialKey = 445931,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "12446a05-f495-45d0-82d0-d4064526d286",
                            SerialKey = 297861,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9b4ce11e-bf29-42ae-86b9-3800f7a2a813",
                            SerialKey = 791088,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "70d5c9ae-8c98-4083-906f-186c4fd06b7d",
                            SerialKey = 363248,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "53c34f72-4d63-49b7-b36f-a58a52bff3db",
                            SerialKey = 853665,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9c475688-0b1a-40d4-97c0-0fa80ffa701b",
                            SerialKey = 812379,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9adbf54f-6541-4178-aa6c-c27ad2efc5ef",
                            SerialKey = 133516,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "ef9a76c1-f9e4-49f4-b2f2-b47196e00802",
                            SerialKey = 587195,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "aa0245eb-6d04-4f4e-8172-88abfc0619ca",
                            SerialKey = 994056,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "977b0429-ec57-4af9-8a46-bd0c15626c2f",
                            SerialKey = 119991,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "e8ddd41a-1ad7-4161-bac3-5a6c94ce729c",
                            SerialKey = 454979,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "931d5db2-4068-4365-94cd-f7c328a16154",
                            SerialKey = 214941,
                            TimesUsed = 0
                        });
                });

            modelBuilder.Entity("Domain.Submission", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Submissions");
                });
#pragma warning restore 612, 618
        }
    }
}
