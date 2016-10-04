﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DeSjoerd.FeedbackApp.Core.Models;

namespace DeSjoerd.FeedbackApp.Core.Migrations
{
    [DbContext(typeof(FeedbackDataContext))]
    partial class FeedbackDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeSjoerd.FeedbackApp.Core.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<int?>("Rating")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });
        }
    }
}
