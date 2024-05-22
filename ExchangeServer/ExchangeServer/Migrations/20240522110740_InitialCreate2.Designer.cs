﻿// <auto-generated />
using System;
using ExchangeServer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExchangeServer.Migrations
{
    [DbContext(typeof(ExchangeServerContext))]
    [Migration("20240522110740_InitialCreate2")]
    partial class InitialCreate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExchangeServer.Models.Authentication", b =>
                {
                    b.Property<int>("AuthenticationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AuthenticationId"));

                    b.Property<string>("Password")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("TwoFa")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.HasKey("AuthenticationId");

                    b.ToTable("Authentication");
                });

            modelBuilder.Entity("ExchangeServer.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("City")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Country")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("ExternalOrderId")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Notes")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Phone")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("SecondName")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("State")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("StreetNumber")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.HasKey("ClientId");

                    b.HasIndex("ExternalOrderId")
                        .IsUnique();

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ExchangeServer.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DocumentId"));

                    b.Property<string>("AdditionalInfo")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DocumentName")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("ShipmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Type")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.HasKey("DocumentId");

                    b.HasIndex("ShipmentId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("ExchangeServer.Models.ExternalOrder", b =>
                {
                    b.Property<int>("ExternalOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ExternalOrderId"));

                    b.Property<string>("OrderId")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("ShipmentId")
                        .HasColumnType("integer");

                    b.HasKey("ExternalOrderId");

                    b.HasIndex("ShipmentId")
                        .IsUnique();

                    b.ToTable("ExternalOrder");
                });

            modelBuilder.Entity("ExchangeServer.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GroupId"));

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("GroupId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Group");
                });

            modelBuilder.Entity("ExchangeServer.Models.Label", b =>
                {
                    b.Property<int>("LabelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LabelId"));

                    b.Property<string>("Country")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ShipmentId")
                        .HasColumnType("integer");

                    b.Property<string>("ShippingId")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("ShippingType")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Status")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.HasKey("LabelId");

                    b.HasIndex("ShipmentId")
                        .IsUnique();

                    b.ToTable("Label");
                });

            modelBuilder.Entity("ExchangeServer.Models.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PermissionId"));

                    b.Property<bool>("Admin")
                        .HasColumnType("boolean");

                    b.Property<bool>("CreateGroups")
                        .HasColumnType("boolean");

                    b.Property<bool>("CreateUsers")
                        .HasColumnType("boolean");

                    b.Property<bool>("DeleteGroups")
                        .HasColumnType("boolean");

                    b.Property<bool>("DeleteUsers")
                        .HasColumnType("boolean");

                    b.Property<bool>("EditGroups")
                        .HasColumnType("boolean");

                    b.Property<bool>("EditUsers")
                        .HasColumnType("boolean");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<bool>("Packaging")
                        .HasColumnType("boolean");

                    b.Property<bool>("ProblemSolving")
                        .HasColumnType("boolean");

                    b.Property<bool>("Statistics")
                        .HasColumnType("boolean");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("PermissionId");

                    b.HasIndex("GroupId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("ExchangeServer.Models.Shipment", b =>
                {
                    b.Property<int>("ShipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ShipmentId"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.HasKey("ShipmentId");

                    b.ToTable("Shipment");
                });

            modelBuilder.Entity("ExchangeServer.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<int?>("AuthenticationId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("ExternalId")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("FirstName")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("SecondName")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("ShipmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.HasKey("UserId");

                    b.HasIndex("AuthenticationId");

                    b.HasIndex("ShipmentId")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("ExchangeServer.Models.Client", b =>
                {
                    b.HasOne("ExchangeServer.Models.ExternalOrder", "ExternalOrder")
                        .WithOne("Client")
                        .HasForeignKey("ExchangeServer.Models.Client", "ExternalOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExternalOrder");
                });

            modelBuilder.Entity("ExchangeServer.Models.Document", b =>
                {
                    b.HasOne("ExchangeServer.Models.Shipment", "Shipment")
                        .WithMany("Documents")
                        .HasForeignKey("ShipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("ExchangeServer.Models.ExternalOrder", b =>
                {
                    b.HasOne("ExchangeServer.Models.Shipment", "Shipment")
                        .WithOne("ExternalOrder")
                        .HasForeignKey("ExchangeServer.Models.ExternalOrder", "ShipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("ExchangeServer.Models.Group", b =>
                {
                    b.HasOne("ExchangeServer.Models.User", "User")
                        .WithOne("Group")
                        .HasForeignKey("ExchangeServer.Models.Group", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExchangeServer.Models.Label", b =>
                {
                    b.HasOne("ExchangeServer.Models.Shipment", "Shipment")
                        .WithOne("Label")
                        .HasForeignKey("ExchangeServer.Models.Label", "ShipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("ExchangeServer.Models.Permission", b =>
                {
                    b.HasOne("ExchangeServer.Models.Group", "Group")
                        .WithOne("Permission")
                        .HasForeignKey("ExchangeServer.Models.Permission", "GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExchangeServer.Models.User", "User")
                        .WithOne("Permission")
                        .HasForeignKey("ExchangeServer.Models.Permission", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExchangeServer.Models.User", b =>
                {
                    b.HasOne("ExchangeServer.Models.Authentication", "Authentication")
                        .WithMany()
                        .HasForeignKey("AuthenticationId");

                    b.HasOne("ExchangeServer.Models.Shipment", "Shipment")
                        .WithOne("User")
                        .HasForeignKey("ExchangeServer.Models.User", "ShipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authentication");

                    b.Navigation("Shipment");
                });

            modelBuilder.Entity("ExchangeServer.Models.ExternalOrder", b =>
                {
                    b.Navigation("Client");
                });

            modelBuilder.Entity("ExchangeServer.Models.Group", b =>
                {
                    b.Navigation("Permission");
                });

            modelBuilder.Entity("ExchangeServer.Models.Shipment", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("ExternalOrder");

                    b.Navigation("Label");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExchangeServer.Models.User", b =>
                {
                    b.Navigation("Group");

                    b.Navigation("Permission");
                });
#pragma warning restore 612, 618
        }
    }
}