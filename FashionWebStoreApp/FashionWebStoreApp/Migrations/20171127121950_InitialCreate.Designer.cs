﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FashionWebStoreApp.Entities;

namespace FashionWebStoreApp.Migrations
{
    [DbContext(typeof(FashionStoreContext))]
    [Migration("20171127121950_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FashionWebStoreApp.Models.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("ItemName");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Size");

                    b.Property<double>("UnitPrice");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });
        }
    }
}
