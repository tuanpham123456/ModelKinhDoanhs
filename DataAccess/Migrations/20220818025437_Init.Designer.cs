﻿// <auto-generated />
using System;
using DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220818025437_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("DataAccess.Ivoice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Ivoices");
                });

            modelBuilder.Entity("DataAccess.Member", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FacebookAvatarUrl")
                        .HasColumnType("text");

                    b.Property<string>("FacebookId")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<bool>("IsActived")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("DataAccess.Payment", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Ach_ID")
                        .HasColumnType("int");

                    b.Property<double>("Balance")
                        .HasColumnType("double");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Credit_Car_ID")
                        .HasColumnType("text");

                    b.Property<int>("Currency_ID")
                        .HasColumnType("int");

                    b.Property<int>("Deleted")
                        .HasColumnType("int");

                    b.Property<int>("Is_PreAuth")
                        .HasColumnType("int");

                    b.Property<int>("Is_Refund")
                        .HasColumnType("int");

                    b.Property<string>("Method_ID")
                        .HasColumnType("text");

                    b.Property<int>("Optlock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Payment_Date")
                        .HasColumnType("datetime");

                    b.Property<int>("Payment_ID")
                        .HasColumnType("int");

                    b.Property<string>("Payment_Notes")
                        .HasColumnType("text");

                    b.Property<int>("Payment_Period")
                        .HasColumnType("int");

                    b.Property<int>("Payout_ID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("User_ID")
                        .HasColumnType("text");

                    b.Property<double>("amount")
                        .HasColumnType("double");

                    b.Property<string>("attempt")
                        .HasColumnType("text");

                    b.Property<string>("result_ID")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DataAccess.Payment_info_cheque", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Bank")
                        .HasColumnType("text");

                    b.Property<DateTime>("Cheque_date")
                        .HasColumnType("datetime");

                    b.Property<string>("Cheque_number")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Optlock")
                        .HasColumnType("int");

                    b.Property<int>("Paymet_ID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("Payment_info_cheque");
                });

            modelBuilder.Entity("DataAccess.Payment_invoice", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Invoice_ID")
                        .HasColumnType("int");

                    b.Property<int>("Optlock")
                        .HasColumnType("int");

                    b.Property<int>("Payment_ID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("Payment_Invoices");
                });

            modelBuilder.Entity("DataAccess.payment_authorization", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Approval_code")
                        .HasColumnType("text");

                    b.Property<string>("Avs")
                        .HasColumnType("text");

                    b.Property<string>("Card_code")
                        .HasColumnType("text");

                    b.Property<string>("Code1")
                        .HasColumnType("text");

                    b.Property<string>("Code2")
                        .HasColumnType("text");

                    b.Property<string>("Code3")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Md5")
                        .HasColumnType("text");

                    b.Property<int>("Optlock")
                        .HasColumnType("int");

                    b.Property<int>("Payment_ID")
                        .HasColumnType("int");

                    b.Property<string>("Processor")
                        .HasColumnType("text");

                    b.Property<string>("Response_message")
                        .HasColumnType("text");

                    b.Property<string>("Transaction_ID")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("Payment_Authorizations");
                });
#pragma warning restore 612, 618
        }
    }
}