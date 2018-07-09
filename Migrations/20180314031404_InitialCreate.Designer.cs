﻿// <auto-generated />
using deleohynekwedding.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace deleohynekwedding.Migrations
{
    [DbContext(typeof(WeddingContext))]
    [Migration("20180314031404_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("deleohynekwedding.Models.Guest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName");

                    b.Property<int?>("InvitationID");

                    b.Property<string>("LastName");

                    b.Property<int?>("ResponseInfoID");

                    b.HasKey("ID");

                    b.HasIndex("InvitationID");

                    b.HasIndex("ResponseInfoID");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("deleohynekwedding.Models.GuestResponseInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Attending");

                    b.Property<string>("ChopShopSelection")
                        .HasMaxLength(200);

                    b.Property<string>("DietaryRestrictions")
                        .HasMaxLength(200);

                    b.Property<string>("OakmontBBQSelection")
                        .HasMaxLength(200);

                    b.Property<string>("SongRequest")
                        .HasMaxLength(200);

                    b.HasKey("ID");

                    b.ToTable("GuestResponseInfo");
                });

            modelBuilder.Entity("deleohynekwedding.Models.Invitation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Attending");

                    b.Property<string>("RsvpCode")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Invitation");
                });

            modelBuilder.Entity("deleohynekwedding.Models.Guest", b =>
                {
                    b.HasOne("deleohynekwedding.Models.Invitation")
                        .WithMany("Guests")
                        .HasForeignKey("InvitationID");

                    b.HasOne("deleohynekwedding.Models.GuestResponseInfo", "ResponseInfo")
                        .WithMany()
                        .HasForeignKey("ResponseInfoID");
                });
#pragma warning restore 612, 618
        }
    }
}