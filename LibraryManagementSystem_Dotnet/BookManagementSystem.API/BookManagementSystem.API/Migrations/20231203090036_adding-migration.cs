using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class addingmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "000baffb-cab4-41b3-8ec9-7dcda6df0e30" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "0328a630-b6f3-415f-b3a3-8d5c8e187f0d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "1699067d-437a-40db-b729-6532de6fc769" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "1699067d-437a-40db-b729-6532de6fc769" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "bda14ead-e719-4182-aea9-732ceaa3545c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "cf3167a8-cda9-440e-bac2-79523e51401b" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("576c4358-1fd8-4b73-8c6c-834d66b203d3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("59e04f5c-3f96-4401-ba87-ce9d5749593e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("421b10ef-a2c5-46b4-afd6-18293ed8aade"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6c9efb98-bebc-4dc3-b30d-416c0e5fc1f6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c497a3d9-6d82-4457-b791-3853cdd16331"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c93f21b5-c45d-4dfd-ab7e-305b73beb8b7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000baffb-cab4-41b3-8ec9-7dcda6df0e30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0328a630-b6f3-415f-b3a3-8d5c8e187f0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1699067d-437a-40db-b729-6532de6fc769");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bda14ead-e719-4182-aea9-732ceaa3545c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf3167a8-cda9-440e-bac2-79523e51401b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TokensAvailable", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02ccf2e9-f1b2-4945-ae61-6a8b120e2375", 0, "a250609d-4e00-45c3-a056-eec794325c90", "user1@test.com", false, false, null, "User01", "USER1@TEST.COM", "USER1@TEST.COM", "AQAAAAIAAYagAAAAEH2UXUo/6QmjJrV12Qlr5htcA9NgpKDgn7ZsiqxJcapQ4E8yKT7TOH9pgJE6PBs2ag==", null, false, "1563ee01-469c-40e9-8465-c36a3b92337d", 1, false, "user1@test.com" },
                    { "435a6274-6ea1-4f2a-b202-5c23af9d7127", 0, "b3249088-72b7-48d6-9d3a-1dee016167dd", "user2@test.com", false, false, null, "User02", "USER2@TEST.COM", "USER2@TEST.COM", "AQAAAAIAAYagAAAAEMzJFYfL4segGt+PVzikqY8qCqGOc2WzdAs1BkCTSADCMBcz9QzS5GlVw3athl73BA==", null, false, "9fa1a729-e888-4c58-a59f-9f03c62b40c6", 1, false, "user2@test.com" },
                    { "4d293ac5-4a19-4694-8274-e9081f1aa899", 0, "38b9ec6e-3fdd-4b26-b71c-5850c67a8cf1", "user3@test.com", false, false, null, "User03", "USER3@TEST.COM", "USER3@TEST.COM", "AQAAAAIAAYagAAAAEJ1pjuRaRXBnbIk/WRIQVlKKnnZ4IXLXQkQauwx11bStuFHWrfIUQlvcUGwvbgyUgw==", null, false, "cba5e2f5-9a06-46f3-858b-ffd06bd47f37", 1, false, "user3@test.com" },
                    { "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9", 0, "af03fb15-e699-484c-b4eb-1ea95d74b7f0", "admin@test.com", false, false, null, "Admin", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAELacwTL6g1DiL0mi0dmLCUYexvwkS8JdG8XV3S7T6MneNnmPNo7Cpn6Uw7OOVaLWFQ==", null, false, "6682021d-eb2f-472f-b224-85fa7a525504", 0, false, "admin@test.com" },
                    { "c40a8ca1-3b33-4242-a4c1-8ebd77a26dad", 0, "9c814822-5d67-4635-b971-bc29b500a3a3", "amisha@gmail.com", false, false, null, "Amisha", "AMISHA@GMAIL.COM", "AMISHA@GMAIL.COM", "AQAAAAIAAYagAAAAELOzvWoziOSnTTWTk1XgWVX14XQ78HKqa6msHjuwy6AoCbzFHwbsP+HhRT5D5byGew==", null, false, "9ffa3cb6-7537-4305-8c15-c4e4eff06b15", 1, false, "amisha123" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("0f4461bb-8066-43ec-b250-9d721436fde0"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg", true, "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9", "Jail Diary", 0.0, "Jail Diary By Bhagat Singh" },
                    { new Guid("32769abb-94ae-4577-91c5-db857e13810d"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", true, "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9", "Harry Potter", 0.0, "Harry Potter and the Sorcerer's Stone" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("4f51de1c-4b16-456b-aa60-8ad0f45a37b8"), "Novel", "/Novel" },
                    { new Guid("4f6de814-a6fd-4561-b807-06f4922bfa97"), "Others", "/Others" },
                    { new Guid("54007cfd-68de-4dcb-84e5-e96f4b60e91f"), "Fantasy", "/Fantasy" },
                    { new Guid("dffb2735-2de2-46d8-b957-f986cdb4f08f"), "Science Fiction", "Science Fiction" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "02ccf2e9-f1b2-4945-ae61-6a8b120e2375" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "435a6274-6ea1-4f2a-b202-5c23af9d7127" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "4d293ac5-4a19-4694-8274-e9081f1aa899" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "c40a8ca1-3b33-4242-a4c1-8ebd77a26dad" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "02ccf2e9-f1b2-4945-ae61-6a8b120e2375" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "435a6274-6ea1-4f2a-b202-5c23af9d7127" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "4d293ac5-4a19-4694-8274-e9081f1aa899" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "c40a8ca1-3b33-4242-a4c1-8ebd77a26dad" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0f4461bb-8066-43ec-b250-9d721436fde0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("32769abb-94ae-4577-91c5-db857e13810d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f51de1c-4b16-456b-aa60-8ad0f45a37b8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4f6de814-a6fd-4561-b807-06f4922bfa97"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("54007cfd-68de-4dcb-84e5-e96f4b60e91f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dffb2735-2de2-46d8-b957-f986cdb4f08f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ccf2e9-f1b2-4945-ae61-6a8b120e2375");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435a6274-6ea1-4f2a-b202-5c23af9d7127");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d293ac5-4a19-4694-8274-e9081f1aa899");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adf7dec8-c439-4d1e-b71e-4eeffb9a7af9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c40a8ca1-3b33-4242-a4c1-8ebd77a26dad");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TokensAvailable", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "000baffb-cab4-41b3-8ec9-7dcda6df0e30", 0, "1d1b11dc-ce31-414f-acf4-687d385bd9ef", "avinash@test.com", false, false, null, "Avinash", "AVINASH@TEST.COM", "AVINASH@TEST.COM", "AQAAAAIAAYagAAAAECDtDftlubTOs762r7hsHyA39p7EYzs/pJh1mKULwb2eBN1wk8d4jnPxp2FnQyWYzw==", null, false, "bb77af58-8f28-46a1-8149-798ce8ecc64a", 1, false, "avinash@test.com" },
                    { "0328a630-b6f3-415f-b3a3-8d5c8e187f0d", 0, "4719144f-b5d6-4adb-ad37-67c30f8b6e85", "swatantra@test.com", false, false, null, "Swatantra", "SWATANTRA@TEST.COM", "SWATANTRA@TEST.COM", "AQAAAAIAAYagAAAAEH7fsrBxDCTYfJbUwIHZOEeIczizMQzmX8kEQQDn9wNQPEetzZcblVWeyHvU0KEZvA==", null, false, "923ced21-d617-426f-9611-a1f7b40cc9df", 1, false, "swatantra@test.com" },
                    { "1699067d-437a-40db-b729-6532de6fc769", 0, "fdb5ea99-8746-43e5-a578-b1c5aaaa4430", "admin@test.com", false, false, null, "Admin", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEErxMan9URPw2O/BeDEKEFYierikKOMaQdIolumOiUFZF2VYPqLDjJGgfKtDG32Xzg==", null, false, "409e9546-7ef7-42ef-919b-2fd07f6ef677", 0, false, "admin@test.com" },
                    { "bda14ead-e719-4182-aea9-732ceaa3545c", 0, "8addac29-8653-4d55-b2fa-bd5706e3bf2c", "abhishek@test.com", false, false, null, "Abhishek", "ABHISHEK@TEST.COM", "ABHISHEK@TEST.COM", "AQAAAAIAAYagAAAAEIlCcJPs/Qyrc0PvCg4eXO1E2n4Avm1/e45wdk2BHAKj43dXMJA3XjS1eOSFDHGSJQ==", null, false, "7ab561a8-0f2e-4b27-b207-333c53ec3c8c", 1, false, "abhishek@test.com" },
                    { "cf3167a8-cda9-440e-bac2-79523e51401b", 0, "d92a42a6-6868-48d1-bee5-7b34e3145b74", "pranav@test.com", false, false, null, "Pranav", "PRANAV@TEST.COM", "PRANAV@TEST.COM", "AQAAAAIAAYagAAAAEAVcbPALPT58Vk5pHoi2JGE0vmilObBfu6vSIAXticKylxo6Nnrop4xX+AWWFoEn9w==", null, false, "f6559256-6b17-4704-b90c-49e02df1bd23", 1, false, "pranav@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("576c4358-1fd8-4b73-8c6c-834d66b203d3"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg", true, "1699067d-437a-40db-b729-6532de6fc769", "Jail Diary", 0.0, "Jail Diary By Bhagat Singh" },
                    { new Guid("59e04f5c-3f96-4401-ba87-ce9d5749593e"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", true, "1699067d-437a-40db-b729-6532de6fc769", "Harry Potter", 0.0, "Harry Potter and the Sorcerer's Stone" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("421b10ef-a2c5-46b4-afd6-18293ed8aade"), "Others", "/Others" },
                    { new Guid("6c9efb98-bebc-4dc3-b30d-416c0e5fc1f6"), "Science Fiction", "Science Fiction" },
                    { new Guid("c497a3d9-6d82-4457-b791-3853cdd16331"), "Fantasy", "/Fantasy" },
                    { new Guid("c93f21b5-c45d-4dfd-ab7e-305b73beb8b7"), "Novel", "/Novel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "000baffb-cab4-41b3-8ec9-7dcda6df0e30" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "0328a630-b6f3-415f-b3a3-8d5c8e187f0d" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "1699067d-437a-40db-b729-6532de6fc769" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "1699067d-437a-40db-b729-6532de6fc769" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "bda14ead-e719-4182-aea9-732ceaa3545c" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "cf3167a8-cda9-440e-bac2-79523e51401b" }
                });
        }
    }
}
