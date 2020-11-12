﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = "e65cef35-2b18-42a7-b8e1-5edf0411aa28",
                            SerialKey = 518711,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "f2228d88-aa70-41ba-804e-723904e1075d",
                            SerialKey = 558404,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "7b77e49c-114a-4e88-8b58-7176289a928e",
                            SerialKey = 822759,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "0c7d359c-6307-49cd-8c06-aa86a4395a3e",
                            SerialKey = 559063,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "46301537-70dd-463d-b110-a9a911e54c36",
                            SerialKey = 997390,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "e8bf8ba3-5f8c-4bc2-a7a8-42d31d540894",
                            SerialKey = 653867,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "dbc63fd3-5a5d-4b92-b268-b7a6f62a01d1",
                            SerialKey = 633007,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "41399652-2c9d-4c04-a364-bda50b1cb350",
                            SerialKey = 788968,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "c16d8786-7115-4838-880f-b197d9045268",
                            SerialKey = 494063,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "3e780bed-3c1a-48d4-b22c-cc46b47bfe77",
                            SerialKey = 112692,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "2fff297f-6cb9-4b01-a22e-0c17f101d4f8",
                            SerialKey = 182362,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "1b8341e0-7517-4987-81b9-f3cbed6142d7",
                            SerialKey = 181140,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "915a391b-1fab-4f3f-9032-fa0659cf1c86",
                            SerialKey = 191207,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "5d3deb82-ba42-4d55-9cbf-a0b63c1254ec",
                            SerialKey = 369416,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "59ff70c8-5b1e-4999-81ea-7bcf1d6e581b",
                            SerialKey = 710185,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "25b90053-0f96-457e-ab17-1e5c546e532b",
                            SerialKey = 965916,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "6c536c63-565b-4e61-914f-80eadd1efcf3",
                            SerialKey = 693512,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "ac44a5ca-dda6-4b3e-8de5-cb0b669307f7",
                            SerialKey = 474007,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "fcf8f43f-05f9-4b23-b02c-cc849cd8dedc",
                            SerialKey = 943885,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "59d9eb7e-8011-4f82-bcb3-d63742b18f41",
                            SerialKey = 289238,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "125ddb96-d990-466a-8126-187a2e66d400",
                            SerialKey = 956290,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "3c6becb7-4b5e-4670-8696-e4fbfcf4622d",
                            SerialKey = 490146,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "51cd2c5e-cebf-4057-90e2-e1355029d642",
                            SerialKey = 505932,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "b194ec46-b0f6-4936-9fec-68131ca82cf9",
                            SerialKey = 812562,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9ae55db3-4112-4877-b7a6-a1c7397801b8",
                            SerialKey = 441665,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "a9f2230b-e61f-48bd-a1ec-c2bdacd83ba5",
                            SerialKey = 171088,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "867faca0-cd89-4755-b34e-c0c8d6677dd0",
                            SerialKey = 825226,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "2fe3d78b-d518-49bd-b7fc-8ea3b3e5c095",
                            SerialKey = 538763,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "3aac48ce-107e-4051-b0c8-833733baafbc",
                            SerialKey = 524419,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "f834e3ff-b256-4d8b-b32d-f1148797a0d9",
                            SerialKey = 472985,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "24e23d52-dfe7-44cf-9428-bc3206f7b55a",
                            SerialKey = 828373,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "51905f69-9c96-4267-86b7-9ffb76b02936",
                            SerialKey = 198731,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "1ac798ed-3f23-4c35-9025-ad6f17bb31c4",
                            SerialKey = 100985,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "12c8412f-fe1a-413b-abf5-0454b237894a",
                            SerialKey = 726143,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "bbc7c06c-8802-4a58-9603-0fdfef6712ad",
                            SerialKey = 627727,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "fb02f3be-6f06-4375-b83a-6f9b9e396b02",
                            SerialKey = 711872,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "eed59368-c77f-4d5e-a152-5e579c14a972",
                            SerialKey = 586101,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "6247a86e-0290-43f4-a162-e927edaf0a1e",
                            SerialKey = 330453,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "f24f5ac0-340f-4945-862b-890c139e0c22",
                            SerialKey = 238034,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "34879e96-7195-44a2-af62-84b08e7f30a0",
                            SerialKey = 977745,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d7959937-e0c5-483b-a9e2-8a62b6184521",
                            SerialKey = 837735,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "64055eb8-d0f5-46f1-aa72-d219f3ae65de",
                            SerialKey = 472701,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "4db76410-c91f-4536-bd76-31a0a5eadb6f",
                            SerialKey = 909558,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "45063d64-4aef-4e2d-b0ae-a29be009494e",
                            SerialKey = 212762,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "f5ef93e9-33fb-4498-a7c4-c0b662e2a2b5",
                            SerialKey = 767889,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "6a4ea392-8e39-496d-aaf9-efa449342817",
                            SerialKey = 279440,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "116c1c10-55c3-43db-96e9-03e9b4461498",
                            SerialKey = 926718,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "82b5dc94-b040-4479-9277-da8afe46cb54",
                            SerialKey = 751389,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "89874e9c-7137-47d1-811a-3b8373fc7c3b",
                            SerialKey = 387417,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d3d59bfc-5351-47c6-b95a-998fb2ef3a31",
                            SerialKey = 630446,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "41fe8f63-6ad2-4894-97ef-39b1e5473f73",
                            SerialKey = 858511,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "6625322e-89c3-44af-844f-9e45426a353e",
                            SerialKey = 850279,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9ab75593-7ee3-431a-a261-a9680e3cafb7",
                            SerialKey = 159151,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "8c5d2215-92ea-4e8d-9ce9-735741a7576e",
                            SerialKey = 850463,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d7eccc89-c757-4837-b263-e290af082b1f",
                            SerialKey = 792659,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "36f80212-512f-447e-80ed-1b7b6346b627",
                            SerialKey = 128565,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "f2b57a10-a158-4811-a967-262c57aab5b6",
                            SerialKey = 152471,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "62d6f4bb-59f8-4fc9-ba84-336a8016a8eb",
                            SerialKey = 110197,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "64918d82-7907-4c21-a1ef-883f7eaed366",
                            SerialKey = 217397,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "80bcabcb-313e-4f11-9d30-e5dd0cdadcbf",
                            SerialKey = 926302,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "5471f025-a081-43aa-a6ea-9cb326337b2f",
                            SerialKey = 828639,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "dfa5b6ba-f3a8-47b0-8ded-5659ba5385cf",
                            SerialKey = 194244,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d26b6e99-83d0-4b8d-9064-788d67188814",
                            SerialKey = 364548,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d59bcd7a-7f54-4f68-adf4-e38c2876f97b",
                            SerialKey = 121077,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "4187f2e1-d8eb-4e02-a65a-35f4487ae59f",
                            SerialKey = 284318,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "3e52f525-b858-45bf-9a43-f0c11b9a1e66",
                            SerialKey = 983630,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "996ab793-454b-4109-95ce-e620ad1cb83b",
                            SerialKey = 180154,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "626cc23b-85d4-4896-b9f9-50238e4557b6",
                            SerialKey = 465062,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "68cea172-b014-49b9-966a-0a37d4a5ffc3",
                            SerialKey = 741688,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9dae5f4d-5ded-4d9c-8952-97062e9e7f5a",
                            SerialKey = 998312,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "89282cdb-ee41-4585-8894-65d4df4a9654",
                            SerialKey = 479814,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "613942c7-03a0-45bd-846b-02382365181e",
                            SerialKey = 463059,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "ac210891-bf98-4204-8b56-cc1e7fc191f4",
                            SerialKey = 335972,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "40e71aba-7bdc-40a6-9da7-1e79c3e74b11",
                            SerialKey = 966139,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "dec38ab0-5b71-4bc1-9003-c2f307f5e43c",
                            SerialKey = 451501,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "81a16fb2-26bb-4387-91dc-38e00f34bc48",
                            SerialKey = 583588,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "192c5526-25fe-45ee-ade0-763daa83f4fb",
                            SerialKey = 580587,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "eae58974-1d6b-4695-8cf1-051d1fa38a09",
                            SerialKey = 393170,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "662fc1b6-cb8e-4f6e-b06e-02c054921028",
                            SerialKey = 144672,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d9cb7892-c0fc-4dbd-b9e9-233a159b0411",
                            SerialKey = 262225,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "098736fb-38f4-46d9-a561-365ee0083363",
                            SerialKey = 244368,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "0ead175a-4fce-4e53-b72d-e0ae44c26e18",
                            SerialKey = 173836,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "4ee2b5a0-5711-466f-b1ad-89ff26dcde7a",
                            SerialKey = 251345,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "88e2639c-4862-439f-aa24-1bd4d103a3d8",
                            SerialKey = 893972,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "97da97ef-c5d1-4019-902b-74fe603ac93f",
                            SerialKey = 614473,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "659d80e3-514e-4e7c-8811-9291706d021c",
                            SerialKey = 978092,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "be1d14f4-f016-4ad1-a8bc-cb5190a0417e",
                            SerialKey = 139579,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "9cb09f13-072f-445e-952f-8d8431913d5a",
                            SerialKey = 250521,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "c1955c17-fd10-4990-8a2f-0e7e9f5f811c",
                            SerialKey = 933482,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "87c27e62-427a-4c1f-945d-8b7283497f3c",
                            SerialKey = 599161,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "cc4cd8f2-4f4e-4b4e-bfd7-cbf5e10e3c84",
                            SerialKey = 659400,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "fe58a45f-d436-4326-af6d-828e0d154d8e",
                            SerialKey = 575903,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "1e85bee5-0bd3-437e-87be-1b2797fea0ff",
                            SerialKey = 213055,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "985ca1a3-b9a8-4ca4-9551-088d888d1a54",
                            SerialKey = 311731,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "49698db3-d31f-4dbe-bba4-0ec6eddd3eac",
                            SerialKey = 249105,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "39cdc4c4-4931-4b6e-9f92-b603bd84ef0e",
                            SerialKey = 743491,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "867397ae-5b98-482f-8eaf-6b35cc80e577",
                            SerialKey = 208152,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "8e8a98fd-1e9c-48a4-89a7-017e08056399",
                            SerialKey = 888480,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "f558543a-51f3-4da9-bcad-23172c087417",
                            SerialKey = 928443,
                            TimesUsed = 0
                        },
                        new
                        {
                            Id = "d643ad6c-c53b-40c0-bb9a-7df452fd73e4",
                            SerialKey = 784258,
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

                    b.Property<string>("SerialNumberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SerialNumberId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Domain.Submission", b =>
                {
                    b.HasOne("Domain.SerialNumber", "SerialNumber")
                        .WithMany()
                        .HasForeignKey("SerialNumberId");

                    b.Navigation("SerialNumber");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
