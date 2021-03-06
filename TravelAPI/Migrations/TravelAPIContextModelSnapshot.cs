﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI;

namespace TravelAPI.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    partial class TravelAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TravelAPI.Models.AttractionModel", b =>
                {
                    b.Property<int>("AttractionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsChildFriendly")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("AttractionId");

                    b.HasIndex("CityId");

                    b.ToTable("Attractions");

                    b.HasData(
                        new
                        {
                            AttractionId = 1,
                            CityId = 1,
                            Information = "The empty niches of the Buddha statues dominate the Bamiyan valley. Carved in the 6th century, the two statues, standing 38m and 55m respectively, were the tallest standing statues of Buddha ever made.",
                            IsChildFriendly = true,
                            Location = "Bamiyan Valley, west of Kabul",
                            Name = "Buddha Niches",
                            Rating = 4
                        },
                        new
                        {
                            AttractionId = 2,
                            CityId = 1,
                            Information = "The Kabul Museum was once one of the greatest museums in the world. Its exhibits, ranging from Hellenistic gold coins to Buddhist statuary and Islamic bronzes, testified to Afghanistan’s location at the crossroads of Asia. After years of abuse during the civil war, help from the international community and the peerless dedication of its staff means the museum is slowly rising from the ashes. The museum opened in 1919, and was almost entirely stocked with items excavated in Afghanistan.",
                            IsChildFriendly = true,
                            Location = "Kabul",
                            Name = "Kabul Museum",
                            Rating = 3
                        });
                });

            modelBuilder.Entity("TravelAPI.Models.CityModel", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CountryId = 1,
                            Name = "Kabul",
                            Population = 4221532
                        },
                        new
                        {
                            CityId = 2,
                            CountryId = 1,
                            Name = "Balkh",
                            Population = 1382200
                        },
                        new
                        {
                            CityId = 3,
                            CountryId = 1,
                            Name = "Kandahar",
                            Population = 614118
                        },
                        new
                        {
                            CityId = 4,
                            CountryId = 2,
                            Name = "Belgrade",
                            Population = 1397939
                        },
                        new
                        {
                            CityId = 5,
                            CountryId = 2,
                            Name = "Novi Sad",
                            Population = 289128
                        },
                        new
                        {
                            CityId = 6,
                            CountryId = 2,
                            Name = "Niš",
                            Population = 185987
                        },
                        new
                        {
                            CityId = 7,
                            CountryId = 3,
                            Name = "Tokyo",
                            Population = 37435191
                        },
                        new
                        {
                            CityId = 8,
                            CountryId = 3,
                            Name = "Yokohama",
                            Population = 3725000
                        },
                        new
                        {
                            CityId = 9,
                            CountryId = 3,
                            Name = "Osaka",
                            Population = 2691000
                        },
                        new
                        {
                            CityId = 10,
                            CountryId = 4,
                            Name = "Kampala",
                            Population = 1680600
                        },
                        new
                        {
                            CityId = 11,
                            CountryId = 4,
                            Name = "Nansana",
                            Population = 365124
                        },
                        new
                        {
                            CityId = 12,
                            CountryId = 4,
                            Name = "Kira",
                            Population = 317157
                        },
                        new
                        {
                            CityId = 13,
                            CountryId = 5,
                            Name = "Bridgetown",
                            Population = 110000
                        },
                        new
                        {
                            CityId = 14,
                            CountryId = 5,
                            Name = "Speightstown",
                            Population = 3634
                        },
                        new
                        {
                            CityId = 15,
                            CountryId = 5,
                            Name = "Oistins",
                            Population = 2285
                        },
                        new
                        {
                            CityId = 16,
                            CountryId = 6,
                            Name = "Ottawa",
                            Population = 994837
                        },
                        new
                        {
                            CityId = 17,
                            CountryId = 6,
                            Name = "Toronto",
                            Population = 2930000
                        },
                        new
                        {
                            CityId = 18,
                            CountryId = 6,
                            Name = "Montreal",
                            Population = 1780000
                        },
                        new
                        {
                            CityId = 19,
                            CountryId = 7,
                            Name = "Brasilia",
                            Population = 4645943
                        },
                        new
                        {
                            CityId = 20,
                            CountryId = 7,
                            Name = "São Paulo",
                            Population = 21846507
                        },
                        new
                        {
                            CityId = 21,
                            CountryId = 7,
                            Name = "Rio de Janeiro",
                            Population = 13458075
                        },
                        new
                        {
                            CityId = 22,
                            CountryId = 8,
                            Name = "Auckland",
                            Population = 1657000
                        },
                        new
                        {
                            CityId = 23,
                            CountryId = 8,
                            Name = "Christchurch",
                            Population = 381500
                        },
                        new
                        {
                            CityId = 24,
                            CountryId = 8,
                            Name = "Wellington",
                            Population = 212700
                        });
                });

            modelBuilder.Entity("TravelAPI.Models.CountryInfoModel", b =>
                {
                    b.Property<int>("CountryInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<int>("BNP")
                        .HasColumnType("int");

                    b.Property<string>("CapitalCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Governance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.Property<bool>("RightHandTraffic")
                        .HasColumnType("bit");

                    b.Property<string>("TimeZone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryInfoId");

                    b.ToTable("CountryInfo");

                    b.HasData(
                        new
                        {
                            CountryInfoId = 1,
                            Area = 65200,
                            BNP = 19360,
                            CapitalCity = "Kabul",
                            Governance = "Islamic Republic",
                            Language = "Dari/Pashtu/Iranian",
                            NationalDay = "19/08",
                            Population = 50000,
                            RightHandTraffic = true,
                            TimeZone = "GMT+4:30"
                        },
                        new
                        {
                            CountryInfoId = 2,
                            Area = 88361,
                            BNP = 7246,
                            CapitalCity = "Belgrad",
                            Governance = "Parliamentary Republic",
                            Language = "Serbian",
                            NationalDay = "15/02",
                            Population = 80000,
                            RightHandTraffic = true,
                            TimeZone = "GMT+2"
                        },
                        new
                        {
                            CountryInfoId = 3,
                            Area = 377918,
                            BNP = 39289,
                            CapitalCity = "Tokyo",
                            Governance = "Constitutional Monarch",
                            Language = "Japanese/Ryukyuan/Ainu/Orok/Evenki/Nivkh",
                            NationalDay = "11/02",
                            Population = 126244,
                            RightHandTraffic = false,
                            TimeZone = "GMT+9"
                        },
                        new
                        {
                            CountryInfoId = 4,
                            Area = 241037,
                            BNP = 2746,
                            CapitalCity = "Kampala",
                            Governance = "Democratic State",
                            Language = "Bantu/Nilotic/Central Sudanic",
                            NationalDay = "18/05",
                            Population = 4272,
                            RightHandTraffic = false,
                            TimeZone = "GMT+3"
                        },
                        new
                        {
                            CountryInfoId = 5,
                            Area = 431,
                            BNP = 5145,
                            CapitalCity = "Bridgetown",
                            Governance = "Monarch",
                            Language = "English/Bajan Dialect",
                            NationalDay = "30/11",
                            Population = 286641,
                            RightHandTraffic = false,
                            TimeZone = "GMT-4"
                        },
                        new
                        {
                            CountryInfoId = 6,
                            Area = 9985000,
                            BNP = 1713,
                            CapitalCity = "Ottawa",
                            Governance = "Constitutional Monarchy",
                            Language = "French/English",
                            NationalDay = "01/07",
                            Population = 3759,
                            RightHandTraffic = true,
                            TimeZone = "GMT-4"
                        },
                        new
                        {
                            CountryInfoId = 7,
                            Area = 8516000,
                            BNP = 1869,
                            CapitalCity = "Brasília",
                            Governance = "Democratic Federal Republic",
                            Language = "Portuguese",
                            NationalDay = "07/09",
                            Population = 2095,
                            RightHandTraffic = true,
                            TimeZone = "GMT-3"
                        },
                        new
                        {
                            CountryInfoId = 8,
                            Area = 268021,
                            BNP = 2049,
                            CapitalCity = "Wellington",
                            Governance = "Unitary parliamentary constitutional monarchy",
                            Language = "Maori/English",
                            NationalDay = "06/02",
                            Population = 4886,
                            RightHandTraffic = false,
                            TimeZone = "GMT+12"
                        });
                });

            modelBuilder.Entity("TravelAPI.Models.CountryModel", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryInfoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelRestrictionId")
                        .HasColumnType("int");

                    b.HasKey("CountryId");

                    b.HasIndex("CountryInfoId");

                    b.HasIndex("TravelRestrictionId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryInfoId = 1,
                            Name = "Afghanistan",
                            TravelRestrictionId = 1
                        },
                        new
                        {
                            CountryId = 2,
                            CountryInfoId = 2,
                            Name = "Serbia",
                            TravelRestrictionId = 1
                        },
                        new
                        {
                            CountryId = 3,
                            CountryInfoId = 3,
                            Name = "Japan",
                            TravelRestrictionId = 1
                        },
                        new
                        {
                            CountryId = 4,
                            CountryInfoId = 4,
                            Name = "Uganda",
                            TravelRestrictionId = 1
                        },
                        new
                        {
                            CountryId = 5,
                            CountryInfoId = 5,
                            Name = "Barbados",
                            TravelRestrictionId = 1
                        },
                        new
                        {
                            CountryId = 6,
                            CountryInfoId = 6,
                            Name = "Canada",
                            TravelRestrictionId = 1
                        },
                        new
                        {
                            CountryId = 7,
                            CountryInfoId = 7,
                            Name = "Brazil",
                            TravelRestrictionId = 1
                        },
                        new
                        {
                            CountryId = 8,
                            CountryInfoId = 8,
                            Name = "New Zealand",
                            TravelRestrictionId = 1
                        });
                });

            modelBuilder.Entity("TravelAPI.Models.TravelRestrictionModel", b =>
                {
                    b.Property<int>("TravelRestrictionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsCitizenshipAllowed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFamilyVisitAllowed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsImmigrationAllowed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTourismAllowed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVisaNeeded")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWorkTravelAllowed")
                        .HasColumnType("bit");

                    b.Property<int>("RiskLevel")
                        .HasColumnType("int");

                    b.HasKey("TravelRestrictionId");

                    b.ToTable("TravelRestrictions");

                    b.HasData(
                        new
                        {
                            TravelRestrictionId = 1,
                            IsCitizenshipAllowed = true,
                            IsFamilyVisitAllowed = true,
                            IsImmigrationAllowed = true,
                            IsTourismAllowed = false,
                            IsVisaNeeded = true,
                            IsWorkTravelAllowed = true,
                            RiskLevel = 4
                        });
                });

            modelBuilder.Entity("TravelAPI.Models.AttractionModel", b =>
                {
                    b.HasOne("TravelAPI.Models.CityModel", "City")
                        .WithMany("Attractions")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelAPI.Models.CityModel", b =>
                {
                    b.HasOne("TravelAPI.Models.CountryModel", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelAPI.Models.CountryModel", b =>
                {
                    b.HasOne("TravelAPI.Models.CountryInfoModel", "CountryInfo")
                        .WithMany()
                        .HasForeignKey("CountryInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelAPI.Models.TravelRestrictionModel", "TravelRestriction")
                        .WithMany()
                        .HasForeignKey("TravelRestrictionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
