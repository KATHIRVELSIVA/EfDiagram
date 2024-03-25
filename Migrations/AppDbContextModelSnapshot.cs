﻿// <auto-generated />
using System;
using EfDiagram.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfDiagram.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("EfDiagram.Models.AddOnPolicyModel", b =>
                {
                    b.Property<int>("AddOnPolicyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AddOnPolicyID"));

                    b.Property<string>("AddOnPolicyDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("AddOnPolicyName")
                        .HasColumnType("longtext");

                    b.Property<float?>("AddOnPrice")
                        .HasColumnType("float");

                    b.Property<bool?>("AddOnStatus")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("AddOnPolicyID");

                    b.ToTable("AddOnPolicy");
                });

            modelBuilder.Entity("EfDiagram.Models.AdminModel", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AdminID"));

                    b.Property<string>("EmailID")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.HasKey("AdminID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("EfDiagram.Models.ClaimAmountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddOnPolicyID")
                        .HasColumnType("int");

                    b.Property<double>("ClaimAmount")
                        .HasColumnType("double");

                    b.Property<int>("ClaimID")
                        .HasColumnType("int");

                    b.Property<int>("PolicyID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(95)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddOnPolicyID");

                    b.HasIndex("ClaimID");

                    b.HasIndex("PolicyID");

                    b.HasIndex("Status")
                        .IsUnique();

                    b.HasIndex("VehicleId");

                    b.ToTable("ClaimAmounts");
                });

            modelBuilder.Entity("EfDiagram.Models.ClaimModel", b =>
                {
                    b.Property<int>("ClaimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ClaimID"));

                    b.Property<int>("ApplyId")
                        .HasColumnType("int");

                    b.Property<string>("ClaimName")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimReason")
                        .HasColumnType("longtext");

                    b.Property<string>("FIRNo")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(95)");

                    b.HasKey("ClaimID");

                    b.HasIndex("ApplyId");

                    b.HasIndex("Status")
                        .IsUnique();

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("EfDiagram.Models.InsuranceApplyModel", b =>
                {
                    b.Property<int>("ApplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ApplyId"));

                    b.Property<int>("AddOnPolicyID")
                        .HasColumnType("int");

                    b.Property<int>("PolicyID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("VehicleID")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.HasKey("ApplyId");

                    b.HasIndex("AddOnPolicyID");

                    b.HasIndex("PolicyID");

                    b.HasIndex("UserID");

                    b.HasIndex("VehicleID")
                        .IsUnique();

                    b.ToTable("InsuranceApply");
                });

            modelBuilder.Entity("EfDiagram.Models.PdfDocumentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("FIelData")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("PdfDocument");
                });

            modelBuilder.Entity("EfDiagram.Models.PolicyModel", b =>
                {
                    b.Property<int>("PolicyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PolicyID"));

                    b.Property<string>("PolicyDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("PolicyName")
                        .HasColumnType("longtext");

                    b.Property<float>("PolicyPrice")
                        .HasColumnType("float");

                    b.Property<bool?>("PolicyStatus")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("PolicyID");

                    b.ToTable("Policy");
                });

            modelBuilder.Entity("EfDiagram.Models.UserModel", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserID"));

                    b.Property<long>("AadharNo")
                        .HasColumnType("bigint");

                    b.Property<long>("BankAccNo")
                        .HasColumnType("bigint");

                    b.Property<string>("EmailID")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<long>("PhoneNo")
                        .HasColumnType("bigint");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.Property<bool>("status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("UserID");

                    b.HasIndex("EmailID")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("EfDiagram.Models.VehicleModel", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("VehicleId"));

                    b.Property<int?>("IDVvalue")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("VehicleName")
                        .HasColumnType("longtext");

                    b.Property<string>("VehicleNo")
                        .HasColumnType("longtext");

                    b.Property<string>("VehicleType")
                        .HasColumnType("longtext");

                    b.Property<string>("YearOfMake")
                        .HasColumnType("longtext");

                    b.HasKey("VehicleId");

                    b.HasIndex("UserID");

                    b.HasIndex("VehicleId")
                        .IsUnique();

                    b.ToTable("VehicleModel");
                });

            modelBuilder.Entity("EfDiagram.Models.ClaimAmountModel", b =>
                {
                    b.HasOne("EfDiagram.Models.AddOnPolicyModel", "AddOnPolicyId")
                        .WithMany()
                        .HasForeignKey("AddOnPolicyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfDiagram.Models.ClaimModel", "ClaimId")
                        .WithMany()
                        .HasForeignKey("ClaimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfDiagram.Models.PolicyModel", "PolicyId")
                        .WithMany()
                        .HasForeignKey("PolicyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfDiagram.Models.VehicleModel", "VehicleID")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddOnPolicyId");

                    b.Navigation("ClaimId");

                    b.Navigation("PolicyId");

                    b.Navigation("VehicleID");
                });

            modelBuilder.Entity("EfDiagram.Models.ClaimModel", b =>
                {
                    b.HasOne("EfDiagram.Models.InsuranceApplyModel", "InsuranceApplyId")
                        .WithMany()
                        .HasForeignKey("ApplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsuranceApplyId");
                });

            modelBuilder.Entity("EfDiagram.Models.InsuranceApplyModel", b =>
                {
                    b.HasOne("EfDiagram.Models.AddOnPolicyModel", "AddOnPolicy")
                        .WithMany()
                        .HasForeignKey("AddOnPolicyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfDiagram.Models.PolicyModel", "PolicyModelID")
                        .WithMany()
                        .HasForeignKey("PolicyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfDiagram.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddOnPolicy");

                    b.Navigation("PolicyModelID");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("EfDiagram.Models.PdfDocumentModel", b =>
                {
                    b.HasOne("EfDiagram.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EfDiagram.Models.VehicleModel", b =>
                {
                    b.HasOne("EfDiagram.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("UserModel");
                });
#pragma warning restore 612, 618
        }
    }
}
