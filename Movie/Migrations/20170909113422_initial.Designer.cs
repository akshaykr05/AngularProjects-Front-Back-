using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Movie.Models;

namespace Movie.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20170909113422_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movie.Models.MovieDetails", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("comment");

                    b.Property<int>("id");

                    b.Property<string>("poster_path");

                    b.Property<string>("release_date");

                    b.Property<string>("title");

                    b.HasKey("movieId");

                    b.ToTable("Movies");
                });
        }
    }
}
