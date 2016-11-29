using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreWeb2015r2.Models;

namespace CoreWeb2015r2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("CoreWeb2015r2.Models.Conference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<decimal>("TicketPrice");

                    b.HasKey("Id");

                    b.ToTable("Conferences");
                });

            modelBuilder.Entity("CoreWeb2015r2.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ConferenceId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("CoreWeb2015r2.Models.Session", b =>
                {
                    b.HasOne("CoreWeb2015r2.Models.Conference", "Conference")
                        .WithMany("Sessions")
                        .HasForeignKey("ConferenceId");
                });
        }
    }
}
