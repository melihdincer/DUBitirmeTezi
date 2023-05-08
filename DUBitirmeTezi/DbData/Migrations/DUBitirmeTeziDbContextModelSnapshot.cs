﻿// <auto-generated />
using System;
using DUBitirmeTezi.DbData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DUBitirmeTezi.DbData.Migrations
{
    [DbContext(typeof(DUBitirmeTeziDbContext))]
    partial class DUBitirmeTeziDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.Enstitu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnstituName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Enstitus");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.EnstituDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Description2")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("EnstituId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnstituId");

                    b.ToTable("EnstituDetays");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.Fakulte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Fakultes");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.FakulteDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Description2")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("EducationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("FakulteId")
                        .HasColumnType("int");

                    b.Property<string>("Mission")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Vision")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("FakulteId");

                    b.ToTable("FakulteDetays");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.MeslekYuksekokulDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description1")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Description2")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("MeslekYuksekokuluId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MeslekYuksekokuluId");

                    b.ToTable("MeslekYuksekokulDetays");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.MeslekYuksekokulu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TechnicalSchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("MeslekYuksekokulus");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.Yuksekokul", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CollageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Yuksekokuls");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.YuksekokulDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description1")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Description2")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("YuksekokulId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YuksekokulId");

                    b.ToTable("YuksekokulDetays");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Anasayfa.ProjeSayilari", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("BapProjesi")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Enstitu")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Fakulte")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Koordinatorluk")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LisansProgrami")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LisansutsuProgrami")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MeslekYuksekokulu")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Patent")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SponsorluProje")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TubitakProjesi")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UygulamaArastirmaMerkezi")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Yuksekokul")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("ProjeSayilaris");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "Sanayi ve iş dünyası ile üniversiteyi ortak akıl, ortak hedef ve ortak başarı ilkeleri doğrultusunda ortak projelerle biraraya getirerek üniversitenin ve sanayinin gelişmesine katkıda bulunmaktır.",
                            BapProjesi = "500",
                            Baslik = "KENTİMİZ VE SANAYİ ELELE ÜRETEN ÜNİVERSİTE",
                            Enstitu = "4",
                            Fakulte = "14",
                            Koordinatorluk = "7",
                            LisansProgrami = "66",
                            LisansutsuProgrami = "71",
                            MeslekYuksekokulu = "17",
                            Patent = "300",
                            SponsorluProje = "5",
                            TubitakProjesi = "77",
                            UygulamaArastirmaMerkezi = "21",
                            Yuksekokul = "14"
                        });
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Duyurular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama1")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Aciklama2")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<string>("DuyuruAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("EklendigiTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.ToTable("Duyurulars");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Universitemiz.FotografGalerisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(MAX)");

                    b.HasKey("Id");

                    b.ToTable("FotografGalerisis");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Universitemiz.Yonetim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Unvan")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Yonetims");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Universitemiz.YonetimDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("YonetimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YonetimId");

                    b.ToTable("YonetimDetays");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.YetkiliGirisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<string>("DahiliTelefon")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("KullanicininEklendigiTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("YetkiliGirisis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Melih",
                            AktifMi = true,
                            DahiliTelefon = "1234",
                            KullaniciAdi = "MelihDincer",
                            KullanicininEklendigiTarih = new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mail = "melihdincer@gmail.com",
                            Sifre = "melih",
                            Soyad = "Dinçer",
                            Telefon = "05311048276"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "admin",
                            AktifMi = true,
                            DahiliTelefon = "1234",
                            KullaniciAdi = "admin",
                            KullanicininEklendigiTarih = new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Mail = "admin@gmail.com",
                            Sifre = "admin",
                            Soyad = "admin",
                            Telefon = "05055055555"
                        });
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.EnstituDetay", b =>
                {
                    b.HasOne("DUBitirmeTezi.Models.Akademik.Enstitu", "Enstitu")
                        .WithMany()
                        .HasForeignKey("EnstituId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enstitu");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.FakulteDetay", b =>
                {
                    b.HasOne("DUBitirmeTezi.Models.Akademik.Fakulte", "Fakulte")
                        .WithMany()
                        .HasForeignKey("FakulteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fakulte");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.MeslekYuksekokulDetay", b =>
                {
                    b.HasOne("DUBitirmeTezi.Models.Akademik.MeslekYuksekokulu", "MeslekYuksekokulu")
                        .WithMany()
                        .HasForeignKey("MeslekYuksekokuluId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeslekYuksekokulu");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Akademik.YuksekokulDetay", b =>
                {
                    b.HasOne("DUBitirmeTezi.Models.Akademik.Yuksekokul", "Yuksekokul")
                        .WithMany()
                        .HasForeignKey("YuksekokulId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yuksekokul");
                });

            modelBuilder.Entity("DUBitirmeTezi.Models.Universitemiz.YonetimDetay", b =>
                {
                    b.HasOne("DUBitirmeTezi.Models.Universitemiz.Yonetim", "YonetimTable")
                        .WithMany()
                        .HasForeignKey("YonetimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YonetimTable");
                });
#pragma warning restore 612, 618
        }
    }
}