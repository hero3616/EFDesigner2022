﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoredProcs;

#nullable disable

namespace StoredProcs.Migrations
{
    [DbContext(typeof(ProcContext))]
    partial class ProcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("AdultSequence");

            modelBuilder.HasSequence("GradeSequence");

            modelBuilder.HasSequence("SchoolSequence");

            modelBuilder.HasSequence("StudentSequence");

            modelBuilder.Entity("AdultStudent", b =>
                {
                    b.Property<long>("Adult_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Student_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Adult_Id", "Student_Id");

                    b.HasIndex("Student_Id");

                    b.ToTable("Adult_x_Student", "dbo");
                });

            modelBuilder.Entity("StoredProcs.Adult", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("NEXT VALUE FOR [dbo].[AdultSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<long>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("FirstName");

                    b.HasIndex("LastName");

                    b.ToTable("Adult", "dbo");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("StoredProcs.Grade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("NEXT VALUE FOR [dbo].[GradeSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("SchoolId");

                    b.ToTable("Grade", "dbo");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("StoredProcs.School", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("NEXT VALUE FOR [dbo].[SchoolSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Schools", "dbo");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("StoredProcs.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("NEXT VALUE FOR [dbo].[StudentSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<long>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("GPA")
                        .HasColumnType("real");

                    b.Property<long>("GradeId")
                        .HasColumnType("bigint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("FirstName");

                    b.HasIndex("GradeId");

                    b.HasIndex("LastName");

                    b.ToTable("Students", "dbo");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("AdultStudent", b =>
                {
                    b.HasOne("StoredProcs.Adult", null)
                        .WithMany()
                        .HasForeignKey("Adult_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoredProcs.Student", null)
                        .WithMany()
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoredProcs.Grade", b =>
                {
                    b.HasOne("StoredProcs.School", "School")
                        .WithMany("Grades")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("StoredProcs.Student", b =>
                {
                    b.HasOne("StoredProcs.Grade", "Grade")
                        .WithMany("Students")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });

            modelBuilder.Entity("StoredProcs.Grade", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("StoredProcs.School", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
