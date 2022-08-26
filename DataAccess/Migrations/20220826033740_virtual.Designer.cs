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
    [Migration("20220826033740_virtual")]
    partial class @virtual
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("DataAccess.Config", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("key")
                        .HasColumnType("text");

                    b.Property<string>("value")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("DataAccess.Invoice_line", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<long>("invoice_ID")
                        .HasColumnType("bigint");

                    b.Property<double>("quantity")
                        .HasColumnType("double");

                    b.Property<int>("type_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Invoice_lines");
                });

            modelBuilder.Entity("DataAccess.Ivoice", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

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

                    b.Property<long?>("MemberID")
                        .HasColumnType("bigint");

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

                    b.HasIndex("MemberID");

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

                    b.ToTable("Payment_info_cheques");
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

                    b.ToTable("Payment_invoices");
                });

            modelBuilder.Entity("DataAccess.Payment_momo", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("accessKey")
                        .HasColumnType("text");

                    b.Property<string>("amount")
                        .HasColumnType("text");

                    b.Property<string>("errorCode")
                        .HasColumnType("text");

                    b.Property<string>("extraData")
                        .HasColumnType("text");

                    b.Property<string>("localMessage")
                        .HasColumnType("text");

                    b.Property<string>("message")
                        .HasColumnType("text");

                    b.Property<string>("orderId")
                        .HasColumnType("text");

                    b.Property<string>("orderInfo")
                        .HasColumnType("text");

                    b.Property<string>("orderType")
                        .HasColumnType("text");

                    b.Property<string>("partnerCode")
                        .HasColumnType("text");

                    b.Property<string>("payType")
                        .HasColumnType("text");

                    b.Property<string>("requestId")
                        .HasColumnType("text");

                    b.Property<string>("responseTime")
                        .HasColumnType("text");

                    b.Property<string>("signature")
                        .HasColumnType("text");

                    b.Property<string>("transId")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("payment_momos");
                });

            modelBuilder.Entity("DataAccess.Payment_vnp", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.Property<int>("vnp_Amount")
                        .HasColumnType("int");

                    b.Property<string>("vnp_BankCode")
                        .HasColumnType("text");

                    b.Property<string>("vnp_Command")
                        .HasColumnType("text");

                    b.Property<string>("vnp_CurrCode")
                        .HasColumnType("text");

                    b.Property<string>("vnp_IpAddr")
                        .HasColumnType("text");

                    b.Property<string>("vnp_Locale")
                        .HasColumnType("text");

                    b.Property<string>("vnp_OrderInfo")
                        .HasColumnType("text");

                    b.Property<string>("vnp_OrderType")
                        .HasColumnType("text");

                    b.Property<string>("vnp_ReturnUrl")
                        .HasColumnType("text");

                    b.Property<string>("vnp_TmnCode")
                        .HasColumnType("text");

                    b.Property<string>("vnp_TxnRef")
                        .HasColumnType("text");

                    b.Property<string>("vnp_Version")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Payment_vnps");
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

                    b.ToTable("Payment_authorizations");
                });

            modelBuilder.Entity("DataAccess.Payment", b =>
                {
                    b.HasOne("DataAccess.Member", "Member")
                        .WithMany("Payment")
                        .HasForeignKey("MemberID");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("DataAccess.Member", b =>
                {
                    b.Navigation("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}
