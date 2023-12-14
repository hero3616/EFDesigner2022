﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Transient;

#nullable disable

namespace Transient_Owned.Migrations
{
    [DbContext(typeof(TransientContext))]
    [Migration("20231214114021_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("PersistentDetailSequence");

            modelBuilder.Entity("Transient.Master", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Foo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Masters", "dbo");
                });

            modelBuilder.Entity("Transient.PersistentDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("NEXT VALUE FOR [dbo].[PersistentDetailSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<long>("Id"));

                    b.Property<string>("Bar")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long?>("MasterPersistentDetailsId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MasterPersistentDetailsId");

                    b.ToTable("PersistentDetails", "dbo");

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Transient.Master", b =>
                {
                    b.OwnsOne("Transient.TransientDetailAsJson", "TransientDetailAsJson", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint");

                            b1.Property<string>("Zoom")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("Id");

                            b1.ToTable("Masters", "dbo");

                            b1.WithOwner()
                                .HasForeignKey("Id");
                        });

                    b.OwnsMany("Transient.TransientDetail", "TransientDetails", b1 =>
                        {
                            b1.Property<long>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<long>("Id"));

                            b1.Property<string>("Baz")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<long?>("MasterId")
                                .HasColumnType("bigint");

                            b1.HasKey("Id");

                            b1.HasIndex("MasterId");

                            b1.ToTable("TransientDetails", "dbo");

                            b1.WithOwner()
                                .HasForeignKey("MasterId");
                        });

                    b.Navigation("TransientDetailAsJson");

                    b.Navigation("TransientDetails");
                });

            modelBuilder.Entity("Transient.PersistentDetail", b =>
                {
                    b.HasOne("Transient.Master", null)
                        .WithMany("PersistentDetails")
                        .HasForeignKey("MasterPersistentDetailsId");
                });

            modelBuilder.Entity("Transient.Master", b =>
                {
                    b.Navigation("PersistentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
