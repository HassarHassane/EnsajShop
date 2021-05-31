using EnsajShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnsajShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Video Games", Url = "video-games", Icon = "aperture" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Seven Life Lessons -Surviving Crises",
                    Description = "The current crisis will one day come to an end, leaving behind countless victims and few victors.",
                    Image = "https://virginmegastore.ma/storage/2020/04/Sept-Le%C3%A7ons-de-vie-Survivre-aux-crises.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "To be in agreement with oneself",
                    Description = "How to succeed in a negotiation, where one learns to move from the logic of a dead-end confrontation to the logic of a win-win situation. The author now develops an essential dimension of successful relationships with others (but absent from the first opus): to find profitable common ground with others, one must first know how to get along with oneself. The major obstacle in any relationship is in fact not the other person but oneself. In order to obtain the \"yes\" of others, one must learn to say \"yes\" to oneself and \"yes\" to life. Starting from there, the author undertakes more than just prolonging a bookon successful negotiation. It is also about sharing all that it can teach us about how to live better with ourselves, to the benefit of our relationship with others.",
                    Image = "https://virginmegastore.ma/storage/2020/03/etre-en-accord-avec-soi-meme.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "La PNL pour les Nuls",
                    Description = "Neuro-linguistic programming is a psychological technique that allows us to modify our thought patterns to better communicate with others. Through NLP, you will learn to change your bad communication habits, believe in your abilities, be in tune with your audience or negotiate solutions that satisfy everyone. You will finally master all the situations of daily life!",
                    Image = "https://virginmegastore.ma/storage/2020/11/pnl.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Câble Lightning vers USB (2m)",
                    Description = "This 2 meter USB 2.0 cable connects your iPhone, iPad or iPod with Lightning connector to your computer's USB port, allowing you to sync and charge your device. You can also use the Apple USB Power Adapter to charge your device from a wall outlet.",
                    Image = "https://virginmegastore.ma/storage/2016/10/cable-lightning-vers-usb-2-m.png",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Connected watch Huawei GT2e -Mint Green",
                    Description = "She is incredibly attentive and intelligent! Just do your usual workout, and the watch will automatically detect it, and then it will start monitoring your activity with a simple touch. This feature is now available for six common workout modes: indoor/outdoor running, indoor/outdoor walking, elliptical and rowing.",
                    Image = "https://virginmegastore.ma/storage/2020/08/huawei-mint-green.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Call of Duty Game: Black Ops Cold War for PS5",
                    Description = "The iconic Black Ops saga is back with Call of Duty®: Black Ops ColdWar -the direct sequel to the game-changing episode for fans around the world, Call of Duty®: Black Ops.Black Ops Cold War will plunge players into the geopolitical tensions of the Cold War of the early 1980s. In a breathtaking single-player campaign where truth and conspiracy theories intertwine, players will cross paths with some of the iconic figures of the period and face the cold reality of combat in a manhunt that takes them to the four corners of the globe, from East Berlin to Vietnam, Turkey, KGB headquarters and more.",
                    Image = "https://virginmegastore.ma/storage/2021/02/011-1.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Title = "Game Fortnite Pack Last Laugh for PS5",
                    Description = "Genius can take many forms -whether you're being dangerously funny, cultivating chaos with poisonous plants, or flooding the island with your best intentions -and its sidekick is often: madness.",
                    Image = "https://virginmegastore.ma/storage/2021/02/019.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                }
            );
            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "Default" },
                    new Edition { Id = 2, Name = "Paperback" },
                    new Edition { Id = 3, Name = "E-Book" },
                    new Edition { Id = 4, Name = "Audiobook" },
                    new Edition { Id = 5, Name = "PC" },
                    new Edition { Id = 6, Name = "PlayStation" },
                    new Edition { Id = 7, Name = "Xbox" }
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 99.99m,
                    OriginalPrice = 199.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 79.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 199.99m,
                    OriginalPrice = 299.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 79.99m,
                    OriginalPrice = 149.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 1669.99m,
                    OriginalPrice = 2499.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 1,
                    Price = 1599.99m,
                    OriginalPrice = 2999.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 739.99m,
                    OriginalPrice = 4009.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 5,
                    Price = 199.99m,
                    OriginalPrice = 299.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 6,
                    Price = 699.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 7,
                    Price = 499.99m,
                    OriginalPrice = 599.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 5,
                    Price = 99.99m,
                    OriginalPrice = 249.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 5,
                    Price = 149.99m
                }
            );
        }
    }
}
