﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using challengePaggcerto.src.api.Models.EntityModel;

#nullable disable

namespace challengePaggcerto.src.api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("challengePaggcerto.src.api.Models.EntityModel.Anticipation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("AnalysisState")
                        .HasColumnType("int");

                    b.Property<double>("AnticipatedRequiredValue")
                        .HasColumnType("float");

                    b.Property<double>("AnticipatedValue")
                        .HasColumnType("float");

                    b.Property<DateTime?>("FinalAnalysisDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartAnalysisDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Anticipations");
                });

            modelBuilder.Entity("challengePaggcerto.src.api.Models.EntityModel.Parcel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("DatePassedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateReceived")
                        .HasColumnType("datetime2");

                    b.Property<double>("GrossValue")
                        .HasColumnType("float");

                    b.Property<double>("NetValue")
                        .HasColumnType("float");

                    b.Property<int>("ParcelNumber")
                        .HasColumnType("int");

                    b.Property<long?>("TransactionId")
                        .HasColumnType("bigint");

                    b.Property<double>("ValueAnticipated")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId");

                    b.ToTable("Parcels");
                });

            modelBuilder.Entity("challengePaggcerto.src.api.Models.EntityModel.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("AcquirerConfirm")
                        .HasColumnType("bit");

                    b.Property<bool>("Anticipated")
                        .HasColumnType("bit");

                    b.Property<long?>("AnticipationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateAccepted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateExecuted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRejected")
                        .HasColumnType("datetime2");

                    b.Property<double>("FixRate")
                        .HasColumnType("float");

                    b.Property<double>("GrossValue")
                        .HasColumnType("float");

                    b.Property<string>("LastFourCardDigits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NetValue")
                        .HasColumnType("float");

                    b.Property<int>("ParcelAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnticipationId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("challengePaggcerto.src.api.Models.EntityModel.Parcel", b =>
                {
                    b.HasOne("challengePaggcerto.src.api.Models.EntityModel.Transaction", "Transaction")
                        .WithMany("Parcels")
                        .HasForeignKey("TransactionId");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("challengePaggcerto.src.api.Models.EntityModel.Transaction", b =>
                {
                    b.HasOne("challengePaggcerto.src.api.Models.EntityModel.Anticipation", "Anticipation")
                        .WithMany("Transactions")
                        .HasForeignKey("AnticipationId");

                    b.Navigation("Anticipation");
                });

            modelBuilder.Entity("challengePaggcerto.src.api.Models.EntityModel.Anticipation", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("challengePaggcerto.src.api.Models.EntityModel.Transaction", b =>
                {
                    b.Navigation("Parcels");
                });
#pragma warning restore 612, 618
        }
    }
}
