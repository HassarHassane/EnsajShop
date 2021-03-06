// <auto-generated />
using System;
using EnsajShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnsajShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210226182826_NewProducts2")]
    partial class NewProducts2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EnsajShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-slr",
                            Name = "Electronics",
                            Url = "electronics"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "aperture",
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("EnsajShop.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 3,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 5,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 6,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Xbox"
                        });
                });

            modelBuilder.Entity("EnsajShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The current crisis will one day come to an end, leaving behind countless victims and few victors.",
                            Image = "https://virginmegastore.ma/storage/2020/04/Sept-Le%C3%A7ons-de-vie-Survivre-aux-crises.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Seven Life Lessons -Surviving Crises"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "How to succeed in a negotiation, where one learns to move from the logic of a dead-end confrontation to the logic of a win-win situation. The author now develops an essential dimension of successful relationships with others (but absent from the first opus): to find profitable common ground with others, one must first know how to get along with oneself. The major obstacle in any relationship is in fact not the other person but oneself. In order to obtain the \"yes\" of others, one must learn to say \"yes\" to oneself and \"yes\" to life. Starting from there, the author undertakes more than just prolonging a bookon successful negotiation. It is also about sharing all that it can teach us about how to live better with ourselves, to the benefit of our relationship with others.",
                            Image = "https://virginmegastore.ma/storage/2020/03/etre-en-accord-avec-soi-meme.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "To be in agreement with oneself"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Neuro-linguistic programming is a psychological technique that allows us to modify our thought patterns to better communicate with others. Through NLP, you will learn to change your bad communication habits, believe in your abilities, be in tune with your audience or negotiate solutions that satisfy everyone. You will finally master all the situations of daily life!",
                            Image = "https://virginmegastore.ma/storage/2020/11/pnl.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "La PNL pour les Nuls"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "This 2 meter USB 2.0 cable connects your iPhone, iPad or iPod with Lightning connector to your computer's USB port, allowing you to sync and charge your device. You can also use the Apple USB Power Adapter to charge your device from a wall outlet.",
                            Image = "https://virginmegastore.ma/storage/2016/10/cable-lightning-vers-usb-2-m.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Câble Lightning vers USB (2m)"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Xbox"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "She is incredibly attentive and intelligent! Just do your usual workout, and the watch will automatically detect it, and then it will start monitoring your activity with a simple touch. This feature is now available for six common workout modes: indoor/outdoor running, indoor/outdoor walking, elliptical and rowing.",
                            Image = "https://virginmegastore.ma/storage/2020/08/huawei-mint-green.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Connected watch Huawei GT2e -Mint Green"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The iconic Black Ops saga is back with Call of Duty®: Black Ops ColdWar -the direct sequel to the game-changing episode for fans around the world, Call of Duty®: Black Ops.Black Ops Cold War will plunge players into the geopolitical tensions of the Cold War of the early 1980s. In a breathtaking single-player campaign where truth and conspiracy theories intertwine, players will cross paths with some of the iconic figures of the period and face the cold reality of combat in a manhunt that takes them to the four corners of the globe, from East Berlin to Vietnam, Turkey, KGB headquarters and more.",
                            Image = "https://virginmegastore.ma/storage/2021/02/011-1.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Call of Duty Game: Black Ops Cold War for PS5"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Genius can take many forms -whether you're being dangerously funny, cultivating chaos with poisonous plants, or flooding the island with your best intentions -and its sidekick is often: madness.",
                            Image = "https://virginmegastore.ma/storage/2021/02/019.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "Game Fortnite Pack Last Laugh for PS5"
                        });
                });

            modelBuilder.Entity("EnsajShop.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 199.99m,
                            Price = 99.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 3,
                            OriginalPrice = 0m,
                            Price = 79.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 4,
                            OriginalPrice = 299.99m,
                            Price = 199.99m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 2,
                            OriginalPrice = 149.99m,
                            Price = 79.99m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 2,
                            OriginalPrice = 0m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 1,
                            OriginalPrice = 2499.99m,
                            Price = 1669.99m
                        },
                        new
                        {
                            ProductId = 5,
                            EditionId = 1,
                            OriginalPrice = 2999.99m,
                            Price = 1599.99m
                        },
                        new
                        {
                            ProductId = 6,
                            EditionId = 1,
                            OriginalPrice = 4009.99m,
                            Price = 739.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 5,
                            OriginalPrice = 299.99m,
                            Price = 199.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 6,
                            OriginalPrice = 0m,
                            Price = 699.99m
                        },
                        new
                        {
                            ProductId = 7,
                            EditionId = 7,
                            OriginalPrice = 599.99m,
                            Price = 499.99m
                        },
                        new
                        {
                            ProductId = 8,
                            EditionId = 5,
                            OriginalPrice = 249.99m,
                            Price = 99.99m
                        },
                        new
                        {
                            ProductId = 9,
                            EditionId = 5,
                            OriginalPrice = 0m,
                            Price = 149.99m
                        });
                });

            modelBuilder.Entity("EnsajShop.Shared.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("LastVisit")
                        .HasColumnType("datetime2");

                    b.Property<int>("Visits")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("EnsajShop.Shared.Product", b =>
                {
                    b.HasOne("EnsajShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EnsajShop.Shared.ProductVariant", b =>
                {
                    b.HasOne("EnsajShop.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnsajShop.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EnsajShop.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
