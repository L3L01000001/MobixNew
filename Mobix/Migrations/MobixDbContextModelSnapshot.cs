﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mobix.Data;

#nullable disable

namespace Mobix.Migrations
{
    [DbContext(typeof(MobixDbContext))]
    partial class MobixDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "555346cf-2ab7-4405-bad7-423adab7c7c6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "7a6ace2e-440d-44e5-ae36-1a5816ab74b8",
                            Name = "Korisnik",
                            NormalizedName = "KORISNIK"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        });
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Mobix.EntityModels.Dobavljac", b =>
                {
                    b.Property<int>("DobavljacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DobavljacID"), 1L, 1);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DobavljacID");

                    b.ToTable("Dobavljaci");

                    b.HasData(
                        new
                        {
                            DobavljacID = 1,
                            Adresa = "Dr Ante Starcevica 51, Mostar",
                            BrojTelefona = "065111111",
                            Naziv = "Najbolji Dobavljac1"
                        },
                        new
                        {
                            DobavljacID = 2,
                            Adresa = "Dr Ante Starcevica 52, Mostar",
                            BrojTelefona = "062111111",
                            Naziv = "Najbolji Dobavljac2"
                        });
                });

            modelBuilder.Entity("Mobix.EntityModels.Korisnik", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "14dc27ce-c45b-431b-b821-49c913c639a5",
                            Email = "admin@mobix.com",
                            EmailConfirmed = true,
                            Ime = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MOBIX.COM",
                            NormalizedUserName = "ADMIN@MOBIX.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEA+t6A9Ynpjmrt77NsfufGRCEDVkveFAQtwQgX1BQWfUwkyRPziwqupC7S0jZj7tFA==",
                            PhoneNumberConfirmed = false,
                            Prezime = "Admin",
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin@mobix.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6de2246-1fe1-4881-94ec-8870ff44d227",
                            Email = "korisnik@mobix.com",
                            EmailConfirmed = true,
                            Ime = "Korisnik",
                            LockoutEnabled = false,
                            NormalizedEmail = "KORISNIK@MOBIX.COM",
                            NormalizedUserName = "KORISNIK@MOBIX.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECX98XHmcB9UPIg74UlXhw7E0DTs9IEN2EwqQs0nZRQ/vvfuTrKfRWtyhY4uIxoFvQ==",
                            PhoneNumberConfirmed = false,
                            Prezime = "Korisnik",
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "korisnik@mobix.com"
                        });
                });

            modelBuilder.Entity("Mobix.EntityModels.Korpa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("KorisnikId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikId1");

                    b.ToTable("Korpa");
                });

            modelBuilder.Entity("Mobix.EntityModels.KorpaStavke", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("KorpaId")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorpaId");

                    b.HasIndex("ProizvodID");

                    b.ToTable("KorpaStavke");
                });

            modelBuilder.Entity("MobixWebShop.EntityModels.Proizvod", b =>
                {
                    b.Property<int>("ProizvodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProizvodID"), 1L, 1);

                    b.Property<int>("Cijena")
                        .HasColumnType("int");

                    b.Property<int?>("DobavljacProizvodaID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlikaProizvoda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProizvodID");

                    b.HasIndex("DobavljacProizvodaID");

                    b.ToTable("Proizvodi");

                    b.HasData(
                        new
                        {
                            ProizvodID = 1,
                            Cijena = 700,
                            DobavljacProizvodaID = 2,
                            Kolicina = 1,
                            Naziv = "iPhone 11",
                            Opis = "Apple iPhone 11 GREEN \r\n-Memorija 128 GB\r\n-Mobitel je kao nov (stanje 10/10)\r\n-Svi dijelovi originalni, ništa mijenjano \r\n-Face id i True tone rade \r\n-Apsolutno sve ispravno i otključano\r\n-Fabrička kutija, originalne Apple slušalice, kabal za punjenje, zaštitno staklo, papiri",
                            SlikaProizvoda = "https://pcmarket.ba/wp-content/uploads/2021/09/Apple-iPhone-11-64GB-Green..jpg",
                            Stanje = "Polovno"
                        });
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
                    b.HasOne("Mobix.EntityModels.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Mobix.EntityModels.Korisnik", null)
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

                    b.HasOne("Mobix.EntityModels.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Mobix.EntityModels.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mobix.EntityModels.Korpa", b =>
                {
                    b.HasOne("Mobix.EntityModels.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId1");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Mobix.EntityModels.KorpaStavke", b =>
                {
                    b.HasOne("Mobix.EntityModels.Korpa", "Korpa")
                        .WithMany("KorpaStavke")
                        .HasForeignKey("KorpaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MobixWebShop.EntityModels.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korpa");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("MobixWebShop.EntityModels.Proizvod", b =>
                {
                    b.HasOne("Mobix.EntityModels.Dobavljac", "DobavljacProizvoda")
                        .WithMany()
                        .HasForeignKey("DobavljacProizvodaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DobavljacProizvoda");
                });

            modelBuilder.Entity("Mobix.EntityModels.Korpa", b =>
                {
                    b.Navigation("KorpaStavke");
                });
#pragma warning restore 612, 618
        }
    }
}
