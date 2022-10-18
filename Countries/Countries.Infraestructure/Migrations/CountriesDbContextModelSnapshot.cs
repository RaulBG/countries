﻿// <auto-generated />
using System;
using Countries.Infraestructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Countries.Infraestructure.Migrations
{
    [DbContext(typeof(CountriesDbContext))]
    partial class CountriesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Countries.Domain.Models.CapitalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Latlng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CapitalInfo");
                });

            modelBuilder.Entity("Countries.Domain.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Side")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Signs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Countries.Domain.Models.CoatOfArms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoatOfArms");
                });

            modelBuilder.Entity("Countries.Domain.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AltSpellings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Area")
                        .HasColumnType("bigint");

                    b.Property<string>("Borders")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Capital")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CapitalInfoId")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Cca2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cca3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Ccn3")
                        .HasColumnType("bigint");

                    b.Property<string>("Cioc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoatOfArmsId")
                        .HasColumnType("int");

                    b.Property<string>("Continents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrenciesId")
                        .HasColumnType("int");

                    b.Property<int>("DemonymsId")
                        .HasColumnType("int");

                    b.Property<string>("Fifa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlagsId")
                        .HasColumnType("int");

                    b.Property<int>("GiniId")
                        .HasColumnType("int");

                    b.Property<int>("IddId")
                        .HasColumnType("int");

                    b.Property<bool>("Independent")
                        .HasColumnType("bit");

                    b.Property<bool>("Landlocked")
                        .HasColumnType("bit");

                    b.Property<int>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<string>("Latlng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MapsId")
                        .HasColumnType("int");

                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.Property<long>("Population")
                        .HasColumnType("bigint");

                    b.Property<int>("PostalCodeId")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartOfWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subregion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timezones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tld")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UnMember")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CapitalInfoId");

                    b.HasIndex("CarId");

                    b.HasIndex("CoatOfArmsId");

                    b.HasIndex("CurrenciesId");

                    b.HasIndex("DemonymsId");

                    b.HasIndex("FlagsId");

                    b.HasIndex("GiniId");

                    b.HasIndex("IddId");

                    b.HasIndex("LanguagesId");

                    b.HasIndex("MapsId");

                    b.HasIndex("NameId");

                    b.HasIndex("PostalCodeId");

                    b.ToTable("contries");
                });

            modelBuilder.Entity("Countries.Domain.Models.Currencies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PenId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PenId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Countries.Domain.Models.Demonyms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("designationsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("designationsId");

                    b.ToTable("Demonyms");
                });

            modelBuilder.Entity("Countries.Domain.Models.Designations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("Countries.Domain.Models.DesignationsAttributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DesignationsId")
                        .HasColumnType("int");

                    b.Property<string>("F")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("M")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DesignationsId");

                    b.ToTable("DesignationsAttributes");
                });

            modelBuilder.Entity("Countries.Domain.Models.Flags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Flags");
                });

            modelBuilder.Entity("Countries.Domain.Models.Gini", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("The2019")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Gini");
                });

            modelBuilder.Entity("Countries.Domain.Models.Idd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Root")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suffixes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Idd");
                });

            modelBuilder.Entity("Countries.Domain.Models.Languages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aym")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Que")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Countries.Domain.Models.Maps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GoogleMaps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenStreetMaps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("Countries.Domain.Models.Name", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Common")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Official")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("names");
                });

            modelBuilder.Entity("Countries.Domain.Models.NativeNameTranslations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Common")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NameId")
                        .HasColumnType("int");

                    b.Property<string>("Official")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NameId");

                    b.ToTable("NativeNameTranslations");
                });

            modelBuilder.Entity("Countries.Domain.Models.Pen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pen");
                });

            modelBuilder.Entity("Countries.Domain.Models.PostalCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PostalCode");
                });

            modelBuilder.Entity("Countries.Domain.Models.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Common")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Official")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Translation");
                });

            modelBuilder.Entity("Countries.Domain.Models.Country", b =>
                {
                    b.HasOne("Countries.Domain.Models.CapitalInfo", "CapitalInfo")
                        .WithMany()
                        .HasForeignKey("CapitalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.CoatOfArms", "CoatOfArms")
                        .WithMany()
                        .HasForeignKey("CoatOfArmsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.Currencies", "Currencies")
                        .WithMany()
                        .HasForeignKey("CurrenciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.Demonyms", "Demonyms")
                        .WithMany()
                        .HasForeignKey("DemonymsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.Flags", "Flags")
                        .WithMany()
                        .HasForeignKey("FlagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.Gini", "Gini")
                        .WithMany()
                        .HasForeignKey("GiniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.Idd", "Idd")
                        .WithMany()
                        .HasForeignKey("IddId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.Languages", "Languages")
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.Maps", "Maps")
                        .WithMany()
                        .HasForeignKey("MapsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.Name", "Name")
                        .WithMany()
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Countries.Domain.Models.PostalCode", "PostalCode")
                        .WithMany()
                        .HasForeignKey("PostalCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CapitalInfo");

                    b.Navigation("Car");

                    b.Navigation("CoatOfArms");

                    b.Navigation("Currencies");

                    b.Navigation("Demonyms");

                    b.Navigation("Flags");

                    b.Navigation("Gini");

                    b.Navigation("Idd");

                    b.Navigation("Languages");

                    b.Navigation("Maps");

                    b.Navigation("Name");

                    b.Navigation("PostalCode");
                });

            modelBuilder.Entity("Countries.Domain.Models.Currencies", b =>
                {
                    b.HasOne("Countries.Domain.Models.Pen", "Pen")
                        .WithMany()
                        .HasForeignKey("PenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pen");
                });

            modelBuilder.Entity("Countries.Domain.Models.Demonyms", b =>
                {
                    b.HasOne("Countries.Domain.Models.Designations", "designations")
                        .WithMany()
                        .HasForeignKey("designationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("designations");
                });

            modelBuilder.Entity("Countries.Domain.Models.DesignationsAttributes", b =>
                {
                    b.HasOne("Countries.Domain.Models.Designations", null)
                        .WithMany("DesignationsAttributes")
                        .HasForeignKey("DesignationsId");
                });

            modelBuilder.Entity("Countries.Domain.Models.NativeNameTranslations", b =>
                {
                    b.HasOne("Countries.Domain.Models.Name", null)
                        .WithMany("NativeNameTranslations")
                        .HasForeignKey("NameId");
                });

            modelBuilder.Entity("Countries.Domain.Models.Translation", b =>
                {
                    b.HasOne("Countries.Domain.Models.Country", null)
                        .WithMany("Translations")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("Countries.Domain.Models.Country", b =>
                {
                    b.Navigation("Translations");
                });

            modelBuilder.Entity("Countries.Domain.Models.Designations", b =>
                {
                    b.Navigation("DesignationsAttributes");
                });

            modelBuilder.Entity("Countries.Domain.Models.Name", b =>
                {
                    b.Navigation("NativeNameTranslations");
                });
#pragma warning restore 612, 618
        }
    }
}
