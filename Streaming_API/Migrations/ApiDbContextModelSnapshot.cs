﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Streaming_API.Data;

#nullable disable

namespace StreamingAPI.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Streaming_API.Models.Broadcaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfileImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Broadcasters", (string)null);
                });

            modelBuilder.Entity("Streaming_API.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BroadcasterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BroadcasterId");

                    b.ToTable("Videos", (string)null);
                });

            modelBuilder.Entity("Streaming_API.Models.Video", b =>
                {
                    b.HasOne("Streaming_API.Models.Broadcaster", "Broadcaster")
                        .WithMany("Videos")
                        .HasForeignKey("BroadcasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Broadcaster");
                });

            modelBuilder.Entity("Streaming_API.Models.Broadcaster", b =>
                {
                    b.Navigation("Videos");
                });
#pragma warning restore 612, 618
        }
    }
}
