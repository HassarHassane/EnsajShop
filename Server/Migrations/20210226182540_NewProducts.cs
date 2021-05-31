using Microsoft.EntityFrameworkCore.Migrations;

namespace EnsajShop.Server.Migrations
{
    public partial class NewProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "The current crisis will one day come to an end, leaving behind countless victims and few victors.", "https://virginmegastore.ma/storage/2020/04/Sept-Le%C3%A7ons-de-vie-Survivre-aux-crises.jpg", "Seven Life Lessons -Surviving Crises" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "How to succeed in a negotiation, where one learns to move from the logic of a dead-end confrontation to the logic of a win-win situation. The author now develops an essential dimension of successful relationships with others (but absent from the first opus): to find profitable common ground with others, one must first know how to get along with oneself. The major obstacle in any relationship is in fact not the other person but oneself. In order to obtain the \"yes\" of others, one must learn to say \"yes\" to oneself and \"yes\" to life. Starting from there, the author undertakes more than just prolonging a bookon successful negotiation. It is also about sharing all that it can teach us about how to live better with ourselves, to the benefit of our relationship with others.", "https://virginmegastore.ma/storage/2020/03/etre-en-accord-avec-soi-meme.jpg", "To be in agreement with oneself" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Neuro-linguistic programming is a psychological technique that allows us to modify our thought patterns to better communicate with others. Through NLP, you will learn to change your bad communication habits, believe in your abilities, be in tune with your audience or negotiate solutions that satisfy everyone. You will finally master all the situations of daily life!", "https://virginmegastore.ma/storage/2020/11/pnl.jpg", "La PNL pour les Nuls" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "This 2 meter USB 2.0 cable connects your iPhone, iPad or iPod with Lightning connector to your computer's USB port, allowing you to sync and charge your device. You can also use the Apple USB Power Adapter to charge your device from a wall outlet.", "https://virginmegastore.ma/storage/2016/10/cable-lightning-vers-usb-2-m.png", "Câble Lightning vers USB (2m)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "She is incredibly attentive and intelligent! Just do your usual workout, and the watch will automatically detect it, and then it will start monitoring your activity with a simple touch. This feature is now available for six common workout modes: indoor/outdoor running, indoor/outdoor walking, elliptical and rowing.", "Connected watch Huawei GT2e -Mint Green" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "The iconic Black Ops saga is back with Call of Duty®: Black Ops ColdWar -the direct sequel to the game-changing episode for fans around the world, Call of Duty®: Black Ops.Black Ops Cold War will plunge players into the geopolitical tensions of the Cold War of the early 1980s. In a breathtaking single-player campaign where truth and conspiracy theories intertwine, players will cross paths with some of the iconic figures of the period and face the cold reality of combat in a manhunt that takes them to the four corners of the globe, from East Berlin to Vietnam, Turkey, KGB headquarters and more.", "https://virginmegastore.ma/storage/2021/02/011-1.jpg", "Call of Duty Game: Black Ops Cold War for PS5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Genius can take many forms -whether you're being dangerously funny, cultivating chaos with poisonous plants, or flooding the island with your best intentions -and its sidekick is often: madness.", "https://virginmegastore.ma/storage/2021/02/019.jpg", "Game Fortnite Pack Last Laugh for PS5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.", "https://upload.wikimedia.org/wikipedia/en/c/c3/1984first.jpg", "Nineteen Eighty-Four" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.", "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg", "Pentax Spotmatic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "Super Nintendo Entertainment System" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" });
        }
    }
}
