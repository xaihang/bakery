﻿// <auto-generated />
using DotnetBakery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DotnetBakery.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230329184234_MakeRelationToBaker")]
    partial class MakeRelationToBaker
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DotnetBakery.Models.Baker", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Bakers");
                });

            modelBuilder.Entity("DotnetBakery.Models.Bread", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("bakedById")
                        .HasColumnType("integer");

                    b.Property<int>("count")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("bakedById");

                    b.ToTable("Breads");
                });

            modelBuilder.Entity("DotnetBakery.Models.Bread", b =>
                {
                    b.HasOne("DotnetBakery.Models.Baker", "bakedBy")
                        .WithMany()
                        .HasForeignKey("bakedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bakedBy");
                });
#pragma warning restore 612, 618
        }
    }
}
