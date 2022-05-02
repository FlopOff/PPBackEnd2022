﻿// <auto-generated />
using System;
using AT1__PerfectPolicy_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AT1__PerfectPolicy_.Migrations
{
    [DbContext(typeof(QuizContext))]
    partial class QuizContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AT1__PerfectPolicy_.Models.Option", b =>
                {
                    b.Property<int>("OptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionOrderByLetter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionOrderByNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OptionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("OptionID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("AT1__PerfectPolicy_.Models.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionTopic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizID")
                        .HasColumnType("int");

                    b.Property<string>("QuizTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionID");

                    b.HasIndex("QuizID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("AT1__PerfectPolicy_.Models.Quiz", b =>
                {
                    b.Property<int>("QuizID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("PassingPercentage")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuizID");

                    b.ToTable("Quizs");

                    b.HasData(
                        new
                        {
                            QuizID = 1,
                            Creator = "Steve",
                            DateCreated = new DateTime(2022, 5, 2, 13, 27, 59, 918, DateTimeKind.Local).AddTicks(5405),
                            PassingPercentage = 12,
                            Title = "QuizTime",
                            Topic = "Quiz"
                        },
                        new
                        {
                            QuizID = 2,
                            Creator = "Hank",
                            DateCreated = new DateTime(2022, 5, 2, 13, 27, 59, 919, DateTimeKind.Local).AddTicks(3147),
                            PassingPercentage = 60,
                            Title = "QuizzyTime",
                            Topic = "Yes"
                        });
                });

            modelBuilder.Entity("AT1__PerfectPolicy_.Models.UserInfo", b =>
                {
                    b.Property<int>("UserInfoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserInfoID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserInfoID = 1,
                            Password = "abc_1234",
                            Username = "Shaun"
                        });
                });

            modelBuilder.Entity("AT1__PerfectPolicy_.Models.Option", b =>
                {
                    b.HasOne("AT1__PerfectPolicy_.Models.Question", "Questions")
                        .WithMany("Options")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("AT1__PerfectPolicy_.Models.Question", b =>
                {
                    b.HasOne("AT1__PerfectPolicy_.Models.Quiz", "quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizID");

                    b.Navigation("quiz");
                });

            modelBuilder.Entity("AT1__PerfectPolicy_.Models.Question", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("AT1__PerfectPolicy_.Models.Quiz", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
